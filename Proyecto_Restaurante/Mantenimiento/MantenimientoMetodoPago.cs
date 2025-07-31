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
using Proyecto_Restaurante.Principal;

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class MantenimientoMetodoPago : Form
    {
        private int id_metodopago_seleccionada;
        //SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        public MantenimientoMetodoPago()
        {
            InitializeComponent();
            llenar_tabla_datagridview();
            id_metodopago_seleccionada = -1;

        }

        public void Limpiar()
        {
            nomMetodoPago.Clear();
            activo.Checked = false;
            inactivo.Checked = false;
            buscanom.Clear();
            id_metodopago_seleccionada = -1;

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void llenar_tabla_datagridview()
        {
            try
            {
                string consulta = "SELECT * FROM metodo_pago";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                dt.Columns.Add(columnaSecuencia);

                // Llenar con la secuencia
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }

                // Mover la columna "No" a la posición 0 (primera)
                dt.Columns["No"].SetOrdinal(0);

                DGVMetodoPago.DataSource = dt;

                if (DGVMetodoPago.Columns.Contains("id_metodo_pago"))
                {
                    DGVMetodoPago.Columns["id_metodo_pago"].Visible = false;
                }
                DGVMetodoPago.Columns["No"].HeaderText = "#";
                DGVMetodoPago.Columns["descripcion"].HeaderText = "Nombre";
                DGVMetodoPago.Columns["estado"].HeaderText = "Estado";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar tabla: " + ex.Message);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nomMetodoPago.Text) ||
                    (!activo.Checked && !inactivo.Checked))
                {
                    MessageBox.Show("Por favor, complete el nombre y seleccione el estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conexion.Open();

                int estado = activo.Checked ? 1 : 0;

                SqlCommand cmd;

                if (id_metodopago_seleccionada != -1)
                {
                    // MODIFICAR
                    string consulta = "UPDATE metodo_pago SET descripcion = @descripcion, estado = @estado WHERE id_metodo_pago = @id";
                    cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@id", id_metodopago_seleccionada);
                    MessageBox.Show("Metodo de pago modificado correctamente");
                }
                else
                {
                    // INSERTAR
                    string consulta = "INSERT INTO metodo_pago (descripcion, estado) VALUES (@descripcion, @estado)";
                    cmd = new SqlCommand(consulta, conexion);
                    MessageBox.Show("Metodo de pago registrado correctamente");
                }

                cmd.Parameters.AddWithValue("@descripcion", nomMetodoPago.Text.Trim());
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.ExecuteNonQuery();

                llenar_tabla_datagridview();
                Limpiar(); // esto también resetea el id
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

        private void buscanom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string consulta = "SELECT * FROM metodo_pago WHERE descripcion LIKE @descripcion";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.SelectCommand.Parameters.AddWithValue("@descripcion", "%" + buscanom.Text.Trim() + "%");

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Agregar columna "No"
                DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                dt.Columns.Add(columnaSecuencia);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }

                dt.Columns["No"].SetOrdinal(0); // mover al inicio

                DGVMetodoPago.DataSource = dt;

                if (DGVMetodoPago.Columns.Contains("id_metodo_pago"))
                {
                    DGVMetodoPago.Columns["id_metodo_pago"].Visible = false;
                }

                DGVMetodoPago.Columns["No"].HeaderText = "#";
                DGVMetodoPago.Columns["descripcion"].HeaderText = "Nombre";
                DGVMetodoPago.Columns["estado"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void DGVMetodoPago_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGVMetodoPago.Rows[e.RowIndex];
                id_metodopago_seleccionada = Convert.ToInt32(fila.Cells["id_metodo_pago"].Value); // guardamos el id

                nomMetodoPago.Text = fila.Cells["descripcion"].Value.ToString();

                int estado = Convert.ToInt32(fila.Cells["estado"].Value);
                if (estado == 1)
                    activo.Checked = true;
                else
                    inactivo.Checked = true;
            }
        }

        private void nomMetodoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
