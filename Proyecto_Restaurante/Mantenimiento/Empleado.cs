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
using Proyecto_Restaurante.Mantenimiento;

namespace Proyecto_Restaurante
{

    public partial class Empleado : Form
    {
        //SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB; integrated security=true");
        SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB; integrated security=true");
        public Empleado()
        {
            InitializeComponent();
            limpiar();
            llenar_tabla_datagridview();

        }

        public void llenar_tabla_datagridview()
        {
            try
            {
                string consulta = "SELECT * FROM empleado";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns[0].Visible = false; // Índice 0 = primera columna (ID)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar tabla: " + ex.Message);
            }
        }

        public void limpiar()
        {
            login.Clear();
            contrasena.Clear();
            nombre.Clear();
            apellido.Clear();
            activo.Checked = false;
            desactivo.Checked = false;
            login.Focus();
            busca.Clear();
            buscausuario.Checked = false;
            buscanombre.Checked = false;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                int estado = 0;

                if (activo.Checked == true)
                {
                    estado = 1;
                }
                else if (desactivo.Checked == true)
                {
                    estado = 0;
                }

                // Verificar si ya existe el usuario
                string verificar = "select count(*) from empleado where usuario = '" + login.Text + "'";
                SqlCommand cmdVerificar = new SqlCommand(verificar, conexion);
                int existe = (int)cmdVerificar.ExecuteScalar();

                string consulta;

                if (existe > 0)
                {
                    // Ya existe: MODIFICAR
                    consulta = "update empleado set clave = '" + contrasena.Text + "', nombre = '" + nombre.Text + "', apellidos = '" + apellido.Text + "', estado = " + estado +
                               " where usuario = '" + login.Text + "'";
                    MessageBox.Show("Registro modificado correctamente");
                }
                else
                {
                    // No existe: INSERTAR
                    consulta = "insert into empleado (usuario, clave, nombre, apellidos, estado) " +
                               "values ('" + login.Text + "','" + contrasena.Text + "','" + nombre.Text + "','" + apellido.Text + "'," + estado + ")";
                    MessageBox.Show("Registro insertado correctamente");
                }

                SqlCommand ejecutar = new SqlCommand(consulta, conexion);
                ejecutar.ExecuteNonQuery();

                llenar_tabla_datagridview();
                limpiar();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
                conexion.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                login.Text = dataGridView1.SelectedCells[1].Value.ToString();
                contrasena.Text = dataGridView1.SelectedCells[2].Value.ToString();
                nombre.Text = dataGridView1.SelectedCells[3].Value.ToString();
                apellido.Text = dataGridView1.SelectedCells[4].Value.ToString();

                int estado = Convert.ToInt32(dataGridView1.SelectedCells[5].Value);
                if (estado == 1)
                    activo.Checked = true;
                else if (estado == 0)
                    desactivo.Checked = true;
            }
            catch
            {
                // Evitar errores si se hace clic fuera de los datos
            }
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                login.Text = fila.Cells["usuario"].Value.ToString();
                contrasena.Text = fila.Cells["clave"].Value.ToString();
                nombre.Text = fila.Cells["nombre"].Value.ToString();
                apellido.Text = fila.Cells["apellidos"].Value.ToString();

                int estado = Convert.ToInt32(fila.Cells["estado"].Value);
                if (estado == 1)
                    activo.Checked = true;
                else
                    desactivo.Checked = true;
            }
        }
        private void busca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string consulta = "";

                if (buscausuario.Checked)
                {
                    consulta = "SELECT * FROM empleado WHERE usuario LIKE '%" + busca.Text.Trim() + "%'";
                }
                else if (buscanombre.Checked)
                {
                    consulta = "SELECT * FROM empleado WHERE nombre LIKE '%" + busca.Text.Trim() + "%'";
                }
                else
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda");
                    return;
                }

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

        private void Limpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void guardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(login.Text) ||
                string.IsNullOrWhiteSpace(contrasena.Text) ||
                string.IsNullOrWhiteSpace(nombre.Text) ||
                string.IsNullOrWhiteSpace(apellido.Text) ||
                (!activo.Checked && !desactivo.Checked))
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione el estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conexion.Open();

                int estado = 0;

                if (activo.Checked == true)
                {
                    estado = 1;
                }
                else if (desactivo.Checked == true)
                {
                    estado = 0;
                }

                // Verificar si ya existe el usuario
                string verificar = "select count(*) from empleado where usuario = '" + login.Text + "'";
                SqlCommand cmdVerificar = new SqlCommand(verificar, conexion);
                int existe = (int)cmdVerificar.ExecuteScalar();

                string consulta;

                if (existe > 0)
                {
                    // Ya existe: MODIFICAR
                    consulta = "update empleado set clave = '" + contrasena.Text + "', nombre = '" + nombre.Text + "', apellidos = '" + apellido.Text + "', estado = " + estado +
                               " where usuario = '" + login.Text + "'";
                    MessageBox.Show("Registro modificado correctamente");
                }
                else
                {
                    // No existe: INSERTAR
                    consulta = "insert into empleado (usuario, clave, nombre, apellidos, estado) " +
                               "values ('" + login.Text + "','" + contrasena.Text + "','" + nombre.Text + "','" + apellido.Text + "'," + estado + ")";
                    MessageBox.Show("Registro insertado correctamente");
                }

                SqlCommand ejecutar = new SqlCommand(consulta, conexion);
                ejecutar.ExecuteNonQuery();

                llenar_tabla_datagridview();
                limpiar();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
                conexion.Close();
            }
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                MessageBox.Show("Solo se permiten letras en el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                MessageBox.Show("Solo se permiten letras en el apellido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
