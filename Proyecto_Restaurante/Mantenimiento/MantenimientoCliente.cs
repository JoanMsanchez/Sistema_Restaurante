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
using Proyecto_Restaurante.Consulta;

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class MantenimientoCliente : Form
    {
        private int idCliente = -1; // -1 indica nuevo cliente
        private int? idClienteSeleccionado = null;

        //Fields
        private int bordeSize = 2;

        //Constructor
        public MantenimientoCliente()
        {
            InitializeComponent();
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

        private void panelMantenimientoCliente_MouseDown(object sender, MouseEventArgs e)
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

        private void limpiar()
        {
            nombre.Clear();
            telefono.Clear();
            email.Clear();
            direccion.Clear();
            comboCondicion.SelectedIndex = -1;
            activo.Checked = false;
            desactivo.Checked = false;
            guardar.Text = "Guardar";
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) ||
       string.IsNullOrWhiteSpace(telefono.Text) ||
       string.IsNullOrWhiteSpace(email.Text) ||
       string.IsNullOrWhiteSpace(direccion.Text) ||
       comboCondicion.SelectedIndex == -1 ||
       (!activo.Checked && !desactivo.Checked))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conexion.Open();

                int estadoValor = activo.Checked ? 1 : 0;
                int idCondicion = Convert.ToInt32(comboCondicion.SelectedValue);

                SqlCommand cmd;

                if (idClienteSeleccionado == null || idClienteSeleccionado == -1)
                {
                    // Insertar nuevo cliente
                    string consultaInsert = @"INSERT INTO cliente 
                (nombre, telefono, email, direccion, id_condicion, estado) 
                VALUES (@nombre, @telefono, @email, @direccion, @idCondicion, @estado)";

                    cmd = new SqlCommand(consultaInsert, conexion);
                    cmd.Parameters.AddWithValue("@nombre", nombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", telefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", email.Text.Trim());
                    cmd.Parameters.AddWithValue("@direccion", direccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@idCondicion", idCondicion);
                    cmd.Parameters.AddWithValue("@estado", estadoValor);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente agregado correctamente.");
                }
                else
                {
                    // Actualizar cliente existente
                    string consultaUpdate = @"UPDATE cliente SET 
                nombre = @nombre, telefono = @telefono, email = @email, direccion = @direccion, 
                id_condicion = @idCondicion, estado = @estado 
                WHERE id_cliente = @idCliente";

                    cmd = new SqlCommand(consultaUpdate, conexion);
                    cmd.Parameters.AddWithValue("@nombre", nombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", telefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", email.Text.Trim());
                    cmd.Parameters.AddWithValue("@direccion", direccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@idCondicion", idCondicion);
                    cmd.Parameters.AddWithValue("@estado", estadoValor);
                    cmd.Parameters.AddWithValue("@idCliente", idClienteSeleccionado.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente actualizado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

                limpiar();
                idClienteSeleccionado = null;
                guardar.Text = "Guardar";
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private ConsultaCliente consultaClienteForm = null;

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            if (consultaClienteForm == null || consultaClienteForm.IsDisposed)
            {
                consultaClienteForm = new ConsultaCliente(this);
                consultaClienteForm.Show();
            }
            else
            {
                consultaClienteForm.BringToFront();
            }
        }

        private void CargarCondiciones()
        {
            try
            {
                conexion.Open();
                string query = "SELECT id_condicion, descripcion FROM condicion";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboCondicion.DataSource = dt;
                comboCondicion.DisplayMember = "descripcion";
                comboCondicion.ValueMember = "id_condicion";
                comboCondicion.SelectedIndex = -1; // Para que no haya selección al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar condiciones: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {
            CargarCondiciones();
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, tecla de retroceso y espacio
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en el campo nombre.");
            }
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (ej. borrar)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en el campo teléfono.");
            }
        }

        public void CargarDatosCliente(int idCliente, string nombreCliente, string telefonoCliente, string emailCliente, string direccionCliente, string condicionCliente, int estado)
        {
            // Guardamos el ID del cliente cargado
            idClienteSeleccionado = idCliente;

            nombre.Text = nombreCliente;
            telefono.Text = telefonoCliente;
            email.Text = emailCliente;
            direccion.Text = direccionCliente;
            comboCondicion.Text = condicionCliente;
            activo.Checked = (estado == 1);
            desactivo.Checked = (estado == 0);

            guardar.Text = "Actualizar";
        }




    }
}
