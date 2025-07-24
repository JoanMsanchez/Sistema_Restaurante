using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Empleado u = new Empleado();
            u.Show();
        }

        private void btnAcceso_Empleado(object sender, EventArgs e)
        {
            Empleado u = new Empleado();
            u.Show();
        }
       
        private void panelEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Empleado u = new Empleado();
            u.Show();
        }
    }
}
