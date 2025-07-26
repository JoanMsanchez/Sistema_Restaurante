using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class Categoria : Form
    {

        private int id_categoria_seleccionada = -1;

        //Fields
        private int bordeSize = 2;


        //Constructor
        public Categoria()
        {
            InitializeComponent();
            llenar_tabla_datagridview();
            this.Padding = new Padding(bordeSize); //Border size
            this.BackColor = Color.FromArgb(255, 161, 43); //Border color
        }

        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        //SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");


        public void Limpiar()
        {
            nomcategoria.Clear();
            activo.Checked = false;
            inactivo.Checked = false;
            buscanom.Clear();
            id_categoria_seleccionada = -1;
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

                int estado = activo.Checked ? 1 : 0;

                SqlCommand cmd;

                if (id_categoria_seleccionada != -1)
                {
                    // MODIFICAR
                    string consulta = "UPDATE categoria_producto SET nombre = @nombre, estado = @estado WHERE id_categoria = @id";
                    cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@id", id_categoria_seleccionada);
                    MessageBox.Show("Categoría modificada correctamente");
                }
                else
                {
                    // INSERTAR
                    string consulta = "INSERT INTO categoria_producto (nombre, estado) VALUES (@nombre, @estado)";
                    cmd = new SqlCommand(consulta, conexion);
                    MessageBox.Show("Categoría registrada correctamente");
                }

                cmd.Parameters.AddWithValue("@nombre", nomcategoria.Text.Trim());
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

                string consulta = "SELECT * FROM categoria_producto WHERE nombre LIKE @nombre";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.SelectCommand.Parameters.AddWithValue("@nombre", "%" + buscanom.Text.Trim() + "%");

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

                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("id_categoria"))
                {
                    dataGridView1.Columns["id_categoria"].Visible = false;
                }

                dataGridView1.Columns["No"].HeaderText = "#";
                dataGridView1.Columns["nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["estado"].HeaderText = "Estado";
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
                id_categoria_seleccionada = Convert.ToInt32(fila.Cells["id_categoria"].Value); // guardamos el id

                nomcategoria.Text = fila.Cells["nombre"].Value.ToString();

                int estado = Convert.ToInt32(fila.Cells["estado"].Value);
                if (estado == 1)
                    activo.Checked = true;
                else
                    inactivo.Checked = true;
            }
        }

        private void panelCategoria_MouseDown(object sender, MouseEventArgs e)
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
        private void Categoria_Resize(object sender, EventArgs e)
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

        private void btnMinimizarCategoria_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarCategoria_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
