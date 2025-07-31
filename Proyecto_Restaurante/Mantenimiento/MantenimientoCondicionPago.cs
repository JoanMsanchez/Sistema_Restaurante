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
    public partial class MantenimientoCondicionPago : Form
    {

        private int id_condicion_seleccionada = -1;

        //SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        public MantenimientoCondicionPago()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            nomCondicion.Clear();
            activo.Checked = false;
            inactivo.Checked = false;
            autopagoSI.Checked = false;
            autopagoNO.Checked = false;
            diascredito.Clear();
            buscanom.Clear();
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void llenar_tabla_datagridview()
        {
            try
            {
                string consulta = "SELECT * FROM condicion";
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

                DGVCondiconPago.DataSource = dt;

                if (DGVCondiconPago.Columns.Contains("id_condicion"))
                {
                    DGVCondiconPago.Columns["id_condicion"].Visible = false;
                }
                DGVCondiconPago.Columns["No"].HeaderText = "#";
                DGVCondiconPago.Columns["descripcion"].HeaderText = "Descripción";
                DGVCondiconPago.Columns["autopago"].HeaderText = "Autopago";
                DGVCondiconPago.Columns["dias_credito"].HeaderText = "Día credito";
                DGVCondiconPago.Columns["estado"].HeaderText = "Estado";

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
                // Validaciones básicas
                if (string.IsNullOrWhiteSpace(nomCondicion.Text) ||
                    (!autopagoSI.Checked && !autopagoNO.Checked) ||
                    string.IsNullOrWhiteSpace(diascredito.Text) ||
                    (!activo.Checked && !inactivo.Checked))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que la cantidad de días sea un número válido
                if (!int.TryParse(diascredito.Text.Trim(), out int cantidadDias))
                {
                    MessageBox.Show("Cantidad de días debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conexion.Open();

                int autopago = autopagoSI.Checked ? 1 : 0;
                int estado = activo.Checked ? 1 : 0;

                SqlCommand cmd;

                if (id_condicion_seleccionada != -1)
                {
                    // MODIFICAR
                    string consulta = "UPDATE condicion SET descripcion = @descripcion, autopago = @autopago, dias_credito = @dias_credito, estado = @estado WHERE id_condicion = @id";
                    cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@id", id_condicion_seleccionada);
                    MessageBox.Show("Condición modificada correctamente.");
                }
                else
                {
                    // INSERTAR
                    string consulta = "INSERT INTO condicion (descripcion, autopago, dias_credito, estado) VALUES (@descripcion, @autopago, @dias_credito, @estado)";
                    cmd = new SqlCommand(consulta, conexion);
                    MessageBox.Show("Condición guardada correctamente.");
                }

                // Parámetros comunes
                cmd.Parameters.AddWithValue("@descripcion", nomCondicion.Text.Trim());
                cmd.Parameters.AddWithValue("@autopago", autopago);
                cmd.Parameters.AddWithValue("@dias_credito", int.Parse(diascredito.Text.Trim()));
                cmd.Parameters.AddWithValue("@estado", estado);

                cmd.ExecuteNonQuery();

                llenar_tabla_datagridview();
                Limpiar(); // también reinicia id_seleccionado
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
    }
}
