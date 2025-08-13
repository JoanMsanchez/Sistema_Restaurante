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

namespace Proyecto_Restaurante.Mantenimiento
{

    public partial class MantenimientoMesa : Form
    {
        private MenuPrincipal menuPrincipal;
        private int id_mesa_seleccionada = -1;

        //Fields
        private int bordeSize = 2;

        //Constructor
        public MantenimientoMesa(MenuPrincipal menu = null)
        {
            InitializeComponent();
            menuPrincipal = menu; // guarda la referencia (puede venir null)
            llenar_tabla_datagridview();
            this.Padding = new Padding(bordeSize);
            this.BackColor = Color.FromArgb(255, 161, 43);
        }

        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        //SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        private void panelMesa_MouseDown(object sender, MouseEventArgs e)
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

        private void btnMinimizarMesa_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarMesa_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarMesa_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Limpiar()
        {
            desMesa.Clear();
            asientos.Clear();
            activo.Checked = true;
            inactivo.Checked = false;
            rbDescripcion.Checked = false;
            rbSala.Checked = false;
            rbAsientos.Checked = false;
            busca.Clear();
            boxSala.SelectedIndex = -1;
            id_mesa_seleccionada = -1;
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void llenar_tabla_datagridview()
        {
            try
            {
                string consulta = @"
                SELECT 
                m.id_mesa, 
                m.descripcion, 
                m.asientos, 
                m.id_sala, 
                s.descripcion AS sala, 
                m.fecha, 
                m.estado 
            FROM mesa m
            INNER JOIN sala s ON m.id_sala = s.id_sala";


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

                DGVMesa.DataSource = dt;

                if (DGVMesa.Columns.Contains("id_mesa"))
                {
                    DGVMesa.Columns["id_mesa"].Visible = false;
                }
                if (DGVMesa.Columns.Contains("id_sala"))
                {
                    DGVMesa.Columns["id_sala"].Visible = false;
                }

                DGVMesa.Columns["No"].HeaderText = "#";
                DGVMesa.Columns["descripcion"].HeaderText = "Descripcion";
                DGVMesa.Columns["asientos"].HeaderText = "No. Asientos";
                DGVMesa.Columns["sala"].HeaderText = "Sala";
                DGVMesa.Columns["fecha"].HeaderText = "Fecha";
                DGVMesa.Columns["estado"].HeaderText = "Estado";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar tabla: " + ex.Message);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(desMesa.Text) ||
                    string.IsNullOrWhiteSpace(asientos.Text) ||
                    boxSala.SelectedValue == null ||
                    (!activo.Checked && !inactivo.Checked))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(asientos.Text, out int numeroAsientos))
                {
                    MessageBox.Show("El número de asientos debe ser un número válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int estado = activo.Checked ? 1 : 0;
                DateTime fechaActual = DateTime.Now;
                fecha.Text = fechaActual.ToString("yyyy-MM-dd");

                int idSalaSeleccionada = Convert.ToInt32(boxSala.SelectedValue);

                conexion.Open();

                if (id_mesa_seleccionada != -1)
                {
                    // MODIFICAR
                    string sql = @"UPDATE mesa 
                           SET descripcion = @descripcion,
                               id_sala     = @id_sala,
                               asientos    = @asientos,
                               fecha       = @fecha,
                               estado      = @estado
                           WHERE id_mesa  = @id_mesa;";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@descripcion", desMesa.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_sala", idSalaSeleccionada);
                        cmd.Parameters.AddWithValue("@asientos", numeroAsientos);
                        cmd.Parameters.AddWithValue("@fecha", fechaActual);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@id_mesa", id_mesa_seleccionada);

                        cmd.ExecuteNonQuery();
                    }

                    // Refrescar el MenuPrincipal
                    menuPrincipal?.InicializarPlanoSalas();

                    MessageBox.Show("Mesa modificada correctamente.");
                }
                else
                {
                    // INSERTAR
                    string sql = @"INSERT INTO mesa (descripcion, id_sala, asientos, fecha, estado)
                           VALUES (@descripcion, @id_sala, @asientos, @fecha, @estado);";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@descripcion", desMesa.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_sala", idSalaSeleccionada);
                        cmd.Parameters.AddWithValue("@asientos", numeroAsientos);
                        cmd.Parameters.AddWithValue("@fecha", fechaActual);
                        cmd.Parameters.AddWithValue("@estado", estado);

                        cmd.ExecuteNonQuery();
                    }

                    // Refrescar el MenuPrincipal
                    menuPrincipal?.InicializarPlanoSalas();

                    MessageBox.Show("Mesa registrada correctamente.");
                }

                llenar_tabla_datagridview();
                Limpiar();
                id_mesa_seleccionada = -1; // Resetear
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        public void CargarSalas()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT id_sala, descripcion FROM sala WHERE estado = 1", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                boxSala.DataSource = dt;
                boxSala.DisplayMember = "descripcion";
                boxSala.ValueMember = "id_sala";
                boxSala.SelectedIndex = -1; // No seleccionar ninguno al cargar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar salas: " + ex.Message);
            }
        }

        private void boxSala_MouseEnter(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb != null && cb.Items.Count > 0 && !cb.DroppedDown)
            {
                cb.DroppedDown = true;
            }
        }

        private void MantenimientoMesa_Load(object sender, EventArgs e)
        {
            CargarSalas();
            desMesa.Focus();
            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void DGVMesa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGVMesa.Rows[e.RowIndex];
                id_mesa_seleccionada = Convert.ToInt32(fila.Cells["id_mesa"].Value); // guardamos el id

                desMesa.Text = fila.Cells["descripcion"].Value.ToString();
                asientos.Text = fila.Cells["asientos"].Value.ToString();
                boxSala.SelectedValue = Convert.ToInt32(fila.Cells["id_sala"].Value);




                // Cargar fecha al TextBox
                if (fila.Cells["fecha"].Value != DBNull.Value)
                {
                    DateTime fechaGuardada = Convert.ToDateTime(fila.Cells["fecha"].Value);
                    fecha.Text = fechaGuardada.ToString("yyyy-MM-dd");
                }
                else
                {
                    fecha.Clear();
                }

                // Cargar estado
                int estado = Convert.ToInt32(fila.Cells["estado"].Value);
                if (estado == 1)
                    activo.Checked = true;
                else
                    inactivo.Checked = true;

            }
        }

        private void busca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!rbDescripcion.Checked && !rbSala.Checked && !rbAsientos.Checked)
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda");
                    return;
                }

                conexion.Open();

                string consulta = @"
                        SELECT 
                    m.id_mesa, 
                    m.descripcion, 
                    m.asientos, 
                    m.id_sala, 
                    s.descripcion AS sala, 
                    m.fecha, 
                    m.estado 
                FROM mesa m
                INNER JOIN sala s ON m.id_sala = s.id_sala
                WHERE 1 = 1";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;

                if (rbDescripcion.Checked)
                {
                    consulta += " AND m.descripcion LIKE @buscar";
                    cmd.Parameters.AddWithValue("@buscar", "%" + busca.Text.Trim() + "%");
                }
                else if (rbSala.Checked)
                {
                    consulta += " AND s.descripcion LIKE @buscar";
                    cmd.Parameters.AddWithValue("@buscar", "%" + busca.Text.Trim() + "%");
                }
                else if (rbAsientos.Checked)
                {
                    consulta += " AND CAST(m.asientos AS VARCHAR) LIKE @buscar";
                    cmd.Parameters.AddWithValue("@buscar", "%" + busca.Text.Trim() + "%");
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

                DGVMesa.DataSource = dt;

                if (DGVMesa.Columns.Contains("id_mesa"))
                {
                    DGVMesa.Columns["id_mesa"].Visible = false;
                }
                if (DGVMesa.Columns.Contains("id_sala"))
                {
                    DGVMesa.Columns["id_sala"].Visible = false;
                }

                DGVMesa.Columns["No"].HeaderText = "#";
                DGVMesa.Columns["descripcion"].HeaderText = "Descripcion";
                DGVMesa.Columns["asientos"].HeaderText = "No. Asientos";
                DGVMesa.Columns["sala"].HeaderText = "Sala";
                DGVMesa.Columns["fecha"].HeaderText = "Fecha";
                DGVMesa.Columns["estado"].HeaderText = "Estado";
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

        private void asientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
