using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Restaurante.Proceso.ProcesoFacturacion;

namespace Proyecto_Restaurante.Proceso
{
    public partial class PreCuenta : Form
    {
        private readonly PrecuentaData _data;

        public PreCuenta()
        {
            InitializeComponent();
            txtOrden.TabStop = false; 
            txtSalaMesa.TabStop = false;

        }

        public PreCuenta(PrecuentaData data) : this()
        {
            _data = data;
            Shown += (s, e) => CargarDatos();
        }

        private void CargarDatos()
        {
            // ===== Cabecera / meta =====
            txtOrden.Text = "Orden #" + _data.IdOrden;
            txtSalaMesa.Text = _data.SalaMesa ?? $"Mesa ?";
            txtCliente.Text = string.IsNullOrWhiteSpace(_data.Cliente) ? "Consumidor Final" : _data.Cliente.Trim();
            txtCondicion.Text = _data.Condicion ?? "";
            txtAtendido.Text = _data.Atendido ?? "";
            if (txtFecha != null)
                txtFecha.Text = (_data.Fecha == default ? DateTime.Now : _data.Fecha)
                                .ToString("dd/MM/yyyy HH:mm");

            // ===== Grilla =====
            ConfigurarGridSiHaceFalta();
            dgvPreCuenta.AutoGenerateColumns = false;
            dgvPreCuenta.DataSource = _data.Lineas;

            // ===== Totales =====
            RecalcularTotales();
        }

        private void RecalcularTotales()
        {
            decimal sub = _data.Lineas?.Sum(l => l.Importe) ?? 0m;
            decimal itb = Math.Round(sub * _data.ItbisRate, 2);
            decimal tot = sub + itb;

            txtSubTotal.Text = sub.ToString("N2");
            txtItbis.Text = itb.ToString("N2");
            txtTotal.Text = tot.ToString("N2");
        }

        private void ConfigurarGridSiHaceFalta()
        {
            if (dgvPreCuenta.Columns.Count > 0) return;

            // Evita filas en blanco y edición
            dgvPreCuenta.ReadOnly = true;
            dgvPreCuenta.AllowUserToAddRows = false;
            dgvPreCuenta.AllowUserToDeleteRows = false;
            dgvPreCuenta.RowHeadersVisible = false;
            dgvPreCuenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Columnas
            var colNo = new DataGridViewTextBoxColumn
            {
                HeaderText = "No",
                DataPropertyName = nameof(PrecuentaLinea.Nro),
                Width = 50,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            var colProd = new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = nameof(PrecuentaLinea.Nombre),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            var colCant = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cant",
                DataPropertyName = nameof(PrecuentaLinea.Cantidad),
                Width = 80,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "N2" }
            };
            var colPrecio = new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio",
                DataPropertyName = nameof(PrecuentaLinea.Precio),
                Width = 95,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" }
            };
            var colImporte = new DataGridViewTextBoxColumn
            {
                HeaderText = "Importe",
                DataPropertyName = nameof(PrecuentaLinea.Importe),
                Width = 110,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" }
            };

            dgvPreCuenta.Columns.AddRange(colNo, colProd, colCant, colPrecio, colImporte);
        }

    }
}
