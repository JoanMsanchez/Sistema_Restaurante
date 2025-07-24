using Proyecto_Restaurante.Mantenimiento;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Restaurante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
