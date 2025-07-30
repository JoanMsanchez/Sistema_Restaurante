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
        public ConsultaProductos()
        {
            InitializeComponent();
            llenar_tabla_datagridview();
            this.Padding = new Padding(bordeSize); //Border size
            this.BackColor = Color.FromArgb(255, 161, 43); //Border color
        }

        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

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

        private void llenar_tabla_datagridview()
        {
            try
            {
                conexion.Open();
                string consulta = @"
            SELECT 
                p.id_producto,
                p.nombre,
                p.descripcion,
                c.nombre AS categoria,
                u.nombre AS unidad,
                p.stock_actual,
                p.stock_minimo,
                p.precio_costo,
                p.precio_venta,
                p.estado
            FROM producto p
            INNER JOIN categoria_producto c ON p.id_categoria = c.id_categoria
            INNER JOIN unidad_medida u ON p.id_unidad = u.id_unidad";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                int id = Convert.ToInt32(fila.Cells["id_producto"].Value);
                string nombre = fila.Cells["nombre"].Value.ToString();
                string descripcion = fila.Cells["descripcion"].Value.ToString();
                string categoria = fila.Cells["categoria"].Value.ToString();
                string unidad = fila.Cells["unidad"].Value.ToString();
                decimal precioCosto = Convert.ToDecimal(fila.Cells["precio_costo"].Value);
                decimal precioVenta = Convert.ToDecimal(fila.Cells["precio_venta"].Value);
                decimal stockActual = Convert.ToDecimal(fila.Cells["stock_actual"].Value);
                decimal stockMinimo = Convert.ToDecimal(fila.Cells["stock_minimo"].Value);
                int estado = Convert.ToInt32(fila.Cells["estado"].Value);

                Form formularioExistente = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is MantenimientoProducto);
                if (formularioExistente != null)
                {
                    formularioExistente.BringToFront();
                    MessageBox.Show("El formulario ya está abierto.");
                    return;
                }

                MantenimientoProducto mantenimiento = new MantenimientoProducto();
                mantenimiento.Show();
                mantenimiento.CargarDatosProducto(id, nombre, descripcion, precioCosto, precioVenta, stockActual, stockMinimo, categoria, unidad, estado);
            }

        }
    }
}
