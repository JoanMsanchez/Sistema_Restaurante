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
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Restaurante.Proceso;

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class MenuPrincipal : Form
    {
        // ====== Salas/Mesas: campos y utilidades ======

        // Usa el mismo connection string que usas en tus mantenimientos

        //private const string CS = @"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true";
        private const string CS = @"server=MSI; database=SistemaRestauranteDB1; integrated security=true";

        // Método público para iniciar/recargar el plano de salas
        public void InicializarPlanoSalas()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                tabSalas.TabPages.Clear();

                // SIEMPRE inicializa las tablas en el MISMO alcance
                DataTable dtSalas = new DataTable();
                DataTable dtMesas = new DataTable();

                using (var con = new SqlConnection(CS))
                {
                    con.Open();

                    // Salas activas
                    using (var da = new SqlDataAdapter(
                        @"SELECT id_sala, descripcion, estado
                  FROM sala
                  WHERE estado = 1
                  ORDER BY descripcion;", con))
                    {
                        da.Fill(dtSalas);
                    }

                    // Mesas activas + flag de ocupación
                    using (var da = new SqlDataAdapter(
                        @"
                SELECT 
                    m.id_mesa,
                    m.id_sala,
                    m.descripcion,
                    m.asientos,
                    m.estado,
                    CASE WHEN EXISTS (
                        SELECT 1 FROM orden o
                        WHERE o.id_mesa = m.id_mesa
                          AND o.procesada = 0
                          AND o.estado = 1
                    ) THEN 1 ELSE 0 END AS ocupada
                FROM mesa m
                WHERE m.estado = 1
                ORDER BY m.descripcion;", con))
                    {
                        da.Fill(dtMesas);
                    }
                }

                // Debug rápido (opcional):
                // MessageBox.Show($"Salas: {dtSalas.Rows.Count} - Mesas: {dtMesas.Rows.Count}");

                foreach (DataRow s in dtSalas.Rows) // <== ya no dará error
                {
                    int idSala = (int)s["id_sala"];
                    string nombreSala = Convert.ToString(s["descripcion"]);

                    var page = new TabPage(nombreSala) { ToolTipText = $"Sala #{idSala}" };
                    var flow = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        AutoScroll = true,
                        WrapContents = true,
                        FlowDirection = FlowDirection.LeftToRight,
                        Padding = new Padding(10),
                        BackColor = Color.OldLace
                    };
                    page.Controls.Add(flow);

                    DataRow[] mesasDeSala = dtMesas.Select($"id_sala = {idSala}");
                    if (mesasDeSala.Length == 0)
                    {
                        flow.Controls.Add(new Label
                        {
                            AutoSize = true,
                            Font = new Font("Verdana", 10, FontStyle.Bold),
                            Text = "No hay mesas registradas en esta sala.",
                            Margin = new Padding(10),
                            BackColor = Color.OldLace
                        });
                    }
                    else
                    {
                        foreach (DataRow m in mesasDeSala)
                        {
                            int idMesa = (int)m["id_mesa"];
                            string desc = Convert.ToString(m["descripcion"]);
                            int asientos = Convert.ToInt32(m["asientos"]);
                            bool ocupada = Convert.ToInt32(m["ocupada"]) == 1;

                            var btn = CrearBotonMesa(idMesa, desc, asientos, ocupada);
                            flow.Controls.Add(btn);
                        }
                    }

                    tabSalas.TabPages.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando salas/mesas: " + ex.Message, "MenuPrincipal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private Button CrearBotonMesa(int idMesa, string descripcion, int asientos, bool ocupada)
        {
            var btn = new Button
            {
                Tag = idMesa,
                Width = 150,
                Height = 110,
                Margin = new Padding(8),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                // Muestra libre/ocupada en el texto
                Text = $"{descripcion}\nAsientos: {asientos}\n{(ocupada ? "Ocupada" : "Libre")}",
                // Color: gris si ocupada, verde si libre
                BackColor = ocupada ? Color.Gray : Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += Mesa_Click;

            var tt = new ToolTip { IsBalloon = true };
            tt.SetToolTip(btn, ocupada ? "Mesa ocupada" : "Mesa libre");
            return btn;
        }

        private void Mesa_Click(object sender, EventArgs e)
        {
            if (sender is Button b && b.Tag is int idMesa)
            {
                using (var f = new Proyecto_Restaurante.Proceso.ProcesoFacturacion(idMesa))
                {
                    var r = f.ShowDialog(this);
                    if (r == DialogResult.OK)
                        InicializarPlanoSalas();  // ← vuelve a pintar mesa libre / ocupada
                }
            }
        }
        // ====== /Salas/Mesas ======


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
            MantenimientoProducto mp = new MantenimientoProducto();

            mp.Show();
            mp.Hide();

            ConsultaProductos consulta = new ConsultaProductos(mp);
            consulta.Show();
        }

        private void btnCxc_Click(object sender, EventArgs e)
        {
            DropMenu_CuentasXcobrar.Show(btnCxc, new Point(btnCxc.Width, 0));
        }

        private void MantenimientoProveedores_Click(object sender, EventArgs e)
        {
            MantenimientoProveedor proveedor = new MantenimientoProveedor();
            proveedor.Show();
        }

        private void ClientesCXC_Click(object sender, EventArgs e)
        {
            MantenimientoCliente cliente = new MantenimientoCliente();
            cliente.Show();
        }

        private void CondiciondePagoCXC_Click(object sender, EventArgs e)
        {
            MantenimientoCondicionPago condicion = new MantenimientoCondicionPago();
            condicion.Show();

        }

        private void MetododePagoCXC_Click(object sender, EventArgs e)
        {
            MantenimientoMetodoPago metodopago = new MantenimientoMetodoPago();
            metodopago.Show();
        }

        private void MantenimientoTipoDeMovimiento_Click(object sender, EventArgs e)
        {
            MantenimientoTipoMovimiento tipomovimiento = new MantenimientoTipoMovimiento();
            tipomovimiento.Show();
        }

        private void ConsultaProveedor_Click(object sender, EventArgs e)
        {
            ConsultaProveedor consultaProveedor = new ConsultaProveedor();
            consultaProveedor.Show();
        }

        private void ConsultaCliente_Click(object sender, EventArgs e)
        {
            ConsultaCliente consultaCliente = new ConsultaCliente();
            consultaCliente.Show();
        }

        private void MantenimientoMesas_Click(object sender, EventArgs e)
        {
            var f = new MantenimientoMesa(this);
            f.ShowDialog();
        }

        private void MantenimientoSala_Click(object sender, EventArgs e)
        {
            var f = new MantenimientoSala(this);
            f.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            InicializarPlanoSalas();
        }

        private void RegistroDeMovimientoInventario_Click(object sender, EventArgs e)
        {
            ProcesoRegistroMovimiento regmov = new ProcesoRegistroMovimiento();
            regmov.Show();
        }

        private void FacturacionRestaurante_Click(object sender, EventArgs e)
        {
        }
    }
}
