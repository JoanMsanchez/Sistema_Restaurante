using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Restaurante
{
    public partial class menuprincipal : Form
    {
        public menuprincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Show();

            //this.Hide();
        }
    }
}
