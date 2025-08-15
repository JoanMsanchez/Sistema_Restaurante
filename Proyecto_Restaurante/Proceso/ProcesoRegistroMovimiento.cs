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
        /*// ===== Campos =====
         private int afecta_stock_actual = 0;          // +1 = entrada, -1 = salida
         private DataTable dtLineas;                   // líneas del DGV

         // Productos (búsqueda en el mismo combo)
         private DataTable _dtProductos;
         private DataView _dvProductos;

         // ===== Conexión (ajusta si usas otro servidor/BD) =====
         private readonly SqlConnection conexion =
             // new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
             new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

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
             CargarProveedores();

             //CargarProductos();

             // Fecha solo display (la BD guardará GETDATE())
             fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
             //fecha.Enabled = false;
             fecha.TabStop = false;

             // Estado (Activo=1 / Inactivo=0)
             activo.Checked = true;
             inactivo.Checked = false;

             comboTipoMovimiento.SelectedIndex = -1;

             // ===== Eventos (desuscribe y vuelve a suscribir una sola vez) =====
             comboTipoMovimiento.SelectedIndexChanged -= comboTipoMovimiento_SelectedIndexChanged;
             comboTipoMovimiento.SelectedIndexChanged += comboTipoMovimiento_SelectedIndexChanged;

             dgvProductoselect.CellContentClick -= dgvLineas_CellContentClick;
             dgvProductoselect.CellContentClick += dgvLineas_CellContentClick;

             dgvProductoselect.CellValidating -= dgvLineas_CellValidating;
             dgvProductoselect.CellValidating += dgvLineas_CellValidating;

             btnGuardar.Click -= btnGuardar_Click;
             btnGuardar.Click += btnGuardar_Click;

             btnLimpiar.Click -= btnLimpiar_Click;
             btnLimpiar.Click += btnLimpiar_Click;
         }



         private void InsertarLinea(int idProd, string nombre, decimal stock)
         {
             // ¿Ya está en el grid?
             foreach (DataGridViewRow r in dgvProductoselect.Rows)
             {
                 if (r.DataBoundItem is DataRowView drv && (int)drv["id_producto"] == idProd)
                 {
                     dgvProductoselect.CurrentCell = r.Cells["Cantidad"];
                     dgvProductoselect.BeginEdit(true);
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

             // Enfocar cantidad de la última fila
             int last = dgvProductoselect.Rows.Count - 1;
             if (last >= 0)
             {
                 dgvProductoselect.CurrentCell = dgvProductoselect.Rows[last].Cells["Cantidad"];
                 dgvProductoselect.BeginEdit(true);
             }
         }

         private void btnConsultaProducto_Click(object sender, EventArgs e)
         {
             using (var consulta = new Proyecto_Restaurante.Consulta.ConsultaProductos())
             {
                 if (consulta.ShowDialog(this) == DialogResult.OK)
                 {
                     // Viene del mismo form de consulta que ya usas
                     InsertarLinea(consulta.SelectedId, consulta.SelectedNombre, consulta.SelectedStock);
                 }
             }
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

             dgvProductoselect.AutoGenerateColumns = false;
             dgvProductoselect.DataSource = dtLineas;
             dgvProductoselect.Columns.Clear();

             var colNo = new DataGridViewTextBoxColumn { Name = "No", DataPropertyName = "No", HeaderText = "#", Width = 40, ReadOnly = true };
             var colNombre = new DataGridViewTextBoxColumn { Name = "Nombre", DataPropertyName = "Nombre", HeaderText = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true };
             var colStock = new DataGridViewTextBoxColumn { Name = "Stock", DataPropertyName = "Stock", HeaderText = "Stock", Width = 90, ReadOnly = true, DefaultCellStyle = { Format = "N2" } };
             var colCant = new DataGridViewTextBoxColumn { Name = "Cantidad", DataPropertyName = "Cantidad", HeaderText = "Cantidad", Width = 90, ReadOnly = false, DefaultCellStyle = { Format = "N2" } };
             var colBtn = new DataGridViewButtonColumn { Name = "Quitar", HeaderText = "", Text = "Quitar", UseColumnTextForButtonValue = true, Width = 70 };

             dgvProductoselect.Columns.AddRange(colNo, colNombre, colStock, colCant, colBtn);
             dgvProductoselect.AllowUserToAddRows = false;
             dgvProductoselect.RowHeadersVisible = false;
             dgvProductoselect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             dgvProductoselect.MultiSelect = false;
             dgvProductoselect.ReadOnly = false; // Cantidad editable
         }

         private void RecalcularSecuenciaGrid()
         {
             // numera según el orden visible del grid
             for (int i = 0; i < dgvProductoselect.Rows.Count; i++)
                 if (dgvProductoselect.Rows[i].DataBoundItem is DataRowView drv)
                     drv["No"] = i + 1;
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
             if (dgvProductoselect.Columns[e.ColumnIndex].Name != "Cantidad" || e.RowIndex < 0) return;

             if (!decimal.TryParse(Convert.ToString(e.FormattedValue), out var cant) || cant <= 0)
             { e.Cancel = true; dgvProductoselect.Rows[e.RowIndex].ErrorText = "Cantidad inválida."; return; }

             if (afecta_stock_actual == -1) // salida
             {
                 var stock = Convert.ToDecimal(dgvProductoselect.Rows[e.RowIndex].Cells["Stock"].Value);
                 if (cant > stock)
                 { e.Cancel = true; dgvProductoselect.Rows[e.RowIndex].ErrorText = "La cantidad excede el stock disponible."; return; }
             }

             dgvProductoselect.Rows[e.RowIndex].ErrorText = string.Empty;
         }

         // ==================== GUARDAR ====================
         private void btnGuardar_Click(object sender, EventArgs e)
         {
             if (comboTipoMovimiento.SelectedIndex < 0) { MessageBox.Show("Seleccione un tipo de movimiento."); return; }
             if (dgvProductoselect.Rows.Count == 0) { MessageBox.Show("Agregue al menos un producto."); return; }
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
                     foreach (DataGridViewRow gr in dgvProductoselect.Rows)
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
         private void btnLimpiar_Click(object sender, EventArgs e)
         {
             Limpiar();
         }

         private void Limpiar()
         {
             observaciones.Clear();
             activo.Checked = true; inactivo.Checked = false;
             comboTipoMovimiento.SelectedIndex = -1;

             if (_dvProductos != null) _dvProductos.RowFilter = string.Empty;

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


         private CancellationTokenSource _cts; // para debounce

         private void buscar_TextChanged(object sender, EventArgs e)
         {
             string query = buscar.Text.Trim();
             BuscarSugerencias(buscar.Text);
             BuscarSugerencias(query);              // TOP 20
         }


         private void BuscarSugerencias(string q)
         {
             if (string.IsNullOrWhiteSpace(q)) { listSugerencia.Visible = false; return; }

             using (var da = new SqlDataAdapter(
                 "SELECT TOP 20 id_producto, nombre, stock_actual, p.id_proveedor " +
                 "FROM producto WHERE estado=1 AND nombre LIKE @q ORDER BY nombre", conexion))
             {
                 da.SelectCommand.Parameters.AddWithValue("@q", "%" + q + "%");

                 var dt = new DataTable();
                 da.Fill(dt);

                 listSugerencia.DisplayMember = "nombre";
                 listSugerencia.ValueMember = "id_producto";
                 listSugerencia.DataSource = dt;
                 listSugerencia.Visible = dt.Rows.Count > 0;
             }
         }
         private void SeleccionarSugerencia()
         {
             if (!listSugerencia.Visible || listSugerencia.SelectedItem is not DataRowView r) return;

             int idProd = Convert.ToInt32(r["id_producto"]);
             string nombre = r["nombre"].ToString();
             decimal stock = Convert.ToDecimal(r["stock_actual"]);

             InsertarLinea(idProd, nombre, stock);

             buscar.Clear();
             listSugerencia.Visible = false;
             buscar.Focus();
         }

         private void listSugerencia_MouseDoubleClick(object sender, MouseEventArgs e)
         {
             SeleccionarSugerencia();
         }

         private void CargarProveedores()
         {
             try
             {
                 using (var da = new SqlDataAdapter(
                     "SELECT id_proveedor, nombre FROM proveedor WHERE estado = 1 ORDER BY nombre",
                     conexion))
                 {
                     var dt = new DataTable();
                     da.Fill(dt);
                     comboProveedor.DataSource = dt;
                     comboProveedor.DisplayMember = "nombre";
                     comboProveedor.ValueMember = "id_proveedor";
                     comboProveedor.SelectedIndex = -1;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al cargar proveedores: " + ex.Message);
             }
         }*/


        // ===== Conexión =====
        //SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        // ===== Tablas =====
        private readonly DataTable dtLineas = new DataTable();   // datasource del GridMovimiento
        private readonly DataTable dtProveedores = new DataTable(); // catálogo proveedores

        // ===== Drag opcional =====
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")] private static extern void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")] private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitulo_MouseDown(object s, MouseEventArgs e) { ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0); }

        public ProcesoRegistroMovimiento()
        {
            InitializeComponent();
            // NO suscribo Load aquí; usa el del Designer si ya lo tienes.
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

            btnGuardar.Click += btnGuardar_Click;
            btnLimpiar.Click += (s, ev) => Limpiar();

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
                dgvProductoselect.Columns.Add(new DataGridViewButtonColumn { Name = "Quitar", HeaderText = "", Text = "Quitar", UseColumnTextForButtonValue = true, Width = 70 });

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

        // ==================== GUARDAR ====================
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