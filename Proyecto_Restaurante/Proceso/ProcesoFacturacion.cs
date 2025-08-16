using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
// Si tu ConsultaCliente está en este namespace:
using Proyecto_Restaurante.Consulta;
using Proyecto_Restaurante.Mantenimiento;

namespace Proyecto_Restaurante.Proceso
{
    public partial class ProcesoFacturacion : Form
    {
        // Connection string
        //private const string CS = @"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true";
        private const string CS = @"server=MSI; database=SistemaRestauranteDB1; integrated security=true";

        private readonly MenuPrincipal _menu; // NUEVO


        // Estado
        private int _idMesa;
        private int _idOrden = -1;
        private int _idEmpleado = 1; // TODO: setear desde login
        private bool _autopago = false;
        private int _idCondicionActual = -1;     // ← NUEVO: ID de condición actual (sin combo)
        private int _diasCreditoActual = 0;      // ← NUEVO: días de crédito de la condición
        private const decimal ITBIS_RATE = 0.18m; // 18%


        // Scroll infinito catálogo
        private int _page = 0;
        private const int _pageSize = 24;
        private bool _loading = false;
        private bool _hasMore = true;

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
            _menu = menu;                    // para refrescar colores/estado de mesas
            this.Load += ProcesoFacturacion_Load;
            this.Shown += ProcesoFacturacion_Shown;
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

            // Selección por defecto: Consumidor Final (+ su condición) ANTES de abrir/crear la orden
            SeleccionarClienteConsumidorFinal();

            AbrirOCrearOrden();    // crea/obtiene orden abierta y fija _autopago y _idEmpleado
            CargarEmpleadoLabel(); // llena lbEmpleado
            CargarCabeceraVisual(); // fechas / saldo / (cliente + condición si ya existía)
            CargarDetalle();
            ResetCatalogo();       // catálogo con scroll infinito
            RecalcularTotales();
        }

        // ===== UI =====
        private void WireEventosUI()
        {
            // Filtros catálogo → reinician lista
            if (txtBuscarProd != null) txtBuscarProd.TextChanged += (_, __) => ResetCatalogo();
            if (cmbCategoria != null) cmbCategoria.SelectedIndexChanged += (_, __) => ResetCatalogo();

            // Scroll infinito
            flpCatalogo.AutoScroll = true;
            flpCatalogo.Scroll += (s, e) =>
            {
                var v = flpCatalogo.VerticalScroll;
                if (v.Value + flpCatalogo.ClientSize.Height + 50 >= v.Maximum)
                    CargarMasProductos();
            };

            // Botones
            if (btnGuardar != null) btnGuardar.Click += (_, __) => GuardarCabecera();
            if (btnPrecuenta != null) btnPrecuenta.Click += (_, __) => MostrarPrecuenta();
            if (btnProcesar != null) btnProcesar.Click += (_, __) => Procesar();
            if (btnCancelar != null) btnCancelar.Click += BtnCancelar_Click;

            // Condición

            // Buscar cliente (abre consulta en modo selector)
            if (btnBuscarCliente != null) btnBuscarCliente.Click += BtnBuscarCliente_Click;

            // Si cambia el cliente (combo o por la consulta), aplicar su condición y desactivar el combo
            if (cmbCliente != null) cmbCliente.SelectedValueChanged += (_, __) =>
            {
                if (int.TryParse(Convert.ToString(cmbCliente.SelectedValue), out int idCli) && idCli > 0)
                    AplicarCondicionDeCliente(idCli);
               // else
                    //cmbCondicion.Enabled = true; // si vuelve a (Consumidor Final), permitir elegir manualmente (opcional)
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
            g.ReadOnly = true; // ← NO editable
            g.Columns.Clear();

            g.Columns.Add(new DataGridViewTextBoxColumn { Name = "colIdDet", HeaderText = "IdDet", DataPropertyName = "IdDetalle", Visible = false });
            g.Columns.Add(new DataGridViewTextBoxColumn { Name = "colIdProd", HeaderText = "Id", DataPropertyName = "IdProducto", Visible = false });
            g.Columns.Add(new DataGridViewTextBoxColumn { Name = "colProducto", HeaderText = "Producto", DataPropertyName = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCant",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" }
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
            g.CellClick += Dgv_CellClick;     // botón quitar funciona aunque sea ReadOnly
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

                    // Clientes
                    var dtCli = new DataTable();
                    new SqlDataAdapter("SELECT id_cliente, nombre FROM cliente WHERE estado=1 ORDER BY nombre", con).Fill(dtCli);
                    cmbCliente.DisplayMember = "nombre"; cmbCliente.ValueMember = "id_cliente"; cmbCliente.DataSource = dtCli;


                    // Condiciones
                    //var dtCon = new DataTable();
                    //new SqlDataAdapter("SELECT id_condicion, descripcion, autopago, dias_credito FROM condicion WHERE estado=1 ORDER BY descripcion", con).Fill(dtCon);
                    //cmbCondicion.DisplayMember = "descripcion"; cmbCondicion.ValueMember = "id_condicion"; cmbCondicion.DataSource = dtCon;

                    // Métodos de pago
                    var dtMet = new DataTable();
                    new SqlDataAdapter("SELECT id_metodo_pago, descripcion FROM metodo_pago WHERE estado=1 ORDER BY descripcion", con).Fill(dtMet);
                    cmbMetodoPago.DisplayMember = "descripcion"; cmbMetodoPago.ValueMember = "id_metodo_pago"; cmbMetodoPago.DataSource = dtMet;
                    cmbMetodoPago.Enabled = false;

                    // Categorías
                    var dtCat = new DataTable();
                    new SqlDataAdapter("SELECT id_categoria, nombre FROM categoria_producto WHERE estado=1 ORDER BY nombre", con).Fill(dtCat);
                    var all = dtCat.NewRow(); all["id_categoria"] = DBNull.Value; all["nombre"] = "Todas";
                    dtCat.Rows.InsertAt(all, 0);
                    cmbCategoria.DisplayMember = "nombre"; cmbCategoria.ValueMember = "id_categoria";
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
                Height = 220,   // alto suficiente para que no se corte el botón
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
                TextAlign = ContentAlignment.MiddleCenter,
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

        // ===== Orden / Detalle =====
        private void AbrirOCrearOrden()
        {
            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();

                    // Buscar orden abierta (traemos también id_empleado)
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
                            _idEmpleado = rd.GetInt32(2); // empleado que atiende esta orden
                            cmbMetodoPago.Enabled = _autopago;
                            return;
                        }
                    }

                    // Crear nueva
                    if (_idCondicionActual <= 0)
                    {
                        // intenta obtener desde el cliente seleccionado
                        using var cmdCli = new SqlCommand("SELECT id_condicion FROM cliente WHERE id_cliente=@c", con);
                        cmdCli.Parameters.AddWithValue("@c", (object?)cmbCliente.SelectedValue ?? DBNull.Value);
                        var obj = cmdCli.ExecuteScalar();
                        if (obj != null && obj != DBNull.Value)
                        {
                            _idCondicionActual = Convert.ToInt32(obj);
                            SetCondicionInterna(_idCondicionActual); // carga autopago/dias/descripcion
                        }
                    }

                    var ins = new SqlCommand(@"
                        INSERT INTO orden(id_cliente, id_mesa, id_empleado, id_condicion, fecha_hora,
                                          fecha_vencimiento, total, saldo_pendiente, procesada, estado)
                        VALUES (@cli, @mesa, @emp, @cond, GETDATE(), NULL, 0, 0, 0, 1);
                        SELECT CAST(SCOPE_IDENTITY() AS int);", con);
                    ins.Parameters.AddWithValue("@cli", (object?)cmbCliente.SelectedValue ?? DBNull.Value);
                    ins.Parameters.AddWithValue("@mesa", _idMesa);
                    ins.Parameters.AddWithValue("@emp", _idEmpleado);
                    ins.Parameters.AddWithValue("@cond", _idCondicionActual);

                    _idOrden = (int)ins.ExecuteScalar();

                    // auto/No auto pago desde condición
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

                // Intento 1: desde la orden (nombre completo con CONCAT maneja NULLs)
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

                // Intento 2: por _idEmpleado en caso de que no haya orden o campos distintos
                if (string.IsNullOrWhiteSpace(nombreCompleto))
                {
                    using var cmd2 = new SqlCommand(
                        "SELECT LTRIM(RTRIM(CONCAT(nombre,' ',apellidos))) FROM empleado WHERE id_empleado=@id", con);
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

                    if (txtCreacion != null) {txtCreacion.Text = fcrea.ToString("dd/MM/yyyy"); }
                    if (txtVence != null)
                    {
                        //txtVence.ReadOnly = true;
                        txtVence.Text = (fven ?? DateTime.Now.Date).ToString("dd/MM/yyyy"); // ← NUEVO: default HOY
                    }
                    if (txtSaldoPendiente != null)
                        txtSaldoPendiente.Text = saldo.ToString("N2");

                    // Cliente y condición en UI (si la orden ya existía)
                    if (idCli.HasValue && cmbCliente != null)
                        cmbCliente.SelectedValue = idCli.Value;

                    SetCondicionInterna(idCond);
                    MostrarCondicionEnTextBox(idCond); // pinta el TextBox con la descripción
                }
            }
            catch
            {
                // visual opcional
            }
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
            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    using var tx = con.BeginTransaction();

                    // precio
                    var pCmd = new SqlCommand("SELECT precio_venta FROM producto WHERE id_producto=@p AND estado=1", con, tx);
                    pCmd.Parameters.AddWithValue("@p", idProducto);
                    var precioObj = pCmd.ExecuteScalar();
                    if (precioObj == null) throw new Exception("Producto inactivo o inexistente.");
                    decimal precio = Convert.ToDecimal(precioObj);

                    // ¿línea activa?
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

                    RecalcularTotalOrden(con, tx);
                    tx.Commit();
                }
            }
            catch (Exception ex) { MessageBox.Show("No se pudo agregar el producto: " + ex.Message); }

            CargarDetalle();
        }

        // ===== Grid eventos =====
        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvDetalle.Columns[e.ColumnIndex].Name != "colQuitar") return;

            var lin = (Linea)dgvDetalle.Rows[e.RowIndex].DataBoundItem;
            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    using var tx = con.BeginTransaction();

                    var del = new SqlCommand("UPDATE detalle_orden SET estado=0 WHERE id_detalle=@d", con, tx);
                    del.Parameters.AddWithValue("@d", lin.IdDetalle);
                    del.ExecuteNonQuery();

                    RecalcularTotalOrden(con, tx);
                    tx.Commit();
                }
            }
            catch (Exception ex) { MessageBox.Show("No se pudo quitar la línea: " + ex.Message); }

            CargarDetalle();
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
                    var up = new SqlCommand("UPDATE orden SET id_cliente=@cli, id_condicion=@con WHERE id_orden=@o", con);
                    up.Parameters.AddWithValue("@cli", (object?)cmbCliente.SelectedValue ?? DBNull.Value);
                    up.Parameters.AddWithValue("@con", _idCondicionActual);     // ← SIN combo
                    up.Parameters.AddWithValue("@o", _idOrden);
                    up.ExecuteNonQuery();
                }

                MessageBox.Show("Orden guardada.");
                CambiarCondicionUI();

                _menu?.InicializarPlanoSalas();
                (this.Owner as MenuPrincipal)?.InicializarPlanoSalas();
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message); }
        }

        private void CambiarCondicionUI()
        {
            // Método de pago
            if (cmbMetodoPago != null)
            {
                cmbMetodoPago.Enabled = _autopago;
                if (!_autopago)
                {
                    cmbMetodoPago.SelectedIndex = -1;
                    cmbMetodoPago.Text = "No aplica";
                }
            }

            // Vencimiento
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

        private void Procesar()
        {
            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    using var tx = con.BeginTransaction();

                    // Recalcular total
                    RecalcularTotalOrden(con, tx);

                    if (_autopago)
                    {
                        if (cmbMetodoPago.SelectedValue == null) throw new Exception("Seleccione el método de pago.");

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

                MessageBox.Show("Orden procesada. ¡Mesa libre!");
                this.DialogResult = DialogResult.OK;   // MenuPrincipal refrescará ocupación
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error al procesar: " + ex.Message); }
        }

        // ===== Cancelar todo =====
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

                // Anular líneas y anular orden (libera mesa)
                using (var cmd = new SqlCommand("UPDATE detalle_orden SET estado=0 WHERE id_orden=@o", con, tx))
                { cmd.Parameters.AddWithValue("@o", _idOrden); cmd.ExecuteNonQuery(); }

                using (var cmd = new SqlCommand("UPDATE orden SET estado=0, procesada=1, saldo_pendiente=0 WHERE id_orden=@o", con, tx))
                { cmd.Parameters.AddWithValue("@o", _idOrden); cmd.ExecuteNonQuery(); }

                tx.Commit();

                MessageBox.Show("Orden cancelada.");

                _menu?.InicializarPlanoSalas(); //nuevo
                (this.Owner as MenuPrincipal)?.InicializarPlanoSalas();


                this.DialogResult = DialogResult.OK; // refresca colores en MenuPrincipal
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
                        cmbCliente.SelectedValue = idCliente;  // dispara SelectedValueChanged

                        if (frm.SelectedCondicionId > 0)
                        {
                            SetCondicionInterna(frm.SelectedCondicionId);
                            CambiarCondicionUI();                 // aplica autopago / No aplica / vencimiento
                        }
                        else
                        {
                            // safety: si la consulta no envió la condición, la buscamos
                            AplicarCondicionDeCliente(idCliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la consulta de clientes: " + ex.Message);
            }
        }

        // ===== Helpers condición =====
        /*private void SetCondicionFromId(int idCond)
        {
            if (cmbCondicion?.DataSource is DataTable dt)
            {
                // validar que exista el id en el DataSource
                var found = dt.AsEnumerable().Any(r => r.Field<int>("id_condicion") == idCond);
                if (!found)
                {
                    // recargar por seguridad
                    using var con = new SqlConnection(CS);
                    con.Open();
                    dt.Clear();
                    new SqlDataAdapter("SELECT id_condicion, descripcion, autopago, dias_credito FROM condicion WHERE estado=1 ORDER BY descripcion", con).Fill(dt);
                }
                cmbCondicion.SelectedValue = idCond;
            }
            else
            {
                cmbCondicion.SelectedValue = idCond;
            }
        }*/


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

            // Refrescar la UI dependiente
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
                    SetCondicionInterna(idCond); // fija variables y TextBox
                    CambiarCondicionUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo aplicar la condición del cliente: " + ex.Message);
            }
        }

        private void MostrarCondicionEnTextBox(int idCond) // NUEVO
        {
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();
                using var cmd = new SqlCommand(
                    "SELECT descripcion FROM condicion WHERE id_condicion=@c", con);
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

        // ===== Sala-Mesa label =====
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

        private void SeleccionarClienteConsumidorFinal() // NUEVO
        {
            try
            {
                using var con = new SqlConnection(CS);
                con.Open();

                // Ajusta el LIKE si tu nombre exacto es distinto
                using var cmd = new SqlCommand(
                    "SELECT TOP 1 id_cliente, id_condicion " +
                    "FROM cliente WHERE estado=1 AND nombre LIKE '%Consumidor%Final%' " +
                    "ORDER BY id_cliente", con);
                using var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    int idCli = rd.GetInt32(0);
                    int idCond = rd.GetInt32(1);

                    cmbCliente.SelectedValue = idCli;
                    SetCondicionInterna(idCond); // fija _idCondicionActual / txt / autopago / días
                }
            }
            catch
            {
                // si no existe, no rompe el flujo
            }
        }

        private void Titulo_Paint(object sender, PaintEventArgs e) { }
    }
}
