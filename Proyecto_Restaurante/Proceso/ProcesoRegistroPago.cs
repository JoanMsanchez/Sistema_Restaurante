using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Restaurante.Proceso
{
    public partial class ProcesoRegistroPago : Form
    {
        private const string CS =
            @"Server=DESKTOP-HUHR9O6\SQLEXPRESS;Database=SistemaRestauranteDB1;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=15";

        private const int CMD_TIMEOUT = 30;
        private const int ACTIVO = 1;

        private DataTable _dtPendientes;
        private readonly CultureInfo _ci = new CultureInfo("es-DO");
        private readonly ErrorProvider err = new ErrorProvider();

        public ProcesoRegistroPago()
        {
            InitializeComponent();

            err.ContainerControl = this;
            err.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            ConfigurarGrids();
            WireEvents();

            // Fecha / usuario
            SetTextIfExists("txtFechaPago", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            if (txtEmpleado != null) txtEmpleado.Text = Environment.UserName;

            // Espejos de solo lectura
            PrepEspejo(txtAplicadoValor);
            PrepEspejo(txtDiferenciaValor);
            PrepEspejo(txtTotalCobrarValor);

            // Valores iniciales
            SetTextIfExists("txtAplicado", "0.00");
            SetTextIfExists("txtAplicadoValor", "RD$ 0.00");
            SetTextIfExists("txtDiferencia", "0.00");
            SetTextIfExists("txtDiferenciaValor", "RD$ 0.00");
            SetTextIfExists("txtTotalAplicado", "RD$ 0.00");
            SetTextIfExists("txtTotalCobrar", "0.00");
            SetTextIfExists("txtTotalCobrarValor", "RD$ 0.00");

            CargarCombos();
            CargarOrdenesPendientes();
            RecalcularTotales();
        }

        private void PrepEspejo(TextBox tb)
        {
            if (tb == null) return;
            tb.ReadOnly = true;
            tb.TabStop = false;
            tb.TextAlign = HorizontalAlignment.Right;
        }

        // ================= UI =================
        private void ConfigurarGrids()
        {
            // ÓRDENES PENDIENTES
            dgvOrdenesPendientes.AutoGenerateColumns = false;

            if (dgvOrdenesPendientes.Columns.Count == 0)
            {
                dgvOrdenesPendientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOP_IdOrden", HeaderText = "ID Orden", DataPropertyName = "id_orden", FillWeight = 12, ReadOnly = true });
                dgvOrdenesPendientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOP_Cliente", HeaderText = "Cliente", DataPropertyName = "cliente", FillWeight = 28, ReadOnly = true });
                dgvOrdenesPendientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOP_Fecha", HeaderText = "Fecha", DataPropertyName = "fecha_hora", FillWeight = 16, ReadOnly = true });
                dgvOrdenesPendientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOP_Vence", HeaderText = "Vence", DataPropertyName = "fecha_vencimiento", FillWeight = 16, ReadOnly = true });
                dgvOrdenesPendientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOP_Total", HeaderText = "Total", DataPropertyName = "total", FillWeight = 14, ReadOnly = true, DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight } });
                dgvOrdenesPendientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOP_Saldo", HeaderText = "Saldo", DataPropertyName = "saldo_pendiente", FillWeight = 14, ReadOnly = true, DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight } });
            }
            else
            {
                SetDataProperty(dgvOrdenesPendientes, "colOP_IdOrden", "id_orden");
                SetDataProperty(dgvOrdenesPendientes, "colOP_Cliente", "cliente");
                SetDataProperty(dgvOrdenesPendientes, "colOP_Fecha", "fecha_hora");
                SetDataProperty(dgvOrdenesPendientes, "colOP_Vence", "fecha_vencimiento");
                SetDataProperty(dgvOrdenesPendientes, "colOP_Total", "total");
                SetDataProperty(dgvOrdenesPendientes, "colOP_Saldo", "saldo_pendiente");
            }

            dgvOrdenesPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdenesPendientes.MultiSelect = true;
            dgvOrdenesPendientes.AllowUserToAddRows = false;
            dgvOrdenesPendientes.ReadOnly = true;
            dgvOrdenesPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // DISTRIBUCIÓN
            dgvDistribucion.AutoGenerateColumns = false;
            if (dgvDistribucion.Columns.Count == 0)
            {
                dgvDistribucion.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDP_IdOrden", HeaderText = "ID Orden", DataPropertyName = "id_orden", FillWeight = 12, ReadOnly = true });
                dgvDistribucion.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDP_SaldoPend", HeaderText = "Saldo Pend.", DataPropertyName = "saldo_pendiente", FillWeight = 20, ReadOnly = true, DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight } });
                dgvDistribucion.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDP_MontoAplicar", HeaderText = "Monto a aplicar", DataPropertyName = "monto_aplicar", FillWeight = 22, ReadOnly = false, DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight } });
                dgvDistribucion.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDP_NuevoSaldo", HeaderText = "Nuevo saldo", DataPropertyName = "nuevo_saldo", FillWeight = 20, ReadOnly = true, DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight } });
            }

            dgvDistribucion.AllowUserToAddRows = false;
            dgvDistribucion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDistribucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var dt = new DataTable();
            dt.Columns.Add("id_orden", typeof(int));
            dt.Columns.Add("saldo_pendiente", typeof(decimal));
            dt.Columns.Add("monto_aplicar", typeof(decimal));
            dt.Columns.Add("nuevo_saldo", typeof(decimal));
            dgvDistribucion.DataSource = dt;
        }

        private void SetDataProperty(DataGridView grid, string columnName, string dataProperty)
        {
            if (grid.Columns.Contains(columnName))
                grid.Columns[columnName].DataPropertyName = dataProperty;
        }

        private void WireEvents()
        {
            txtMontoTotal.KeyPress += TxtDecimal_KeyPress;
            txtMontoTotal.TextChanged += (_, __) => RecalcularTotales();
            txtMontoTotal.Leave += (_, __) => RecalcularTotales();

            dgvDistribucion.CellEndEdit += DgvDistribucion_CellEndEdit;
            dgvDistribucion.EditingControlShowing += DgvDistribucion_EditingControlShowing;

            btnPasarADistribucion.Click += BtnPasarADistribucion_Click;
            btnQuitarSeleccion.Click += (_, __) => QuitarSeleccionDistrib();
            btnAplicarAuto.Click += (_, __) => AplicarAutomatico();
            btnLimpiar.Click += (_, __) => LimpiarDistribucion();
            btnCancelar.Click += (_, __) => Close();
            btnGuardar.Click += BtnGuardar_Click;

            if (cboClienteFiltro != null)
                cboClienteFiltro.SelectionChangeCommitted += (_, __) => CargarOrdenesPendientes();
        }

        // ================= CARGAS =================
        private void CargarCombos()
        {
            try
            {
                using var cn = new SqlConnection(CS);
                cn.Open();

                // ---- MÉTODO DE PAGO (estado = 1) ----
                var dtMetodo = new DataTable();
                dtMetodo.Columns.Add("id_metodo_pago", typeof(int));
                dtMetodo.Columns.Add("descripcion", typeof(string));

                using (var cmd = new SqlCommand(
                    "SELECT id_metodo_pago, descripcion FROM metodo_pago WHERE estado = @e ORDER BY descripcion", cn))
                {
                    cmd.CommandTimeout = CMD_TIMEOUT;
                    cmd.Parameters.AddWithValue("@e", ACTIVO);
                    using var rd = cmd.ExecuteReader();
                    while (rd.Read())
                        dtMetodo.Rows.Add(rd.GetInt32(0), rd.GetString(1));
                }

                BindCombo(cboMetodoPago, dtMetodo, "descripcion", "id_metodo_pago", preselectNone: true);

                // ---- CLIENTE (filtro) ----
                if (cboClienteFiltro != null)
                {
                    var dtCli = new DataTable();
                    dtCli.Columns.Add("id_cliente", typeof(int));
                    dtCli.Columns.Add("nombre", typeof(string));

                    dtCli.Rows.Add(0, "(Todos)");

                    using (var cmd = new SqlCommand(
                        "SELECT id_cliente, nombre FROM cliente WHERE estado = @e ORDER BY nombre", cn))
                    {
                        cmd.CommandTimeout = CMD_TIMEOUT;
                        cmd.Parameters.AddWithValue("@e", ACTIVO);
                        using var rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            int id = rd.GetInt32(0);
                            string nom = rd.IsDBNull(1) ? "(sin nombre)" : rd.GetString(1);
                            dtCli.Rows.Add(id, nom);
                        }
                    }

                    BindCombo(cboClienteFiltro, dtCli, "nombre", "id_cliente", preselectNone: false);
                    if (cboClienteFiltro.Items.Count > 0) cboClienteFiltro.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando combos (consulta): " + ex.ToString(),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindCombo(ComboBox cbo, DataTable dt, string display, string value, bool preselectNone)
        {
            if (cbo == null) return;

            cbo.BeginUpdate();
            try
            {
                // Evitar estados inconsistentes (origen del error 'key')
                cbo.DataSource = null;
                cbo.Items.Clear();

                if (!dt.Columns.Contains(display)) display = dt.Columns[1].ColumnName;
                if (!dt.Columns.Contains(value)) value = dt.Columns[0].ColumnName;

                cbo.DisplayMember = display;
                cbo.ValueMember = value;
                cbo.DataSource = dt;

                if (preselectNone)
                {
                    // *** NO usar SelectedValue = null (provoca el 'key' nulo) ***
                    cbo.SelectedIndex = -1;
                    cbo.Text = string.Empty;
                }
            }
            finally { cbo.EndUpdate(); }
        }

        private void CargarOrdenesPendientes()
        {
            try
            {
                int idCliente = 0;
                if (cboClienteFiltro != null && cboClienteFiltro.SelectedValue != null)
                    idCliente = Convert.ToInt32(cboClienteFiltro.SelectedValue);

                using var cn = new SqlConnection(CS);
                cn.Open();

                _dtPendientes = new DataTable();

                bool ordenTieneEstado = true;

                using (var da = new SqlDataAdapter(
                    @"SELECT o.id_orden,
                             ISNULL(c.nombre,'(sin cliente)') AS cliente,
                             CONVERT(varchar(10), o.fecha_hora, 103)        AS fecha_hora,
                             CONVERT(varchar(10), o.fecha_vencimiento, 103) AS fecha_vencimiento,
                             o.total, o.saldo_pendiente
                      FROM orden o
                      LEFT JOIN cliente c ON c.id_cliente = o.id_cliente
                      WHERE o.saldo_pendiente > 0
                        AND (@id_cliente = 0 OR o.id_cliente = @id_cliente)
                        AND (@usa_estado = 0 OR o.estado = @e)
                      ORDER BY o.fecha_hora DESC", cn))
                {
                    da.SelectCommand.CommandTimeout = CMD_TIMEOUT;
                    da.SelectCommand.Parameters.AddWithValue("@id_cliente", idCliente);
                    da.SelectCommand.Parameters.AddWithValue("@e", ACTIVO);
                    da.SelectCommand.Parameters.AddWithValue("@usa_estado", ordenTieneEstado ? 1 : 0);
                    da.Fill(_dtPendientes);
                }

                string[] esperadas = { "id_orden", "cliente", "fecha_hora", "fecha_vencimiento", "total", "saldo_pendiente" };
                bool nombresOk = esperadas.All(c => _dtPendientes.Columns.Contains(c));
                if (!nombresOk && _dtPendientes.Columns.Count > 0)
                {
                    dgvOrdenesPendientes.AutoGenerateColumns = true;
                    dgvOrdenesPendientes.Columns.Clear();
                }

                dgvOrdenesPendientes.DataSource = _dtPendientes;
                dgvOrdenesPendientes.Refresh();

                if (_dtPendientes.Rows.Count == 0)
                {
                    using var cn2 = new SqlConnection(CS);
                    cn2.Open();

                    using var da2 = new SqlDataAdapter(
                        @"SELECT TOP 50 o.id_orden,
                                 ISNULL(c.nombre,'(sin cliente)') AS cliente,
                                 CONVERT(varchar(10), o.fecha_hora, 103)        AS fecha_hora,
                                 CONVERT(varchar(10), o.fecha_vencimiento, 103) AS fecha_vencimiento,
                                 o.total, o.saldo_pendiente
                          FROM orden o
                          LEFT JOIN cliente c ON c.id_cliente = o.id_cliente
                          ORDER BY o.fecha_hora DESC", cn2);

                    var dtFallback = new DataTable();
                    da2.Fill(dtFallback);

                    if (dtFallback.Rows.Count > 0)
                    {
                        dgvOrdenesPendientes.AutoGenerateColumns = true;
                        dgvOrdenesPendientes.Columns.Clear();
                        dgvOrdenesPendientes.DataSource = dtFallback;
                        MessageBox.Show("No hay órdenes con saldo pendiente. Se muestran órdenes recientes para verificar datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando órdenes (consulta): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============== LÓGICA DISTRIBUCIÓN ==============
        private void BtnPasarADistribucion_Click(object sender, EventArgs e)
        {
            if (dgvOrdenesPendientes.SelectedRows.Count == 0) return;

            var dtDist = (DataTable)dgvDistribucion.DataSource;

            foreach (DataGridViewRow r in dgvOrdenesPendientes.SelectedRows)
            {
                int idOrden = Convert.ToInt32(r.Cells.Contains("colOP_IdOrden") ? r.Cells["colOP_IdOrden"].Value : r.Cells["id_orden"].Value);
                decimal saldo = Convert.ToDecimal(r.Cells.Contains("colOP_Saldo") ? r.Cells["colOP_Saldo"].Value : r.Cells["saldo_pendiente"].Value);

                if (dtDist.AsEnumerable().Any(x => x.Field<int>("id_orden") == idOrden)) continue;

                var row = dtDist.NewRow();
                row["id_orden"] = idOrden;
                row["saldo_pendiente"] = saldo;
                row["monto_aplicar"] = 0m;
                row["nuevo_saldo"] = saldo;
                dtDist.Rows.Add(row);
            }

            RecalcularTotales();
        }

        private void QuitarSeleccionDistrib()
        {
            var dt = (DataTable)dgvDistribucion.DataSource;
            foreach (DataGridViewRow r in dgvDistribucion.SelectedRows)
                if (!r.IsNewRow) dt.Rows.RemoveAt(r.Index);
            RecalcularTotales();
        }

        private void AplicarAutomatico()
        {
            decimal total = ParseMonto(txtMontoTotal.Text);
            var dt = (DataTable)dgvDistribucion.DataSource;
            if (dt.Rows.Count == 0 || total <= 0m) return;

            decimal restante = total;
            foreach (DataRow row in dt.Rows)
            {
                decimal saldo = row.Field<decimal>("saldo_pendiente");
                decimal aplicar = Math.Min(saldo, restante);
                row["monto_aplicar"] = aplicar;
                row["nuevo_saldo"] = saldo - aplicar;
                restante -= aplicar;
                if (restante <= 0m) break;
            }
            foreach (DataRow row in dt.Rows)
                if (row.Field<decimal>("monto_aplicar") == 0m)
                    row["nuevo_saldo"] = row.Field<decimal>("saldo_pendiente");

            RecalcularTotales();
        }

        private void LimpiarDistribucion()
        {
            ((DataTable)dgvDistribucion.DataSource).Rows.Clear();
            RecalcularTotales();
        }

        private void DgvDistribucion_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDistribucion.CurrentCell?.OwningColumn?.Name == "colDP_MontoAplicar" && e.Control is TextBox tb)
            {
                tb.KeyPress -= TxtDecimal_KeyPress;
                tb.KeyPress += TxtDecimal_KeyPress;
            }
        }

        private void DgvDistribucion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvDistribucion.Columns[e.ColumnIndex].Name != "colDP_MontoAplicar") return;

            var row = dgvDistribucion.Rows[e.RowIndex];
            decimal saldo = Convert.ToDecimal(row.Cells["colDP_SaldoPend"].Value);

            decimal aplicar = 0m;
            if (row.Cells["colDP_MontoAplicar"].Value != null)
                aplicar = ParseMonto(row.Cells["colDP_MontoAplicar"].Value.ToString());

            if (aplicar < 0m) aplicar = 0m;
            if (aplicar > saldo) aplicar = saldo;

            row.Cells["colDP_MontoAplicar"].Value = aplicar;
            row.Cells["colDP_NuevoSaldo"].Value = saldo - aplicar;

            RecalcularTotales();
        }

        private void RecalcularTotales()
        {
            // 1) Monto digitado
            decimal total = ParseMonto(txtMontoTotal.Text);

            // 2) Suma aplicada y suma de saldos de las órdenes ya seleccionadas a la derecha
            decimal aplicado = 0m;
            decimal totalSaldosSeleccionados = 0m;

            foreach (DataGridViewRow r in dgvDistribucion.Rows)
            {
                if (r.IsNewRow) continue;

                if (r.Cells["colDP_MontoAplicar"].Value != null)
                    aplicado += ParseMonto(Convert.ToString(r.Cells["colDP_MontoAplicar"].Value));

                if (r.Cells["colDP_SaldoPend"].Value != null)
                    totalSaldosSeleccionados += ParseMonto(Convert.ToString(r.Cells["colDP_SaldoPend"].Value));
            }

            decimal diferencia = total - aplicado;

            // Números
            SetTextIfExists("txtAplicado", aplicado.ToString("N2", _ci));
            SetTextIfExists("txtDiferencia", diferencia.ToString("N2", _ci));
            SetTextIfExists("txtTotalCobrar", totalSaldosSeleccionados.ToString("N2", _ci));

            // Espejos con RD$
            if (txtAplicadoValor != null) txtAplicadoValor.Text = $"RD$ {aplicado.ToString("N2", _ci)}";
            if (txtDiferenciaValor != null) txtDiferenciaValor.Text = $"RD$ {diferencia.ToString("N2", _ci)}";
            if (txtTotalCobrarValor != null) txtTotalCobrarValor.Text = $"RD$ {totalSaldosSeleccionados.ToString("N2", _ci)}";

            // “Total aplicado” también con RD$
            SetTextIfExists("txtTotalAplicado", $"RD$ {aplicado.ToString("N2", _ci)}");

            btnGuardar.Enabled = aplicado > 0m
                                 && Math.Round(diferencia, 2) == 0m
                                 && GetSelectedId(cboMetodoPago) > 0;
        }

        // ================= GUARDAR =================
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (GetSelectedId(cboMetodoPago) <= 0) { err.SetError(cboMetodoPago, "Seleccione método de pago"); return; }
            decimal total = ParseMonto(txtMontoTotal.Text);
            if (total <= 0m) { err.SetError(txtMontoTotal, "Monto total > 0"); return; }

            decimal aplicado = 0m;
            foreach (DataGridViewRow r in dgvDistribucion.Rows)
                if (!r.IsNewRow) aplicado += ParseMonto(Convert.ToString(r.Cells["colDP_MontoAplicar"].Value));

            if (Math.Round(total - aplicado, 2) != 0m)
            {
                MessageBox.Show("La suma aplicada debe ser igual al monto total.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (aplicado <= 0m)
            {
                MessageBox.Show("No hay distribución para guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var cn = new SqlConnection(CS);
            cn.Open();
            using var tx = cn.BeginTransaction();

            try
            {
                var cmdPago = new SqlCommand(
                    @"INSERT INTO pago (fecha_pago, monto_total, id_metodo_pago, nota, estado)
                      OUTPUT INSERTED.id_pago
                      VALUES (@fecha, @monto, @metodo, @nota, @estado);", cn, tx)
                { CommandTimeout = CMD_TIMEOUT };

                cmdPago.Parameters.AddWithValue("@fecha", GetFechaPago());
                cmdPago.Parameters.AddWithValue("@monto", total);
                cmdPago.Parameters.AddWithValue("@metodo", GetSelectedId(cboMetodoPago));
                cmdPago.Parameters.AddWithValue("@nota", (object)(txtNota?.Text ?? string.Empty));
                cmdPago.Parameters.AddWithValue("@estado", ACTIVO);
                int idPago = Convert.ToInt32(cmdPago.ExecuteScalar());

                foreach (DataGridViewRow r in dgvDistribucion.Rows)
                {
                    if (r.IsNewRow) continue;

                    int idOrden = Convert.ToInt32(r.Cells["colDP_IdOrden"].Value);
                    decimal monto = ParseMonto(Convert.ToString(r.Cells["colDP_MontoAplicar"].Value));
                    if (monto <= 0m) continue;

                    var cmdDet = new SqlCommand(
                        @"INSERT INTO detalle_pago (id_pago, id_orden, monto_aplicado)
                          VALUES (@id_pago, @id_orden, @monto);", cn, tx)
                    { CommandTimeout = CMD_TIMEOUT };
                    cmdDet.Parameters.AddWithValue("@id_pago", idPago);
                    cmdDet.Parameters.AddWithValue("@id_orden", idOrden);
                    cmdDet.Parameters.AddWithValue("@monto", monto);
                    cmdDet.ExecuteNonQuery();

                    var cmdUpd = new SqlCommand(
                        @"UPDATE orden
                          SET saldo_pendiente = CASE WHEN saldo_pendiente >= @monto THEN saldo_pendiente - @monto ELSE 0 END
                          WHERE id_orden = @id_orden;", cn, tx)
                    { CommandTimeout = CMD_TIMEOUT };
                    cmdUpd.Parameters.AddWithValue("@monto", monto);
                    cmdUpd.Parameters.AddWithValue("@id_orden", idOrden);
                    cmdUpd.ExecuteNonQuery();
                }

                tx.Commit();

                SetTextIfExists("txtIdPago", idPago.ToString());
                MessageBox.Show($"Pago #{idPago} registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarDistribucion();
                CargarOrdenesPendientes();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("Error al guardar el pago (consulta): " + ex.Message, "Timeout/Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= HELPERS =================
        private void TxtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '.' || e.KeyChar == ','))
            { e.Handled = true; return; }
            if ((e.KeyChar == '.' || e.KeyChar == ',') && sender is TextBox tb && (tb.Text.Contains('.') || tb.Text.Contains(',')))
            { e.Handled = true; }
        }

        private decimal ParseMonto(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return 0m;
            raw = raw.Replace("RD$", "", StringComparison.InvariantCultureIgnoreCase).Replace("$", "").Trim();
            if (decimal.TryParse(raw, NumberStyles.Any, _ci, out var v)) return v;
            raw = raw.Replace(".", "").Replace(",", ".");
            if (decimal.TryParse(raw, NumberStyles.Any, CultureInfo.InvariantCulture, out v)) return v;
            return 0m;
        }

        private DateTime GetFechaPago()
        {
            var txt = FindControl<TextBox>("txtFechaPago");
            if (txt == null || string.IsNullOrWhiteSpace(txt.Text)) return DateTime.Now;

            var formatos = new[] { "dd/MM/yyyy HH:mm", "dd/MM/yyyy", "MM/dd/yyyy HH:mm", "MM/dd/yyyy" };
            if (DateTime.TryParseExact(txt.Text.Trim(), formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out var d))
                return d;
            return DateTime.Now;
        }

        private int GetSelectedId(ComboBox cbo)
        {
            try { return cbo?.SelectedValue == null ? 0 : Convert.ToInt32(cbo.SelectedValue); }
            catch { return 0; }
        }

        private void SetTextIfExists(string controlName, string text)
        {
            var ctl = this.Controls.Find(controlName, true).FirstOrDefault();
            if (ctl != null) ctl.Text = text;
        }

        private T FindControl<T>(string name) where T : Control
            => this.Controls.Find(name, true).FirstOrDefault() as T;
    }

    internal static class DataGridViewRowExt
    {
        public static bool Contains(this DataGridViewCellCollection cells, string name) => cells.ContainsKey(name);
        public static bool ContainsKey(this DataGridViewCellCollection cells, string name)
        {
            try { var _ = cells[name]; return true; } catch { return false; }
        }
    }
}
