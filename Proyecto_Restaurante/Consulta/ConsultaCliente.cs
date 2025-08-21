using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Proyecto_Restaurante.Mantenimiento;

namespace Proyecto_Restaurante.Consulta
{
    public partial class ConsultaCliente : Form
    {

        // Cadena de conexión: usa la misma
        //private const string CS = @"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true";
        private const string CS = @"server=MSI; database=SistemaRestauranteDB1; integrated security=true";


        // === MODO INTEGRADO ===
        private readonly bool _selectorMode = false;            
        private MantenimientoCliente mantenimientoClienteForm;

        // Valores devueltos en modo selector
        public int SelectedId { get; private set; } = -1;
        public int SelectedCondicionId { get; private set; } = -1;

        // Constructores
        public ConsultaCliente(MantenimientoCliente mantenimientoForm = null, bool selectorMode = false)
        {
            InitializeComponent();
            this._selectorMode = selectorMode;
            this.mantenimientoClienteForm = mantenimientoForm;

            // Cargar datos
            llenar_tabla_datagridview();

            // Hook de doble click del grid
            this.DGVConsultaCliente.CellMouseDoubleClick += DGVConsultaCliente_CellMouseDoubleClick;
            this.buscar.TextChanged += buscar_TextChanged;
            this.buscaNombre.CheckedChanged += buscaNombre_CheckedChanged;
            this.buscaCondicion.CheckedChanged += buscaCondicion_CheckedChanged;

            this.Padding = new Padding(bordeSize);
            this.BackColor = Color.FromArgb(255, 161, 43);
        }

        //Fields
        private int bordeSize = 2;


        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        // ===== Datos =====
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
                    INNER JOIN condicion co ON c.id_condicion = co.id_condicion
                    ORDER BY c.nombre;";

                using var con = new SqlConnection(CS);
                using var da = new SqlDataAdapter(query, con);
                var dt = new DataTable();

                con.Open();
                da.Fill(dt);

                // Secuencia
                var colNo = new DataColumn("No", typeof(int));
                dt.Columns.Add(colNo);
                for (int i = 0; i < dt.Rows.Count; i++) dt.Rows[i]["No"] = i + 1;
                dt.Columns["No"].SetOrdinal(0);

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
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!buscaNombre.Checked && !buscaCondicion.Checked)
                {
                    // opcional: UX
                    return;
                }

                using var con = new SqlConnection(CS);
                con.Open();

                string consulta = @"
                    SELECT c.id_cliente, c.nombre, c.telefono, c.email, c.direccion,
                           c.id_condicion, co.descripcion AS condicion,
                           CASE WHEN c.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS estadoCliente
                    FROM cliente c
                    INNER JOIN condicion co ON c.id_condicion = co.id_condicion
                    WHERE 1=1";

                using var cmd = new SqlCommand();
                cmd.Connection = con;

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

                using var adaptador = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adaptador.Fill(dt);

                // Secuencia
                var colNo = new DataColumn("No", typeof(int));
                dt.Columns.Add(colNo);
                for (int i = 0; i < dt.Rows.Count; i++) dt.Rows[i]["No"] = i + 1;
                dt.Columns["No"].SetOrdinal(0);

                DGVConsultaCliente.DataSource = dt;

                if (DGVConsultaCliente.Columns.Contains("id_cliente"))
                    DGVConsultaCliente.Columns["id_cliente"].Visible = false;
                DGVConsultaCliente.Columns["id_condicion"].Visible = false;

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
        }

        private void buscaNombre_CheckedChanged(object sender, EventArgs e)
        {
            buscar.Focus();
            buscar.Clear();
        }

        private void buscaCondicion_CheckedChanged(object sender, EventArgs e)
        {
            buscar.Focus();
            buscar.Clear();
        }

        // ===== Doble click: selector o mantenimiento =====
        private void DGVConsultaCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || DGVConsultaCliente.Rows.Count == 0) return;

            var fila = DGVConsultaCliente.Rows[e.RowIndex];

            int idCliente = Convert.ToInt32(fila.Cells["id_cliente"].Value);
            string nombre = Convert.ToString(fila.Cells["nombre"].Value);
            string telefono = Convert.ToString(fila.Cells["telefono"].Value);
            string email = Convert.ToString(fila.Cells["email"].Value);
            string direccion = Convert.ToString(fila.Cells["direccion"].Value);
            int idCondicion = Convert.ToInt32(fila.Cells["id_condicion"].Value);
            string estadoStr = Convert.ToString(fila.Cells["estadoCliente"].Value);
            int estado = estadoStr == "Activo" ? 1 : 0;

            if (_selectorMode)
            {
                // === MODO SELECTOR (para ProcesoFacturacion) ===
                this.SelectedId = idCliente;
                this.SelectedCondicionId = idCondicion;
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            // === MODO MANTENIMIENTO ===
            if (mantenimientoClienteForm == null || mantenimientoClienteForm.IsDisposed)
                mantenimientoClienteForm = new MantenimientoCliente();

            mantenimientoClienteForm.Show();
            mantenimientoClienteForm.BringToFront();
            mantenimientoClienteForm.CargarDatosCliente(idCliente, nombre, telefono, email, direccion, idCondicion, estado);
            this.Close();
        }
    }
}
