using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;

// PDF (MigraDoc / PDFsharp)
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace Proyecto_Restaurante.Proceso
{
    public partial class ProcesoRegistroPago : Form
    {
        private const string CS =
            @"Server=DESKTOP-HUHR9O6\SQLEXPRESS;Database=SistemaRestauranteDB1;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=15";

        private const int CMD_TIMEOUT = 30;
        private const int ACTIVO = 1;

        // Carpeta destino de PDFs de recibo
        private const string RECIBOS_FOLDER = @"C:\imagen\PDF";
        // Ruta del logo
        private const string LOGO_PATH = @"C:\imagen\LOGONEGRO.png";

        private DataTable _dtPendientes;
        private readonly CultureInfo _ci = new CultureInfo("es-DO");
        private readonly ErrorProvider err = new ErrorProvider();

        // Estética
        private int bordeSize = 2;

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

            // Estética del formulario
            this.Padding = new Padding(bordeSize);
            this.BackColor = System.Drawing.Color.FromArgb(255, 161, 43);
        }

        // ================= Drag / bordes =================
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) return;
            base.WndProc(ref m);
        }

        private void Producto_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

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

        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;
        }
        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

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
                cbo.DataSource = null;
                cbo.Items.Clear();

                if (!dt.Columns.Contains(display)) display = dt.Columns[1].ColumnName;
                if (!dt.Columns.Contains(value)) value = dt.Columns[0].ColumnName;

                cbo.DisplayMember = display;
                cbo.ValueMember = value;
                cbo.DataSource = dt;

                if (preselectNone)
                {
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
                    MessageBox.Show("No hay órdenes con saldo pendiente para el filtro seleccionado.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // ===== Suma total YA aplicado históricamente en las órdenes seleccionadas
        private decimal GetYaAplicadoHistoricoSeleccion()
        {
            decimal yaAplicado = 0m;

            if (dgvDistribucion?.Rows == null) return 0m;

            foreach (DataGridViewRow r in dgvDistribucion.Rows)
            {
                if (r.IsNewRow) continue;
                int idOrden = Convert.ToInt32(r.Cells["colDP_IdOrden"].Value);

                // 1) Buscar en el DataTable (_dtPendientes) si está cargado
                if (_dtPendientes != null && _dtPendientes.Rows.Count > 0)
                {
                    var rows = _dtPendientes.Select($"id_orden = {idOrden}");
                    if (rows.Length > 0)
                    {
                        decimal total = Convert.ToDecimal(rows[0]["total"]);
                        decimal saldo = Convert.ToDecimal(rows[0]["saldo_pendiente"]);
                        yaAplicado += (total - saldo);
                        continue;
                    }
                }

                // 2) Fallback: consulta directa
                using (var cn = new SqlConnection(CS))
                {
                    cn.Open();
                    using var cmd = new SqlCommand("SELECT total, saldo_pendiente FROM orden WHERE id_orden=@o", cn);
                    cmd.Parameters.AddWithValue("@o", idOrden);
                    using var rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        decimal total = rd.GetDecimal(0);
                        decimal saldo = rd.GetDecimal(1);
                        yaAplicado += (total - saldo);
                    }
                }
            }

            return yaAplicado;
        }

        // ===== Recalculadora con “Total aplicado histórico” y permiso de sobrante
        private void RecalcularTotales()
        {
            // 1) Monto digitado
            decimal total = ParseMonto(txtMontoTotal.Text);

            // 2) Suma aplicada AHORA y suma de saldos de las órdenes seleccionadas
            decimal aplicadoAhora = 0m;
            decimal totalSaldosSeleccionados = 0m;

            foreach (DataGridViewRow r in dgvDistribucion.Rows)
            {
                if (r.IsNewRow) continue;

                if (r.Cells["colDP_MontoAplicar"].Value != null)
                    aplicadoAhora += ParseMonto(Convert.ToString(r.Cells["colDP_MontoAplicar"].Value));

                if (r.Cells["colDP_SaldoPend"].Value != null)
                    totalSaldosSeleccionados += ParseMonto(Convert.ToString(r.Cells["colDP_SaldoPend"].Value));
            }

            // 3) Ya aplicado HISTÓRICO en esas órdenes (antes de este pago)
            decimal yaAplicadoHistorico = GetYaAplicadoHistoricoSeleccion();

            // 4) Totales compuestos
            decimal diferencia = total - aplicadoAhora; // sobrante si > 0
            decimal totalAplicadoHistorico = yaAplicadoHistorico + aplicadoAhora;

            // 5) Números base
            SetTextIfExists("txtAplicado", aplicadoAhora.ToString("N2", _ci));
            SetTextIfExists("txtDiferencia", diferencia.ToString("N2", _ci));
            SetTextIfExists("txtTotalCobrar", totalSaldosSeleccionados.ToString("N2", _ci));

            // 6) Espejos RD$
            if (txtAplicadoValor != null) txtAplicadoValor.Text = $"RD$ {aplicadoAhora.ToString("N2", _ci)}";
            if (txtDiferenciaValor != null) txtDiferenciaValor.Text = $"RD$ {diferencia.ToString("N2", _ci)}";
            if (txtTotalCobrarValor != null) txtTotalCobrarValor.Text = $"RD$ {totalSaldosSeleccionados.ToString("N2", _ci)}";

            // 7) Total aplicado HISTÓRICO (anterior + ahora)
            SetTextIfExists("txtTotalAplicado", $"RD$ {totalAplicadoHistorico.ToString("N2", _ci)}");

            // 8) Permitir guardar
            btnGuardar.Enabled = aplicadoAhora > 0m
                                 && Math.Round(total - aplicadoAhora, 2) >= 0m
                                 && GetSelectedId(cboMetodoPago) > 0;
        }

        // ================= GUARDAR =================
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            err.SetError(cboMetodoPago, "");
            err.SetError(txtMontoTotal, "");

            if (GetSelectedId(cboMetodoPago) <= 0) { err.SetError(cboMetodoPago, "Seleccione método de pago"); return; }
            decimal total = ParseMonto(txtMontoTotal.Text);
            if (total <= 0m) { err.SetError(txtMontoTotal, "Monto total > 0"); return; }

            decimal aplicado = 0m;
            foreach (DataGridViewRow r in dgvDistribucion.Rows)
                if (!r.IsNewRow) aplicado += ParseMonto(Convert.ToString(r.Cells["colDP_MontoAplicar"].Value));

            if (Math.Round(aplicado - total, 2) > 0m)
            {
                MessageBox.Show("Está aplicando más de lo cobrado. Ajuste el monto o la distribución.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (aplicado <= 0m)
            {
                MessageBox.Show("No hay distribución para guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal sobrante = Math.Round(total - aplicado, 2); // si > 0, es cambio/no asignado

            using var cn = new SqlConnection(CS);
            cn.Open();
            using var tx = cn.BeginTransaction();

            try
            {
                // Encabezado del pago por el MONTO TOTAL cobrado
                var cmdPago = new SqlCommand(
                    @"INSERT INTO pago (fecha_pago, monto_total, id_metodo_pago, nota, estado)
                      OUTPUT INSERTED.id_pago
                      VALUES (@fecha, @monto, @metodo, @nota, @estado);", cn, tx)
                { CommandTimeout = CMD_TIMEOUT };

                string notaOriginal = (txtNota?.Text ?? string.Empty).Trim();
                string notaConSobrante = notaOriginal;
                if (sobrante > 0m)
                    notaConSobrante = (notaConSobrante.Length == 0 ? "" : (notaConSobrante + " | "))
                                      + $"Sobrante (cambio) RD$ {sobrante.ToString("N2", _ci)}";

                cmdPago.Parameters.AddWithValue("@fecha", GetFechaPago());
                cmdPago.Parameters.AddWithValue("@monto", total); // total cobrado (incluye sobrante)
                cmdPago.Parameters.AddWithValue("@metodo", GetSelectedId(cboMetodoPago));
                cmdPago.Parameters.AddWithValue("@nota", (object)notaConSobrante);
                cmdPago.Parameters.AddWithValue("@estado", ACTIVO);
                int idPago = Convert.ToInt32(cmdPago.ExecuteScalar());

                // Detalle y actualización de saldos SOLO por lo aplicado
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

                // Confirmar transacción ANTES de generar el PDF
                tx.Commit();

                // Guardar id en UI (si existe ese textbox)
                SetTextIfExists("txtIdPago", idPago.ToString());

                // ========= GENERAR Y ABRIR RECIBO INMEDIATAMENTE =========
                try
                {
                    string pdf = CrearReciboPdf(idPago);
                    try
                    {
                        Process.Start(new ProcessStartInfo { FileName = pdf, UseShellExecute = true });
                    }
                    catch
                    {
                        Process.Start(pdf);
                    }
                }
                catch (Exception exPdf)
                {
                    MessageBox.Show("El pago fue guardado, pero ocurrió un error generando el recibo PDF.\n\nDetalle: " + exPdf.Message,
                        "Recibo PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Mensaje de éxito
                string msg = $"Pago #{idPago} registrado.\n" +
                             $"Cobrado: RD$ {total.ToString("N2", _ci)}\n" +
                             $"Aplicado: RD$ {aplicado.ToString("N2", _ci)}\n";
                if (sobrante > 0m) msg += $"Sobrante (cambio): RD$ {sobrante.ToString("N2", _ci)}";
                MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar UI
                LimpiarDistribucion();
                CargarOrdenesPendientes();
                RecalcularTotales();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("Error al guardar el pago (consulta): " + ex.Message, "Timeout/Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================== RECIBO (PDF) ==================
        private string RD(decimal v) => "RD$ " + v.ToString("N2", _ci);

        private string CrearReciboPdf(int idPago)
        {
            // ===== 1) Consultas: encabezado y detalle =====
            DateTime fechaPago = DateTime.Now;
            decimal montoTotal = 0m;
            string metodoDesc = "(Sin método)";
            string nota = "";

            var detalle = new System.Collections.Generic.List<(int idOrden, string cliente, decimal aplicado, decimal saldoRestante)>();

            using (var cn = new SqlConnection(CS))
            {
                cn.Open();

                // Encabezado
                using (var cmd = new SqlCommand(@"
                    SELECT p.fecha_pago, p.monto_total, ISNULL(p.nota,''), ISNULL(mp.descripcion,'(Sin método)')
                    FROM pago p
                    LEFT JOIN metodo_pago mp ON mp.id_metodo_pago = p.id_metodo_pago
                    WHERE p.id_pago = @id", cn))
                {
                    cmd.Parameters.AddWithValue("@id", idPago);
                    using var rd = cmd.ExecuteReader();
                    if (!rd.Read())
                        throw new Exception($"No existe el pago #{idPago}.");

                    fechaPago = rd.GetDateTime(0);
                    montoTotal = rd.GetDecimal(1);
                    nota = rd.IsDBNull(2) ? "" : rd.GetString(2);
                    metodoDesc = rd.IsDBNull(3) ? "(Sin método)" : rd.GetString(3);
                }

                // Detalle por orden
                using (var cmd = new SqlCommand(@"
                    SELECT dp.id_orden,
                           ISNULL(c.nombre,'(sin cliente)') AS cliente,
                           dp.monto_aplicado,
                           ISNULL(o.saldo_pendiente,0) AS saldo_restante
                    FROM detalle_pago dp
                    JOIN orden o       ON o.id_orden = dp.id_orden
                    LEFT JOIN cliente c ON c.id_cliente = o.id_cliente
                    WHERE dp.id_pago = @id
                    ORDER BY dp.id_orden", cn))
                {
                    cmd.Parameters.AddWithValue("@id", idPago);
                    using var rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        int idOrden = rd.GetInt32(0);
                        string cliente = rd.IsDBNull(1) ? "(sin cliente)" : rd.GetString(1);
                        decimal aplicado = rd.IsDBNull(2) ? 0m : rd.GetDecimal(2);
                        decimal saldoRest = rd.IsDBNull(3) ? 0m : rd.GetDecimal(3);
                        detalle.Add((idOrden, cliente, aplicado, saldoRest));
                    }
                }
            }

            decimal aplicadoTotal = detalle.Sum(d => d.aplicado);
            decimal sobrante = Math.Max(0m, montoTotal - aplicadoTotal);

            string clienteMostrar = "(Varios clientes)";
            var distintos = detalle.Select(d => d.cliente).Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
            if (distintos.Count == 1) clienteMostrar = distintos[0];

            string usuario = FindControl<TextBox>("txtEmpleado")?.Text?.Trim();
            if (string.IsNullOrWhiteSpace(usuario)) usuario = Environment.UserName;

            // ===== 2) Documento PDF (MigraDoc) =====
            var doc = new Document();
            doc.Info.Title = $"Recibo #{idPago}";
            doc.UseCmykColor = false;

            var normal = doc.Styles["Normal"];
            normal.Font.Name = "Arial";
            normal.Font.Size = 10;

            var h1 = doc.Styles.AddStyle("H1", "Normal");
            h1.Font.Size = 16; h1.Font.Bold = true; h1.ParagraphFormat.SpaceAfter = 6;

            var small = doc.Styles.AddStyle("Small", "Normal");
            small.Font.Size = 9; small.ParagraphFormat.SpaceAfter = 1.5;

            var sec = doc.AddSection();
            sec.PageSetup.PageFormat = PageFormat.Letter;
            sec.PageSetup.LeftMargin = Unit.FromCentimeter(1.6);
            sec.PageSetup.RightMargin = Unit.FromCentimeter(1.6);
            sec.PageSetup.TopMargin = Unit.FromCentimeter(1.6);
            sec.PageSetup.BottomMargin = Unit.FromCentimeter(1.6);

            // ===== Encabezado: título IZQ + logo DER =====
            var head = sec.AddTable();
            head.Borders.Visible = false;
            head.AddColumn(Unit.FromCentimeter(12.5)); // texto
            head.AddColumn(Unit.FromCentimeter(5.0));  // logo

            var hr = head.AddRow();

            // Texto
            var pTitle = hr.Cells[0].AddParagraph("RECIBO DE PAGO");
            pTitle.Style = "H1";
            var pSub = hr.Cells[0].AddParagraph($"Recibo #{idPago} • {fechaPago:dd/MM/yyyy HH:mm} • Usuario: {usuario}");
            pSub.Style = "Small";

            // Logo (derecha, alto mayor)
            if (File.Exists(LOGO_PATH))
            {
                var pLogo = hr.Cells[1].AddParagraph();
                pLogo.Format.Alignment = ParagraphAlignment.Right;
                var img = pLogo.AddImage(LOGO_PATH);
                img.LockAspectRatio = true;
                img.Height = Unit.FromCentimeter(3.2);
            }

            sec.AddParagraph().AddLineBreak();

            // ===== Meta (cliente/método/nota + totales a la derecha) =====
            var meta = sec.AddTable();
            meta.Borders.Visible = false;
            meta.AddColumn(Unit.FromCentimeter(9.5));
            meta.AddColumn(Unit.FromCentimeter(8.0));
            var mr = meta.AddRow();

            // Izquierda
            mr.Cells[0].AddParagraph($"Cliente: {clienteMostrar}");
            mr.Cells[0].AddParagraph($"Método de pago: {metodoDesc}");
            if (!string.IsNullOrWhiteSpace(nota))
                mr.Cells[0].AddParagraph($"Nota: {nota}");

            // Derecha (totales con tab stop a la derecha)
            var cTot = mr.Cells[1];
            Unit anchoCaja = cTot.Column.Width;
            var tabRight = anchoCaja - Unit.FromMillimeter(2);
            var indent = Unit.FromMillimeter(2);

            Paragraph t1 = cTot.AddParagraph();
            t1.Format.TabStops.AddTabStop(tabRight, MigraDoc.DocumentObjectModel.TabAlignment.Right);
            t1.Format.LeftIndent = indent; t1.Format.RightIndent = indent;
            t1.AddText("Monto cobrado:"); t1.AddTab(); t1.AddText(RD(montoTotal));

            Paragraph t2 = cTot.AddParagraph();
            t2.Format.TabStops.AddTabStop(tabRight, MigraDoc.DocumentObjectModel.TabAlignment.Right);
            t2.Format.LeftIndent = indent; t2.Format.RightIndent = indent;
            t2.AddText("Aplicado:"); t2.AddTab(); t2.AddText(RD(aplicadoTotal));

            Paragraph t3 = cTot.AddParagraph();
            t3.Format.TabStops.AddTabStop(tabRight, MigraDoc.DocumentObjectModel.TabAlignment.Right);
            t3.Format.LeftIndent = indent; t3.Format.RightIndent = indent;
            t3.Format.Font.Bold = true; t3.Format.SpaceBefore = 2;
            t3.AddText("Sobrante (cambio):"); t3.AddTab(); t3.AddText(RD(sobrante));

            sec.AddParagraph().AddLineBreak();

            // ===== Tabla de detalle por orden =====
            var tbl = sec.AddTable();
            tbl.Borders.Color = Colors.Gainsboro;
            tbl.Borders.Width = 0.75;
            tbl.Rows.LeftIndent = 0;

            tbl.AddColumn(Unit.FromCentimeter(2.5)); // Orden
            tbl.AddColumn(Unit.FromCentimeter(8.5)); // Cliente
            tbl.AddColumn(Unit.FromCentimeter(3.5)); // Aplicado
            tbl.AddColumn(Unit.FromCentimeter(3.5)); // Saldo restante

            var th = tbl.AddRow();
            th.Shading.Color = Colors.WhiteSmoke;
            th.HeadingFormat = true;
            th.Format.Font.Bold = true;
            th.Cells[0].AddParagraph("Orden").Format.Alignment = ParagraphAlignment.Left;
            th.Cells[1].AddParagraph("Cliente");
            th.Cells[2].AddParagraph("Aplicado").Format.Alignment = ParagraphAlignment.Right;
            th.Cells[3].AddParagraph("Saldo restante").Format.Alignment = ParagraphAlignment.Right;

            if (detalle.Count == 0)
            {
                var r = tbl.AddRow();
                r.Cells[0].MergeRight = 3;
                r.Cells[0].AddParagraph("Sin distribución (no hay líneas de detalle).").Format.Alignment = ParagraphAlignment.Center;
            }
            else
            {
                foreach (var d in detalle)
                {
                    var r = tbl.AddRow();
                    r.Cells[0].AddParagraph(d.idOrden.ToString());
                    r.Cells[1].AddParagraph(d.cliente);
                    r.Cells[2].AddParagraph(RD(d.aplicado)).Format.Alignment = ParagraphAlignment.Right;
                    r.Cells[3].AddParagraph(RD(d.saldoRestante)).Format.Alignment = ParagraphAlignment.Right;
                }
            }

            // ===== Render y guardar =====
            var renderer = new PdfDocumentRenderer(true); // unicode
            renderer.Document = doc;
            renderer.RenderDocument();

            Directory.CreateDirectory(RECIBOS_FOLDER);
            string file = Path.Combine(RECIBOS_FOLDER, $"Recibo_Pago_{idPago}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");
            renderer.PdfDocument.Save(file);
            return file;
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
