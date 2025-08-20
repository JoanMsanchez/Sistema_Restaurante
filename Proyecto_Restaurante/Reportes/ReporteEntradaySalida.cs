using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;


namespace Proyecto_Restaurante.Reportes
{
    public partial class ReporteEntradaySalida : Form
    {

        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        //SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        public ReporteEntradaySalida()
        {
            InitializeComponent();
            var hoy = DateTime.Today;
            dtpDesde.Value = new DateTime(hoy.Year, hoy.Month, 1);
            dtpHasta.Value = dtpDesde.Value.AddMonths(1).AddDays(-1);

            // Refrescar al cambiar filtros
            rbEntrada.CheckedChanged += (s, e) => llenar_tabla_datagridview();
            rbSalida.CheckedChanged += (s, e) => llenar_tabla_datagridview();
            dtpDesde.ValueChanged += (s, e) => llenar_tabla_datagridview();
            dtpHasta.ValueChanged += (s, e) => llenar_tabla_datagridview();

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
            int? afecta = null;       // Todo (sin filtro)
            if (rbEntrada.Checked) afecta = 1;
            else if (rbSalida.Checked) afecta = -1;

            DateTime desde = dtpDesde.Value.Date;
            DateTime hastaExcl = dtpHasta.Value.Date.AddDays(1);

            try
            {
                conexion.Open();

                string consulta = @"
                    SELECT
                        mi.id_movimiento,
                        mi.fecha,
                        p.nombre AS producto,
                        CASE WHEN tm.afecta_stock = 1 THEN 'Entrada'
                             WHEN tm.afecta_stock = -1 THEN 'Salida'
                             ELSE tm.descripcion END AS tipo,
                        mi.cantidad,
                        ISNULL(po.nombre, '') AS proveedor
                    FROM movimiento_inventario mi
                    INNER JOIN producto        p  ON mi.id_producto  = p.id_producto
                    INNER JOIN tipo_movimiento tm ON mi.id_tipo_mov  = tm.id_tipo_mov
                    LEFT  JOIN proveedor       po ON mi.id_proveedor = po.id_proveedor
                    WHERE mi.fecha >= @desde
                      AND mi.fecha <  @hastaExcl
                      AND (@afecta IS NULL OR tm.afecta_stock = @afecta)
                    ORDER BY mi.fecha, p.nombre;";

                using (var cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.Add("@desde", SqlDbType.DateTime).Value = desde;
                    cmd.Parameters.Add("@hastaExcl", SqlDbType.DateTime).Value = hastaExcl;
                    var p = cmd.Parameters.Add("@afecta", SqlDbType.Int);
                    p.Value = afecta.HasValue ? (object)afecta.Value : DBNull.Value;

                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);

                        if (!dt.Columns.Contains("No")) dt.Columns.Add("No", typeof(int));
                        for (int i = 0; i < dt.Rows.Count; i++) dt.Rows[i]["No"] = i + 1;
                        dt.Columns["No"].SetOrdinal(0);

                        dgvReporteEntradaySalida.AutoGenerateColumns = true;
                        dgvReporteEntradaySalida.DataSource = dt;

                        if (dgvReporteEntradaySalida.Columns.Contains("id_movimiento"))
                            dgvReporteEntradaySalida.Columns["id_movimiento"].Visible = false;

                        dgvReporteEntradaySalida.Columns["No"].HeaderText = "No";
                        dgvReporteEntradaySalida.Columns["fecha"].HeaderText = "Fecha";
                        dgvReporteEntradaySalida.Columns["producto"].HeaderText = "Producto";
                        dgvReporteEntradaySalida.Columns["tipo"].HeaderText = "Tipo";
                        dgvReporteEntradaySalida.Columns["cantidad"].HeaderText = "Cantidad";
                        dgvReporteEntradaySalida.Columns["proveedor"].HeaderText = "Proveedor";

                        if (dgvReporteEntradaySalida.Columns.Contains("fecha"))
                            dgvReporteEntradaySalida.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        if (dgvReporteEntradaySalida.Columns.Contains("cantidad"))
                        {
                            dgvReporteEntradaySalida.Columns["cantidad"].DefaultCellStyle.Format = "N2";
                            dgvReporteEntradaySalida.Columns["cantidad"].DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
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
            string[] req = { "No", "fecha", "producto", "tipo", "cantidad", "proveedor" };
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
                doc.Info.Title = "Reporte - Stock Actual";
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
                var titulo = sec.AddParagraph("Reporte de Movimineto de Entrada y Salida");
                titulo.Format.Font.Size = 13;
                titulo.Format.Alignment = ParagraphAlignment.Left;
                titulo.Format.Font.Bold = true;
                titulo.Format.SpaceAfter = Unit.FromCentimeter(0.3);

                // ==== Tabla del reporte ====
                var table = sec.AddTable();
                table.Borders.Width = 0.5;

                // Anchos en cm:
                double[] widths = { 1.2, 3.0, 4.5, 2.0, 2.5, 3.0 };
                foreach (var w in widths) table.AddColumn(Unit.FromCentimeter(w));

                var header = table.AddRow();
                header.HeadingFormat = true; // repetir cabecera en cada página
                header.Cells[0].AddParagraph("No");
                header.Cells[1].AddParagraph("Fecha");
                header.Cells[2].AddParagraph("Producto");
                header.Cells[3].AddParagraph("Tipo");
                header.Cells[4].AddParagraph("Cantidad");
                header.Cells[5].AddParagraph("Proveedor");

                for (int i = 0; i < 6; i++)
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

                    DateTime f = Convert.ToDateTime(row.Cells["fecha"].Value);
                    r.Cells[1].AddParagraph(f.ToString("dd/MM/yyyy"));

                    r.Cells[2].AddParagraph(Convert.ToString(row.Cells["Producto"].Value));
                    r.Cells[3].AddParagraph(Convert.ToString(row.Cells["Tipo"].Value));

                    r.Cells[4].AddParagraph(FormatoN2(row.Cells["Cantidad"].Value));
                    r.Cells[5].AddParagraph(Convert.ToString(row.Cells["Proveedor"].Value));
                }

                // ==== Renderizar y abrir ====
                string carpeta = @"C:\imagen\PDF";
                try { System.IO.Directory.CreateDirectory(carpeta); } catch { /* opcional: manejar error */ }

                string nombre = $"Reporte_Entrada_y_Salida_{DateTime.Now:dd-MM-yyyy_HH.mm}.pdf";
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

        private void pdf_Click_1(object sender, EventArgs e)
        {
            ExportarPDF_StockActual(
               dgvReporteEntradaySalida,
               nombreEmpresa: "LA ESQUINITA",
               lemaEmpresa: "EL GUSTO COMIENZA EN LA ESQUINA",
               rutaLogo: @"C:\imagen\LOGONEGRO.png"  // opcional; pásalo null o "" si no quieres logo
            );
        }
    }
}
