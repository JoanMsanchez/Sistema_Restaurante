using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto_Restaurante.Proceso
{
    public partial class ProcesoRegistroMovimiento : Form
    {
        // ===== Campos =====
        private int afecta_stock_actual = 0;          // +1 = entrada, -1 = salida
        private DataTable dtLineas;                   // líneas del DGV

        // Productos (búsqueda en el mismo combo)
        private DataTable _dtProductos;
        private DataView _dvProductos;

        // ===== Conexión (ajusta si usas otro servidor/BD) =====
        private readonly SqlConnection conexion =
            new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");

        // (Opcional) barra de título personalizada
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public ProcesoRegistroMovimiento()
        {
            InitializeComponent();
            InicializarGrid();
        }

        // ==================== LOAD ====================
        private void ProcesoRegistroMovimiento_Load(object sender, EventArgs e)
        {
            CargarTiposMovimiento();
            CargarProductos();

            // Fecha solo display (la BD guardará GETDATE())
            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            fecha.Enabled = false;
            fecha.TabStop = false;

            // Estado (Activo=1 / Inactivo=0)
            activo.Checked = true;
            inactivo.Checked = false;

            comboTipoMovimiento.SelectedIndex = -1;
            comboProducto.SelectedIndex = -1;

            // Queremos escribir en el combo para filtrar
            comboProducto.DropDownStyle = ComboBoxStyle.DropDown;

            // ===== Eventos (desuscribe y vuelve a suscribir una sola vez) =====
            comboTipoMovimiento.SelectedIndexChanged -= comboTipoMovimiento_SelectedIndexChanged;
            comboTipoMovimiento.SelectedIndexChanged += comboTipoMovimiento_SelectedIndexChanged;

            comboProducto.TextUpdate -= comboProducto_TextUpdate;
            comboProducto.TextUpdate += comboProducto_TextUpdate;

            comboProducto.SelectionChangeCommitted -= comboProducto_SelectionChangeCommitted;
            comboProducto.SelectionChangeCommitted += comboProducto_SelectionChangeCommitted;

            comboProducto.MouseDoubleClick -= comboProducto_MouseDoubleClick;
            comboProducto.MouseDoubleClick += comboProducto_MouseDoubleClick;

            dgvLineas.CellContentClick -= dgvLineas_CellContentClick;
            dgvLineas.CellContentClick += dgvLineas_CellContentClick;

            dgvLineas.CellValidating -= dgvLineas_CellValidating;
            dgvLineas.CellValidating += dgvLineas_CellValidating;

            btnGuardar.Click -= btnGuardar_Click;
            btnGuardar.Click += btnGuardar_Click;

            btnLimpiar.Click -= btnLimpiar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        // ==================== CARGA COMBOS ====================
        private void CargarTiposMovimiento()
        {
            using (var da = new SqlDataAdapter(
                "SELECT id_tipo_mov, descripcion, afecta_stock FROM tipo_movimiento WHERE estado = 1 ORDER BY descripcion",
                conexion))
            {
                var dt = new DataTable();
                da.Fill(dt);
                comboTipoMovimiento.DataSource = dt;
                comboTipoMovimiento.DisplayMember = "descripcion";
                comboTipoMovimiento.ValueMember = "id_tipo_mov";
            }
        }

        private void CargarProductos()
        {
            using (var da = new SqlDataAdapter(
                "SELECT id_producto, nombre, stock_actual FROM producto WHERE estado = 1 ORDER BY nombre",
                conexion))
            {
                _dtProductos = new DataTable();
                da.Fill(_dtProductos);
                _dvProductos = new DataView(_dtProductos);

                comboProducto.DataSource = _dvProductos;
                comboProducto.DisplayMember = "nombre";
                comboProducto.ValueMember = "id_producto";
                comboProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void comboTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            afecta_stock_actual = 0;
            if (comboTipoMovimiento.SelectedIndex >= 0 && comboTipoMovimiento.SelectedItem is DataRowView row)
                afecta_stock_actual = Convert.ToInt32(row["afecta_stock"]); // +1 / -1
        }

        // ==================== GRID ====================
        private void InicializarGrid()
        {
            dtLineas = new DataTable();
            dtLineas.Columns.Add("No", typeof(int));
            dtLineas.Columns.Add("id_producto", typeof(int));
            dtLineas.Columns.Add("Nombre", typeof(string));
            dtLineas.Columns.Add("Stock", typeof(decimal));
            dtLineas.Columns.Add("Cantidad", typeof(decimal));

            dgvLineas.AutoGenerateColumns = false;
            dgvLineas.DataSource = dtLineas;
            dgvLineas.Columns.Clear();

            var colNo = new DataGridViewTextBoxColumn { Name = "No", DataPropertyName = "No", HeaderText = "#", Width = 40, ReadOnly = true };
            var colNombre = new DataGridViewTextBoxColumn { Name = "Nombre", DataPropertyName = "Nombre", HeaderText = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true };
            var colStock = new DataGridViewTextBoxColumn { Name = "Stock", DataPropertyName = "Stock", HeaderText = "Stock", Width = 90, ReadOnly = true, DefaultCellStyle = { Format = "N2" } };
            var colCant = new DataGridViewTextBoxColumn { Name = "Cantidad", DataPropertyName = "Cantidad", HeaderText = "Cantidad", Width = 90, ReadOnly = false, DefaultCellStyle = { Format = "N2" } };
            var colBtn = new DataGridViewButtonColumn { Name = "Quitar", HeaderText = "", Text = "Quitar", UseColumnTextForButtonValue = true, Width = 70 };

            dgvLineas.Columns.AddRange(colNo, colNombre, colStock, colCant, colBtn);
            dgvLineas.AllowUserToAddRows = false;
            dgvLineas.RowHeadersVisible = false;
            dgvLineas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLineas.MultiSelect = false;
            dgvLineas.ReadOnly = false; // Cantidad editable
        }

        private void RecalcularSecuenciaGrid()
        {
            // numera según el orden visible del grid
            for (int i = 0; i < dgvLineas.Rows.Count; i++)
                if (dgvLineas.Rows[i].DataBoundItem is DataRowView drv)
                    drv["No"] = i + 1;
        }

        // ==================== BÚSQUEDA EN COMBO ====================
        private void comboProducto_TextUpdate(object sender, EventArgs e)
        {
            if (_dvProductos == null) return;

            string texto = comboProducto.Text?.Trim() ?? string.Empty;
            _dvProductos.RowFilter = string.IsNullOrEmpty(texto)
                ? string.Empty
                : $"nombre LIKE '%{EscapeLike(texto)}%'";

            comboProducto.DroppedDown = true;
            comboProducto.SelectionStart = comboProducto.Text.Length;
            comboProducto.SelectionLength = 0;
        }

        private void comboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AgregarProductoSeleccionado();                         // agrega al DGV
            if (_dvProductos != null) _dvProductos.RowFilter = ""; // limpia filtro
            if (comboProducto.SelectedItem is DataRowView r)
                comboProducto.Text = r["nombre"].ToString();
        }

        private string EscapeLike(string value)
        {
            return value
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("_", "[_]")
                .Replace("]", "[]]")
                .Replace("*", "[*]");
        }

        // ==================== AGREGAR PRODUCTO ====================
        private void comboProducto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) AgregarProductoSeleccionado();
        }

        private void comboProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarProductoSeleccionado();
                e.SuppressKeyPress = true;
            }
        }

        private void AgregarProductoSeleccionado()
        {
            if (comboProducto.SelectedIndex < 0 || !(comboProducto.SelectedItem is DataRowView row)) return;

            int idProd = Convert.ToInt32(row["id_producto"]);
            string nombre = row["nombre"].ToString();
            decimal stock = Convert.ToDecimal(row["stock_actual"]);

            // Evitar duplicados por ID
            foreach (DataGridViewRow r in dgvLineas.Rows)
            {
                if (r.DataBoundItem is DataRowView drv && (int)drv["id_producto"] == idProd)
                {
                    dgvLineas.CurrentCell = r.Cells["Cantidad"];
                    dgvLineas.BeginEdit(true);
                    return;
                }
            }

            var nueva = dtLineas.NewRow();
            nueva["id_producto"] = idProd;
            nueva["Nombre"] = nombre;
            nueva["Stock"] = stock;
            nueva["Cantidad"] = 1m;
            dtLineas.Rows.Add(nueva);

            RecalcularSecuenciaGrid();

            int last = dgvLineas.Rows.Count - 1;
            if (last >= 0)
            {
                dgvLineas.CurrentCell = dgvLineas.Rows[last].Cells["Cantidad"];
                dgvLineas.BeginEdit(true);
            }
        }

        // ==================== QUITAR (robusto) ====================
        private void dgvLineas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            // índices válidos
            if (e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count) return;
            if (e.ColumnIndex < 0 || e.ColumnIndex >= grid.Columns.Count) return;

            // ¿Es el botón Quitar?
            bool esBotonQuitar =
                grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn ||
                grid.Columns[e.ColumnIndex].Name == "Quitar";

            if (!esBotonQuitar) return;

            // Fila enlazada
            if (grid.Rows[e.RowIndex].DataBoundItem is not DataRowView drv) return;

            // Eliminar del DataTable origen (¡no por índice!)
            DataRow dataRow = drv.Row;
            if (dataRow != null && dataRow.Table != null && dataRow.RowState != DataRowState.Detached)
                dataRow.Delete();   // marca como eliminada

            // Renumerar cuando el grid termine de refrescarse (evita reentradas e índices viejos)
            BeginInvoke(new Action(RecalcularSecuenciaGrid));
        }

        // ==================== VALIDACIÓN DE CANTIDAD ====================
        private void dgvLineas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvLineas.Columns[e.ColumnIndex].Name != "Cantidad" || e.RowIndex < 0) return;

            if (!decimal.TryParse(Convert.ToString(e.FormattedValue), out var cant) || cant <= 0)
            { e.Cancel = true; dgvLineas.Rows[e.RowIndex].ErrorText = "Cantidad inválida."; return; }

            if (afecta_stock_actual == -1) // salida
            {
                var stock = Convert.ToDecimal(dgvLineas.Rows[e.RowIndex].Cells["Stock"].Value);
                if (cant > stock)
                { e.Cancel = true; dgvLineas.Rows[e.RowIndex].ErrorText = "La cantidad excede el stock disponible."; return; }
            }

            dgvLineas.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        // ==================== GUARDAR ====================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboTipoMovimiento.SelectedIndex < 0) { MessageBox.Show("Seleccione un tipo de movimiento."); return; }
            if (dgvLineas.Rows.Count == 0) { MessageBox.Show("Agregue al menos un producto."); return; }
            if (!activo.Checked && !inactivo.Checked) { MessageBox.Show("Seleccione el estado."); return; }

            int idTipoMov = Convert.ToInt32(((DataRowView)comboTipoMovimiento.SelectedItem)["id_tipo_mov"]);
            bool estadoBit = activo.Checked; // Activo=1(true), Inactivo=0(false)
            string obs = string.IsNullOrWhiteSpace(observaciones.Text) ? null : observaciones.Text.Trim();

            try
            {
                conexion.Open();

                int totalInsertados = 0;
                int totalActualizados = 0;

                using (var tx = conexion.BeginTransaction())
                {
                    // 1) Revalidar afecta_stock
                    int afectaBD;
                    using (var cmd = new SqlCommand(
                        "SELECT afecta_stock FROM tipo_movimiento WHERE id_tipo_mov=@id AND estado=1", conexion, tx))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = idTipoMov;
                        var o = cmd.ExecuteScalar();
                        if (o == null) throw new InvalidOperationException("Tipo de movimiento inválido o inactivo.");
                        afectaBD = Convert.ToInt32(o);
                    }

                    // 2) Recorrer líneas visibles del grid
                    foreach (DataGridViewRow gr in dgvLineas.Rows)
                    {
                        if (gr.DataBoundItem is not DataRowView drv) continue;

                        int idProd = (int)drv["id_producto"];
                        decimal cantidad = Convert.ToDecimal(drv["Cantidad"]);

                        // Revalidar stock en servidor si es salida
                        if (afectaBD == -1)
                        {
                            decimal stockBD;
                            using (var cmdS = new SqlCommand(
                                "SELECT stock_actual FROM producto WHERE id_producto=@p", conexion, tx))
                            {
                                cmdS.Parameters.Add("@p", SqlDbType.Int).Value = idProd;
                                var o = cmdS.ExecuteScalar();
                                if (o == null) throw new InvalidOperationException("Producto inexistente.");
                                stockBD = Convert.ToDecimal(o);
                            }
                            if (stockBD < cantidad)
                                throw new InvalidOperationException($"Stock insuficiente para el producto ID {idProd}.");
                        }

                        // 3) INSERT movimiento (fecha = GETDATE(); id_proveedor = NULL)
                        using (var cmdIns = new SqlCommand(@"
                            INSERT INTO movimiento_inventario
                                (id_producto, id_tipo_mov, cantidad, fecha, id_proveedor, observaciones, estado)
                            VALUES
                                (@id_producto, @id_tipo_mov, @cantidad, GETDATE(), NULL, @observaciones, @estado);",
                            conexion, tx))
                        {
                            cmdIns.Parameters.Add("@id_producto", SqlDbType.Int).Value = idProd;
                            cmdIns.Parameters.Add("@id_tipo_mov", SqlDbType.Int).Value = idTipoMov;

                            var pCant = cmdIns.Parameters.Add("@cantidad", SqlDbType.Decimal);
                            pCant.Precision = 10; pCant.Scale = 2; pCant.Value = cantidad;

                            if (obs == null)
                                cmdIns.Parameters.AddWithValue("@observaciones", DBNull.Value);
                            else
                                cmdIns.Parameters.Add("@observaciones", SqlDbType.VarChar, -1).Value = obs;

                            cmdIns.Parameters.Add("@estado", SqlDbType.Bit).Value = estadoBit;

                            int rowsIns = cmdIns.ExecuteNonQuery();
                            if (rowsIns != 1)
                                throw new InvalidOperationException("No se insertó el movimiento.");
                            totalInsertados += rowsIns;
                        }

                        // 4) UPDATE stock
                        using (var cmdUpd = new SqlCommand(@"
                            UPDATE producto
                            SET stock_actual = stock_actual + (@cantidad * @afecta)
                            WHERE id_producto = @id_producto;", conexion, tx))
                        {
                            var pCant2 = cmdUpd.Parameters.Add("@cantidad", SqlDbType.Decimal);
                            pCant2.Precision = 10; pCant2.Scale = 2; pCant2.Value = cantidad;

                            cmdUpd.Parameters.Add("@afecta", SqlDbType.Int).Value = afectaBD;
                            cmdUpd.Parameters.Add("@id_producto", SqlDbType.Int).Value = idProd;

                            int rowsUpd = cmdUpd.ExecuteNonQuery();
                            if (rowsUpd != 1)
                                throw new InvalidOperationException("No se actualizó el stock del producto.");
                            totalActualizados += rowsUpd;
                        }
                    }

                    tx.Commit();
                }

                // Si por algún motivo no se afectó nada, avisa
                if (totalInsertados <= 0 || totalActualizados <= 0)
                {
                    MessageBox.Show(
                        $"No se afectaron filas. Revise la BD/tabla/condiciones.\nBD conectada: {conexion.Database}",
                        "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    $"OK. Movimientos insertados: {totalInsertados}. Productos actualizados: {totalActualizados}.\nBD: {conexion.Database}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        // ==================== LIMPIAR ====================
        private void btnLimpiar_Click(object sender, EventArgs e) => Limpiar();

        private void Limpiar()
        {
            observaciones.Clear();
            activo.Checked = true; inactivo.Checked = false;
            comboTipoMovimiento.SelectedIndex = -1;

            if (_dvProductos != null) _dvProductos.RowFilter = string.Empty;
            comboProducto.SelectedIndex = -1;
            comboProducto.Text = string.Empty;

            dtLineas.Rows.Clear();
            RecalcularSecuenciaGrid();

            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        // (Opcional) si tienes barra de título personalizada
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}








//comboProducto_MouseDoubleClick
//private void panelMovimiento_MouseDown(object sender, MouseEventArgs e)
//{
//    ReleaseCapture();
//    SendMessage(this.Handle, 0x112, 0xf012, 0);
//}

//private void btnMinimizar_Click(object sender, EventArgs e)
//{
//    this.WindowState = FormWindowState.Minimized;
//}

//private void btnMaximizar_Click(object sender, EventArgs e)
//{
//    if (this.WindowState == FormWindowState.Normal)
//        this.WindowState = FormWindowState.Maximized;
//    else
//        this.WindowState = FormWindowState.Normal;
//}

//private void btnCerrar_Click(object sender, EventArgs e)
//{
//    this.Close();
//}