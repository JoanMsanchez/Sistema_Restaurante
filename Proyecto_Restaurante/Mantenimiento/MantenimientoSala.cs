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
    public partial class MantenimientoSala : Form
    {
        private MenuPrincipal menuPrincipal;
        private int id_sala_seleccionada = -1;

        //Fields
        private int bordeSize = 2;


        //Constructor
        public MantenimientoSala(MenuPrincipal menu = null)
        {
            InitializeComponent();
            menuPrincipal = menu; // guarda la referencia (puede ser null)
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
        private void panelSala_MouseDown(object sender, MouseEventArgs e)
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

        private void btnMinimizarSala_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarSala_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarSala_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Limpiar()
        {
            descripcion.Clear();
            activo.Checked = true;
            desactivo.Checked = false;
            buscar.Clear();
            id_sala_seleccionada = -1;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void llenar_tabla_datagridview()
        {
            try
            {
                string consulta = "SELECT * FROM sala";
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

                DGVSala.DataSource = dt;

                if (DGVSala.Columns.Contains("id_sala"))
                {
                    DGVSala.Columns["id_sala"].Visible = false;
                }
                DGVSala.Columns["No"].HeaderText = "#";
                DGVSala.Columns["descripcion"].HeaderText = "Descripcion";
                DGVSala.Columns["fecha"].HeaderText = "Fecha";
                DGVSala.Columns["estado"].HeaderText = "Estado";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar tabla: " + ex.Message);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            buscar.Clear();

            try
            {
                if (string.IsNullOrWhiteSpace(descripcion.Text) ||
                    (!activo.Checked && !desactivo.Checked))
                {
                    MessageBox.Show("Por favor, complete la descripción y seleccione el estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conexion.Open();

                int estado = activo.Checked ? 1 : 0;
                DateTime fechaActual = DateTime.Now; // Fecha del sistema
                string fechaTexto = fechaActual.ToString("yyyy-MM-dd"); // Para insertar en SQL (formato correcto)
                fecha.Text = fechaTexto; // Mostrar en TextBox

                SqlCommand cmd;

                if (id_sala_seleccionada != -1)
                {
                    // MODIFICAR (corregido: UPDATE + WHERE)
                    string consulta = "UPDATE sala SET descripcion = @descripcion, fecha = @fecha, estado = @estado WHERE id_sala = @id";
                    cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha.Text));
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", id_sala_seleccionada);

                    cmd.ExecuteNonQuery();

                    // >>> NUEVO: refrescar el MenuPrincipal
                    menuPrincipal?.InicializarPlanoSalas();

                    MessageBox.Show("Sala modificada correctamente.");
                }
                else
                {
                    // INSERTAR
                    string consulta = "INSERT INTO sala (descripcion, fecha, estado) VALUES (@descripcion, @fecha, @estado)";
                    cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@fecha", fechaActual);
                    cmd.Parameters.AddWithValue("@estado", estado);

                    cmd.ExecuteNonQuery();

                    // >>> NUEVO: refrescar el MenuPrincipal
                    menuPrincipal?.InicializarPlanoSalas();

                    MessageBox.Show("Sala registrada correctamente.");
                }

                llenar_tabla_datagridview();
                Limpiar();
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

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string consulta = "SELECT * FROM sala WHERE descripcion LIKE @descripcion";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.SelectCommand.Parameters.AddWithValue("@descripcion", "%" + buscar.Text.Trim() + "%");

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Agregar columna "No"
                DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                dt.Columns.Add(columnaSecuencia);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }

                dt.Columns["No"].SetOrdinal(0); // mover al inicio

                DGVSala.DataSource = dt;

                if (DGVSala.Columns.Contains("id_sala"))
                {
                    DGVSala.Columns["id_sala"].Visible = false;
                }

                DGVSala.Columns["No"].HeaderText = "#";
                DGVSala.Columns["descripcion"].HeaderText = "Nombre";
                DGVSala.Columns["estado"].HeaderText = "Estado";
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

        private void DGVSala_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGVSala.Rows[e.RowIndex];
                id_sala_seleccionada = Convert.ToInt32(fila.Cells["id_sala"].Value); // guardamos el id

                descripcion.Text = fila.Cells["descripcion"].Value.ToString();

                // Cargar fecha al TextBox
                if (fila.Cells["fecha"].Value != DBNull.Value)
                {
                    DateTime fechaGuardada = Convert.ToDateTime(fila.Cells["fecha"].Value);
                    fecha.Text = fechaGuardada.ToString("yyyy-MM-dd"); // Formato deseado
                }
                else
                {
                    fecha.Clear(); // por si estuviera en blanco
                }

                // Cargar estado
                int estado = Convert.ToInt32(fila.Cells["estado"].Value);
                if (estado == 1)
                    activo.Checked = true;
                else
                    desactivo.Checked = true;
            }
        }

        private void MantenimientoSala_Shown(object sender, EventArgs e)
        {
            descripcion.Focus();
            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
