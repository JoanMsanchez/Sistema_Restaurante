using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Restaurante.Proceso
{
    public partial class ProcesoFacturacion : Form
    {
        // Connection string
        private const string CS = @"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true";

        // Estado
        private int _idMesa;
        private int _idOrden = -1;
        private int _idEmpleado = 1; // TODO: setear desde login
        private bool _autopago = false;

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
        public ProcesoFacturacion(int idMesa)
        {
            InitializeComponent();
            _idMesa = idMesa;
            this.Load += ProcesoFacturacion_Load;
            this.Shown += ProcesoFacturacion_Shown;
        }

        // ===== Arranque =====
        private void ProcesoFacturacion_Load(object sender, EventArgs e)
        {
            Text = $"ProcesoFacturación - Mesa #{_idMesa}";
            ConfigurarGridDetalle();
            WireEventosUI();
        }

        private void ProcesoFacturacion_Shown(object sender, EventArgs e)
        {
            CargarCombos();
            AbrirOCrearOrden();   // crea/obtiene orden abierta y fija _autopago
            CargarDetalle();
            ResetCatalogo();      // <— reemplaza RefrescarCatalogo()
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

            // Condición
            if (cmbCondicion != null) cmbCondicion.SelectedIndexChanged += (_, __) => CambiarCondicionUI();

            // Cambiar mesa / Buscar cliente
            if (btnCambiarMesa != null) btnCambiarMesa.Click += BtnCambiarMesa_Click;
            if (btnBuscarCliente != null) btnBuscarCliente.Click += BtnBuscarCliente_Click;
        }

        private void ConfigurarGridDetalle()
        {
            var g = dgvDetalle;
            g.AutoGenerateColumns = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToResizeRows = false;
            g.RowHeadersVisible = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.Columns.Clear();

            g.Columns.Add(new DataGridViewTextBoxColumn { Name = "colIdDet", HeaderText = "IdDet", DataPropertyName = "IdDetalle", Visible = false });
            g.Columns.Add(new DataGridViewTextBoxColumn { Name = "colIdProd", HeaderText = "Id", DataPropertyName = "IdProducto", Visible = false });
            g.Columns.Add(new DataGridViewTextBoxColumn { Name = "colProducto", HeaderText = "Producto", DataPropertyName = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCant",
                HeaderText = "Cant.",
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
            g.CellClick += Dgv_CellClick;
            g.CellEndEdit += Dgv_CellEndEdit;
            g.EditingControlShowing += Dgv_EditingControlShowing;
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
                    var cf = dtCli.NewRow(); cf["id_cliente"] = DBNull.Value; cf["nombre"] = "(Consumidor Final)";
                    dtCli.Rows.InsertAt(cf, 0);
                    cmbCliente.DisplayMember = "nombre"; cmbCliente.ValueMember = "id_cliente"; cmbCliente.DataSource = dtCli;

                    // Condiciones
                    var dtCon = new DataTable();
                    new SqlDataAdapter("SELECT id_condicion, descripcion, autopago, dias_credito FROM condicion WHERE estado=1 ORDER BY descripcion", con).Fill(dtCon);
                    cmbCondicion.DisplayMember = "descripcion"; cmbCondicion.ValueMember = "id_condicion"; cmbCondicion.DataSource = dtCon;

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

                    // Buscar orden abierta
                    var sel = new SqlCommand(
                        "SELECT TOP 1 o.id_orden, c.autopago " +
                        "FROM orden o JOIN condicion c ON c.id_condicion=o.id_condicion " +
                        "WHERE o.id_mesa=@m AND o.procesada=0 AND o.estado=1 ORDER BY o.id_orden DESC;", con);
                    sel.Parameters.AddWithValue("@m", _idMesa);

                    using (var rd = sel.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            _idOrden = rd.GetInt32(0);
                            _autopago = rd.GetBoolean(1);
                            cmbMetodoPago.Enabled = _autopago;
                            return;
                        }
                    }

                    // Crear nueva
                    int idCond = (int)cmbCondicion.SelectedValue;
                    object idCli = (object?)cmbCliente.SelectedValue ?? DBNull.Value;

                    var ins = new SqlCommand(@"
                        INSERT INTO orden(id_cliente, id_mesa, id_empleado, id_condicion, fecha_hora,
                                          fecha_vencimiento, total, saldo_pendiente, procesada, estado)
                        VALUES (@cli, @mesa, @emp, @cond, GETDATE(), NULL, 0, 0, 0, 1);
                        SELECT CAST(SCOPE_IDENTITY() AS int);", con);
                    ins.Parameters.AddWithValue("@cli", idCli ?? DBNull.Value);
                    ins.Parameters.AddWithValue("@mesa", _idMesa);
                    ins.Parameters.AddWithValue("@emp", _idEmpleado);
                    ins.Parameters.AddWithValue("@cond", idCond);

                    _idOrden = (int)ins.ExecuteScalar();

                    var ap = new SqlCommand("SELECT autopago FROM condicion WHERE id_condicion=@c", con);
                    ap.Parameters.AddWithValue("@c", idCond);
                    _autopago = Convert.ToBoolean(ap.ExecuteScalar());
                    cmbMetodoPago.Enabled = _autopago;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al abrir/crear orden: " + ex.Message); }
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

        private void Dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDetalle.CurrentCell?.OwningColumn?.Name == "colCant" && e.Control is TextBox tb)
            {
                tb.KeyPress -= SoloDecimal;
                tb.KeyPress += SoloDecimal;
            }
        }
        private void SoloDecimal(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            var tb = (TextBox)sender;
            bool yaP = tb.Text.Contains(".");
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && (yaP || tb.SelectionStart == 0)) e.Handled = true;
        }

        private void Dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvDetalle.Columns[e.ColumnIndex].Name != "colCant") return;

            var lin = (Linea)dgvDetalle.Rows[e.RowIndex].DataBoundItem;
            if (lin.Cantidad < 0) lin.Cantidad = 0;

            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    using var tx = con.BeginTransaction();

                    var up = new SqlCommand(@"
                        UPDATE detalle_orden
                           SET cantidad=@c, subtotal=ROUND(@c*precio_unitario,2)
                         WHERE id_detalle=@d AND estado=1;", con, tx);
                    up.Parameters.AddWithValue("@c", lin.Cantidad);
                    up.Parameters.AddWithValue("@d", lin.IdDetalle);
                    up.ExecuteNonQuery();

                    RecalcularTotalOrden(con, tx);
                    tx.Commit();
                }
            }
            catch (Exception ex) { MessageBox.Show("No se pudo actualizar la cantidad: " + ex.Message); }

            CargarDetalle();
        }

        // ===== Totales & cabecera =====
        private void RecalcularTotalOrden(SqlConnection cn, SqlTransaction tx)
        {
            var tot = new SqlCommand(@"
                UPDATE orden
                   SET total = (SELECT ISNULL(SUM(subtotal),0) FROM detalle_orden WHERE id_orden=@o AND estado=1)
                 WHERE id_orden=@o;", cn, tx);
            tot.Parameters.AddWithValue("@o", _idOrden);
            tot.ExecuteNonQuery();
        }

        private void RecalcularTotales()
        {
            decimal sub = _lineas.Sum(l => l.Subtotal);
            if (lblSubTotal != null) lblSubTotal.Text = $"Sub-Total: {sub:C2}";
            if (lblTotal != null) lblTotal.Text = $"TOTAL: {sub:C2}";
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
                    up.Parameters.AddWithValue("@con", (int)cmbCondicion.SelectedValue);
                    up.Parameters.AddWithValue("@o", _idOrden);
                    up.ExecuteNonQuery();
                }

                MessageBox.Show("Orden guardada.");
                CambiarCondicionUI();
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message); }
        }

        private void CambiarCondicionUI()
        {
            if (cmbCondicion.SelectedItem is DataRowView rv)
            {
                _autopago = rv.Row.Field<bool>("autopago");
                if (cmbMetodoPago != null) cmbMetodoPago.Enabled = _autopago;
            }
        }

        private void MostrarPrecuenta()
        {
            var texto = string.Join(Environment.NewLine,
                _lineas.Select(l => $"{l.Nombre} x {l.Cantidad:N2} = {l.Subtotal:C2}"));
            MessageBox.Show(texto + Environment.NewLine + Environment.NewLine + (lblTotal?.Text ?? ""), "Precuenta");
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
                        int dias;
                        using (var cmdD = new SqlCommand("SELECT dias_credito FROM condicion WHERE id_condicion=@c", con, tx))
                        { cmdD.Parameters.AddWithValue("@c", (int)cmbCondicion.SelectedValue); dias = Convert.ToInt32(cmdD.ExecuteScalar()); }

                        var up = new SqlCommand(@"
                            UPDATE orden
                               SET fecha_vencimiento = CAST(DATEADD(day,@d,GETDATE()) AS date),
                                   saldo_pendiente   = total,
                                   procesada         = 1
                             WHERE id_orden=@o;", con, tx);
                        up.Parameters.AddWithValue("@d", dias);
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

        // ===== Cambiar Mesa / Buscar Cliente =====
        private void BtnCambiarMesa_Click(object sender, EventArgs e)
        {
            int? nueva = ElegirMesaLibre();
            if (!nueva.HasValue || nueva.Value == _idMesa) return;

            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    var up = new SqlCommand("UPDATE orden SET id_mesa=@m WHERE id_orden=@o", con);
                    up.Parameters.AddWithValue("@m", nueva.Value);
                    up.Parameters.AddWithValue("@o", _idOrden);
                    up.ExecuteNonQuery();
                }

                _idMesa = nueva.Value;
                this.Text = $"ProcesoFacturación - Mesa #{_idMesa}";
                MessageBox.Show("Mesa cambiada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cambiar la mesa: " + ex.Message);
            }
        }

        // Wrappers por si el Diseñador apunta a estos nombres (evita errores de “no existe en el contexto”)
        private void btnCambiarMesa_Click(object sender, EventArgs e) => BtnCambiarMesa_Click(sender, e);
        private void btnBuscarCliente_Click(object sender, EventArgs e) => BtnBuscarCliente_Click(sender, e);

        private int? ElegirMesaLibre()
        {
            DataTable dt = new DataTable();
            using (var con = new SqlConnection(CS))
            {
                con.Open();
                using var da = new SqlDataAdapter(@"
                    SELECT m.id_mesa, s.descripcion + ' - ' + m.descripcion AS nombre
                    FROM mesa m
                    JOIN sala s ON s.id_sala = m.id_sala
                    WHERE m.estado = 1
                      AND NOT EXISTS (
                        SELECT 1 FROM orden o
                        WHERE o.id_mesa = m.id_mesa AND o.procesada = 0 AND o.estado = 1
                      )
                    ORDER BY s.descripcion, m.descripcion;", con);
                da.Fill(dt);
            }
            if (dt.Rows.Count == 0) { MessageBox.Show("No hay mesas libres."); return null; }

            using var f = new Form { Width = 420, Height = 150, Text = "Cambiar a mesa…" };
            var cb = new ComboBox { Left = 20, Top = 20, Width = 360, DropDownStyle = ComboBoxStyle.DropDownList };
            cb.DisplayMember = "nombre"; cb.ValueMember = "id_mesa"; cb.DataSource = dt;
            var ok = new Button { Text = "Aceptar", Left = 220, Width = 75, Top = 60, DialogResult = DialogResult.OK };
            var cancel = new Button { Text = "Cancelar", Left = 305, Width = 75, Top = 60, DialogResult = DialogResult.Cancel };
            f.Controls.Add(cb); f.Controls.Add(ok); f.Controls.Add(cancel); f.AcceptButton = ok; f.CancelButton = cancel;

            return f.ShowDialog(this) == DialogResult.OK ? (int?)cb.SelectedValue : null;
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            string criterio = Microsoft.VisualBasic.Interaction.InputBox(
                "Nombre del cliente:", "Buscar cliente", "").Trim();
            if (string.IsNullOrEmpty(criterio)) return;

            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    var cmd = new SqlCommand(
                        "SELECT TOP 1 id_cliente FROM cliente WHERE estado=1 AND nombre LIKE @q ORDER BY nombre", con);
                    cmd.Parameters.AddWithValue("@q", "%" + criterio + "%");
                    var id = cmd.ExecuteScalar();
                    if (id != null) cmbCliente.SelectedValue = (int)id;
                    else MessageBox.Show("No se encontró un cliente con ese nombre.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
            }
        }
        private void ProcesoFacturacion_Shown_1(object sender, EventArgs e)
        {
            // Reutiliza el handler nuevo para no duplicar lógica
            ProcesoFacturacion_Shown(sender, e);
        }
    }
}
