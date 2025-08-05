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

namespace Proyecto_Restaurante
{

    public partial class MantenimientoEmpleado : Form
    {
        //Fields
        private int bordeSize = 2;


        //Constructor

        private int id_empleado_seleccionada = -1;

        public MantenimientoEmpleado()
        {
            InitializeComponent();
            login.Focus();
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


        public void llenar_tabla_datagridview()
        {
            try
            {
                string consulta = "SELECT * FROM empleado";
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

                DGVEmpleado.DataSource = dt;

                if (DGVEmpleado.Columns.Contains("id_empleado"))
                {
                    DGVEmpleado.Columns["id_empleado"].Visible = false;
                }
                DGVEmpleado.Columns["No"].HeaderText = "#";
                DGVEmpleado.Columns["usuario"].HeaderText = "Usuario";
                DGVEmpleado.Columns["clave"].HeaderText = "Clave";
                DGVEmpleado.Columns["nombre"].HeaderText = "Nombre";
                DGVEmpleado.Columns["apellidos"].HeaderText = "Apellidos";
                DGVEmpleado.Columns["estado"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar tabla: " + ex.Message);
            }
        }

        public void limpiar()
        {
            login.Clear();
            contrasena.Clear();
            nombre.Clear();
            apellido.Clear();
            activo.Checked = false;
            desactivo.Checked = false;
            login.Focus();
            busca.Clear();
            buscausuario.Checked = false;
            buscanombre.Checked = false;
            id_empleado_seleccionada = -1;

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void busca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string consulta = "";

                if (buscausuario.Checked)
                {
                    // Búsqueda por usuario (insensible a mayúsculas/minúsculas)
                    consulta = "SELECT * FROM empleado WHERE usuario COLLATE Latin1_General_CI_AS LIKE @busqueda";
                }
                else if (buscanombre.Checked)
                {
                    // Búsqueda por nombre (sensible a mayúsculas/minúsculas por defecto)
                    consulta = "SELECT * FROM empleado WHERE nombre LIKE @busqueda";
                }
                else
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda");
                    return;
                }

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

                DGVEmpleado.DataSource = dt;

                // Ocultar id_empleado si está
                if (DGVEmpleado.Columns.Contains("id_empleado"))
                {
                    DGVEmpleado.Columns["id_empleado"].Visible = false;
                }

                // Encabezados personalizados
                DGVEmpleado.Columns["No"].HeaderText = "#";
                DGVEmpleado.Columns["usuario"].HeaderText = "Usuario";
                DGVEmpleado.Columns["clave"].HeaderText = "Clave";
                DGVEmpleado.Columns["nombre"].HeaderText = "Nombre";
                DGVEmpleado.Columns["apellidos"].HeaderText = "Apellidos";
                DGVEmpleado.Columns["estado"].HeaderText = "Estado";
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

        private void Limpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void guardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(login.Text) ||
                    string.IsNullOrWhiteSpace(contrasena.Text) ||
                    string.IsNullOrWhiteSpace(nombre.Text) ||
                    string.IsNullOrWhiteSpace(apellido.Text) ||
                    (!activo.Checked && !desactivo.Checked))
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione el estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conexion.Open();

                string consultaVerificar = "SELECT COUNT(*) FROM empleado WHERE usuario = @usuario AND id_empleado <> @id";
                SqlCommand cmdVerificar = new SqlCommand(consultaVerificar, conexion);
                cmdVerificar.Parameters.AddWithValue("@usuario", login.Text.Trim());
                cmdVerificar.Parameters.AddWithValue("@id", id_empleado_seleccionada != -1 ? id_empleado_seleccionada : 0);
                int usuarioExiste = (int)cmdVerificar.ExecuteScalar();

                if (usuarioExiste > 0)
                {
                    MessageBox.Show("El usuario ya existe. Por favor elige otro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int estado = activo.Checked ? 1 : 0;
                SqlCommand cmd;

                if (id_empleado_seleccionada != -1)
                {
                    // MODIFICAR por ID
                    string consulta = "UPDATE empleado SET usuario = @usuario, clave = @clave, nombre = @nombre, apellidos = @apellidos, estado = @estado WHERE id_empleado = @id";
                    cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@id", id_empleado_seleccionada);
                    MessageBox.Show("Empleado modificado correctamente.");
                }
                else
                {
                    // INSERTAR
                    string consulta = "INSERT INTO empleado (usuario, clave, nombre, apellidos, estado) VALUES (@usuario, @clave, @nombre, @apellidos, @estado)";
                    cmd = new SqlCommand(consulta, conexion);
                    MessageBox.Show("Empleado guardado correctamente.");
                }

                // Parámetros comunes
                cmd.Parameters.AddWithValue("@usuario", login.Text.Trim());
                cmd.Parameters.AddWithValue("@clave", contrasena.Text.Trim());
                cmd.Parameters.AddWithValue("@nombre", nombre.Text.Trim());
                cmd.Parameters.AddWithValue("@apellidos", apellido.Text.Trim());
                cmd.Parameters.AddWithValue("@estado", estado);

                cmd.ExecuteNonQuery();

                llenar_tabla_datagridview();
                limpiar();
                id_empleado_seleccionada = -1;
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

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                MessageBox.Show("Solo se permiten letras en el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                apellido.Focus();
            }
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                MessageBox.Show("Solo se permiten letras en el apellido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                contrasena.Focus();
            }
        }

        private void contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                nombre.Focus();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow fila = DGVEmpleado.Rows[e.RowIndex];

                    id_empleado_seleccionada = Convert.ToInt32(fila.Cells["id_empleado"].Value);

                    login.Text = fila.Cells["usuario"].Value.ToString();
                    contrasena.Text = fila.Cells["clave"].Value.ToString();
                    nombre.Text = fila.Cells["nombre"].Value.ToString();
                    apellido.Text = fila.Cells["apellidos"].Value.ToString();

                    int estado = Convert.ToInt32(fila.Cells["estado"].Value);
                    if (estado == 1)
                        activo.Checked = true;
                    else
                        desactivo.Checked = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del empleado: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEmpleado_MouseDown(object sender, MouseEventArgs e)
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
        private void Empleado_Resize(object sender, EventArgs e)
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

        private void btnMinimizarEmpleado_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarEmpleado_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MantenimientoEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
