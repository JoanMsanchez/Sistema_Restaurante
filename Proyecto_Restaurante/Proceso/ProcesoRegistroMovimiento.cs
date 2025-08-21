using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Proyecto_Restaurante.Consulta;

namespace Proyecto_Restaurante.Proceso
{
    public partial class ProcesoRegistroMovimiento : Form
    {
        // ===== Conexión =====
        //SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        // ===== Tablas =====
        private readonly DataTable dtLineas = new DataTable();   // datasource del GridMovimiento
        private readonly DataTable dtProveedores = new DataTable(); // catálogo proveedores
    
        public ProcesoRegistroMovimiento()
        {
            InitializeComponent();
            this.Padding = new Padding(bordeSize);
            this.BackColor = Color.FromArgb(255, 161, 43);
            // NO suscribo Load aquí; usa el del Designer si ya lo tienes.
        }

        //Fields
        private int bordeSize = 2;


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

        // ==================== LOAD ====================
        private void ProcesoRegistroMovimiento_Load(object sender, EventArgs e)
        {
            // Nada de crear columnas aquí.
            CargarProveedores();
            CargarTiposMovimiento();

            // Defaults visibles
            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            activo.Checked = true; inactivo.Checked = false;
            comboTipoMovimiento.SelectedIndex = -1;
            comboProveedor.SelectedIndex = -1;

            // Enlaces de eventos ligeros
            buscar.TextChanged += buscar_TextChanged;
            listSugerencia.MouseDoubleClick += (s, ev) => SeleccionarSugerencia();

            dgvProductoselect.CellContentClick += GridMovimiento_CellContentClick;           // Quitar
            dgvProductoselect.EditingControlShowing += GridMovimiento_EditingControlShowing; // solo decimales en Cantidad
            dgvProductoselect.DataError += (s, ev) => ev.ThrowException = false;

            //comboProveedor.SelectedIndexChanged += comboProveedor_SelectedIndexChanged;

            //btnGuardar.Click += btnGuardar_Click;
            //btnLimpiar.Click += (s, ev) => Limpiar();

            // Primera pintura (vacía pero con estructura/headers como a ti te gusta)
            Llenar_GridMovimiento();
        }

        // ==================== TU ESTILO: llenar grid ====================
        private void Llenar_GridMovimiento()
        {
            // 1) Estructura del DataTable (crear solo si falta)
            if (!dtLineas.Columns.Contains("No")) dtLineas.Columns.Add("No", typeof(int));
            if (!dtLineas.Columns.Contains("id_producto")) dtLineas.Columns.Add("id_producto", typeof(int));
            if (!dtLineas.Columns.Contains("nombre")) dtLineas.Columns.Add("nombre", typeof(string));
            if (!dtLineas.Columns.Contains("stock_actual")) dtLineas.Columns.Add("stock_actual", typeof(decimal));
            if (!dtLineas.Columns.Contains("id_proveedor")) dtLineas.Columns.Add("id_proveedor", typeof(int));
            if (!dtLineas.Columns.Contains("proveedor")) dtLineas.Columns.Add("proveedor", typeof(string));
            if (!dtLineas.Columns.Contains("cantidad")) dtLineas.Columns.Add("cantidad", typeof(decimal));

            // 2) Recalcular secuencia "No"
            for (int i = 0; i < dtLineas.Rows.Count; i++)
                dtLineas.Rows[i]["No"] = i + 1;

            // 3) Bind al DGV existente
            dgvProductoselect.AutoGenerateColumns = false;
            dgvProductoselect.DataSource = dtLineas;

            // 4) Agregar columnas del DGV SOLO si faltan 
            if (!dgvProductoselect.Columns.Contains("No"))
                dgvProductoselect.Columns.Add(new DataGridViewTextBoxColumn { Name = "No", DataPropertyName = "No", Width = 40, ReadOnly = true });
            if (!dgvProductoselect.Columns.Contains("id_producto"))
                dgvProductoselect.Columns.Add(new DataGridViewTextBoxColumn { Name = "id_producto", DataPropertyName = "id_producto", Visible = false });
            if (!dgvProductoselect.Columns.Contains("nombre"))
                dgvProductoselect.Columns.Add(new DataGridViewTextBoxColumn { Name = "nombre", DataPropertyName = "nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
            if (!dgvProductoselect.Columns.Contains("stock_actual"))
                dgvProductoselect.Columns.Add(new DataGridViewTextBoxColumn { Name = "stock_actual", DataPropertyName = "stock_actual", Width = 110, ReadOnly = true, DefaultCellStyle = { Format = "N2" } });
            if (!dgvProductoselect.Columns.Contains("id_proveedor"))
                dgvProductoselect.Columns.Add(new DataGridViewTextBoxColumn { Name = "id_proveedor", DataPropertyName = "id_proveedor", Visible = false });
            if (!dgvProductoselect.Columns.Contains("proveedor"))
                dgvProductoselect.Columns.Add(new DataGridViewTextBoxColumn { Name = "proveedor", DataPropertyName = "proveedor", Width = 180, ReadOnly = true });
            if (!dgvProductoselect.Columns.Contains("cantidad"))
                dgvProductoselect.Columns.Add(new DataGridViewTextBoxColumn { Name = "cantidad", DataPropertyName = "cantidad", Width = 90, DefaultCellStyle = { Format = "N2" } });
            if (!dgvProductoselect.Columns.Contains("Quitar"))
                dgvProductoselect.Columns.Add(new DataGridViewButtonColumn { Name = "Quitar", HeaderText = "", Text = "X", UseColumnTextForButtonValue = true, Width = 70 });

            // 5) Ocultar IDs y nombrar headers (igual que tu llenar_tabla_datagridview)
            if (dgvProductoselect.Columns.Contains("id_producto")) dgvProductoselect.Columns["id_producto"].Visible = false;
            if (dgvProductoselect.Columns.Contains("id_proveedor")) dgvProductoselect.Columns["id_proveedor"].Visible = false;

            dgvProductoselect.Columns["No"].HeaderText = "#";
            dgvProductoselect.Columns["nombre"].HeaderText = "Nombre";
            dgvProductoselect.Columns["stock_actual"].HeaderText = "Stock Actual";
            dgvProductoselect.Columns["proveedor"].HeaderText = "Proveedor";
            dgvProductoselect.Columns["cantidad"].HeaderText = "Cantidad";
        }

        // ==================== CATÁLOGOS ====================
        private void CargarProveedores()
        {
            try
            {
                using var da = new SqlDataAdapter(
                    "SELECT id_proveedor, nombre FROM proveedor WHERE estado=1 ORDER BY nombre", conexion);
                dtProveedores.Clear();
                da.Fill(dtProveedores);

                comboProveedor.DataSource = dtProveedores;
                comboProveedor.DisplayMember = "nombre";
                comboProveedor.ValueMember = "id_proveedor";
                comboProveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void CargarTiposMovimiento()
        {
            try
            {
                using var da = new SqlDataAdapter(
                    "SELECT id_tipo_mov, descripcion, afecta_stock FROM tipo_movimiento WHERE estado=1 ORDER BY descripcion",
                    conexion);
                var dt = new DataTable();
                da.Fill(dt);
                comboTipoMovimiento.DataSource = dt;
                comboTipoMovimiento.DisplayMember = "descripcion";
                comboTipoMovimiento.ValueMember = "id_tipo_mov";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de movimiento: " + ex.Message);
            }
        }

        // ==================== BUSCAR / AGREGAR ====================
        private void buscar_TextChanged(object sender, EventArgs e)
        {
            string q = buscar.Text.Trim();
            if (string.IsNullOrWhiteSpace(q)) { listSugerencia.Visible = false; return; }

            try
            {
                using var da = new SqlDataAdapter(
                    "SELECT TOP 20 p.id_producto, p.nombre, p.stock_actual, po.id_proveedor, po.nombre AS proveedor " +
                    "FROM producto p INNER JOIN proveedor po ON p.id_proveedor = po.id_proveedor " +
                    "WHERE p.estado=1 AND p.nombre LIKE @q ORDER BY p.nombre", conexion);
                da.SelectCommand.Parameters.AddWithValue("@q", "%" + q + "%");
                var dt = new DataTable();
                da.Fill(dt);

                listSugerencia.DisplayMember = "nombre";
                listSugerencia.ValueMember = "id_producto";
                listSugerencia.DataSource = dt;
                listSugerencia.Visible = dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message);
            }
        }

        private void listSugerencia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SeleccionarSugerencia();
        }
        private void SeleccionarSugerencia()
        {
            if (listSugerencia.SelectedItem is not DataRowView r) return;

            int idProd = Convert.ToInt32(r["id_producto"]);
            string nombre = r["nombre"].ToString();
            decimal stock = Convert.ToDecimal(r["stock_actual"]);
            int idProv = Convert.ToInt32(r["id_proveedor"]);
            string nomProv = r["proveedor"].ToString();

            AgregarProductoAlGrid(idProd, nombre, stock, idProv, nomProv);

            buscar.Clear();
            listSugerencia.Visible = false;
        }

        private void btnConsultaProducto_Click(object sender, EventArgs e)
        {
            using (var frm = new ConsultaProductos())
            {
                // IMPORTANTE: modal, así se cierra solo al elegir (DialogResult.OK)
                if (frm.ShowDialog(this) != DialogResult.OK) return;

                int idProd = frm.SelectedId;
                string nombre = frm.SelectedNombre;
                decimal stock = frm.SelectedStock;
                int idProv = frm.SelectedProveedorId;        // viene del grid de ConsultaProductos
                string nomProv = frm.SelectedProveedorNombre;    // viene del grid de ConsultaProductos

                // por si viniera nulo (no debería): normaliza
                if (idProv <= 0) { idProv = -1; nomProv = ""; }

                // agrega al grid con proveedor ya resuelto, SIN mensajes
                AgregarProductoAlGrid(idProd, nombre, stock, idProv, nomProv);
                EnfocarCantidadDe(idProd);  // cae en la celda Cantidad para editar

            }

        }

        private void AgregarProductoAlGrid(int idProd, string nombre, decimal stock, int idProv, string nomProv)
        {
            foreach (DataRow row in dtLineas.Rows)
            {
                if (row.RowState != DataRowState.Deleted && (int)row["id_producto"] == idProd)
                {
                    // Enfocar cantidad de la fila existente
                    foreach (DataGridViewRow gr in dgvProductoselect.Rows)
                    {
                        if (gr.DataBoundItem is DataRowView drv && (int)drv["id_producto"] == idProd)
                        {
                            dgvProductoselect.CurrentCell = gr.Cells["cantidad"];
                            dgvProductoselect.BeginEdit(true);
                            break;
                        }
                    }
                    // Oculta la lista y limpia búsqueda
                    listSugerencia.Visible = false;
                    buscar.Clear();
                    return;
                }
            }
            var nueva = dtLineas.NewRow();
            nueva["id_producto"] = idProd;
            nueva["nombre"] = nombre;
            nueva["stock_actual"] = stock;
            nueva["id_proveedor"] = idProv;
            nueva["proveedor"] = nomProv;   // lo que se ve
            nueva["cantidad"] = 1m;        // editable
            dtLineas.Rows.Add(nueva);

            Llenar_GridMovimiento();           // AQUÍ es donde se “arma” y se pinta el grid (tu estilo)
            EnfocarCantidadDe(idProd);
        }

        private void EnfocarCantidadDe(int idProd)
        {
            foreach (DataGridViewRow gr in dgvProductoselect.Rows)
                if (gr.DataBoundItem is DataRowView drv && (int)drv["id_producto"] == idProd)
                { dgvProductoselect.CurrentCell = gr.Cells["cantidad"]; dgvProductoselect.BeginEdit(true); break; }
        }

        // ==================== QUITAR / VALIDAR ====================
        private void GridMovimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProductoselect.Columns[e.ColumnIndex].Name != "Quitar") return;
            if (dgvProductoselect.Rows[e.RowIndex].DataBoundItem is DataRowView drv)
            {
                drv.Row.Delete();
                Llenar_GridMovimiento(); // recalcula No y mantiene headers
            }
        }

        private void GridMovimiento_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvProductoselect.CurrentCell?.OwningColumn?.Name != "cantidad") return;
            if (e.Control is TextBox tb)
            {
                tb.KeyPress -= SoloDecimal_KeyPress;
                tb.KeyPress += SoloDecimal_KeyPress;
            }
        }
        private void SoloDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            var tb = (TextBox)sender;
            bool yaPunto = tb.Text.Contains(".");
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && (yaPunto || tb.SelectionStart == 0)) e.Handled = true;
        }


        // ==================== GUARDAR ===================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboTipoMovimiento.SelectedIndex < 0) { MessageBox.Show("Seleccione el tipo de movimiento."); return; }
            if (dtLineas.Rows.Count == 0) { MessageBox.Show("Agregue productos."); return; }
            if (!activo.Checked && !inactivo.Checked) { MessageBox.Show("Seleccione el estado."); return; }

            int idTipoMov = Convert.ToInt32(((DataRowView)comboTipoMovimiento.SelectedItem)["id_tipo_mov"]);
            bool estadoBit = activo.Checked;
            string obs = string.IsNullOrWhiteSpace(observaciones.Text) ? null : observaciones.Text.Trim();

            // Proveedor GLOBAL (como Observación): si está seleccionado (>0), se aplica a todas las filas
            int? provGlobal = null;
            if (comboProveedor.SelectedValue != null &&
                int.TryParse(comboProveedor.SelectedValue.ToString(), out int pg) && pg > 0)
            {
                provGlobal = pg;
            }

            try
            {
                conexion.Open();
                using var tx = conexion.BeginTransaction();

                // Revalidar afecta_stock
                int afecta = Convert.ToInt32(new SqlCommand(
                    "SELECT afecta_stock FROM tipo_movimiento WHERE id_tipo_mov=@id AND estado=1",
                    conexion, tx)
                { Parameters = { new SqlParameter("@id", idTipoMov) } }.ExecuteScalar());

                foreach (DataRow row in dtLineas.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    int idProd = (int)row["id_producto"];
                    string nom = row["nombre"].ToString();

                    if (!decimal.TryParse(row["cantidad"]?.ToString(), out decimal cant) || cant <= 0)
                        throw new Exception($"Cantidad inválida para {nom}.");

                    if (!decimal.TryParse(row["stock_actual"]?.ToString(), out decimal stock))
                        stock = 0m;

                    if (afecta == -1 && cant > stock)
                        throw new Exception($"La salida excede el stock de {nom}.");

                    // === Resolver proveedor FINAL de la fila ===
                    int idProvFila = 0;
                    if (dtLineas.Columns.Contains("id_proveedor") && row["id_proveedor"] != DBNull.Value)
                    {
                        int.TryParse(row["id_proveedor"].ToString(), out idProvFila);
                    }
                    // Fallback: si no hay id_proveedor pero sí nombre, buscar ID por nombre (una sola consulta por fila)
                    if (idProvFila <= 0 && dtLineas.Columns.Contains("proveedor"))
                    {
                        string nomProvFila = Convert.ToString(row["proveedor"]);
                        if (!string.IsNullOrWhiteSpace(nomProvFila))
                        {
                            using var cmdProv = new SqlCommand(
                                "SELECT TOP 1 id_proveedor FROM proveedor WHERE estado=1 AND nombre=@n",
                                conexion, tx);
                            cmdProv.Parameters.Add("@n", SqlDbType.VarChar, 200).Value = nomProvFila;
                            var oProv = cmdProv.ExecuteScalar();
                            if (oProv != null && oProv != DBNull.Value) idProvFila = Convert.ToInt32(oProv);
                        }
                    }

                    // Si hay proveedor global (>0), aplica a TODAS las filas; si no, usa el de la fila (puede quedar null)
                    int? provFinal = provGlobal.HasValue ? provGlobal
                                      : (idProvFila > 0 ? idProvFila : (int?)null);

                    // 1) INSERT movimiento_inventario
                    using (var cmd = new SqlCommand(@"
                        INSERT INTO movimiento_inventario
                            (id_producto, id_tipo_mov, cantidad, fecha, id_proveedor, observaciones, estado)
                        VALUES
                            (@p, @t, @c, GETDATE(), @prov, @obs, @est);", conexion, tx))
                    {
                        cmd.Parameters.Add("@p", SqlDbType.Int).Value = idProd;
                        cmd.Parameters.Add("@t", SqlDbType.Int).Value = idTipoMov;

                        var pC = cmd.Parameters.Add("@c", SqlDbType.Decimal);
                        pC.Precision = 10; pC.Scale = 2; pC.Value = cant;

                        if (provFinal.HasValue) cmd.Parameters.Add("@prov", SqlDbType.Int).Value = provFinal.Value;
                        else cmd.Parameters.AddWithValue("@prov", DBNull.Value);

                        if (obs == null) cmd.Parameters.AddWithValue("@obs", DBNull.Value);
                        else cmd.Parameters.Add("@obs", SqlDbType.VarChar, -1).Value = obs;

                        cmd.Parameters.Add("@est", SqlDbType.Bit).Value = estadoBit;
                        cmd.ExecuteNonQuery();
                    }

                    // 2) UPDATE stock si aplica
                    if (afecta != 0)
                    {
                        using var up = new SqlCommand(
                            "UPDATE producto SET stock_actual = stock_actual + (@c * @a) WHERE id_producto=@p",
                            conexion, tx);
                        up.Parameters.Add("@c", SqlDbType.Decimal).Value = cant;
                        up.Parameters.Add("@a", SqlDbType.Int).Value = afecta;
                        up.Parameters.Add("@p", SqlDbType.Int).Value = idProd;
                        up.ExecuteNonQuery();
                    }

                    // 3) UPDATE del proveedor del producto (para que en Mantenimiento/Consulta salga el nuevo)
                    if (provFinal.HasValue)
                    {
                        using var upProv = new SqlCommand(
                            "UPDATE producto SET id_proveedor = @prov WHERE id_producto = @p;",
                            conexion, tx);
                        upProv.Parameters.Add("@prov", SqlDbType.Int).Value = provFinal.Value;
                        upProv.Parameters.Add("@p", SqlDbType.Int).Value = idProd;
                        upProv.ExecuteNonQuery();
                    }
                }

                tx.Commit();
                MessageBox.Show("Movimiento registrado correctamente y proveedores actualizados.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia como ya lo tienes
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        // ==================== LIMPIAR ====================
        private void Limpiar()
        {
            dtLineas.Clear();          // NO borra columnas ni rompe esquema
            Llenar_GridMovimiento();   // repinta headers y oculta IDs

            buscar.Clear();
            listSugerencia.Visible = false;
            observaciones.Clear();

            comboTipoMovimiento.SelectedIndex = -1;
            comboProveedor.SelectedIndex = -1;

            activo.Checked = true; inactivo.Checked = false;
            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ProcesoRegistroMovimiento_Shown(object sender, EventArgs e)
        {
            buscar.Focus();
        }
    }
}
