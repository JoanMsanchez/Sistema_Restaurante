using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Proyecto_Restaurante.Consulta;
using Proyecto_Restaurante.Mantenimiento;

namespace Proyecto_Restaurante.Proceso
{
    public partial class ProcesoRegistroMovimiento : Form
    {
        private int id_producto_seleccionado = -1;
        private int afecta_stock_actual = 0;     // +1 entrada, -1 salida
        private decimal stock_actual_2 = 0m;     // para validar salidas sin reconsultar

        // Ajusta tu cadena:
        private readonly SqlConnection conexion =
          //new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
          new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        //Fields
        private int bordeSize = 2;

        //Constructor
        public ProcesoRegistroMovimiento()
        {
            InitializeComponent();
            this.Padding = new Padding(bordeSize);
            this.BackColor = Color.FromArgb(255, 161, 43);          
        }

        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelMovimiento_MouseDown(object sender, MouseEventArgs e)
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
            this.Close();
        }

        private void ProcesoRegistroMovimiento_Load(object sender, EventArgs e)
        {
            CargarTiposMovimiento();   // Activo = 1
            CargarProveedores();       // Activo = 1

            // Fecha solo display (no editable)
            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            //fecha.Enabled = true;
            fecha.TabStop = false;

            txtstockatual.ReadOnly = true;
            comboProveedor.Enabled = false; // solo para entradas
            activo.Checked = true; // Activo = 1
            inactivo.Checked = false;

            afecta_stock_actual = 0;
        }

        // ================== COMBOS ==================
        private void CargarTiposMovimiento()
        {
            var da = new SqlDataAdapter(
                "SELECT id_tipo_mov, descripcion, afecta_stock FROM tipo_movimiento WHERE estado = 1 ORDER BY descripcion",
                conexion);
            var dt = new DataTable();
            da.Fill(dt);

            comboTipoMovimiento.SelectedIndexChanged -= comboTipoMovimiento_SelectedIndexChanged;

            comboTipoMovimiento.DataSource = dt;
            comboTipoMovimiento.DisplayMember = "descripcion";
            comboTipoMovimiento.ValueMember = "id_tipo_mov";
            comboTipoMovimiento.SelectedIndex = -1;

            comboTipoMovimiento.SelectedIndexChanged += comboTipoMovimiento_SelectedIndexChanged;
        }

        private void CargarProveedores()
        {
            var da = new SqlDataAdapter(
                "SELECT id_proveedor, nombre FROM proveedor WHERE estado = 1 ORDER BY nombre",
                conexion);
            var dt = new DataTable();
            da.Fill(dt);

            comboProveedor.DataSource = dt;
            comboProveedor.DisplayMember = "nombre";
            comboProveedor.ValueMember = "id_proveedor";
            comboProveedor.SelectedIndex = -1;
        }

        private void comboTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            afecta_stock_actual = 0;
            if (comboTipoMovimiento.SelectedIndex >= 0)
            {
                var row = (DataRowView)comboTipoMovimiento.SelectedItem;
                afecta_stock_actual = Convert.ToInt32(row["afecta_stock"]); // +1 / -1

                bool esEntrada = (afecta_stock_actual == 1);
                comboProveedor.Enabled = esEntrada;
                if (!esEntrada) comboProveedor.SelectedIndex = -1;
            }
        }

        // ================== BUSCAR PRODUCTO ==================
        private void btnConsultaProducto_Click(object sender, EventArgs e)
        {
            using (var consulta = new ConsultaProductos())
            {
                if (consulta.ShowDialog(this) == DialogResult.OK)
                {
                    id_producto_seleccionado = consulta.SelectedId;
                    producto.Text = consulta.SelectedNombre;
                    txtstockatual.Text = consulta.SelectedStock.ToString("F2");
                    stock_actual_2 = consulta.SelectedStock;
                    txtcantidad.Focus();
                }
            }
        }

        public void CargarProductoSeleccionado(int idProducto, string nombreProd, decimal stockActual)
        {
            id_producto_seleccionado = idProducto;
            producto.Text = nombreProd;
            txtstockatual.Text = stockActual.ToString("F2");
            stock_actual_2 = stockActual;
        }

        // ================== GUARDAR ==================
        private void guardar_Click(object sender, EventArgs e)
        {
            // Validaciones UI
            if (id_producto_seleccionado <= 0) { MessageBox.Show("Seleccione un producto."); return; }
            if (comboTipoMovimiento.SelectedIndex == -1) { MessageBox.Show("Seleccione un tipo de movimiento."); return; }
            if (!decimal.TryParse(txtcantidad.Text, out var cantidad) || cantidad <= 0) { MessageBox.Show("Cantidad inválida."); return; }
            if (!activo.Checked && !inactivo.Checked) { MessageBox.Show("Seleccione el estado."); return; }

            // Si es salida, valida con el stock mostrado (UX)
            if (afecta_stock_actual == -1 && cantidad > stock_actual_2)
            {
                MessageBox.Show("Stock insuficiente para realizar la salida.");
                return;
            }

            int idTipoMov = Convert.ToInt32(comboTipoMovimiento.SelectedValue);
            bool estadoBit = activo.Checked; // Activo=1(true), Inactivo=0(false)

            object proveedorParam =
                (comboProveedor.Enabled && comboProveedor.SelectedIndex != -1)
                ? (object)Convert.ToInt32(comboProveedor.SelectedValue)
                : DBNull.Value;

            try
            {
                conexion.Open();
                using (var tx = conexion.BeginTransaction())
                {
                    // 1) Revalidar afecta_stock y stock en servidor (evita condiciones de carrera)
                    int afectaBD;
                    decimal stockBD;

                    // afecta_stock
                    using (var cmd = new SqlCommand(
                        "SELECT afecta_stock FROM tipo_movimiento WHERE id_tipo_mov=@id AND estado=1", conexion, tx))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = idTipoMov;
                        var o = cmd.ExecuteScalar();
                        if (o == null) throw new InvalidOperationException("Tipo de movimiento inválido o inactivo.");
                        afectaBD = Convert.ToInt32(o);
                    }

                    // stock_actual
                    using (var cmd = new SqlCommand(
                        "SELECT stock_actual FROM producto WHERE id_producto=@p", conexion, tx))
                    {
                        cmd.Parameters.Add("@p", SqlDbType.Int).Value = id_producto_seleccionado;
                        var o = cmd.ExecuteScalar();
                        if (o == null) throw new InvalidOperationException("Producto inexistente.");
                        stockBD = Convert.ToDecimal(o);
                    }

                    if (afectaBD == -1 && stockBD < cantidad)
                        throw new InvalidOperationException("Stock insuficiente (validación en servidor).");

                    // 2) INSERT movimiento (fecha desde servidor)
                    int filasIns;
                    using (var cmdIns = new SqlCommand(@"
                        INSERT INTO movimiento_inventario
                            (id_producto, id_tipo_mov, cantidad, fecha, id_proveedor, observaciones, estado)
                        VALUES
                            (@id_producto, @id_tipo_mov, @cantidad, GETDATE(), @id_proveedor, @observaciones, @estado);",
                        conexion, tx))
                    {
                        cmdIns.Parameters.Add("@id_producto", SqlDbType.Int).Value = id_producto_seleccionado;
                        cmdIns.Parameters.Add("@id_tipo_mov", SqlDbType.Int).Value = idTipoMov;

                        var pCant = cmdIns.Parameters.Add("@cantidad", SqlDbType.Decimal);
                        pCant.Precision = 18; pCant.Scale = 2; pCant.Value = cantidad;

                        if (proveedorParam is DBNull)
                            cmdIns.Parameters.AddWithValue("@id_proveedor", DBNull.Value);
                        else
                            cmdIns.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = proveedorParam;

                        // Observaciones como VARCHAR(MAX)
                        var pObs = cmdIns.Parameters.Add("@observaciones", SqlDbType.VarChar, -1);
                        pObs.Value = string.IsNullOrWhiteSpace(observaciones.Text) ? (object)DBNull.Value : observaciones.Text.Trim();

                        cmdIns.Parameters.Add("@estado", SqlDbType.Bit).Value = estadoBit;

                        filasIns = cmdIns.ExecuteNonQuery();
                    }
                    if (filasIns != 1) throw new Exception("No se insertó el movimiento.");

                    // 3) UPDATE stock
                    int filasUpd;
                    using (var cmdUpd = new SqlCommand(@"
                        UPDATE producto
                        SET stock_actual = stock_actual + (@cantidad * @afecta)
                        WHERE id_producto = @id_producto;", conexion, tx))
                    {
                        var pCant2 = cmdUpd.Parameters.Add("@cantidad", SqlDbType.Decimal);
                        pCant2.Precision = 18; pCant2.Scale = 2; pCant2.Value = cantidad;

                        cmdUpd.Parameters.Add("@afecta", SqlDbType.Int).Value = afectaBD;
                        cmdUpd.Parameters.Add("@id_producto", SqlDbType.Int).Value = id_producto_seleccionado;

                        filasUpd = cmdUpd.ExecuteNonQuery();
                    }
                    if (filasUpd != 1) throw new Exception("No se actualizó el stock del producto.");

                    tx.Commit();
                }

                MessageBox.Show("Movimiento registrado y stock actualizado.");
                Limpiar();
                id_producto_seleccionado = -1;
                stock_actual_2 = 0m;
            }
            catch (Exception ex)
            {
                // Muestra detalle para identificar la causa exacta
                MessageBox.Show(ex.ToString(), "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        // ================== LIMPIAR ==================
        private void Limpiar()
        {
            producto.Clear();
            txtcantidad.Clear();
            observaciones.Clear();

            comboTipoMovimiento.SelectedIndex = -1;
            comboProveedor.SelectedIndex = -1;
            comboProveedor.Enabled = false;

            txtstockatual.Text = "0.00";
            activo.Checked = true;   // Activo=1
            inactivo.Checked = false;

            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd"); // solo display
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
