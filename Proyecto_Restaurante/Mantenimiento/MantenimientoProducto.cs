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
using Microsoft.VisualBasic.Logging;
using Proyecto_Restaurante.Consulta;

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class MantenimientoProducto : Form
    {

        //Fields
        private int bordeSize = 2;
        //private int idProductoSeleccionado = -1;


        //Constructor

        private int id_producto_seleccionado = -1;
        public MantenimientoProducto()
        {
            InitializeComponent();
            this.Load += MantenimientoProducto_Load;
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

        private void panelProducto_MouseDown(object sender, MouseEventArgs e)
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

        private void btnMinimizarProducto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarProducto_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaProducto_Click(object sender, EventArgs e)
        {
            ConsultaProductos consulta = new ConsultaProductos(this);
            consulta.Show();
        }

        public event EventHandler ProductoGuardado;

        private void limpiar()
        {
            nombre.Clear();
            costo.Clear();
            venta.Clear();
            txtstockActual.Clear();
            txtstockMinimo.Clear();
            descripcion.Clear();
            comboCategoria.Text = "";
            comboUnidad.Text = "";
            activo.Checked = false;
            desactivo.Checked = false;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) ||
                    string.IsNullOrWhiteSpace(descripcion.Text) ||
                    string.IsNullOrWhiteSpace(costo.Text) ||
                    string.IsNullOrWhiteSpace(venta.Text) ||
                    string.IsNullOrWhiteSpace(txtstockActual.Text) ||
                    string.IsNullOrWhiteSpace(txtstockMinimo.Text) ||
                    comboCategoria.SelectedIndex == -1 ||
                    comboUnidad.SelectedIndex == -1 ||
                    (!activo.Checked && !desactivo.Checked))
            {
                MessageBox.Show("Por favor completa todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conexion.Open();

                int estadoValor = activo.Checked ? 1 : 0;

                // TEMPORAL: usamos ID 1 para categoría y unidad (ajustar cuando agregues ComboBox)
                if (comboCategoria.SelectedIndex == -1 || comboUnidad.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor selecciona una Categoría y una Unidad.");
                    return;
                }

                int idCategoria = Convert.ToInt32(comboCategoria.SelectedValue);
                int idUnidad = Convert.ToInt32(comboUnidad.SelectedValue);

                //string consultaExistencia = "SELECT COUNT(*) FROM producto WHERE nombre = @nombre";
                //SqlCommand cmdExistencia = new SqlCommand(consultaExistencia, conexion);
                //cmdExistencia.Parameters.AddWithValue("@nombre", nombre.Text);
                //int existe = (int)cmdExistencia.ExecuteScalar();
                //string consulta;

                SqlCommand cmd;


                if (id_producto_seleccionado > 0)
                {
                    string consulta = @"UPDATE producto 
                                SET nombre = @nombre, descripcion = @descripcion, id_categoria = @id_categoria, 
                                    id_unidad = @id_unidad, stock_actual = @stock_actual, stock_minimo = @stock_minimo, 
                                    precio_costo = @precio_costo, precio_venta = @precio_venta, estado = @estado 
                                WHERE id_producto = @id";
                    cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@id", id_producto_seleccionado);
                    MessageBox.Show("Producto modificado correctamente.");
                }
                else
                {
                    string consulta = @"INSERT INTO producto (nombre, descripcion, id_categoria, id_unidad, 
                                stock_actual, stock_minimo, precio_costo, precio_venta, estado) 
                                VALUES (@nombre, @descripcion, @id_categoria, @id_unidad, 
                                @stock_actual, @stock_minimo, @precio_costo, @precio_venta, @estado)";
                    cmd = new SqlCommand(consulta, conexion);
                    MessageBox.Show("Producto insertado correctamente.");
                }

                //SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@nombre", nombre.Text);
                cmd.Parameters.AddWithValue("@descripcion", descripcion.Text);
                cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                cmd.Parameters.AddWithValue("@id_unidad", idUnidad);
                cmd.Parameters.AddWithValue("@stock_actual", decimal.Parse(txtstockActual.Text));
                cmd.Parameters.AddWithValue("@stock_minimo", decimal.Parse(txtstockMinimo.Text));
                cmd.Parameters.AddWithValue("@precio_costo", decimal.Parse(costo.Text));
                cmd.Parameters.AddWithValue("@precio_venta", decimal.Parse(venta.Text));
                cmd.Parameters.AddWithValue("@estado", estadoValor);

                cmd.ExecuteNonQuery();
                limpiar();

                id_producto_seleccionado = -1;


                ProductoGuardado?.Invoke(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }



        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => nombre.Focus()));
            CargarCategorias();
            CargarUnidades();
        }

        public void CargarCategorias()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT id_categoria, nombre FROM categoria_producto WHERE estado = 1", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboCategoria.DataSource = dt;
                comboCategoria.DisplayMember = "nombre";
                comboCategoria.ValueMember = "id_categoria";
                comboCategoria.SelectedIndex = -1;  // No seleccionar ninguno por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        public void CargarUnidades()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT id_unidad, nombre FROM unidad_medida WHERE estado = 1", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboUnidad.DataSource = dt;
                comboUnidad.DisplayMember = "nombre";
                comboUnidad.ValueMember = "id_unidad";
                comboUnidad.SelectedIndex = -1; // No seleccionar ninguno por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar unidades: " + ex.Message);
            }
        }

        private void comboUnidad_MouseEnter(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb != null && cb.Items.Count > 0 && !cb.DroppedDown)
            {
                cb.DroppedDown = true;  // Abre el desplegable
            }
        }

        public void CargarDatosProducto(int idProducto,string nombreProd,string descripcionProd,decimal precioCosto,decimal precioVenta,decimal stockActual,decimal stockMinimo,int idCategoria,string nombreCategoria,int idUnidad,string nombreUnidad,int estado)
        {
            // Asegurar que los combos estén cargados
            CargarCategorias();
            CargarUnidades();

            // Forzar refresco de los bindings
            comboCategoria.BindingContext = new BindingContext();
            comboUnidad.BindingContext = new BindingContext();

            comboCategoria.SelectedValue = idCategoria;
            comboUnidad.SelectedValue = idUnidad;

            // ID y textos
            this.id_producto_seleccionado = idProducto;
            nombre.Text = nombreProd;
            descripcion.Text = descripcionProd;
            costo.Text = precioCosto.ToString("F2");
            venta.Text = precioVenta.ToString("F2");
            txtstockActual.Text = stockActual.ToString("F2");
            txtstockMinimo.Text = stockMinimo.ToString("F2");

            // Buscar y asignar la categoría
            foreach (DataRowView item in comboCategoria.Items)
            {
                if ((int)item["id_categoria"] == idCategoria)
                {
                    comboCategoria.SelectedItem = item;
                    break;
                }
            }

            // Buscar y asignar la unidad
            foreach (DataRowView item in comboUnidad.Items)
            {
                if ((int)item["id_unidad"] == idUnidad)
                {
                    comboUnidad.SelectedItem = item;
                    break;
                }
            }

            // Estado
            activo.Checked = (estado == 1);
            desactivo.Checked = (estado == 0);
        }

        private void txtstockActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtstockMinimo.Focus();
            }
        }

        private void txtstockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                costo.Focus();
            }
        }

        private void costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                venta.Focus();
            }
        }

        private void venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                descripcion.Focus();
            }
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtstockActual.Focus();
            }
        }
    }
}
