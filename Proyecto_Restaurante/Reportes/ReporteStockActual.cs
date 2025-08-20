using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;



namespace Proyecto_Restaurante.Reportes
{
    public partial class ReporteStockActual : Form
    {

        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        //SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        public ReporteStockActual()
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

        private void btnMinimizarUnidadMedida_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarUnidadMedida_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarUnidadMedida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenar_tabla_datagridview()
        {
            try
            {
                conexion.Open();

                string consulta = @"
                    SELECT
                        p.id_producto,
                        p.nombre  AS producto,
                        c.nombre  AS categoria,
                        p.stock_actual,
                        p.stock_minimo
                    FROM producto p
                    INNER JOIN categoria_producto c ON p.id_categoria = c.id_categoria
                    WHERE p.estado = 1";  // solo activos

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Columna secuencia "No" al principio
                if (!dt.Columns.Contains("No"))
                {
                    DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                    dt.Columns.Add(columnaSecuencia);
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }

                dt.Columns["No"].SetOrdinal(0);
                dgvReporteProducto.DataSource = dt;

                // Ocultar columnas de ID
                if (dgvReporteProducto.Columns.Contains("id_producto"))
                    dgvReporteProducto.Columns["id_producto"].Visible = false;

                // Cambiar encabezados (igual que tú)
                dgvReporteProducto.Columns["No"].HeaderText = "#";
                dgvReporteProducto.Columns["producto"].HeaderText = "Nombre";
                dgvReporteProducto.Columns["categoria"].HeaderText = "Categoría";
                dgvReporteProducto.Columns["stock_actual"].HeaderText = "Stock Actual";
                dgvReporteProducto.Columns["stock_minimo"].HeaderText = "Stock Mínimo";
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

        private void pdf_Click(object sender, EventArgs e)
        {
            ExportarPDF_StockActual(
               dgvReporteProducto,
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
            string[] req = { "No", "producto", "categoria", "stock_actual", "stock_minimo" };
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
                var titulo = sec.AddParagraph("Reporte de Productos — Stock Actual");
                titulo.Format.Font.Size = 13;
                titulo.Format.Alignment = ParagraphAlignment.Left;
                titulo.Format.Font.Bold = true;
                titulo.Format.SpaceAfter = Unit.FromCentimeter(0.3);

                // ==== Tabla del reporte ====
                var table = sec.AddTable();
                table.Borders.Width = 0.5;

                // Anchos en cm: #, Nombre, Categoría, Stock, Mínimo
                double[] widths = { 1.2, 5.5, 3.5, 3.0, 3.0 };
                foreach (var w in widths) table.AddColumn(Unit.FromCentimeter(w));

                var header = table.AddRow();
                header.HeadingFormat = true; // repetir cabecera en cada página
                header.Cells[0].AddParagraph("#");
                header.Cells[1].AddParagraph("Nombre");
                header.Cells[2].AddParagraph("Categoría");
                header.Cells[3].AddParagraph("Stock Actual");
                header.Cells[4].AddParagraph("Stock Mínimo");
                for (int i = 0; i < 5; i++)
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
                    r.Cells[1].AddParagraph(Convert.ToString(row.Cells["producto"].Value));
                    r.Cells[2].AddParagraph(Convert.ToString(row.Cells["categoria"].Value));
                    r.Cells[3].AddParagraph(FormatoN2(row.Cells["stock_actual"].Value));
                    r.Cells[4].AddParagraph(FormatoN2(row.Cells["stock_minimo"].Value));
                }

                // ==== Renderizar y abrir ====
                string carpeta = @"C:\imagen\PDF";
                try { System.IO.Directory.CreateDirectory(carpeta); } catch { /* opcional: manejar error */ }

                string nombre = $"Reporte_StockActual_{DateTime.Now:dd-MM-yyyy_HH.mm}.pdf";
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
    }
}
