using Proyecto_Restaurante.Mantenimiento;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Restaurante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Hola mundo
            //Prueba 1
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            //menuprincipal menu = new menuprincipal();
            //menu.Show();

            FormPadre formP = new FormPadre();
            formP.Show();

            this.Hide();
        }
    }
}
