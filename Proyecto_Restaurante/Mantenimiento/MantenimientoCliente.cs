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

namespace Proyecto_Restaurante.Mantenimiento
{
    public partial class MantenimientoCliente : Form
    {
        //SqlConnection conexion = new SqlConnection(@"server=DESKTOP-HUHR9O6\SQLEXPRESS; database=SistemaRestauranteDB1; integrated security=true");
        SqlConnection conexion = new SqlConnection(@"server=MSI; database=SistemaRestauranteDB1; integrated security=true");

        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            nombre.Clear();
            telefono.Clear();
            email.Clear();
            direccion.Clear();
            activo.Checked = false;
            desactivo.Checked = false;
        }

        private void guardar_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
