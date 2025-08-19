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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Restaurante.Consulta
{
    public partial class ConsultaProveedor : Form
    {
        private MantenimientoProveedor mantenimientoForm;

        //Fields
        private int bordeSize = 2;
        private int idProductoSeleccionado = -1;


        //Constructor
        public ConsultaProveedor()
        {
            InitializeComponent();
            llenar_tabla_datagridview();
            this.Shown += ConsultaProveedor_Shown;
            this.Padding = new Padding(bordeSize); //Border size
            this.BackColor = Color.FromArgb(255, 161, 43); //Border color
        }

        private void ConsultaProveedor_Shown1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        //SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        private void panelConsultaProveedor_MouseDown(object sender, MouseEventArgs e)
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

        private void btnMinimizarProveedor_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarproveedor_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenar_tabla_datagridview()
        {
            try
            {
                string consulta = "SELECT * FROM proveedor";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                dt.Columns.Add(columnaSecuencia);

                // Llenar con la secuencia
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }

                // Mover la columna "No" a la posición 0 (primera)
                dt.Columns["No"].SetOrdinal(0);

                DGVProveedor.DataSource = dt;

                if (DGVProveedor.Columns.Contains("id_proveedor"))
                {
                    DGVProveedor.Columns["id_proveedor"].Visible = false;
                }
                DGVProveedor.Columns["No"].HeaderText = "#";
                DGVProveedor.Columns["nombre"].HeaderText = "Nombre";
                DGVProveedor.Columns["telefono"].HeaderText = "Telefono";
                DGVProveedor.Columns["email"].HeaderText = "E-mail";
                DGVProveedor.Columns["direccion"].HeaderText = "Direccion";
                DGVProveedor.Columns["estado"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar tabla: " + ex.Message);
            }
        }

        private void busca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                // Consulta por nombre (LIKE)
                string consulta = "SELECT * FROM proveedor WHERE nombre LIKE @busqueda";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.SelectCommand.Parameters.AddWithValue("@busqueda", "%" + busca.Text.Trim() + "%");

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Agregar columna "No"
                DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                dt.Columns.Add(columnaSecuencia);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }

                dt.Columns["No"].SetOrdinal(0); // Mover la columna "No" al inicio

                DGVProveedor.DataSource = dt;

                // Ocultar columna id si existe
                if (DGVProveedor.Columns.Contains("id_proveedor"))
                {
                    DGVProveedor.Columns["id_proveedor"].Visible = false;
                }

                // Encabezados personalizados
                DGVProveedor.Columns["No"].HeaderText = "#";
                DGVProveedor.Columns["nombre"].HeaderText = "Nombre";
                DGVProveedor.Columns["telefono"].HeaderText = "Teléfono";
                DGVProveedor.Columns["email"].HeaderText = "Correo";
                DGVProveedor.Columns["direccion"].HeaderText = "Dirección";
                DGVProveedor.Columns["estado"].HeaderText = "Estado";
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

        public ConsultaProveedor(MantenimientoProveedor mantenimientoForm = null)
        {
            InitializeComponent();
            this.mantenimientoForm = mantenimientoForm;
            llenar_tabla_datagridview();
        }


        private void DGVProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGVProveedor.Rows[e.RowIndex];

                int idProveedor = Convert.ToInt32(fila.Cells["id_proveedor"].Value);
                string nombreProveedor = fila.Cells["nombre"].Value.ToString();
                string telefonoProveedor = fila.Cells["telefono"].Value.ToString();
                string emailProveedor = fila.Cells["email"].Value.ToString();
                string direccionProveedor = fila.Cells["direccion"].Value.ToString();
                int estadoProveedor = Convert.ToInt32(fila.Cells["estado"].Value);
                //string estadoProveedor = fila.Cells["estado"].Value.ToString();

                // Crear form si es necesario
                if (mantenimientoForm == null || mantenimientoForm.IsDisposed)
                {
                    mantenimientoForm = new MantenimientoProveedor();
                }

                // Solo una llamada válida
                mantenimientoForm.CargarDatos(idProveedor, nombreProveedor, telefonoProveedor, emailProveedor, direccionProveedor, estadoProveedor);

                mantenimientoForm.Show();
                mantenimientoForm.BringToFront();

                this.Close();
            }
        }

        private void ConsultaProveedor_Shown(object sender, EventArgs e)
        {
            busca.Focus();

        }
    }
}
