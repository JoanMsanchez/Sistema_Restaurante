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
using System.Windows.Automation;
using System.Windows.Forms;
using Proyecto_Restaurante.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class MantenimientoTipoMovimiento : Form
    {
        private int id_tipomovimiento_seleccionada = -1;

        //Fields
        private int bordeSize = 2;

        //Constructor
        public MantenimientoTipoMovimiento()
        {
            InitializeComponent();
            this.Shown += MantenimientoTipoMovimiento_Shown;
            llenar_tabla_datagridview();
            this.Padding = new Padding(bordeSize); //Border size
            this.BackColor = Color.FromArgb(255, 161, 43); //Border color
        }

        //Drag Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        private void panelMantenimientoCliente_MouseDown(object sender, MouseEventArgs e)
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
        private void btnMinimizarTipodeMovimiento_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarTipodeMovimiento_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarTipodeMovimiento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Limpiar()
        {
            nomMovimiento.Clear();
            activo.Checked = false;
            inactivo.Checked = false;
            afectastock.Clear();
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
                string consulta = "SELECT * FROM tipo_movimiento";
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

                DGVTipoMovimiento.DataSource = dt;

                if (DGVTipoMovimiento.Columns.Contains("id_tipo_mov"))
                {
                    DGVTipoMovimiento.Columns["id_tipo_mov"].Visible = false;
                }
                DGVTipoMovimiento.Columns["No"].HeaderText = "#";
                DGVTipoMovimiento.Columns["descripcion"].HeaderText = "Descripción";
                DGVTipoMovimiento.Columns["afecta_stock"].HeaderText = "Operación de Stock";
                DGVTipoMovimiento.Columns["estado"].HeaderText = "Estado";

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
                if (string.IsNullOrWhiteSpace(nomMovimiento.Text) ||
                    (string.IsNullOrWhiteSpace(afectastock.Text)) ||
                    (!activo.Checked && !inactivo.Checked))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conexion.Open();

                //int afectastock = stockmas.Checked ? 1 : -1;

                int afectastockm;
                if (!int.TryParse(afectastock.Text.Trim(), out afectastockm))
                {
                    MessageBox.Show("El valor de 'Afecta Stock' debe ser un número válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int estado = activo.Checked ? 1 : 0;

                SqlCommand cmd;

                if (id_tipomovimiento_seleccionada != -1)
                {
                    // MODIFICAR
                    string consulta = "UPDATE tipo_movimiento SET descripcion = @descripcion, afecta_stock = @afecta_stock, estado = @estado WHERE id_tipo_mov = @id";
                    cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@id", id_tipomovimiento_seleccionada);
                    MessageBox.Show("Tipo de movimiento modificado correctamente.");
                }
                else
                {
                    // INSERTAR
                    string consulta = "INSERT INTO tipo_movimiento (descripcion, afecta_stock, estado) VALUES (@descripcion, @afecta_stock, @estado)";
                    cmd = new SqlCommand(consulta, conexion);
                    MessageBox.Show("Tipo de movimiento guardada correctamente.");
                }

                // Parámetros comunes
                cmd.Parameters.AddWithValue("@descripcion", nomMovimiento.Text.Trim());
                cmd.Parameters.AddWithValue("@afecta_stock", afectastockm);
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

        private void nomMovimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en el nombre del movimiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                afectastock.Focus();
            }
        }

        private void buscanom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string consulta = "SELECT * FROM tipo_movimiento WHERE descripcion LIKE @descripcion";
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

                DGVTipoMovimiento.DataSource = dt;

                if (DGVTipoMovimiento.Columns.Contains("id_tipo_mov"))
                {
                    DGVTipoMovimiento.Columns["id_tipo_mov"].Visible = false;
                }

                DGVTipoMovimiento.Columns["No"].HeaderText = "#";
                DGVTipoMovimiento.Columns["descripcion"].HeaderText = "Descripción";
                DGVTipoMovimiento.Columns["afecta_stock"].HeaderText = "Operación de Stock";
                DGVTipoMovimiento.Columns["estado"].HeaderText = "Estado";
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

        private void DGVTipoMovimiento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGVTipoMovimiento.Rows[e.RowIndex];
                id_tipomovimiento_seleccionada = Convert.ToInt32(fila.Cells["id_tipo_mov"].Value); // guardamos el id

                nomMovimiento.Text = fila.Cells["descripcion"].Value.ToString();
                afectastock.Text = fila.Cells["afecta_stock"].Value.ToString();

                //int afectastock = Convert.ToInt32(fila.Cells["afecta_stock"].Value);
                int estado = Convert.ToInt32(fila.Cells["estado"].Value);
                if (estado == 1)
                    activo.Checked = true;
                else
                    inactivo.Checked = true;
            }
        }

        private void afectastock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MantenimientoTipoMovimiento_Shown(object sender, EventArgs e)
        {
            nomMovimiento.Focus();
        }
    }
}
