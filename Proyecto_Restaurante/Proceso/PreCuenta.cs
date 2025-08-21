using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using static Proyecto_Restaurante.Proceso.ProcesoFacturacion;

namespace Proyecto_Restaurante.Proceso
{
    public partial class PreCuenta : Form
    {
        private readonly PrecuentaData _data;

        public PreCuenta()
        {
            InitializeComponent();
            txtOrden.TabStop = false;
            txtSalaMesa.TabStop = false;

        }

        public PreCuenta(PrecuentaData data) : this()
        {
            _data = data;
            Shown += (s, e) => CargarDatos();
        }

        private void CargarDatos()
        {
            // ===== Cabecera / meta =====
            txtOrden.Text = "Orden #" + _data.IdOrden;
            txtSalaMesa.Text = _data.SalaMesa ?? $"Mesa ?";
            txtCliente.Text = string.IsNullOrWhiteSpace(_data.Cliente) ? "Consumidor Final" : _data.Cliente.Trim();
            txtCondicion.Text = _data.Condicion ?? "";
            txtAtendido.Text = _data.Atendido ?? "";
            if (txtFecha != null)
                txtFecha.Text = (_data.Fecha == default ? DateTime.Now : _data.Fecha)
                                .ToString("dd/MM/yyyy HH:mm");

            // ===== Grilla =====
            ConfigurarGridSiHaceFalta();
            dgvPreCuenta.AutoGenerateColumns = false;
            dgvPreCuenta.DataSource = _data.Lineas;

            // ===== Totales =====
            RecalcularTotales();
        }

        private void RecalcularTotales()
        {
            decimal sub = _data.Lineas?.Sum(l => l.Importe) ?? 0m;
            decimal itb = Math.Round(sub * _data.ItbisRate, 2);
            decimal tot = sub + itb;

            txtSubTotal.Text = sub.ToString("N2");
            txtItbis.Text = itb.ToString("N2");
            txtTotal.Text = tot.ToString("N2");
        }

        private void ConfigurarGridSiHaceFalta()
        {
            if (dgvPreCuenta.Columns.Count > 0) return;

            // Evita filas en blanco y edición
            dgvPreCuenta.ReadOnly = true;
            dgvPreCuenta.AllowUserToAddRows = false;
            dgvPreCuenta.AllowUserToDeleteRows = false;
            dgvPreCuenta.RowHeadersVisible = false;
            dgvPreCuenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Columnas
            var colNo = new DataGridViewTextBoxColumn
            {
                HeaderText = "No",
                DataPropertyName = nameof(PrecuentaLinea.Nro),
                Width = 50,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            var colProd = new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = nameof(PrecuentaLinea.Nombre),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            var colCant = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cant",
                DataPropertyName = nameof(PrecuentaLinea.Cantidad),
                Width = 80,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "N2" }
            };
            var colPrecio = new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio",
                DataPropertyName = nameof(PrecuentaLinea.Precio),
                Width = 95,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" }
            };
            var colImporte = new DataGridViewTextBoxColumn
            {
                HeaderText = "Importe",
                DataPropertyName = nameof(PrecuentaLinea.Importe),
                Width = 110,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" }
            };

            dgvPreCuenta.Columns.AddRange(colNo, colProd, colCant, colPrecio, colImporte);
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            ExportarPDF_PreCuenta(
                dgvPreCuenta,
                nombreEmpresa: "LA ESQUINITA",
                lemaEmpresa: "EL GUSTO COMIENZA EN LA ESQUINA",
                rutaLogo: @"C:\imagen\LOGONEGRO.png"
            );
        }

        private void ExportarPDF_PreCuenta(
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

            // ===== Resolver índices por HeaderText (sin helpers) =====
            int idxNo = -1, idxProd = -1, idxCant = -1, idxPrecio = -1, idxImporte = -1;
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                string h = grid.Columns[i].HeaderText?.Trim();
                if (string.Equals(h, "No", StringComparison.OrdinalIgnoreCase)) idxNo = i;
                else if (string.Equals(h, "Producto", StringComparison.OrdinalIgnoreCase)) idxProd = i;
                else if (string.Equals(h, "Cant", StringComparison.OrdinalIgnoreCase)) idxCant = i;
                else if (string.Equals(h, "Precio", StringComparison.OrdinalIgnoreCase)) idxPrecio = i;
                else if (string.Equals(h, "Importe", StringComparison.OrdinalIgnoreCase)) idxImporte = i;
            }
            if (idxNo < 0 || idxProd < 0 || idxCant < 0 || idxPrecio < 0 || idxImporte < 0)
            {
                MessageBox.Show("Falta una o más columnas requeridas: 'No', 'Producto', 'Cant', 'Precio', 'Importe'.");
                return;
            }

            try
            {
                // ==== Documento ====
                var doc = new MigraDoc.DocumentObjectModel.Document();
                doc.Info.Title = "Pre-Cuenta";
                var sec = doc.AddSection();
                sec.PageSetup.TopMargin = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(1.5);
                sec.PageSetup.BottomMargin = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(1.5);

                // ==== TÍTULO PRINCIPAL ====
                var titulo = sec.AddParagraph("PRE CUENTA");
                titulo.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;
                titulo.Format.Font.Size = 20;
                titulo.Format.Font.Bold = true;
                titulo.Format.SpaceAfter = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(0.7);

                // ==== Encabezado empresa ====
                var pEmpresa = sec.AddParagraph(nombreEmpresa ?? "");
                pEmpresa.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Left;
                pEmpresa.Format.Font.Size = 14;
                pEmpresa.Format.Font.Bold = true;

                var pLema = sec.AddParagraph(lemaEmpresa ?? "");
                pLema.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Left;
                pLema.Format.Font.Size = 10;
                pLema.Format.Font.Italic = true;

                var pFecha = sec.AddParagraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
                pFecha.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Left;
                pFecha.Format.Font.Size = 9;
                pFecha.Format.SpaceAfter = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(0.5);

                if (!string.IsNullOrWhiteSpace(rutaLogo) && System.IO.File.Exists(rutaLogo))
                {
                    var logo = sec.AddImage(rutaLogo);
                    logo.LockAspectRatio = true;
                    logo.Width = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(5.0);
                    logo.RelativeHorizontal = MigraDoc.DocumentObjectModel.Shapes.RelativeHorizontal.Margin;
                    logo.RelativeVertical = MigraDoc.DocumentObjectModel.Shapes.RelativeVertical.Page;
                    logo.Left = MigraDoc.DocumentObjectModel.Shapes.ShapePosition.Right;
                    logo.Top = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(0.2);
                }

                // ==== Cabecera de la orden ====
                var cab = sec.AddTable();
                cab.Borders.Visible = false;
                cab.AddColumn(MigraDoc.DocumentObjectModel.Unit.FromCentimeter(3.2));
                cab.AddColumn(MigraDoc.DocumentObjectModel.Unit.FromCentimeter(12.5));

                var r1 = cab.AddRow(); r1.Cells[0].AddParagraph("Cliente").Format.Font.Bold = true; r1.Cells[1].AddParagraph(txtCliente.Text ?? "");
                var r2 = cab.AddRow(); r2.Cells[0].AddParagraph("Condicion").Format.Font.Bold = true; r2.Cells[1].AddParagraph(txtCondicion.Text ?? "");
                var r3 = cab.AddRow(); r3.Cells[0].AddParagraph("Fecha").Format.Font.Bold = true; r3.Cells[1].AddParagraph(txtFecha.Text ?? "");
                var r4 = cab.AddRow(); r4.Cells[0].AddParagraph("Atendido por").Format.Font.Bold = true; r4.Cells[1].AddParagraph(txtAtendido.Text ?? "");
                sec.AddParagraph().AddLineBreak();

                // ==== Tabla detalle ====
                var table = sec.AddTable();
                table.Borders.Width = 0.5;

                double[] widths = { 1.2, 6.0, 2.5, 3.0, 3.5 };
                foreach (var w in widths) table.AddColumn(MigraDoc.DocumentObjectModel.Unit.FromCentimeter(w));

                var header = table.AddRow();
                header.HeadingFormat = true;
                header.Cells[0].AddParagraph("No");
                header.Cells[1].AddParagraph("Producto");
                header.Cells[2].AddParagraph("Cant");
                header.Cells[3].AddParagraph("Precio");
                header.Cells[4].AddParagraph("Importe");
                for (int i = 0; i < 5; i++)
                {
                    header.Cells[i].Format.Font.Bold = true;
                    header.Cells[i].Shading.Color = MigraDoc.DocumentObjectModel.Colors.LightGray;
                    header.Cells[i].Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;
                }

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow) continue;

                    var tr = table.AddRow();
                    tr.Cells[0].AddParagraph(Convert.ToString(row.Cells[idxNo].Value));
                    tr.Cells[1].AddParagraph(Convert.ToString(row.Cells[idxProd].Value));
                    tr.Cells[2].AddParagraph(FormatoN2(row.Cells[idxCant].Value));
                    tr.Cells[3].AddParagraph(FormatoN2(row.Cells[idxPrecio].Value));
                    tr.Cells[4].AddParagraph(FormatoN2(row.Cells[idxImporte].Value));
                }

                // ==== Totales ====
                sec.AddParagraph().AddLineBreak();
                var tot = sec.AddTable();
                tot.Borders.Visible = false;
                tot.AddColumn(MigraDoc.DocumentObjectModel.Unit.FromCentimeter(12.0));
                tot.AddColumn(MigraDoc.DocumentObjectModel.Unit.FromCentimeter(4.2));

                var t1 = tot.AddRow(); t1.Cells[0].AddParagraph("SubTotal:").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right; t1.Cells[0].Format.Font.Bold = true; t1.Cells[1].AddParagraph(txtSubTotal.Text ?? "0.00").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
                var t2 = tot.AddRow(); t2.Cells[0].AddParagraph("ITBIS:").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right; t2.Cells[0].Format.Font.Bold = true; t2.Cells[1].AddParagraph(txtItbis.Text ?? "0.00").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
                var t3 = tot.AddRow(); t3.Cells[0].AddParagraph("Total:").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right; t3.Cells[0].Format.Font.Bold = true; t3.Cells[1].AddParagraph(txtTotal.Text ?? "0.00").Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;

                // ==== Guardar ====
                string carpeta = @"C:\imagen\PDF";
                try { System.IO.Directory.CreateDirectory(carpeta); } catch { }
                string nombre = $"PreCuenta_{DateTime.Now:dd-MM-yyyy_HH.mm}.pdf";
                string ruta = System.IO.Path.Combine(carpeta, nombre);

                var renderer = new MigraDoc.Rendering.PdfDocumentRenderer(true) { Document = doc };
                renderer.RenderDocument();
                renderer.PdfDocument.Save(ruta);

                Process.Start(new ProcessStartInfo { FileName = ruta, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PDF: " + ex.Message);
            }

            // === Formato N2 dentro del método (como pediste) ===
            static string FormatoN2(object val)
            {
                if (val == null || val == DBNull.Value) return "0.00";
                if (decimal.TryParse(Convert.ToString(val), out var d)) return d.ToString("N2");
                return Convert.ToString(val);
            }
        }
    }
}
