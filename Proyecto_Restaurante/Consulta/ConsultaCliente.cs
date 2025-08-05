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
    public partial class ConsultaCliente : Form
    {
        //Fields
        private int bordeSize = 2;
        private int idProductoSeleccionado = -1;


        //Constructor
        public ConsultaCliente()
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

        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        //SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");


        private void panelConsultaCliente_MouseDown(object sender, MouseEventArgs e)
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

        private void btnMinimizarCategoria_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarCategoria_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenar_tabla_datagridview()
        {
            try
            {
                string query = @"
            SELECT c.id_cliente, c.nombre, c.telefono, c.email, c.direccion,
                   c.id_condicion,
                   co.descripcion AS condicion,
                   CASE WHEN c.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS estadoCliente
            FROM cliente c
            INNER JOIN condicion co ON c.id_condicion = co.id_condicion";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();

                conexion.Open();
                adapter.Fill(dt);
                // Agregar columna de números secuenciales
                DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                dt.Columns.Add(columnaSecuencia);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }
                dt.Columns["No"].SetOrdinal(0);

                dt.Columns["No"].SetOrdinal(0); // Colocar "No" al inicio
                conexion.Close();

                DGVConsultaCliente.DataSource = dt;
                DGVConsultaCliente.Columns["id_cliente"].Visible = false;
                DGVConsultaCliente.Columns["id_condicion"].Visible = false;
                DGVConsultaCliente.Columns["condicion"].HeaderText = "Condición";
                DGVConsultaCliente.Columns["estadoCliente"].HeaderText = "Estado";
                DGVConsultaCliente.Columns["No"].HeaderText = "#";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
        private void buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!buscaNombre.Checked && !buscaCondicion.Checked)
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda");
                    return;
                }

                conexion.Open();

                string consulta = @"
            SELECT 
                c.id_cliente, c.nombre, c.telefono, c.email, c.direccion,
                c.id_condicion,
                co.descripcion AS condicion,
                CASE WHEN c.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS estadoCliente
            FROM cliente c
            INNER JOIN condicion co ON c.id_condicion = co.id_condicion
            WHERE 1=1";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;

                if (buscaNombre.Checked)
                {
                    consulta += " AND c.nombre LIKE @buscar";
                    cmd.Parameters.AddWithValue("@buscar", "%" + buscar.Text.Trim() + "%");
                }
                else if (buscaCondicion.Checked)
                {
                    consulta += " AND co.descripcion LIKE @buscar";
                    cmd.Parameters.AddWithValue("@buscar", "%" + buscar.Text.Trim() + "%");
                }

                cmd.CommandText = consulta;

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Agregar columna de números secuenciales
                DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                dt.Columns.Add(columnaSecuencia);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }

                dt.Columns["No"].SetOrdinal(0); // Colocar la columna "No" al inicio

                DGVConsultaCliente.DataSource = dt;

                // Ocultar columna id_cliente
                if (DGVConsultaCliente.Columns.Contains("id_cliente"))
                    DGVConsultaCliente.Columns["id_cliente"].Visible = false;
                    DGVConsultaCliente.Columns["id_condicion"].Visible = false;

                // Ajustar encabezados
                DGVConsultaCliente.Columns["No"].HeaderText = "#";
                DGVConsultaCliente.Columns["nombre"].HeaderText = "Nombre";
                DGVConsultaCliente.Columns["telefono"].HeaderText = "Teléfono";
                DGVConsultaCliente.Columns["email"].HeaderText = "Email";
                DGVConsultaCliente.Columns["direccion"].HeaderText = "Dirección";
                DGVConsultaCliente.Columns["condicion"].HeaderText = "Condición";
                DGVConsultaCliente.Columns["estadoCliente"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void buscaNombre_CheckedChanged(object sender, EventArgs e)
        {
            buscar.Clear();
        }

        private void buscaCondicion_CheckedChanged(object sender, EventArgs e)
        {
            buscar.Clear();
        }

        private MantenimientoCliente mantenimientoClienteForm;

        public ConsultaCliente(MantenimientoCliente mantenimientoForm = null)
        {
            InitializeComponent();
            llenar_tabla_datagridview();
            mantenimientoClienteForm = mantenimientoForm;
        }


        private void DGVConsultaCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGVConsultaCliente.Rows[e.RowIndex];

                int idCliente = Convert.ToInt32(fila.Cells["id_cliente"].Value);
                string nombre = fila.Cells["nombre"].Value.ToString();
                string telefono = fila.Cells["telefono"].Value.ToString();
                string email = fila.Cells["email"].Value.ToString();
                string direccion = fila.Cells["direccion"].Value.ToString();
                int idCondicion = Convert.ToInt32(fila.Cells["id_condicion"].Value); // ← importante
                string estadoStr = fila.Cells["estadoCliente"].Value.ToString();
                int estado = estadoStr == "Activo" ? 1 : 0;

                if (mantenimientoClienteForm == null || mantenimientoClienteForm.IsDisposed)
                {
                    mantenimientoClienteForm = new MantenimientoCliente();
                }

                mantenimientoClienteForm.Show();
                mantenimientoClienteForm.BringToFront();
                mantenimientoClienteForm.CargarDatosCliente(idCliente, nombre, telefono, email, direccion, idCondicion, estado);

                this.Close();
            }
        }
    }
}
