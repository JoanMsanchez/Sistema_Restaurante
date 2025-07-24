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
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB; integrated security=true");
        //SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB; integrated security=true");
        public Empleado()
        {
            InitializeComponent();
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
    }
}
