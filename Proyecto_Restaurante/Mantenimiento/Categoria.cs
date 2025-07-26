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
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class Categoria : Form
    {
        //SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");
        public Categoria()
        {
            InitializeComponent();
            llenar_tabla_datagridview();
        }

        public void Limpiar()
        {
            nomcategoria.Clear();
            activo.Checked = false;
            inactivo.Checked = false;
            buscanom.Clear();

        }

        public void llenar_tabla_datagridview()
        {
            try
            {
                string consulta = "SELECT * FROM categoria_producto";
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

                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("id_categoria"))
                {
                    dataGridView1.Columns["id_categoria"].Visible = false;
                }
                dataGridView1.Columns["No"].HeaderText = "#";
                dataGridView1.Columns["nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["estado"].HeaderText = "Estado";
                //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 161, 43); // encabezado
                //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                //dataGridView1.EnableHeadersVisualStyles = false;
                //dataGridView1.Columns["nombre"].DefaultCellStyle.BackColor = Color.FromArgb(255, 161, 43);
                //dataGridView1.Columns["nombre"].DefaultCellStyle.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar tabla: " + ex.Message);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nomcategoria.Text) ||
                    (!activo.Checked && !inactivo.Checked))
                {
                    MessageBox.Show("Por favor, complete el nombre y seleccione el estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conexion.Open();

                int estado = 0;

                if (activo.Checked)
                {
                    estado = 1;
                }
                else if (inactivo.Checked)
                {
                    estado = 0;
                }

                // Verificar si ya existe la categoría
                string verificar = "SELECT COUNT(*) FROM categoria_producto WHERE nombre = @nombre";
                SqlCommand cmdVerificar = new SqlCommand(verificar, conexion);
                cmdVerificar.Parameters.AddWithValue("@nombre", nomcategoria.Text.Trim());
                int existe = (int)cmdVerificar.ExecuteScalar();

                string consulta;

                if (existe > 0)
                {
                    //Ya existe: MODIFICAR
                    consulta = "UPDATE categoria_producto SET nombre = @estado WHERE nombre = @nombre";
                    MessageBox.Show("Categoría actualizada correctamente");
                }
                else
                {
                    // No existe: INSERTAR
                    consulta = "INSERT INTO categoria_producto (nombre, estado) VALUES (@nombre, @estado)";
                    MessageBox.Show("Categoría registrada correctamente");
                }

                SqlCommand ejecutar = new SqlCommand(consulta, conexion);
                ejecutar.Parameters.AddWithValue("@nombre", nomcategoria.Text.Trim());
                ejecutar.Parameters.AddWithValue("@estado", estado);
                ejecutar.ExecuteNonQuery();

                llenar_tabla_datagridview();
                Limpiar();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
                conexion.Close();
            }
        }

        private void nomcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buscanom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string consulta = "";
                consulta = "SELECT * FROM categoria_producto WHERE nombre LIKE '%" + buscanom.Text.Trim() + "%'";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                nomcategoria.Text = fila.Cells["nombre"].Value.ToString();

                int estado = Convert.ToInt32(fila.Cells["estado"].Value);
                if (estado == 1)
                    activo.Checked = true;
                else
                    inactivo.Checked = true;
            }
        }
    }
}
