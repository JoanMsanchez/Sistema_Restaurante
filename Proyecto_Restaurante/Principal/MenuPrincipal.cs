using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Proyecto_Restaurante.Consulta;

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class MenuPrincipal : Form
    {
        //Fields
        private int bordeSize = 2;


        //Constructor
        public MenuPrincipal()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(bordeSize); //Border size
            this.BackColor = Color.FromArgb(255, 161, 43); //Border color
        }

        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
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
            MantenimientoEmpleado u = new MantenimientoEmpleado();
            u.Show();
        }

        private void btnAcceso_Empleado(object sender, EventArgs e)
        {
            MantenimientoEmpleado u = new MantenimientoEmpleado();
            u.Show();
        }

        private void panelEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MantenimientoEmpleado u = new MantenimientoEmpleado();
            u.Show();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
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
        private void MenuPrincipal_Resize(object sender, EventArgs e)
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBarraMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) // Colapsar menú
            {
                this.panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnBarraMenu.Dock = DockStyle.Top;

                foreach (Button btn in panelMenu.Controls.OfType<Button>())
                {
                    btn.Text = "";
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Padding = new Padding(0);
                }
            }
            else // Expandir menú
            {
                this.panelMenu.Width = 265;
                pictureBox1.Visible = true;
                btnBarraMenu.Dock = DockStyle.None;

                foreach (Button btn in panelMenu.Controls.OfType<Button>())
                {
                    btn.Text = "   " + btn.Tag?.ToString(); // Asegúrate de que el texto esté en btn.Tag
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }





        private void iconButton3_Click(object sender, EventArgs e)
        {
            DropMenu_restaurante.Show(btnRestaurante, new Point(btnRestaurante.Width, 0));
        }

        private void MantenimientoEmpleados_Click(object sender, EventArgs e)
        {
            MantenimientoEmpleado en = new MantenimientoEmpleado();
            en.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            DropMenu_inventario.Show(btnInventario, new Point(btnInventario.Width, 0));
        }

        private void MantenimientoCategoria_Click(object sender, EventArgs e)
        {
            MantenimientoCategoria ca = new MantenimientoCategoria();
            ca.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void MantenimientoUnidades_Click(object sender, EventArgs e)
        {
            MantenimientoUnidadMedida unidadMedida = new MantenimientoUnidadMedida();
            unidadMedida.Show();
        }

        private void MantenimientoProductos_Click(object sender, EventArgs e)
        {
            MantenimientoProducto producto = new MantenimientoProducto();
            producto.Show();
        }

        private void ConsultaProducto_Click(object sender, EventArgs e)
        {
            ConsultaProductos consultaProducto = new ConsultaProductos();
            consultaProducto.Show();
        }
    }
}
