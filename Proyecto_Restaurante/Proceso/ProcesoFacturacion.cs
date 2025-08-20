using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

// Si tu ConsultaCliente está en este namespace:
using Proyecto_Restaurante.Consulta;
using Proyecto_Restaurante.Mantenimiento;

namespace Proyecto_Restaurante.Proceso
{
    public partial class ProcesoFacturacion : Form
    {
        // Connection string
        private const string CS = @"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true";
        //private const string CS = @"server=MSI; database=SistemaRestauranteDB1; integrated security=true";

        private readonly MenuPrincipal _menu;

        private bool _ordenCreadaEnEstaSesion = false;   // true si INSERT en AbrirOCrearOrden()
        private bool _cabeceraGuardadaEstaSesion = false; // true si se hizo GuardarCabecera()
        private bool _ordenProcesadaEstaSesion = false;   // true si se hizo Procesar()

        // Estado
        private int _idMesa;
        private int _idOrden = -1;
        private int _idEmpleado = 1; // TODO: setear desde login
        private bool _autopago = false;
        private int _idCondicionActual = -1;     // ID de condición actual (sin combo)
        private int _diasCreditoActual = 0;      // días de crédito de la condición
        private const decimal ITBIS_RATE = 0.18m; // 18%

        // ---- Tipos de movimiento inventario (según tus tablas) ----
        private const int TIPO_SALIDA_VENTA = 1;
        private const int TIPO_DEVOLUCION_CLIENTE = 2; // ← antes 6

        // Scroll infinito catálogo
        private int _page = 0;
        private const int _pageSize = 24;
        private bool _loading = false;
        private bool _hasMore = true;

        // Avisos de stock bajo (evitar spam)
        private readonly HashSet<int> _lowStockWarned = new HashSet<int>();

        // ===== Modelo de líneas =====
        private class Linea
        {
            public int IdDetalle { get; set; }
            public int IdProducto { get; set; }
            public string Nombre { get; set; }
            public decimal Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Subtotal => Math.Round(Cantidad * Precio, 2);
        }
        private readonly BindingList<Linea> _lineas = new BindingList<Linea>();

        // ===== Ctor =====
        public ProcesoFacturacion(int idMesa, MenuPrincipal menu = null)
        {
            InitializeComponent();
            _idMesa = idMesa;
            _menu = menu;
            this.Load += ProcesoFacturacion_Load;
            this.Shown += ProcesoFacturacion_Shown;
            this.FormClosing += ProcesoFacturacion_FormClosing;
            this.Padding = new Padding(bordeSize);
            this.BackColor = Color.FromArgb(255, 161, 43);
        }

        //Fields
        private int bordeSize = 2;

        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelFacturacion_MouseDown(object sender, MouseEventArgs e)
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

        // Si el Designer aún llama a este handler viejo, lo puenteamos:
        private void ProcesoFacturacion_Shown_1(object sender, EventArgs e) => ProcesoFacturacion_Shown(sender, e);

        // ===== Arranque =====
        private void ProcesoFacturacion_Load(object sender, EventArgs e)
        {
            Text = $"ProcesoFacturación - Mesa #{_idMesa}";
            ConfigurarGridDetalle();
            WireEventosUI();
            CargarSalaMesaLabel();
            txtITEBIS.Text = "0.00";
        }

        private void ProcesoFacturacion_Shown(object sender, EventArgs e)
        {
            CargarCombos();
            SeleccionarClienteConsumidorFinal();
            AbrirOCrearOrden();
            CargarEmpleadoLabel();
            CargarCabeceraVisual();
            CargarDetalle();
            ResetCatalogo();
            RecalcularTotales();
        }

        // ===== UI =====
        private void WireEventosUI()
        {
            if (txtBuscarProd != null) txtBuscarProd.TextChanged += (_, __) => ResetCatalogo();
            if (cmbCategoria != null) cmbCategoria.SelectedIndexChanged += (_, __) => ResetCatalogo();

            flpCatalogo.AutoScroll = true;
            flpCatalogo.Scroll += (s, e) =>
            {
                var v = flpCatalogo.VerticalScroll;
                if (v.Value + flpCatalogo.ClientSize.Height + 50 >= v.Maximum)
                    CargarMasProductos();
            };

            if (btnGuardar != null) btnGuardar.Click += (_, __) => GuardarCabecera();
            if (btnPrecuenta != null) btnPrecuenta.Click += (_, __) => MostrarPrecuenta();
            if (btnProcesar != null) btnProcesar.Click += (_, __) => Procesar();
            if (btnCancelar != null) btnCancelar.Click += BtnCancelar_Click;

            if (btnBuscarCliente != null) btnBuscarCliente.Click += BtnBuscarCliente_Click;

            if (cmbCliente != null) cmbCliente.SelectionChangeCommitted += (_, __) =>
            {
                int idCli = GetClienteIdDesdeCombo();
                if (idCli > 0)
                {
                    AplicarCondicionDeCliente(idCli);
                    ActualizarClienteEnOrdenSiAbierta(idCli);
                }
            };
        }

        private void ConfigurarGridDetalle()
        {
            var g = dgvDetalle;
            g.AutoGenerateColumns = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToResizeRows = false;
            g.RowHeadersVisible = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.ReadOnly = true;
            g.Columns.Clear();

            g.Columns.Add(new DataGridViewTextBoxColumn { Name = "colIdDet", HeaderText = "IdDet", DataPropertyName = "IdDetalle", Visible = false });
            g.Columns.Add(new DataGridViewTextBoxColumn { Name = "colIdProd", HeaderText = "Id", DataPropertyName = "IdProducto", Visible = false });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProducto",
                HeaderText = "Producto",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCant",
                HeaderText = "Cant.",
                DataPropertyName = "Cantidad",
                Width = 110,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "N0" }
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecio",
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                ReadOnly = true,
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C2" }
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSubtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal",
                ReadOnly = true,
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C2" }
            });

            g.Columns.Add(new DataGridViewButtonColumn { Name = "colQuitar", HeaderText = "", Text = "X", UseColumnTextForButtonValue = true, Width = 42 });

            g.DataSource = _lineas;

            g.CellPainting -= dgvDetalle_CellPainting;
            g.CellPainting += dgvDetalle_CellPainting;

            g.CellClick -= dgvDetalle_CellClick;
            g.CellClick += dgvDetalle_CellClick;

            g.DataError += (s, e) => e.ThrowException = false;
        }

        // ===== Combos y catálogo =====
        private void CargarCombos()
        {
            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();

                    var dtCli = new DataTable();
                    new SqlDataAdapter("SELECT id_cliente, nombre FROM cliente WHERE estado=1 ORDER BY nombre", con).Fill(dtCli);
                    cmbCliente.DisplayMember = "nombre";
                    cmbCliente.ValueMember = "id_cliente";
                    cmbCliente.DataSource = dtCli;
                    cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;

                    var dtMet = new DataTable();
                    new SqlDataAdapter("SELECT id_metodo_pago, descripcion FROM metodo_pago WHERE estado=1 ORDER BY descripcion", con).Fill(dtMet);
                    cmbMetodoPago.DisplayMember = "descripcion";
                    cmbMetodoPago.ValueMember = "id_metodo_pago";
                    cmbMetodoPago.DataSource = dtMet;
                    cmbMetodoPago.Enabled = false;

                    var dtCat = new DataTable();
                    new SqlDataAdapter("SELECT id_categoria, nombre FROM categoria_producto WHERE estado=1 ORDER BY nombre", con).Fill(dtCat);
                    var all = dtCat.NewRow(); all["id_categoria"] = DBNull.Value; all["nombre"] = "Todas";
                    dtCat.Rows.InsertAt(all, 0);
                    cmbCategoria.DisplayMember = "nombre";
                    cmbCategoria.ValueMember = "id_categoria";
                    cmbCategoria.DataSource = dtCat;
                    cmbCategoria.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar combos: " + ex.Message); }
        }

        private Control CrearCardProducto(int id, string nombre, decimal precio, string imagePath)
        {
            var card = new Panel
            {
                Width = 180,
                Height = 220,
                Margin = new Padding(8),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            var pic = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 120,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.White
            };
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                pic.ImageLocation = imagePath;

            var lbl = new Label
            {
                Dock = DockStyle.Top,
                Height = 50,
                Text = nombre,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                AutoEllipsis = true
            };

            var btn = new Button
            {
                Dock = DockStyle.Bottom,
                Height = 36,
                Text = $"Agregar  {precio:C2}",
                Tag = id
            };
            btn.Click += (s, e) => AgregarProductoALaOrden((int)((Button)s).Tag, 1m);

            card.Controls.Add(btn);
            card.Controls.Add(lbl);
            card.Controls.Add(pic);
            return card;
        }

        // ==== Helper: id_cliente desde combo ====
        private int GetClienteIdDesdeCombo()
        {
            if (cmbCliente?.SelectedValue is int sv && sv > 0) return sv;
            if (int.TryParse(Convert.ToString(cmbCliente?.SelectedValue), out int id) && id > 0) return id;

            string nombre = cmbCliente?.Text?.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var cmd = new SqlCommand("SELECT TOP 1 id_cliente FROM cliente WHERE estado=1 AND nombre=@n ORDER BY id_cliente", con);
                cmd.Parameters.AddWithValue("@n", nombre);
                var o = cmd.ExecuteScalar();
                if (o != null && o != DBNull.Value) return Convert.ToInt32(o);
            }

            using (var con2 = new SqlConnection(CS))
            {
                con2.Open();
                using var cmd2 = new SqlCommand("SELECT TOP 1 id_cliente FROM cliente WHERE estado=1 AND nombre LIKE '%Consumidor%Final%' ORDER BY id_cliente", con2);
                var o2 = cmd2.ExecuteScalar();
                if (o2 != null && o2 != DBNull.Value) return Convert.ToInt32(o2);
            }

            throw new Exception("No se pudo determinar el cliente seleccionado.");
        }

        // ==== Helpers de stock ====
        private bool TryDescontarStock(SqlConnection con, SqlTransaction tx, int idProducto, decimal cantidad, out decimal stockRestante, out decimal stockMinimo, out string nombre)
        {
            stockRestante = 0m; stockMinimo = 0m; nombre = "";
            // Descuenta solo si hay stock suficiente (operación atómica)
            using (var up = new SqlCommand(@"
                UPDATE producto
                   SET stock_actual = stock_actual - @c
                 WHERE id_producto = @p AND stock_actual >= @c;
                SELECT CAST(@@ROWCOUNT AS int);", con, tx))
            {
                up.Parameters.AddWithValue("@p", idProducto);
                up.Parameters.AddWithValue("@c", cantidad);
                int rows = Convert.ToInt32(up.ExecuteScalar());
                if (rows == 0)
                {
                    // Obtener stock para informar
                    using var q = new SqlCommand("SELECT nombre, ISNULL(stock_actual,0), ISNULL(stock_minimo,0) FROM producto WHERE id_producto=@p", con, tx);
                    q.Parameters.AddWithValue("@p", idProducto);
                    using var rd = q.ExecuteReader();
                    if (rd.Read())
                    {
                        nombre = rd.IsDBNull(0) ? "" : rd.GetString(0);
                        stockRestante = rd.IsDBNull(1) ? 0m : rd.GetDecimal(1);
                        stockMinimo = rd.IsDBNull(2) ? 0m : rd.GetDecimal(2);
                    }
                    return false;
                }
            }

            using (var q2 = new SqlCommand("SELECT nombre, ISNULL(stock_actual,0), ISNULL(stock_minimo,0) FROM producto WHERE id_producto=@p", con, tx))
            {
                q2.Parameters.AddWithValue("@p", idProducto);
                using var rd2 = q2.ExecuteReader();
                if (rd2.Read())
                {
                    nombre = rd2.IsDBNull(0) ? "" : rd2.GetString(0);
                    stockRestante = rd2.IsDBNull(1) ? 0m : rd2.GetDecimal(1);
                    stockMinimo = rd2.IsDBNull(2) ? 0m : rd2.GetDecimal(2);
                }
            }
            return true;
        }

        private void DevolverStock(SqlConnection con, SqlTransaction tx, int idProducto, decimal cantidad)
        {
            using var cmd = new SqlCommand("UPDATE producto SET stock_actual = stock_actual + @c WHERE id_producto=@p", con, tx);
            cmd.Parameters.AddWithValue("@c", cantidad);
            cmd.Parameters.AddWithValue("@p", idProducto);
            cmd.ExecuteNonQuery();
        }

        // --------- NUEVO: soporte a proveedor + agrupación estable ----------
        // Obtiene proveedor del producto si no se pasó (si tu tabla producto no tiene id_proveedor, este método devuelve null)
        private int? GetProveedorDeProducto(SqlConnection con, SqlTransaction tx, int idProducto)
        {
            using var cmd = new SqlCommand("SELECT TOP 1 id_proveedor FROM producto WHERE id_producto=@p", con, tx);
            cmd.Parameters.AddWithValue("@p", idProducto);
            var o = cmd.ExecuteScalar();
            return (o == null || o == DBNull.Value) ? (int?)null : Convert.ToInt32(o);
        }

        // AGRUPA por orden+producto+tipo usando una clave al inicio de 'observaciones'
        private void RegistrarMovInventario(
            SqlConnection con, SqlTransaction tx,
            int idProducto, int idTipoMov, decimal cantidad,
            string observaciones, int? idProveedor = null)
        {
            if (cantidad <= 0m) return;

            // 1) Clave estable SIN corchetes (evita comodines de LIKE)
            //    Ej: {ORD:123|P:45|T:1}
            string clave = $"{{ORD:{_idOrden}|P:{idProducto}|T:{idTipoMov}}}";
            string obsFinal = $"{clave} {observaciones ?? ""}".Trim();

            // 2) Resolver proveedor si no viene
            int? prov = idProveedor ?? GetProveedorDeProducto(con, tx, idProducto);

            // 3) Buscar una fila existente cuyo INICIO sea exactamente la clave
            int? idMov = null;
            using (var sel = new SqlCommand(@"
        SELECT TOP (1) id_movimiento
          FROM movimiento_inventario WITH (UPDLOCK, HOLDLOCK)
         WHERE id_producto = @p
           AND id_tipo_mov = @t
           AND estado = 1
           AND LEFT(CAST(observaciones AS nvarchar(4000)), LEN(@pref)) = @pref;", con, tx))
            {
                sel.Parameters.Add("@p", SqlDbType.Int).Value = idProducto;
                sel.Parameters.Add("@t", SqlDbType.Int).Value = idTipoMov;
                sel.Parameters.Add("@pref", SqlDbType.NVarChar, 200).Value = clave;

                var o = sel.ExecuteScalar();
                if (o != null && o != DBNull.Value) idMov = Convert.ToInt32(o);
            }

            if (idMov.HasValue)
            {
                // 4) Acumular cantidad y completar proveedor si estaba nulo
                using var up = new SqlCommand(@"
            UPDATE movimiento_inventario
               SET cantidad = cantidad + @c,
                   id_proveedor = COALESCE(id_proveedor, @prov)
             WHERE id_movimiento = @id;", con, tx);
                up.Parameters.Add("@c", SqlDbType.Decimal).Value = cantidad;
                up.Parameters.Add("@prov", SqlDbType.Int).Value = (object)prov ?? DBNull.Value;
                up.Parameters.Add("@id", SqlDbType.Int).Value = idMov.Value;
                up.ExecuteNonQuery();
            }
            else
            {
                // 5) Insert único (con la clave al inicio)
                using var ins = new SqlCommand(@"
            INSERT INTO movimiento_inventario
                (id_producto, id_tipo_mov, cantidad, fecha, id_proveedor, observaciones, estado)
            VALUES
                (@p, @t, @c, GETDATE(), @prov, @obs, 1);", con, tx);
                ins.Parameters.Add("@p", SqlDbType.Int).Value = idProducto;
                ins.Parameters.Add("@t", SqlDbType.Int).Value = idTipoMov;
                ins.Parameters.Add("@c", SqlDbType.Decimal).Value = cantidad;
                ins.Parameters.Add("@prov", SqlDbType.Int).Value = (object)prov ?? DBNull.Value;
                ins.Parameters.Add("@obs", SqlDbType.NVarChar, 4000).Value = obsFinal;
                ins.ExecuteNonQuery();
            }
        }

        // ====== NUEVO: posteo diferido por DELTA al Guardar/Procesar ======
        /// <summary>
        /// Registra solo la diferencia entre lo ya asentado (salidas - devoluciones)
        /// y la cantidad actual del detalle por producto.
        /// </summary>
        private void PostearMovimientosDelta(SqlConnection con, SqlTransaction tx)
        {
            // 1) Cantidades actuales del detalle por producto
            var actuales = new Dictionary<int, decimal>();
            using (var cmd = new SqlCommand(@"
                SELECT id_producto, SUM(cantidad)
                  FROM detalle_orden
                 WHERE id_orden=@o AND estado=1
                 GROUP BY id_producto;", con, tx))
            {
                cmd.Parameters.AddWithValue("@o", _idOrden);
                using var rd = cmd.ExecuteReader();
                while (rd.Read()) actuales[rd.GetInt32(0)] = rd.GetDecimal(1);
            }

            // 2) Para cada producto del detalle: calcular neto ya registrado (salida - devolución)
            foreach (var kv in actuales)
            {
                int idProd = kv.Key;
                decimal cantDeseada = kv.Value;

                string pref = $"{{ORD:{_idOrden}|P:{idProd}|";

                decimal netoAsentado = 0m;
                using (var cmd = new SqlCommand(@"
                    SELECT
                      COALESCE(SUM(CASE WHEN id_tipo_mov = @tOut THEN cantidad END), 0)
                      - COALESCE(SUM(CASE WHEN id_tipo_mov = @tIn  THEN cantidad END), 0)
                    FROM movimiento_inventario
                    WHERE id_producto=@p AND estado=1
                      AND LEFT(CAST(observaciones AS nvarchar(4000)), LEN(@pref)) = @pref;", con, tx))
                {
                    cmd.Parameters.AddWithValue("@tOut", TIPO_SALIDA_VENTA);
                    cmd.Parameters.AddWithValue("@tIn", TIPO_DEVOLUCION_CLIENTE);
                    cmd.Parameters.AddWithValue("@p", idProd);
                    cmd.Parameters.AddWithValue("@pref", pref);
                    var o = cmd.ExecuteScalar();
                    if (o != null && o != DBNull.Value) netoAsentado = Convert.ToDecimal(o);
                }

                if (cantDeseada > netoAsentado)
                {
                    // faltan salidas
                    decimal delta = cantDeseada - netoAsentado;
                    RegistrarMovInventario(con, tx, idProd, TIPO_SALIDA_VENTA, delta,
                        $"Salida por venta - Orden #{_idOrden}");
                }
                else if (cantDeseada < netoAsentado)
                {
                    // sobran salidas → devoluciones por la diferencia
                    decimal delta = netoAsentado - cantDeseada;
                    RegistrarMovInventario(con, tx, idProd, TIPO_DEVOLUCION_CLIENTE, delta,
                        $"Devolución cliente (Guardar/Procesar) - Orden #{_idOrden}");
                }
            }

            // 3) Productos con movimientos asentados que ya no están en el detalle → devolver todo el neto
            using (var productosAsentados = new SqlCommand(@"
                SELECT DISTINCT id_producto
                  FROM movimiento_inventario
                 WHERE estado=1
                   AND (id_tipo_mov=@tOut OR id_tipo_mov=@tIn)
                   AND LEFT(CAST(observaciones AS nvarchar(4000)), LEN(@prefOrden)) = @prefOrden;", con, tx))
            {
                string prefOrden = $"{{ORD:{_idOrden}|P:";
                productosAsentados.Parameters.AddWithValue("@tOut", TIPO_SALIDA_VENTA);
                productosAsentados.Parameters.AddWithValue("@tIn", TIPO_DEVOLUCION_CLIENTE);
                productosAsentados.Parameters.AddWithValue("@prefOrden", prefOrden);

                using var rd = productosAsentados.ExecuteReader();
                var lista = new List<int>();
                while (rd.Read()) lista.Add(rd.GetInt32(0));
                rd.Close();

                foreach (var idProd in lista)
                {
                    if (actuales.ContainsKey(idProd)) continue; // ya contemplado

                    string pref = $"{{ORD:{_idOrden}|P:{idProd}|";
                    decimal netoAsentado = 0m;
                    using (var cmd = new SqlCommand(@"
                        SELECT
                          COALESCE(SUM(CASE WHEN id_tipo_mov = @tOut THEN cantidad END), 0)
                          - COALESCE(SUM(CASE WHEN id_tipo_mov = @tIn  THEN cantidad END), 0)
                        FROM movimiento_inventario
                        WHERE id_producto=@p AND estado=1
                          AND LEFT(CAST(observaciones AS nvarchar(4000)), LEN(@pref)) = @pref;", con, tx))
                    {
                        cmd.Parameters.AddWithValue("@tOut", TIPO_SALIDA_VENTA);
                        cmd.Parameters.AddWithValue("@tIn", TIPO_DEVOLUCION_CLIENTE);
                        cmd.Parameters.AddWithValue("@p", idProd);
                        cmd.Parameters.AddWithValue("@pref", pref);
                        var o = cmd.ExecuteScalar();
                        if (o != null && o != DBNull.Value) netoAsentado = Convert.ToDecimal(o);
                    }

                    if (netoAsentado > 0m)
                    {
                        RegistrarMovInventario(con, tx, idProd, TIPO_DEVOLUCION_CLIENTE, netoAsentado,
                            $"Devolución cliente (Guardar/Procesar) - Orden #{_idOrden}");
                    }
                }
            }
        }
        // -------------------------------------------------------------------

        private void VerificarYNotificarStockBajo(int idProducto)
        {
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var cmd = new SqlCommand("SELECT nombre, ISNULL(stock_actual,0), ISNULL(stock_minimo,0) FROM producto WHERE id_producto=@p", con);
                cmd.Parameters.AddWithValue("@p", idProducto);
                using var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    string nom = rd.IsDBNull(0) ? "" : rd.GetString(0);
                    decimal actual = rd.IsDBNull(1) ? 0m : rd.GetDecimal(1);
                    decimal minimo = rd.IsDBNull(2) ? 0m : rd.GetDecimal(2);
                    if (actual < minimo && !_lowStockWarned.Contains(idProducto))
                    {
                        _lowStockWarned.Add(idProducto);
                        MessageBox.Show($"Stock bajo para \"{nom}\". Actual: {actual:N2}, mínimo: {minimo:N2}.", "Aviso de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch { /* aviso opcional */ }
        }

        // ===== Orden / Detalle =====
        private void AbrirOCrearOrden()
        {
            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();

                    var sel = new SqlCommand(
                        "SELECT TOP 1 o.id_orden, c.autopago, o.id_empleado " +
                        "FROM orden o JOIN condicion c ON c.id_condicion=o.id_condicion " +
                        "WHERE o.id_mesa=@m AND o.procesada=0 AND o.estado=1 ORDER BY o.id_orden DESC;", con);
                    sel.Parameters.AddWithValue("@m", _idMesa);

                    using (var rd = sel.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            _idOrden = rd.GetInt32(0);
                            _autopago = rd.GetBoolean(1);
                            _idEmpleado = rd.GetInt32(2);
                            cmbMetodoPago.Enabled = _autopago;
                            return;
                        }
                    }

                    if (_idCondicionActual <= 0)
                    {
                        int cli = GetClienteIdDesdeCombo();
                        using var cmdCli = new SqlCommand("SELECT id_condicion FROM cliente WHERE id_cliente=@c", con);
                        cmdCli.Parameters.AddWithValue("@c", cli);
                        var obj = cmdCli.ExecuteScalar();
                        if (obj != null && obj != DBNull.Value)
                        {
                            _idCondicionActual = Convert.ToInt32(obj);
                            SetCondicionInterna(_idCondicionActual);
                        }
                    }

                    int cliParaInsert = GetClienteIdDesdeCombo();

                    var ins = new SqlCommand(@"
                        INSERT INTO orden(id_cliente, id_mesa, id_empleado, id_condicion, fecha_hora,
                                          fecha_vencimiento, total, saldo_pendiente, procesada, estado)
                        VALUES (@cli, @mesa, @emp, @cond, GETDATE(), NULL, 0, 0, 0, 1);
                        SELECT CAST(SCOPE_IDENTITY() AS int);", con);
                    ins.Parameters.AddWithValue("@cli", cliParaInsert);
                    ins.Parameters.AddWithValue("@mesa", _idMesa);
                    ins.Parameters.AddWithValue("@emp", _idEmpleado);
                    ins.Parameters.AddWithValue("@cond", _idCondicionActual);

                    _idOrden = (int)ins.ExecuteScalar();
                    _ordenCreadaEnEstaSesion = true;

                    using var ap = new SqlCommand("SELECT autopago FROM condicion WHERE id_condicion=@c", con);
                    ap.Parameters.AddWithValue("@c", _idCondicionActual);
                    _autopago = Convert.ToBoolean(ap.ExecuteScalar());
                    cmbMetodoPago.Enabled = _autopago;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al abrir/crear orden: " + ex.Message); }
        }

        private void CargarEmpleadoLabel()
        {
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();

                string nombreCompleto = null;
                using (var cmd = new SqlCommand(@"
                    SELECT LTRIM(RTRIM(CONCAT(e.nombre,' ',e.apellidos)))
                    FROM orden o
                    JOIN empleado e ON e.id_empleado = o.id_empleado
                    WHERE o.id_orden = @o;", con))
                {
                    cmd.Parameters.AddWithValue("@o", _idOrden);
                    var o = cmd.ExecuteScalar();
                    if (o != null && o != DBNull.Value) nombreCompleto = Convert.ToString(o);
                }

                if (string.IsNullOrWhiteSpace(nombreCompleto))
                {
                    using var cmd2 = new SqlCommand("SELECT LTRIM(RTRIM(CONCAT(nombre,' ',apellidos))) FROM empleado WHERE id_empleado=@id", con);
                    cmd2.Parameters.AddWithValue("@id", _idEmpleado);
                    var o2 = cmd2.ExecuteScalar();
                    if (o2 != null && o2 != DBNull.Value) nombreCompleto = Convert.ToString(o2);
                }

                if (lbEmpleado != null)
                    lbEmpleado.Text = string.IsNullOrWhiteSpace(nombreCompleto) ? "(Empleado desconocido)" : nombreCompleto;
            }
            catch
            {
                if (lbEmpleado != null) lbEmpleado.Text = "(Empleado desconocido)";
            }
        }

        private void CargarCabeceraVisual()
        {
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                var cmd = new SqlCommand(@"
                    SELECT fecha_hora, fecha_vencimiento, ISNULL(saldo_pendiente,0),
                           id_cliente, id_condicion
                    FROM orden WHERE id_orden=@o;", con);
                cmd.Parameters.AddWithValue("@o", _idOrden);
                using var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    var fcrea = rd.GetDateTime(0);
                    DateTime? fven = rd.IsDBNull(1) ? (DateTime?)null : rd.GetDateTime(1);
                    var saldo = rd.GetDecimal(2);
                    int? idCli = rd.IsDBNull(3) ? (int?)null : rd.GetInt32(3);
                    int idCond = rd.GetInt32(4);

                    if (txtCreacion != null) { txtCreacion.Text = fcrea.ToString("dd/MM/yyyy"); }
                    if (txtVence != null) { txtVence.Text = (fven ?? DateTime.Now.Date).ToString("dd/MM/yyyy"); }
                    if (txtSaldoPendiente != null) txtSaldoPendiente.Text = saldo.ToString("N2");

                    if (idCli.HasValue && cmbCliente != null)
                        cmbCliente.SelectedValue = idCli.Value;

                    SetCondicionInterna(idCond);
                    MostrarCondicionEnTextBox(idCond);
                }
            }
            catch { }
        }

        private void CargarDetalle()
        {
            _lineas.Clear();
            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    var cmd = new SqlCommand(@"
                        SELECT d.id_detalle, d.id_producto, p.nombre, d.cantidad, d.precio_unitario
                        FROM detalle_orden d
                        JOIN producto p ON p.id_producto=d.id_producto
                        WHERE d.id_orden=@o AND d.estado=1
                        ORDER BY d.id_detalle;", con);
                    cmd.Parameters.AddWithValue("@o", _idOrden);

                    using var rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        _lineas.Add(new Linea
                        {
                            IdDetalle = rd.GetInt32(0),
                            IdProducto = rd.GetInt32(1),
                            Nombre = rd.GetString(2),
                            Cantidad = rd.GetDecimal(3),
                            Precio = rd.GetDecimal(4)
                        });
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar detalle: " + ex.Message); }

            dgvDetalle.Refresh();
            RecalcularTotales();
        }

        private void AgregarProductoALaOrden(int idProducto, decimal cantidad)
        {
            decimal stockRestante = 0, stockMin = 0;
            string nombre = "";
            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    using var tx = con.BeginTransaction();

                    // 0) Verificar y descontar stock (atómico)
                    if (!TryDescontarStock(con, tx, idProducto, cantidad, out stockRestante, out stockMin, out nombre))
                    {
                        tx.Rollback();
                        MessageBox.Show($"No hay stock suficiente de \"{nombre}\". Disponible: {stockRestante:N2}.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // 1) precio actual
                    var pCmd = new SqlCommand("SELECT precio_venta FROM producto WHERE id_producto=@p AND estado=1", con, tx);
                    pCmd.Parameters.AddWithValue("@p", idProducto);
                    var precioObj = pCmd.ExecuteScalar();
                    if (precioObj == null) throw new Exception("Producto inactivo o inexistente.");
                    decimal precio = Convert.ToDecimal(precioObj);

                    // 2) ¿línea activa existente?
                    int? idDet = null;
                    var sel = new SqlCommand("SELECT id_detalle FROM detalle_orden WHERE id_orden=@o AND id_producto=@p AND estado=1", con, tx);
                    sel.Parameters.AddWithValue("@o", _idOrden);
                    sel.Parameters.AddWithValue("@p", idProducto);
                    var o = sel.ExecuteScalar();
                    if (o != null && o != DBNull.Value) idDet = Convert.ToInt32(o);

                    if (idDet.HasValue)
                    {
                        var up = new SqlCommand(@"
                            UPDATE detalle_orden
                               SET cantidad = cantidad + @c,
                                   precio_unitario = @pr,
                                   subtotal = ROUND((cantidad + @c) * @pr, 2)
                             WHERE id_detalle=@d;", con, tx);
                        up.Parameters.AddWithValue("@c", cantidad);
                        up.Parameters.AddWithValue("@pr", precio);
                        up.Parameters.AddWithValue("@d", idDet.Value);
                        up.ExecuteNonQuery();
                    }
                    else
                    {
                        var ins = new SqlCommand(@"
                            INSERT INTO detalle_orden(id_orden, id_producto, cantidad, precio_unitario, subtotal, estado)
                            VALUES (@o, @p, @c, @pr, ROUND(@c*@pr,2), 1);", con, tx);
                        ins.Parameters.AddWithValue("@o", _idOrden);
                        ins.Parameters.AddWithValue("@p", idProducto);
                        ins.Parameters.AddWithValue("@c", cantidad);
                        ins.Parameters.AddWithValue("@pr", precio);
                        ins.ExecuteNonQuery();
                    }

                    // *** YA NO se registran movimientos aquí ***

                    RecalcularTotalOrden(con, tx);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el producto: " + ex.Message);
                return;
            }

            // UI & avisos
            CargarDetalle();
            if (stockRestante <= 0) ResetCatalogo(); // para ocultar el producto que se quedó sin stock
            if (stockRestante < stockMin) VerificarYNotificarStockBajo(idProducto);
        }

        // ===== Totales & cabecera =====
        private void RecalcularTotalOrden(SqlConnection cn, SqlTransaction tx)
        {
            var cmd = new SqlCommand(@"
                UPDATE orden
                   SET total = ROUND(
                        (SELECT ISNULL(SUM(subtotal),0)
                           FROM detalle_orden
                          WHERE id_orden=@o AND estado=1) * (1 + @rate), 2)
                 WHERE id_orden=@o;", cn, tx);
            cmd.Parameters.AddWithValue("@o", _idOrden);
            cmd.Parameters.AddWithValue("@rate", ITBIS_RATE);
            cmd.ExecuteNonQuery();
        }

        private void RecalcularTotales()
        {
            decimal sub = _lineas.Sum(l => l.Subtotal);
            decimal itbis = Math.Round(sub * ITBIS_RATE, 2);
            decimal tot = sub + itbis;

            if (txtSubTotal != null) txtSubTotal.Text = sub.ToString("N2");
            if (txtITEBIS != null) txtITEBIS.Text = itbis.ToString("N2");
            if (txtTotal != null) txtTotal.Text = tot.ToString("N2");
        }

        private void GuardarCabecera()
        {
            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    using var tx = con.BeginTransaction();

                    var up = new SqlCommand("UPDATE orden SET id_cliente=@cli, id_condicion=@con WHERE id_orden=@o", con, tx);
                    up.Parameters.AddWithValue("@cli", GetClienteIdDesdeCombo());
                    up.Parameters.AddWithValue("@con", _idCondicionActual);
                    up.Parameters.AddWithValue("@o", _idOrden);
                    up.ExecuteNonQuery();

                    // ← Asentar movimientos por DELTA SOLO al Guardar
                    PostearMovimientosDelta(con, tx);

                    tx.Commit();
                }

                MessageBox.Show("Orden guardada.");
                CambiarCondicionUI();

                _menu?.InicializarPlanoSalas();
                (this.Owner as MenuPrincipal)?.InicializarPlanoSalas();

                _cabeceraGuardadaEstaSesion = true;
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message); }
        }

        private void CambiarCondicionUI()
        {
            if (cmbMetodoPago != null)
            {
                cmbMetodoPago.Enabled = _autopago;
                if (_autopago)
                {
                    if (cmbMetodoPago.SelectedValue == null && cmbMetodoPago.Items.Count > 0)
                        cmbMetodoPago.SelectedIndex = 0;
                }
                else
                {
                    cmbMetodoPago.SelectedIndex = -1;
                    cmbMetodoPago.Text = "No aplica";
                }
            }

            if (txtCreacion != null && txtVence != null)
            {
                if (!DateTime.TryParseExact(txtCreacion.Text, "dd/MM/yyyy", null,
                    System.Globalization.DateTimeStyles.None, out DateTime baseDate))
                    baseDate = DateTime.Now.Date;

                txtVence.Text = baseDate.AddDays(_diasCreditoActual).ToString("dd/MM/yyyy");
            }
        }

        private void MostrarPrecuenta()
        {
            var lineas = string.Join(Environment.NewLine,
            _lineas.Select(l => $"{l.Nombre} x {l.Cantidad:N2} = {l.Subtotal:C2}"));

            decimal sub = _lineas.Sum(l => l.Subtotal);
            decimal itbis = Math.Round(sub * ITBIS_RATE, 2);
            decimal tot = sub + itbis;

            MessageBox.Show(
                lineas + Environment.NewLine + Environment.NewLine +
                $"Subtotal: {sub:C2}" + Environment.NewLine +
                $"ITBIS (18%): {itbis:C2}" + Environment.NewLine +
                $"Total: {tot:C2}",
                "Precuenta");
        }

        // ===== Persistir cabecera dentro de la transacción de Procesar =====
        private void PersistirClienteYCondicion(SqlConnection con, SqlTransaction tx)
        {
            int idCli = GetClienteIdDesdeCombo();

            if (_idCondicionActual <= 0)
                AplicarCondicionDeCliente(idCli);

            using (var up = new SqlCommand(
                "UPDATE orden SET id_cliente=@cli, id_condicion=@con WHERE id_orden=@o", con, tx))
            {
                up.Parameters.AddWithValue("@cli", idCli);
                up.Parameters.AddWithValue("@con", _idCondicionActual);
                up.Parameters.AddWithValue("@o", _idOrden);
                up.ExecuteNonQuery();
            }

            using (var cmd = new SqlCommand(
                "SELECT autopago, dias_credito FROM condicion WHERE id_condicion=@c", con, tx))
            {
                cmd.Parameters.AddWithValue("@c", _idCondicionActual);
                using var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    _autopago = !rd.IsDBNull(0) && rd.GetBoolean(0);
                    _diasCreditoActual = rd.IsDBNull(1) ? 0 : rd.GetInt32(1);
                }
            }
        }

        private void Procesar()
        {
            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    using var tx = con.BeginTransaction();

                    PersistirClienteYCondicion(con, tx);
                    RecalcularTotalOrden(con, tx);

                    // ← Asentar movimientos por DELTA SOLO al Procesar
                    PostearMovimientosDelta(con, tx);

                    if (_autopago)
                    {
                        if (cmbMetodoPago?.SelectedValue == null && cmbMetodoPago != null && cmbMetodoPago.Items.Count > 0)
                            cmbMetodoPago.SelectedIndex = 0;

                        if (cmbMetodoPago?.SelectedValue == null)
                            throw new Exception("Seleccione el método de pago.");

                        decimal total;
                        using (var cmdT = new SqlCommand("SELECT total FROM orden WHERE id_orden=@o", con, tx))
                        { cmdT.Parameters.AddWithValue("@o", _idOrden); total = Convert.ToDecimal(cmdT.ExecuteScalar()); }

                        var pago = new SqlCommand(
                            "INSERT INTO pago(fecha_pago,monto_total,id_metodo_pago,nota,estado) " +
                            "VALUES (GETDATE(),@m,@mp,'Pago automático de orden',1); " +
                            "SELECT CAST(SCOPE_IDENTITY() AS int);", con, tx);
                        pago.Parameters.AddWithValue("@m", total);
                        pago.Parameters.AddWithValue("@mp", (int)cmbMetodoPago.SelectedValue);
                        int idPago = (int)pago.ExecuteScalar();

                        var dp = new SqlCommand("INSERT INTO detalle_pago(id_pago,id_orden,monto_aplicado) VALUES (@p,@o,@m)", con, tx);
                        dp.Parameters.AddWithValue("@p", idPago);
                        dp.Parameters.AddWithValue("@o", _idOrden);
                        dp.Parameters.AddWithValue("@m", total);
                        dp.ExecuteNonQuery();

                        var up = new SqlCommand("UPDATE orden SET saldo_pendiente=0, procesada=1 WHERE id_orden=@o", con, tx);
                        up.Parameters.AddWithValue("@o", _idOrden);
                        up.ExecuteNonQuery();
                    }
                    else
                    {
                        var up = new SqlCommand(@"
                            UPDATE orden
                               SET fecha_vencimiento = CAST(DATEADD(day,@d,GETDATE()) AS date),
                                   saldo_pendiente   = total,
                                   procesada         = 1
                             WHERE id_orden=@o;", con, tx);
                        up.Parameters.AddWithValue("@d", _diasCreditoActual);
                        up.Parameters.AddWithValue("@o", _idOrden);
                        up.ExecuteNonQuery();
                    }

                    tx.Commit();
                }

                _ordenProcesadaEstaSesion = true;

                MessageBox.Show("Orden procesada. ¡Mesa libre!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error al procesar: " + ex.Message); }
        }

        // ===== Cancelar todo (botón) =====
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (_idOrden <= 0) { Close(); return; }
            if (MessageBox.Show("¿Cancelar y limpiar toda la orden?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var tx = con.BeginTransaction();

                // Devolver stock de cada línea activa antes de borrar
                using (var sel = new SqlCommand("SELECT id_producto, cantidad FROM detalle_orden WHERE id_orden=@o AND estado=1", con, tx))
                {
                    sel.Parameters.AddWithValue("@o", _idOrden);
                    using var rd = sel.ExecuteReader();
                    var devolver = new List<(int p, decimal c)>();
                    while (rd.Read()) devolver.Add((rd.GetInt32(0), rd.GetDecimal(1)));
                    rd.Close();
                    foreach (var it in devolver)
                    {
                        DevolverStock(con, tx, it.p, it.c);
                        // *** YA NO se registran movimientos aquí ***
                    }
                }

                using (var cmd = new SqlCommand("DELETE FROM detalle_orden WHERE id_orden=@o", con, tx))
                { cmd.Parameters.AddWithValue("@o", _idOrden); cmd.ExecuteNonQuery(); }

                using (var cmd = new SqlCommand("DELETE FROM orden WHERE id_orden=@o", con, tx))
                { cmd.Parameters.AddWithValue("@o", _idOrden); cmd.ExecuteNonQuery(); }

                tx.Commit();

                MessageBox.Show("Orden cancelada.");

                _menu?.InicializarPlanoSalas();
                (this.Owner as MenuPrincipal)?.InicializarPlanoSalas();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cancelar: " + ex.Message);
            }
        }

        // ===== Catálogo con scroll infinito =====
        private void ResetCatalogo()
        {
            flpCatalogo.SuspendLayout();
            flpCatalogo.Controls.Clear();
            _page = 0;
            _hasMore = true;
            flpCatalogo.ResumeLayout();
            CargarMasProductos();
        }

        private void CargarMasProductos()
        {
            if (_loading || !_hasMore) return;
            _loading = true;

            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    var cmd = new SqlCommand(@"
                        SELECT id_producto, nombre, precio_venta, imagen_ruta
                        FROM producto
                        WHERE estado = 1
                          AND stock_actual > 0                                  -- ← ocultar sin stock
                          AND (@cat IS NULL OR id_categoria = @cat)
                          AND (@q = '' OR nombre LIKE '%'+@q+'%' OR ISNULL(descripcion,'') LIKE '%'+@q+'%')
                        ORDER BY nombre
                        OFFSET @skip ROWS FETCH NEXT @take ROWS ONLY;", con);

                    object cat = (cmbCategoria?.SelectedValue == DBNull.Value) ? null : cmbCategoria?.SelectedValue;
                    cmd.Parameters.AddWithValue("@cat", (object)cat ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@q", txtBuscarProd?.Text?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@skip", _page * _pageSize);
                    cmd.Parameters.AddWithValue("@take", _pageSize);

                    using var rd = cmd.ExecuteReader();
                    int count = 0;

                    flpCatalogo.SuspendLayout();
                    while (rd.Read())
                    {
                        int id = rd.GetInt32(0);
                        string nom = rd.GetString(1);
                        decimal precio = rd.GetDecimal(2);
                        string img = rd.IsDBNull(3) ? null : rd.GetString(3);

                        flpCatalogo.Controls.Add(CrearCardProducto(id, nom, precio, img));
                        count++;
                    }
                    flpCatalogo.ResumeLayout();

                    _hasMore = (count == _pageSize);
                    if (_hasMore) _page++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar catálogo: " + ex.Message);
            }
            finally { _loading = false; }
        }

        // ===== Buscar Cliente (abre ConsultaCliente en modo SELECTOR) =====
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frm = new ConsultaCliente(mantenimientoForm: null, selectorMode: true))
                {
                    var r = frm.ShowDialog(this);
                    if (r == DialogResult.OK && frm.SelectedId > 0)
                    {
                        int idCliente = frm.SelectedId;
                        cmbCliente.SelectedValue = idCliente;

                        AplicarCondicionDeCliente(idCliente);
                        ActualizarClienteEnOrdenSiAbierta(idCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la consulta de clientes: " + ex.Message);
            }
        }

        private void SetCondicionInterna(int idCond)
        {
            _idCondicionActual = idCond;

            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var cmd = new SqlCommand(
                    "SELECT descripcion, autopago, dias_credito FROM condicion WHERE id_condicion=@c", con);
                cmd.Parameters.AddWithValue("@c", idCond);
                using var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    string desc = rd.IsDBNull(0) ? "" : rd.GetString(0);
                    _autopago = !rd.IsDBNull(1) && rd.GetBoolean(1);
                    _diasCreditoActual = rd.IsDBNull(2) ? 0 : rd.GetInt32(2);

                    if (txtCondicionPago != null)
                    {
                        txtCondicionPago.ReadOnly = true;
                        txtCondicionPago.Text = desc;
                    }
                }
            }
            catch
            {
                _autopago = false;
                _diasCreditoActual = 0;
                if (txtCondicionPago != null) txtCondicionPago.Text = "";
            }

            CambiarCondicionUI();
        }

        private void AplicarCondicionDeCliente(int idCliente)
        {
            if (idCliente <= 0) return;

            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var cmd = new SqlCommand("SELECT id_condicion FROM cliente WHERE id_cliente=@id", con);
                cmd.Parameters.AddWithValue("@id", idCliente);
                var obj = cmd.ExecuteScalar();

                if (obj != null && obj != DBNull.Value)
                {
                    int idCond = Convert.ToInt32(obj);
                    SetCondicionInterna(idCond);
                    CambiarCondicionUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo aplicar la condición del cliente: " + ex.Message);
            }
        }

        private void MostrarCondicionEnTextBox(int idCond)
        {
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var cmd = new SqlCommand("SELECT descripcion FROM condicion WHERE id_condicion=@c", con);
                cmd.Parameters.AddWithValue("@c", idCond);
                var desc = Convert.ToString(cmd.ExecuteScalar()) ?? "";
                if (txtCondicionPago != null)
                {
                    txtCondicionPago.ReadOnly = true;
                    txtCondicionPago.Text = desc;
                }
            }
            catch { if (txtCondicionPago != null) txtCondicionPago.Text = ""; }
        }

        private void ActualizarClienteEnOrdenSiAbierta(int idCli)
        {
            if (_idOrden <= 0) return;
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var up = new SqlCommand("UPDATE orden SET id_cliente=@cli, id_condicion=@con WHERE id_orden=@o", con);
                up.Parameters.AddWithValue("@cli", idCli);
                up.Parameters.AddWithValue("@con", _idCondicionActual);
                up.Parameters.AddWithValue("@o", _idOrden);
                up.ExecuteNonQuery();
            }
            catch { }
        }

        private void CargarSalaMesaLabel()
        {
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                var cmd = new SqlCommand(
                    "SELECT s.descripcion AS sala, m.descripcion AS mesa " +
                    "FROM mesa m JOIN sala s ON s.id_sala = m.id_sala WHERE m.id_mesa=@m", con);
                cmd.Parameters.AddWithValue("@m", _idMesa);

                using var rd = cmd.ExecuteReader();
                if (rd.Read() && lbSalaMesa != null)
                {
                    lbSalaMesa.Text = $"{rd.GetString(0)} - {rd.GetString(1)}";
                }
            }
            catch { /* solo visual */ }
        }

        private void SeleccionarClienteConsumidorFinal()
        {
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var cmd = new SqlCommand(
                    "SELECT TOP 1 id_cliente, id_condicion FROM cliente WHERE estado=1 AND nombre LIKE '%Consumidor%Final%' ORDER BY id_cliente", con);
                using var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    int idCli = rd.GetInt32(0);
                    int idCond = rd.GetInt32(1);

                    cmbCliente.SelectedValue = idCli;
                    SetCondicionInterna(idCond);
                }
            }
            catch { }
        }

        private void Titulo_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void dgvDetalle_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvDetalle.Columns[e.ColumnIndex].Name != "colCant") return;

            e.Handled = true;
            e.PaintBackground(e.CellBounds, true);

            var lin = (Linea)dgvDetalle.Rows[e.RowIndex].DataBoundItem;
            int cantidad = (int)Math.Round(lin.Cantidad);

            int padding = 3;
            int btnW = 28;
            int btnH = e.CellBounds.Height - (padding * 2);
            int y = e.CellBounds.Y + padding;

            var rectMenos = new Rectangle(e.CellBounds.X + padding, y, btnW, btnH);
            var rectMas = new Rectangle(e.CellBounds.Right - btnW - padding, y, btnW, btnH);
            var rectTexto = new Rectangle(rectMenos.Right + padding, y, e.CellBounds.Width - (btnW * 2) - (padding * 4), btnH);

            ButtonRenderer.DrawButton(e.Graphics, rectMenos, "-", dgvDetalle.Font, false, PushButtonState.Normal);
            ButtonRenderer.DrawButton(e.Graphics, rectMas, "+", dgvDetalle.Font, false, PushButtonState.Normal);

            TextRenderer.DrawText(
                e.Graphics,
                cantidad.ToString(),
                dgvDetalle.Font,
                rectTexto,
                Color.Black,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis
            );

            e.Paint(e.CellBounds, DataGridViewPaintParts.Border);
        }

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var colName = dgvDetalle.Columns[e.ColumnIndex].Name;
            var lin = (Linea)dgvDetalle.Rows[e.RowIndex].DataBoundItem;

            if (colName == "colQuitar")
            {
                CambiarCantidad(lin.IdDetalle, -999999m); // fuerza a eliminar
                return;
            }

            if (colName != "colCant") return;

            var cellRect = dgvDetalle.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

            int padding = 3;
            int btnW = 28;
            int btnH = cellRect.Height - (padding * 2);
            int y = cellRect.Y + padding;

            var rectMenos = new Rectangle(cellRect.X + padding, y, btnW, btnH);
            var rectMas = new Rectangle(cellRect.Right - btnW - padding, y, btnW, btnH);

            Point p = dgvDetalle.PointToClient(Cursor.Position);

            if (rectMenos.Contains(p))
            {
                CambiarCantidad(lin.IdDetalle, -1m);
            }
            else if (rectMas.Contains(p))
            {
                CambiarCantidad(lin.IdDetalle, +1m);
            }
        }

        private void CambiarCantidad(int idDetalle, decimal delta)
        {
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var tx = con.BeginTransaction();

                // Leer producto, cantidad y precio actuales
                int idProd;
                decimal cantActual, precio;
                using (var cmd = new SqlCommand("SELECT id_producto, cantidad, precio_unitario FROM detalle_orden WHERE id_detalle=@d AND estado=1", con, tx))
                {
                    cmd.Parameters.AddWithValue("@d", idDetalle);
                    using var rd = cmd.ExecuteReader();
                    if (!rd.Read()) { tx.Rollback(); return; }
                    idProd = rd.GetInt32(0);
                    cantActual = rd.GetDecimal(1);
                    precio = rd.GetDecimal(2);
                }

                var nueva = cantActual + delta;

                if (delta > 0m)
                {
                    // Aumentar cantidad → requiere descontar stock = delta
                    if (!TryDescontarStock(con, tx, idProd, delta, out decimal restante, out decimal min, out string nombre))
                    {
                        tx.Rollback();
                        MessageBox.Show($"No hay stock suficiente de \"{nombre}\". Disponible: {restante:N2}.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    using var up = new SqlCommand(@"
                        UPDATE detalle_orden
                           SET cantidad=@c, subtotal = ROUND(@c * @p, 2)
                         WHERE id_detalle=@d;", con, tx);
                    up.Parameters.AddWithValue("@c", nueva);
                    up.Parameters.AddWithValue("@p", precio);
                    up.Parameters.AddWithValue("@d", idDetalle);
                    up.ExecuteNonQuery();

                    // *** YA NO se registran movimientos aquí ***

                    RecalcularTotalOrden(con, tx);
                    tx.Commit();

                    if (restante <= 0) ResetCatalogo();
                    if (restante < min) VerificarYNotificarStockBajo(idProd);
                }
                else
                {
                    // Disminuir cantidad → devolver stock
                    decimal devolver = Math.Min(cantActual, -delta); // si delta=-999999 devuelve cantActual
                    if (nueva <= 0m)
                    {
                        // Quitar línea
                        using var del = new SqlCommand(@"
                            UPDATE detalle_orden
                               SET estado=0
                             WHERE id_detalle=@d;", con, tx);
                        del.Parameters.AddWithValue("@d", idDetalle);
                        del.ExecuteNonQuery();
                    }
                    else
                    {
                        using var up = new SqlCommand(@"
                            UPDATE detalle_orden
                               SET cantidad=@c, subtotal = ROUND(@c * @p, 2)
                             WHERE id_detalle=@d;", con, tx);
                        up.Parameters.AddWithValue("@c", nueva);
                        up.Parameters.AddWithValue("@p", precio);
                        up.Parameters.AddWithValue("@d", idDetalle);
                        up.ExecuteNonQuery();
                    }

                    DevolverStock(con, tx, idProd, devolver);

                    // *** YA NO se registran movimientos aquí ***

                    RecalcularTotalOrden(con, tx);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cambiar la cantidad: " + ex.Message);
            }

            CargarDetalle();
        }

        private void ProcesoFacturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_idOrden <= 0) return;

            if (_ordenProcesadaEstaSesion || _cabeceraGuardadaEstaSesion) return;

            if (!_ordenCreadaEnEstaSesion) return;

            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var tx = con.BeginTransaction();

                // Devolver stock de líneas activas
                using (var sel = new SqlCommand("SELECT id_producto, cantidad FROM detalle_orden WHERE id_orden=@o AND estado=1", con, tx))
                {
                    sel.Parameters.AddWithValue("@o", _idOrden);
                    using var rd = sel.ExecuteReader();
                    var devolver = new List<(int p, decimal c)>();
                    while (rd.Read()) devolver.Add((rd.GetInt32(0), rd.GetDecimal(1)));
                    rd.Close();
                    foreach (var it in devolver)
                    {
                        DevolverStock(con, tx, it.p, it.c);
                        // *** YA NO se registran movimientos aquí ***
                    }
                }

                using (var cmd = new SqlCommand("DELETE FROM detalle_orden WHERE id_orden=@o", con, tx))
                { cmd.Parameters.AddWithValue("@o", _idOrden); cmd.ExecuteNonQuery(); }

                using (var cmd = new SqlCommand("DELETE FROM orden WHERE id_orden=@o", con, tx))
                { cmd.Parameters.AddWithValue("@o", _idOrden); cmd.ExecuteNonQuery(); }

                tx.Commit();

                _menu?.InicializarPlanoSalas();
                (this.Owner as MenuPrincipal)?.InicializarPlanoSalas();
            }
            catch
            {
                // no bloquear el cierre
            }
        }
    }
}
