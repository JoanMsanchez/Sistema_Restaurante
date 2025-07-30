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
    public partial class MantenimientoProveedor : Form
    {

        //Fields
        private int bordeSize = 2;
        private int idProductoSeleccionado = -1;


        //Constructor
        public MantenimientoProveedor()
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

        private void panelMantenimientoProveedor_MouseDown(object sender, MouseEventArgs e)
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

        private void btnMaximizarProveedor_Click(object sender, EventArgs e)
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

        private ConsultaProveedor consultaProveedorForm = null;

        private void btnConsultaProveedor_Click(object sender, EventArgs e)
        {
            if (consultaProveedorForm == null || consultaProveedorForm.IsDisposed)
            {
                consultaProveedorForm = new ConsultaProveedor(this);
                consultaProveedorForm.Show();
            }
            else
            {
                // Si ya está abierta, solo la traemos al frente
                consultaProveedorForm.BringToFront();
            }
        }
        private void limpiar()
        {
            nombre.Clear();
            telefono.Clear();
            email.Clear();
            direccion.Clear();
            activo.Checked = false;
            desactivo.Checked = false;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) ||
        string.IsNullOrWhiteSpace(telefono.Text) ||
        string.IsNullOrWhiteSpace(email.Text) ||
        string.IsNullOrWhiteSpace(direccion.Text) ||
        (!activo.Checked && !desactivo.Checked))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conexion.Open();
                int estado = activo.Checked ? 1 : 0;

                // Verificar si el proveedor ya existe
                string verificar = "SELECT COUNT(*) FROM proveedor WHERE email = @email";
                SqlCommand cmdVerificar = new SqlCommand(verificar, conexion);
                cmdVerificar.Parameters.AddWithValue("@email", email.Text.Trim());
                int existe = (int)cmdVerificar.ExecuteScalar();

                string consulta;

                if (existe > 0)
                {
                    consulta = @"UPDATE proveedor 
                         SET nombre = @nombre, telefono = @telefono, direccion = @direccion, estado = @estado
                         WHERE email = @email";
                    MessageBox.Show("Proveedor actualizado correctamente.");
                }
                else
                {
                    consulta = @"INSERT INTO proveedor (nombre, telefono, email, direccion, estado) 
                         VALUES (@nombre, @telefono, @email, @direccion, @estado)";
                    MessageBox.Show("Proveedor insertado correctamente.");
                }

                SqlCommand cmdGuardar = new SqlCommand(consulta, conexion);
                cmdGuardar.Parameters.AddWithValue("@nombre", nombre.Text.Trim());
                cmdGuardar.Parameters.AddWithValue("@telefono", telefono.Text.Trim());
                cmdGuardar.Parameters.AddWithValue("@email", email.Text.Trim());
                cmdGuardar.Parameters.AddWithValue("@direccion", direccion.Text.Trim());
                cmdGuardar.Parameters.AddWithValue("@estado", estado);

                cmdGuardar.ExecuteNonQuery();
                limpiar();
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

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                nombre.Clear();
                MessageBox.Show("Solo se permiten letras en el campo de nombre.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                telefono.Clear();
                MessageBox.Show("Solo se permiten números en el campo de teléfono.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CargarDatos(string nombreProveedor, string telefonoProveedor, string emailProveedor, string direccionProveedor, string estadoProveedor)
        {
            nombre.Text = nombreProveedor;
            telefono.Text = telefonoProveedor;
            email.Text = emailProveedor;
            direccion.Text = direccionProveedor;

            // Puedes usar esto si tienes radio buttons para estado
            if (estadoProveedor == "Activo")
                activo.Checked = true;
            else
                desactivo.Checked = true;
        }
    }
}
