using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Restaurante.Mantenimiento;


namespace Proyecto_Restaurante.Consulta
{
    public partial class ConsultaProductos : Form
    {
        //Fields
        private int bordeSize = 2;


        //Constructor

        private MantenimientoProducto mantenimientoProductoForm;

        public ConsultaProductos(MantenimientoProducto mantenimientoProducto)
        {
            InitializeComponent();
            llenar_tabla_datagridview();
            this.mantenimientoProductoForm = mantenimientoProducto;
            this.Padding = new Padding(bordeSize); //Border size
            this.BackColor = Color.FromArgb(255, 161, 43); //Border color
        }

        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        //SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        private void panelConsultaProducto_MouseDown(object sender, MouseEventArgs e)
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
        private void UnidadMedida_Resize(object sender, EventArgs e)
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

        private void btnMinimizarConsultaProducto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarConsultaProducto_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarConsultaProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenar_tabla_datagridview(string filtroSql = "")
        {
            try
            {
                conexion.Open();
                string consulta = @"
                    SELECT 
                        p.id_producto,
                        p.nombre,
                        p.descripcion,
                        c.id_categoria,
                        c.nombre AS categoria,
                        u.id_unidad,
                        u.nombre AS unidad,
                        p.stock_actual,
                        p.stock_minimo,
                        p.precio_costo,
                        p.precio_venta,
                        p.estado,
                        p.imagen_ruta
                    FROM producto p
                    INNER JOIN categoria_producto c ON p.id_categoria = c.id_categoria
                    INNER JOIN unidad_medida u ON p.id_unidad = u.id_unidad";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                dt.Columns.Add(columnaSecuencia);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }

                dt.Columns["No"].SetOrdinal(0);
                dataGridView1.DataSource = dt;

                // Ocultar columnas de ID
                if (dataGridView1.Columns.Contains("id_categoria"))
                    dataGridView1.Columns["id_categoria"].Visible = false;
                if (dataGridView1.Columns.Contains("id_unidad"))
                    dataGridView1.Columns["id_unidad"].Visible = false;
                if (dataGridView1.Columns.Contains("id_producto"))
                    dataGridView1.Columns["id_producto"].Visible = false;
                if (dataGridView1.Columns.Contains("imagen_ruta"))
                    dataGridView1.Columns["imagen_ruta"].Visible = false;

                // Cambiar encabezados
                dataGridView1.Columns["No"].HeaderText = "#";
                dataGridView1.Columns["nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["descripcion"].HeaderText = "Descripción";
                dataGridView1.Columns["categoria"].HeaderText = "Categoría";
                dataGridView1.Columns["unidad"].HeaderText = "Unidad";
                dataGridView1.Columns["stock_actual"].HeaderText = "Stock Actual";
                dataGridView1.Columns["stock_minimo"].HeaderText = "Stock Mínimo";
                dataGridView1.Columns["precio_costo"].HeaderText = "Costo";
                dataGridView1.Columns["precio_venta"].HeaderText = "Precio Venta";
                dataGridView1.Columns["estado"].HeaderText = "Estado";
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


        private void AbrirMantenimiento(int id, string nombre, string descripcion,
            decimal precioCosto, decimal precioVenta, decimal stockActual, decimal stockMinimo,
            int idCategoria, string nombreCategoria, int idUnidad, string nombreUnidad, int estado, string ruta)
        {
            mantenimientoProductoForm.CargarDatosProducto(id, nombre, descripcion, precioCosto, precioVenta,
               stockActual, stockMinimo, idCategoria, nombreCategoria, idUnidad, nombreUnidad, estado, ruta);

            mantenimientoProductoForm.Show();
            mantenimientoProductoForm.BringToFront();
            this.Close(); // cerrar la ventana de consulta
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                int id = Convert.ToInt32(fila.Cells["id_producto"].Value);
                string nombre = fila.Cells["nombre"].Value.ToString();
                string descripcion = fila.Cells["descripcion"].Value.ToString();
                int idCategoria = Convert.ToInt32(fila.Cells["id_categoria"].Value);
                string nombreCategoria = fila.Cells["categoria"].Value.ToString();
                int idUnidad = Convert.ToInt32(fila.Cells["id_unidad"].Value);
                string nombreUnidad = fila.Cells["unidad"].Value.ToString();
                decimal precioCosto = Convert.ToDecimal(fila.Cells["precio_costo"].Value);
                decimal precioVenta = Convert.ToDecimal(fila.Cells["precio_venta"].Value);
                decimal stockActual = Convert.ToDecimal(fila.Cells["stock_actual"].Value);
                decimal stockMinimo = Convert.ToDecimal(fila.Cells["stock_minimo"].Value);
                int estado = Convert.ToInt32(fila.Cells["estado"].Value);
                string imagen = fila.Cells["imagen_ruta"].Value.ToString();

                AbrirMantenimiento(id, nombre, descripcion, precioCosto, precioVenta,
                    stockActual, stockMinimo, idCategoria, nombreCategoria, idUnidad, nombreUnidad, estado, imagen);
            }
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {

            try
            {
                conexion.Open();

                string consulta = @"
                    SELECT 
                        p.id_producto,
                        p.nombre,
                        p.descripcion,
                        c.id_categoria,
                        c.nombre AS categoria,
                        u.id_unidad,
                        u.nombre AS unidad,
                        p.stock_actual,
                        p.stock_minimo,
                        p.precio_costo,
                        p.precio_venta,
                        p.estado
                    FROM producto p
                    INNER JOIN categoria_producto c ON p.id_categoria = c.id_categoria
                    INNER JOIN unidad_medida u ON p.id_unidad = u.id_unidad
                    WHERE 1=1";

                if (nombreproducto.Checked)
                {
                    consulta += $" AND p.nombre LIKE '%{buscar.Text}%'";
                }
                else if (categoriaproducto.Checked)
                {
                    consulta += $" AND c.nombre LIKE '%{buscar.Text}%'";
                }
                else if (unidadproducto.Checked)
                {
                    consulta += $" AND u.nombre LIKE '%{buscar.Text}%'";
                }
                else
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda");
                    return;
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                dt.Columns.Add(columnaSecuencia);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }

                dt.Columns["No"].SetOrdinal(0);
                dataGridView1.DataSource = dt;

                // Ocultar columnas ID
                if (dataGridView1.Columns.Contains("id_producto"))
                    dataGridView1.Columns["id_producto"].Visible = false;
                if (dataGridView1.Columns.Contains("id_categoria"))
                    dataGridView1.Columns["id_categoria"].Visible = false;
                if (dataGridView1.Columns.Contains("id_unidad"))
                    dataGridView1.Columns["id_unidad"].Visible = false;

                dataGridView1.Columns["No"].HeaderText = "#";
                dataGridView1.Columns["nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["descripcion"].HeaderText = "Descripción";
                dataGridView1.Columns["categoria"].HeaderText = "Categoría";
                dataGridView1.Columns["unidad"].HeaderText = "Unidad";
                dataGridView1.Columns["stock_actual"].HeaderText = "Stock Actual";
                dataGridView1.Columns["stock_minimo"].HeaderText = "Stock Mínimo";
                dataGridView1.Columns["precio_costo"].HeaderText = "Costo";
                dataGridView1.Columns["precio_venta"].HeaderText = "Precio Venta";
                dataGridView1.Columns["estado"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void nombreproducto_CheckedChanged(object sender, EventArgs e)
        {
            buscar.Focus();

        }

        private void categoriaproducto_CheckedChanged(object sender, EventArgs e)
        {
            buscar.Focus();

        }

        private void unidadproducto_CheckedChanged(object sender, EventArgs e)
        {
            buscar.Focus();

        }
    }
}
