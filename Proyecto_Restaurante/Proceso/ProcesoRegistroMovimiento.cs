using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Restaurante.Consulta;
using Proyecto_Restaurante.Mantenimiento;
using Proyecto_Restaurante.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace Proyecto_Restaurante.Proceso
{
    public partial class ProcesoRegistroMovimiento : Form
    {

        private int id_producto_seleccionado = -1;

        private int afecta_stock_actual = 0;

        private decimal stock_actual_2 = 0m;     // para validar salidas sin reconsultar

        public ProcesoRegistroMovimiento()
        {
            InitializeComponent();
        }


        private void ProcesoRegistroMovimiento_Load(object sender, EventArgs e)
        {
            CargarTiposMovimiento();
            CargarProveedores();
            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            afecta_stock_actual = 0;
        }

        //SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");



        // ====== Cargar combos ======
        private void CargarTiposMovimiento()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT id_tipo_mov, descripcion, afecta_stock FROM tipo_movimiento WHERE estado = 1 ORDER BY descripcion", conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Trae también afecta_stock para poder reaccionar al SelectedIndexChanged
            //string sql = @"SELECT id_tipo_mov, descripcion, afecta_stock 
            ///            FROM tipo_movimiento WHERE estado = 1 ORDER BY descripcion";
            //var da = new SqlDataAdapter(sql, conexion);
            //var dt = new DataTable();
            //da.Fill(dt);

            comboTipoMovimiento.DataSource = dt;
            comboTipoMovimiento.DisplayMember = "descripcion";
            comboTipoMovimiento.ValueMember = "id_tipo_mov";
            comboTipoMovimiento.SelectedIndex = -1;

            comboTipoMovimiento.SelectedIndexChanged += comboTipoMovimiento_SelectedIndexChanged;
        }

        private void CargarProveedores()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT id_proveedor, nombre FROM proveedor WHERE estado = 1 ORDER BY nombre", conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //string sql = @"SELECT id_proveedor, nombre 
            //      FROM proveedor WHERE estado = 1 ORDER BY nombre";
            // var da = new SqlDataAdapter(sql, conexion);
            //var dt = new DataTable();
            //da.Fill(dt);

            comboProveedor.DataSource = dt;
            comboProveedor.DisplayMember = "nombre";
            comboProveedor.ValueMember = "id_proveedor";
            comboProveedor.SelectedIndex = -1;
        }

        // ====== Reacción al tipo de movimiento ======
        private void comboTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            afecta_stock_actual = 0;

            if (comboTipoMovimiento.SelectedIndex >= 0)
            {
                var row = (DataRowView)comboTipoMovimiento.SelectedItem;
                afecta_stock_actual = Convert.ToInt32(row["afecta_stock"]); // +1 o -1

                // Entrada -> habilita proveedor; Salida -> deshabilita
                bool esEntrada = (afecta_stock_actual == 1);
                comboProveedor.Enabled = esEntrada;
            }
        }

        private void btnConsultaProducto_Click(object sender, EventArgs e)
        {
            //using (var consulta = new Proyecto_Restaurante.Consulta.ConsultaProductos()) // usa el ctor vacío
                ConsultaProductos consulta = new ConsultaProductos();
            {
                if (consulta.ShowDialog(this) == DialogResult.OK)
                {
                    id_producto_seleccionado = consulta.SelectedId;
                    producto.Text = consulta.SelectedNombre;
                    txtstockatual.Text = consulta.SelectedStock.ToString("F2");
                    txtcantidad.Focus();
                }
            }
        }

        public void CargarProductoSeleccionado(int idProducto, string nombreProd, decimal stockActual)
        {
            id_producto_seleccionado = idProducto;
            producto.Text = nombreProd;
            stock_actual_2 = stockActual;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(producto.Text) ||
                comboTipoMovimiento.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtcantidad.Text) ||
                (!activo.Checked && !inactivo.Checked))
            {
                MessageBox.Show("Por favor completa todos los campos antes de guardar.",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conexion.Open();

                int estadoValor = activo.Checked ? 1 : 0;
                int idTipoMov = Convert.ToInt32(comboTipoMovimiento.SelectedValue);
                decimal cantidad = decimal.Parse(txtcantidad.Text);
                object idProveedor = DBNull.Value;

                // Si el proveedor está habilitado y seleccionado
                if (comboProveedor.Enabled && comboProveedor.SelectedIndex != -1)
                {
                    idProveedor = Convert.ToInt32(comboProveedor.SelectedValue);
                }

                string consulta = @"INSERT INTO movimiento_inventario 
                            (id_producto, id_tipo_mov, cantidad, fecha, id_proveedor, observaciones, estado) 
                            VALUES (@id_producto, @id_tipo_mov, @cantidad, @fecha, @id_proveedor, @observaciones, @estado)";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_producto", id_producto_seleccionado);
                    cmd.Parameters.AddWithValue("@id_tipo_mov", idTipoMov);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id_proveedor", idProveedor);
                    cmd.Parameters.AddWithValue("@observaciones", observaciones.Text);
                    cmd.Parameters.AddWithValue("@estado", estadoValor);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Movimiento registrado correctamente.");

                Limpiar(); // Este método lo haces como en MantenimientoProducto para resetear campos
                id_producto_seleccionado = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void Limpiar()
        {
            producto.Clear();
            txtcantidad.Clear();
            observaciones.Clear();
            //descripcion.Clear();
            comboTipoMovimiento.SelectedIndex = -1;
            comboProveedor.SelectedIndex = -1;
            activo.Checked = true;
            inactivo.Checked = false;

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
