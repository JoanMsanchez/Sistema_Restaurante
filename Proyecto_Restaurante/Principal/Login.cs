using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using Proyecto_Restaurante.Mantenimiento;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Restaurante
{
    public partial class Login : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB; integrated security=true");

        public Login()
        {
            InitializeComponent();
        }

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
    }
}
