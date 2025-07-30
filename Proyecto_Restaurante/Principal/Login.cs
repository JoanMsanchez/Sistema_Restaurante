using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Logging;
using Proyecto_Restaurante.Mantenimiento;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Restaurante
{
    public partial class Login : Form
    {
        //Fields
        private int bordeSize = 2;


        //Constructor
        public Login()
        {
            InitializeComponent();
            this.Load += Login_Load; // Asegúrate de conectar el evento Load
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

        private void Acceder_Click(object sender, EventArgs e)
        {

        }

        private void btnAccederLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string Usuario = usuario.Text.Trim();
                string Clave = contasena.Text.Trim();

                string consulta = "SELECT COUNT(*) FROM empleado WHERE usuario = @usuario AND clave = @clave";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@clave", Clave);

                int resultado = (int)cmd.ExecuteScalar();

                if (resultado > 0)
                {
                    this.Hide();
                    MenuPrincipal frm = new MenuPrincipal();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar acceder: " + ex.Message);
                conexion.Close();
            }
        }

        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                contasena.Focus();
            }
        }

        private void contasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    conexion.Open();

                    string Usuario = usuario.Text.Trim();
                    string Clave = contasena.Text.Trim();

                    string consulta = @"SELECT COUNT(*) FROM empleado 
                    WHERE usuario COLLATE Latin1_General_CS_AS = @usuario 
                      AND clave COLLATE Latin1_General_CS_AS = @clave";

                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@usuario", Usuario);
                    cmd.Parameters.AddWithValue("@clave", Clave);

                    int resultado = (int)cmd.ExecuteScalar();

                    if (resultado > 0)
                    {
                        this.Hide();
                        MenuPrincipal frm = new MenuPrincipal();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o clave incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar acceder: " + ex.Message);
                    conexion.Close();
                }
            }
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
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
        private void Login_Resize(object sender, EventArgs e)
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

        private void btnMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarLogin_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                usuario.Focus();
            }));

        }
    }
}
