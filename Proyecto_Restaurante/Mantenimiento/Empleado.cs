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

    public partial class Empleado : Form
    {
        //Fields
        private int bordeSize = 2;


        //Constructor
        public Empleado()
        {
            InitializeComponent();
            llenar_tabla_datagridview();
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

                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("id_empleado"))
                {
                    dataGridView1.Columns["id_empleado"].Visible = false;
                }
                dataGridView1.Columns["No"].HeaderText = "#";
                dataGridView1.Columns["usuario"].HeaderText = "Usuario";
                dataGridView1.Columns["clave"].HeaderText = "Clave";
                dataGridView1.Columns["nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["apellidos"].HeaderText = "Apellidos";
                dataGridView1.Columns["estado"].HeaderText = "Estado";
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
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                int estado = 0;

                if (activo.Checked == true)
                {
                    estado = 1;
                }
                else if (desactivo.Checked == true)
                {
                    estado = 0;
                }

                // Verificar si ya existe el usuario
                string verificar = "select count(*) from empleado where usuario = '" + login.Text + "'";
                SqlCommand cmdVerificar = new SqlCommand(verificar, conexion);
                int existe = (int)cmdVerificar.ExecuteScalar();

                string consulta;

                if (existe > 0)
                {
                    // Ya existe: MODIFICAR
                    consulta = "update empleado set clave = '" + contrasena.Text + "', nombre = '" + nombre.Text + "', apellidos = '" + apellido.Text + "', estado = " + estado +
                               " where usuario = '" + login.Text + "'";
                    MessageBox.Show("Registro modificado correctamente");
                }
                else
                {
                    // No existe: INSERTAR
                    consulta = "insert into empleado (usuario, clave, nombre, apellidos, estado) " +
                               "values ('" + login.Text + "','" + contrasena.Text + "','" + nombre.Text + "','" + apellido.Text + "'," + estado + ")";
                    MessageBox.Show("Registro insertado correctamente");
                }

                SqlCommand ejecutar = new SqlCommand(consulta, conexion);
                ejecutar.ExecuteNonQuery();

                llenar_tabla_datagridview();
                limpiar();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
                conexion.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                login.Text = dataGridView1.SelectedCells[1].Value.ToString();
                contrasena.Text = dataGridView1.SelectedCells[2].Value.ToString();
                nombre.Text = dataGridView1.SelectedCells[3].Value.ToString();
                apellido.Text = dataGridView1.SelectedCells[4].Value.ToString();

                int estado = Convert.ToInt32(dataGridView1.SelectedCells[5].Value);
                if (estado == 1)
                    activo.Checked = true;
                else if (estado == 0)
                    desactivo.Checked = true;
            }
            catch
            {
                // Evitar errores si se hace clic fuera de los datos
            }
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
                    consulta = "SELECT * FROM empleado WHERE usuario COLLATE Latin1_General_CI_AS LIKE '%" + busca.Text.Trim() + "%'";
                }
                else if (buscanombre.Checked)
                {
                    consulta = "SELECT * FROM empleado WHERE nombre LIKE '%" + busca.Text.Trim() + "%'";
                }
                else
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda");
                    return;
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dataGridView1.DataSource = dt;
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

                int estado = 0;

                if (activo.Checked == true)
                {
                    estado = 1;
                }
                else if (desactivo.Checked == true)
                {
                    estado = 0;
                }

                // Verificar si ya existe el usuario
                string verificar = "select count(*) from empleado where usuario = '" + login.Text + "'";
                SqlCommand cmdVerificar = new SqlCommand(verificar, conexion);
                int existe = (int)cmdVerificar.ExecuteScalar();

                string consulta;

                if (existe > 0)
                {
                    // Ya existe: MODIFICAR
                    consulta = "update empleado set clave = '" + contrasena.Text + "', nombre = '" + nombre.Text + "', apellidos = '" + apellido.Text + "', estado = " + estado +
                               " where usuario = '" + login.Text + "'";
                    MessageBox.Show("Registro modificado correctamente");
                }
                else
                {
                    // No existe: INSERTAR
                    consulta = "insert into empleado (usuario, clave, nombre, apellidos, estado) " +
                               "values ('" + login.Text + "','" + contrasena.Text + "','" + nombre.Text + "','" + apellido.Text + "'," + estado + ")";
                    MessageBox.Show("Registro insertado correctamente");
                }

                SqlCommand ejecutar = new SqlCommand(consulta, conexion);
                ejecutar.ExecuteNonQuery();

                llenar_tabla_datagridview();
                limpiar();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
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
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
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
    }
}
