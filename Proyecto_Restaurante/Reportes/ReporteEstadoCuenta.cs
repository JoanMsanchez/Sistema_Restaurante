using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.Rendering;

namespace Proyecto_Restaurante.Reportes
{
    public partial class ReporteEstadoCuenta : Form
    {
        //private const string CS = @"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true";
        private const string CS = @"server=MSI; database=SistemaRestauranteDB1; integrated security=true";

        public ReporteEstadoCuenta()
        {
            InitializeComponent();
            llenar_tabla_datagridview();
            this.Padding = new Padding(bordeSize);
            this.BackColor = System.Drawing.Color.FromArgb(255, 161, 43);
        }

        //Fields
        private int bordeSize = 2;


        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        //Event methods
        private void Producto_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != bordeSize)
                        this.Padding = new Padding(bordeSize);
                    break;

            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenar_tabla_datagridview()
        {
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();

                string consulta = @"
                        ;WITH mov AS (
                            -- ÓRDENES (DEBE)
                            SELECT 
                                o.id_cliente,
                                COALESCE(c.nombre, CONCAT('Cliente ', o.id_cliente)) AS cliente,
                                o.id_orden            AS ref_id,
                                o.fecha_hora          AS fecha,
                                CAST('Orden' AS varchar(10)) AS tipo,
                                CONCAT('Orden #', o.id_orden) AS referencia,
                                CAST(o.total AS decimal(18,2)) AS debe,
                                CAST(0       AS decimal(18,2)) AS haber
                            FROM orden o
                            LEFT JOIN cliente c ON c.id_cliente = o.id_cliente

                            UNION ALL

                            -- PAGOS (HABER) aplicados a órdenes del cliente
                            SELECT
                                o.id_cliente,
                                COALESCE(c.nombre, CONCAT('Cliente ', o.id_cliente)) AS cliente,
                                p.id_pago             AS ref_id,
                                p.fecha_pago          AS fecha,
                                CAST('Pago' AS varchar(10)) AS tipo,
                                CONCAT('Pago #', p.id_pago)  AS referencia,
                                CAST(0 AS decimal(18,2))     AS debe,
                                CAST(SUM(dp.monto_aplicado) AS decimal(18,2)) AS haber
                            FROM pago p
                            INNER JOIN detalle_pago dp ON dp.id_pago  = p.id_pago
                            INNER JOIN orden        o  ON o.id_orden = dp.id_orden
                            LEFT  JOIN cliente      c  ON c.id_cliente = o.id_cliente
                            GROUP BY o.id_cliente, c.nombre, p.id_pago, p.fecha_pago
                        )
                        SELECT
                            id_cliente,
                            cliente,
                            fecha,
                            tipo,
                            referencia,
                            debe,
                            haber,
                            SUM(debe - haber) OVER (PARTITION BY id_cliente ORDER BY fecha, ref_id
                                                    ROWS UNBOUNDED PRECEDING) AS saldo
                        FROM mov
                        ORDER BY cliente, fecha, ref_id;";

                using var da = new SqlDataAdapter(consulta, con);
                var dt = new DataTable();
                da.Fill(dt);

                if (!dt.Columns.Contains("No")) dt.Columns.Add("No", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++) dt.Rows[i]["No"] = i + 1;
                dt.Columns["No"].SetOrdinal(0);

                dtgEstadoCuenta.AutoGenerateColumns = true;
                dtgEstadoCuenta.DataSource = dt;

                if (dtgEstadoCuenta.Columns.Contains("id_cliente"))
                    dtgEstadoCuenta.Columns["id_cliente"].Visible = false;

                dtgEstadoCuenta.Columns["No"].HeaderText = "#";
                dtgEstadoCuenta.Columns["cliente"].HeaderText = "Cliente";
                dtgEstadoCuenta.Columns["fecha"].HeaderText = "Fecha";
                dtgEstadoCuenta.Columns["tipo"].HeaderText = "Tipo";
                dtgEstadoCuenta.Columns["referencia"].HeaderText = "Referencia";
                dtgEstadoCuenta.Columns["debe"].HeaderText = "Débito ";
                dtgEstadoCuenta.Columns["haber"].HeaderText = "Crédito ";
                dtgEstadoCuenta.Columns["saldo"].HeaderText = "Saldo";

                if (dtgEstadoCuenta.Columns.Contains("fecha"))
                    dtgEstadoCuenta.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

                foreach (var col in new[] { "debe", "haber", "saldo" })
                    if (dtgEstadoCuenta.Columns.Contains(col))
                    {
                        dtgEstadoCuenta.Columns[col].DefaultCellStyle.Format = "N2";
                        dtgEstadoCuenta.Columns[col].DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estado de cuenta: " + ex.Message);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string q = txtNombre.Text.Trim();

                if (string.IsNullOrWhiteSpace(q))
                {
                    llenar_tabla_datagridview();
                    return;
                }

                using var con = new SqlConnection(CS);
                con.Open();

                // 1) Buscar id_cliente y nombre del cliente
                int? idCliente = null;
                string nombreCliente = null;

                using (var cmdId = new SqlCommand(
                            @"SELECT TOP 1 id_cliente, nombre
                      FROM cliente
                      WHERE nombre LIKE @buscar
                      ORDER BY nombre;", con))
                {
                    cmdId.Parameters.Add("@buscar", SqlDbType.VarChar, 200).Value = "%" + q + "%";
                    using var rd = cmdId.ExecuteReader();
                    if (rd.Read())
                    {
                        idCliente = rd.GetInt32(0);
                        nombreCliente = rd.IsDBNull(1) ? "" : rd.GetString(1);
                    }
                }

                if (idCliente == null)
                {
                    dtgEstadoCuenta.DataSource = null; // no encontró cliente
                    return;
                }

                // 2) Traer movimientos del cliente
                string sql = @"
                        ;WITH mov AS (
                            SELECT 
                                o.id_orden                    AS ref_id,
                                o.fecha_hora                  AS fecha,
                                CAST('Orden' AS varchar(10))  AS tipo,
                                CONCAT('Orden #', o.id_orden) AS referencia,
                                CAST(o.total AS decimal(18,2)) AS debe,
                                CAST(0      AS decimal(18,2))  AS haber
                            FROM orden o
                            WHERE o.id_cliente = @idCliente

                            UNION ALL

                            SELECT
                                p.id_pago                     AS ref_id,
                                p.fecha_pago                  AS fecha,
                                CAST('Pago' AS varchar(10))   AS tipo,
                                CONCAT('Pago #', p.id_pago)   AS referencia,
                                CAST(0 AS decimal(18,2))      AS debe,
                                CAST(SUM(dp.monto_aplicado) AS decimal(18,2)) AS haber
                            FROM pago p
                            INNER JOIN detalle_pago dp ON dp.id_pago  = p.id_pago
                            INNER JOIN orden        o  ON o.id_orden = dp.id_orden
                            WHERE o.id_cliente = @idCliente
                            GROUP BY p.id_pago, p.fecha_pago
                        )
                        SELECT fecha, tipo, referencia, debe, haber
                        FROM mov
                        ORDER BY fecha, ref_id;";

                using var cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente.Value;

                using var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                // ======= AQUÍ VA LO QUE TE FALTABA =======
                // Crear/llenar columnas calculadas ANTES de bindear al grid
                if (!dt.Columns.Contains("cliente")) dt.Columns.Add("cliente", typeof(string));
                if (!dt.Columns.Contains("No")) dt.Columns.Add("No", typeof(int));
                if (!dt.Columns.Contains("saldo")) dt.Columns.Add("saldo", typeof(decimal));

                decimal saldo = 0m;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                    dt.Rows[i]["cliente"] = nombreCliente ?? "";

                    decimal debe = dt.Rows[i]["debe"] == DBNull.Value ? 0m : Convert.ToDecimal(dt.Rows[i]["debe"]);
                    decimal haber = dt.Rows[i]["haber"] == DBNull.Value ? 0m : Convert.ToDecimal(dt.Rows[i]["haber"]);
                    saldo += (debe - haber);
                    dt.Rows[i]["saldo"] = saldo;
                }
                dt.Columns["No"].SetOrdinal(0);
                dt.Columns["cliente"].SetOrdinal(1);
                // ======= FIN DEL BLOQUE IMPORTANTE =======

                // 3) Bind al grid
                dtgEstadoCuenta.AutoGenerateColumns = true;
                dtgEstadoCuenta.DataSource = dt;

                // 4) Encabezados/formatos (seguros: solo si la columna existe)
                void SetHeader(string name, string header)
                {
                    var c = dtgEstadoCuenta.Columns[name];
                    if (c != null) c.HeaderText = header;
                }
                SetHeader("No", "#");
                SetHeader("cliente", "Cliente");
                SetHeader("fecha", "Fecha");
                SetHeader("tipo", "Tipo");
                SetHeader("referencia", "Referencia");
                SetHeader("debe", "Débito ");
                SetHeader("haber", "Crédito ");
                SetHeader("saldo", "Saldo");

                if (dtgEstadoCuenta.Columns.Contains("fecha"))
                    dtgEstadoCuenta.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

                foreach (var col in new[] { "debe", "haber", "saldo" })
                    if (dtgEstadoCuenta.Columns.Contains(col))
                    {
                        dtgEstadoCuenta.Columns[col].DefaultCellStyle.Format = "N2";
                        dtgEstadoCuenta.Columns[col].DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar / cargar: " + ex.Message);
            }
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            ExportarPDF_StockActual(
              dtgEstadoCuenta,
              nombreEmpresa: "LA ESQUINITA",
              lemaEmpresa: "EL GUSTO COMIENZA EN LA ESQUINA",
              rutaLogo: @"C:\imagen\LOGONEGRO.png"  // opcional; pásalo null o "" si no quieres logo
           );
        }

        private void ExportarPDF_StockActual(

           DataGridView grid,
           string nombreEmpresa,
           string lemaEmpresa,
           string rutaLogo = null)
        {
            if (grid == null || grid.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            // Verifica que existan las columnas necesarias
            string[] req = { "No", "cliente", "fecha", "tipo", "referencia", "debe", "haber", "saldo" };
            foreach (var col in req)
            {
                if (!grid.Columns.Contains(col))
                {
                    MessageBox.Show($"Falta la columna '{col}' en el DataGridView.");
                    return;
                }
            }

            try
            {
                // ==== Documento ====
                var doc = new Document();
                doc.Info.Title = "Reporte - Estado de Cuenta";
                var sec = doc.AddSection();
                sec.PageSetup.TopMargin = Unit.FromCentimeter(1.5);
                sec.PageSetup.BottomMargin = Unit.FromCentimeter(1.5);

                // ==== Encabezado (logo + nombre + lema + fecha) ====
                var headTbl = sec.AddTable();
                headTbl.Borders.Visible = false;
                headTbl.AddColumn(Unit.FromCentimeter(3.0));
                headTbl.AddColumn(Unit.FromCentimeter(15.0));

                // 1) Texto (izquierda)
                var pEmpresa = sec.AddParagraph(nombreEmpresa ?? "");
                pEmpresa.Format.Alignment = ParagraphAlignment.Left;
                pEmpresa.Format.Font.Size = 16;
                pEmpresa.Format.Font.Bold = true;

                var pLema = sec.AddParagraph(lemaEmpresa ?? "");
                pLema.Format.Alignment = ParagraphAlignment.Left;
                pLema.Format.Font.Size = 10;
                pLema.Format.Font.Italic = true;

                var pFecha = sec.AddParagraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
                pFecha.Format.Alignment = ParagraphAlignment.Left;
                pFecha.Format.Font.Size = 9;
                pFecha.Format.SpaceAfter = Unit.FromCentimeter(1); // separa del título

                // 2) Logo flotante (derecha) con ajuste de texto tipo "cuadrado"
                if (!string.IsNullOrWhiteSpace(rutaLogo) && File.Exists(rutaLogo))
                {
                    var logo = sec.AddImage(rutaLogo);
                    logo.LockAspectRatio = true;
                    logo.Width = Unit.FromCentimeter(5.0);

                    // Posicionamiento relativo
                    logo.RelativeHorizontal = RelativeHorizontal.Margin;   // respecto a los márgenes
                    logo.RelativeVertical = RelativeVertical.Page;       // respecto a la página

                    // Ubicación (derecha, un pelín más abajo del borde superior del contenido)
                    logo.Left = ShapePosition.Right;                       // pegado al margen derecho
                    logo.Top = Unit.FromCentimeter(0.2);                  // baja un poco el logo

                }

                // Título del reporte
                var titulo = sec.AddParagraph("Reporte de Estado de Cuenta");
                titulo.Format.Font.Size = 13;
                titulo.Format.Alignment = ParagraphAlignment.Left;
                titulo.Format.Font.Bold = true;
                titulo.Format.SpaceAfter = Unit.FromCentimeter(0.3);

                // ==== Tabla del reporte ====
                var table = sec.AddTable();
                table.Borders.Width = 0.5;

                // Anchos en cm:
                double[] widths = { 1.0, 3.3, 2.2, 1.8, 2.4, 2.0, 2.0, 2.2 };
                foreach (var w in widths) table.AddColumn(Unit.FromCentimeter(w));

                var header = table.AddRow();
                header.Cells[0].AddParagraph("#");
                header.Cells[1].AddParagraph("Cliente");
                header.Cells[2].AddParagraph("Fecha");
                header.Cells[3].AddParagraph("Tipo");
                header.Cells[4].AddParagraph("Referencia");
                header.Cells[5].AddParagraph("Débito ");
                header.Cells[6].AddParagraph("Crédito ");
                header.Cells[7].AddParagraph("Saldo");

                for (int i = 0; i < 8; i++)
                {
                    header.Cells[i].Format.Font.Bold = true;
                    header.Cells[i].Shading.Color = Colors.LightGray;
                }

                // Filas desde el DataGridView
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow) continue;

                    var r = table.AddRow();
                    r.Cells[0].AddParagraph(Convert.ToString(row.Cells["No"].Value));
                    r.Cells[1].AddParagraph(Convert.ToString(row.Cells["cliente"].Value));

                    if (DateTime.TryParse(Convert.ToString(row.Cells["fecha"].Value), out var f))
                        r.Cells[2].AddParagraph(f.ToString("dd/MM/yyyy"));
                    else
                        r.Cells[2].AddParagraph(Convert.ToString(row.Cells["fecha"].Value));

                    r.Cells[3].AddParagraph(Convert.ToString(row.Cells["tipo"].Value));
                    r.Cells[4].AddParagraph(Convert.ToString(row.Cells["referencia"].Value));
                    r.Cells[5].AddParagraph(FormatoN2(row.Cells["debe"].Value));
                    r.Cells[6].AddParagraph(FormatoN2(row.Cells["haber"].Value));
                    r.Cells[7].AddParagraph(FormatoN2(row.Cells["saldo"].Value));
                }

                // ==== Renderizar y abrir ====
                string carpeta = @"C:\imagen\PDF";
                try { System.IO.Directory.CreateDirectory(carpeta); } catch { /* opcional: manejar error */ }

                string nombre = $"Reporte_de_Estado_Cuenta{DateTime.Now:dd-MM-yyyy_HH.mm}.pdf";
                string ruta = Path.Combine(carpeta, nombre);

                var renderer = new PdfDocumentRenderer(true) { Document = doc };
                renderer.RenderDocument();
                renderer.PdfDocument.Save(ruta);

                Process.Start(new ProcessStartInfo { FileName = ruta, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PDF: " + ex.Message);
            }

            static string FormatoN2(object val)
            {
                if (val == null || val == DBNull.Value) return "0.00";
                if (decimal.TryParse(Convert.ToString(val), out var d)) return d.ToString("N2");
                return Convert.ToString(val);
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
