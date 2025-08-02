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
using Proyecto_Restaurante.Principal;

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class MantenimientoCondicionPago : Form
    {

        //Fields
        private int bordeSize = 2;

        //Constructor
        public MantenimientoCondicionPago()
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

        private int id_condicion_seleccionada = -1;

        private void panelMantenimientoCondicion_MouseDown(object sender, MouseEventArgs e)
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

        private void btnMinimizarCondicion_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarCondicion_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarCondicion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Limpiar()
        {
            nomCondicion.Clear();
            activo.Checked = false;
            inactivo.Checked = false;
            autopagoSI.Checked = false;
            autopagoNO.Checked = false;
            diascredito.Clear();
            diascredito.Enabled = true;
            busca.Clear();
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

        private void DGVCondiconPago_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGVCondiconPago.Rows[e.RowIndex];
                id_condicion_seleccionada = Convert.ToInt32(fila.Cells["id_condicion"].Value); // guardamos el id

                nomCondicion.Text = fila.Cells["descripcion"].Value.ToString();
                diascredito.Text = fila.Cells["dias_credito"].Value.ToString();
                int autopago = Convert.ToInt32(fila.Cells["autopago"].Value);
                if (autopago == 1)
                    autopagoSI.Checked = true;
                else
                    autopagoNO.Checked = true;

                int estado = Convert.ToInt32(fila.Cells["estado"].Value);
                if (estado == 1)
                    activo.Checked = true;
                else
                    inactivo.Checked = true;
            }
        }

        private void buscanom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string consulta = "";

                if (busDescripcion.Checked)
                {
                    // Búsqueda por usuario (insensible a mayúsculas/minúsculas)
                    consulta = "SELECT * FROM condicion WHERE descripcion LIKE @busqueda";
                }
                else if (busDias.Checked)
                {
                    // Búsqueda por nombre (sensible a mayúsculas/minúsculas por defecto)
                    consulta = "SELECT * FROM condicion WHERE dias_credito LIKE @busqueda";
                }
                else
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda");
                    return;
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.SelectCommand.Parameters.AddWithValue("@busqueda", "%" + busca.Text.Trim() + "%");

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Agregar columna "No"
                DataColumn columnaSecuencia = new DataColumn("No", typeof(int));
                dt.Columns.Add(columnaSecuencia);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No"] = i + 1;
                }

                dt.Columns["No"].SetOrdinal(0); // Mover la columna "No" al inicio

                DGVCondiconPago.DataSource = dt;

                // Ocultar id_empleado si está
                if (DGVCondiconPago.Columns.Contains("id_empleado"))
                {
                    DGVCondiconPago.Columns["id_empleado"].Visible = false;
                }

                // Encabezados personalizados
                DGVCondiconPago.Columns["No"].HeaderText = "#";
                DGVCondiconPago.Columns["descripcion"].HeaderText = "Descripción";
                DGVCondiconPago.Columns["autopago"].HeaderText = "Autopago";
                DGVCondiconPago.Columns["dias_credito"].HeaderText = "Día credito";
                DGVCondiconPago.Columns["estado"].HeaderText = "Estado";
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

        private void nomCondicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en la descripción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void diascredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void autopagoSI_CheckedChanged(object sender, EventArgs e)
        {
            if (autopagoSI.Checked)
            {
                diascredito.Text = "0";
                diascredito.Enabled = false;
            }
        }

        private void autopagoNO_CheckedChanged(object sender, EventArgs e)
        {
            if (autopagoNO.Checked)
            {
                diascredito.Enabled = true;
                diascredito.Clear();
            }
        }
    }
}
