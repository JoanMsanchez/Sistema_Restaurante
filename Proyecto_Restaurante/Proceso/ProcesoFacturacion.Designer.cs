namespace Proyecto_Restaurante.Proceso
{
    partial class ProcesoFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            grpCatalogo = new Panel();
            cmbCategoria = new ComboBox();
            flpCatalogo = new FlowLayoutPanel();
            txtBuscarProd = new TextBox();
            grpDetalle = new Panel();
            lblTotal = new Label();
            lblImpuesto = new Label();
            lblDescuento = new Label();
            lblSubTotal = new Label();
            dgvDetalle = new DataGridView();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnPrecuenta = new FontAwesome.Sharp.IconButton();
            btnProcesar = new FontAwesome.Sharp.IconButton();
            Titulo = new Panel();
            cmbMetodoPago = new ComboBox();
            cmbCondicion = new ComboBox();
            btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            cmbCliente = new ComboBox();
            btnCambiarMesa = new FontAwesome.Sharp.IconButton();
            lbEmpleado = new Label();
            lbSalaMesa = new Label();
            tlpMain.SuspendLayout();
            grpCatalogo.SuspendLayout();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            Titulo.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.Controls.Add(grpCatalogo, 0, 0);
            tlpMain.Controls.Add(grpDetalle, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 179);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(1109, 483);
            tlpMain.TabIndex = 2;
            // 
            // grpCatalogo
            // 
            grpCatalogo.Controls.Add(cmbCategoria);
            grpCatalogo.Controls.Add(flpCatalogo);
            grpCatalogo.Controls.Add(txtBuscarProd);
            grpCatalogo.Dock = DockStyle.Fill;
            grpCatalogo.Location = new Point(3, 3);
            grpCatalogo.Name = "grpCatalogo";
            grpCatalogo.Size = new Size(437, 477);
            grpCatalogo.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(335, 17);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(86, 33);
            cmbCategoria.TabIndex = 8;
            // 
            // flpCatalogo
            // 
            flpCatalogo.AutoScroll = true;
            flpCatalogo.Location = new Point(3, 79);
            flpCatalogo.Name = "flpCatalogo";
            flpCatalogo.Size = new Size(434, 380);
            flpCatalogo.TabIndex = 9;
            // 
            // txtBuscarProd
            // 
            txtBuscarProd.Location = new Point(9, 19);
            txtBuscarProd.Name = "txtBuscarProd";
            txtBuscarProd.Size = new Size(300, 31);
            txtBuscarProd.TabIndex = 7;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lblTotal);
            grpDetalle.Controls.Add(lblImpuesto);
            grpDetalle.Controls.Add(lblDescuento);
            grpDetalle.Controls.Add(lblSubTotal);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(btnGuardar);
            grpDetalle.Controls.Add(btnPrecuenta);
            grpDetalle.Controls.Add(btnProcesar);
            grpDetalle.Dock = DockStyle.Fill;
            grpDetalle.Location = new Point(446, 3);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(660, 477);
            grpDetalle.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Location = new Point(303, 322);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(2, 27);
            lblTotal.TabIndex = 12;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.BorderStyle = BorderStyle.FixedSingle;
            lblImpuesto.Location = new Point(175, 325);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(2, 27);
            lblImpuesto.TabIndex = 11;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BorderStyle = BorderStyle.FixedSingle;
            lblDescuento.Location = new Point(46, 398);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(2, 27);
            lblDescuento.TabIndex = 10;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BorderStyle = BorderStyle.FixedSingle;
            lblSubTotal.Location = new Point(45, 334);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(2, 27);
            lblSubTotal.TabIndex = 9;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(6, 9);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.Size = new Size(649, 266);
            dgvDetalle.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(255, 382);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 61);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnPrecuenta
            // 
            btnPrecuenta.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPrecuenta.IconColor = Color.Black;
            btnPrecuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrecuenta.Location = new Point(389, 382);
            btnPrecuenta.Name = "btnPrecuenta";
            btnPrecuenta.Size = new Size(128, 61);
            btnPrecuenta.TabIndex = 6;
            btnPrecuenta.Text = "Precuenta";
            btnPrecuenta.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            btnProcesar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProcesar.IconColor = Color.Black;
            btnProcesar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProcesar.Location = new Point(523, 382);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(128, 61);
            btnProcesar.TabIndex = 5;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            Titulo.Controls.Add(cmbMetodoPago);
            Titulo.Controls.Add(cmbCondicion);
            Titulo.Controls.Add(btnBuscarCliente);
            Titulo.Controls.Add(cmbCliente);
            Titulo.Controls.Add(btnCambiarMesa);
            Titulo.Controls.Add(lbEmpleado);
            Titulo.Controls.Add(lbSalaMesa);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1109, 179);
            Titulo.TabIndex = 3;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(324, 123);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(258, 33);
            cmbMetodoPago.TabIndex = 6;
            // 
            // cmbCondicion
            // 
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Location = new Point(324, 68);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(258, 33);
            cmbCondicion.TabIndex = 5;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarCliente.IconColor = Color.Black;
            btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarCliente.Location = new Point(661, 35);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(128, 61);
            btnBuscarCliente.TabIndex = 4;
            btnBuscarCliente.Text = "Buscar Cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(324, 12);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(258, 33);
            cmbCliente.TabIndex = 3;
            // 
            // btnCambiarMesa
            // 
            btnCambiarMesa.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCambiarMesa.IconColor = Color.Black;
            btnCambiarMesa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCambiarMesa.Location = new Point(131, 17);
            btnCambiarMesa.Name = "btnCambiarMesa";
            btnCambiarMesa.Size = new Size(128, 61);
            btnCambiarMesa.TabIndex = 2;
            btnCambiarMesa.Text = "Cambiar Mesa";
            btnCambiarMesa.UseVisualStyleBackColor = true;
            btnCambiarMesa.Click += btnCambiarMesa_Click;
            // 
            // lbEmpleado
            // 
            lbEmpleado.AutoSize = true;
            lbEmpleado.BorderStyle = BorderStyle.FixedSingle;
            lbEmpleado.Location = new Point(30, 106);
            lbEmpleado.Name = "lbEmpleado";
            lbEmpleado.Size = new Size(2, 27);
            lbEmpleado.TabIndex = 1;
            // 
            // lbSalaMesa
            // 
            lbSalaMesa.AutoSize = true;
            lbSalaMesa.BorderStyle = BorderStyle.FixedSingle;
            lbSalaMesa.Location = new Point(30, 35);
            lbSalaMesa.Name = "lbSalaMesa";
            lbSalaMesa.Size = new Size(2, 27);
            lbSalaMesa.TabIndex = 0;
            // 
            // ProcesoFacturacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(1109, 662);
            Controls.Add(tlpMain);
            Controls.Add(Titulo);
            Name = "ProcesoFacturacion";
            Text = "ProcesoFacturacion";
            Shown += ProcesoFacturacion_Shown_1;
            tlpMain.ResumeLayout(false);
            grpCatalogo.ResumeLayout(false);
            grpCatalogo.PerformLayout();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel Titulo;
        private FontAwesome.Sharp.IconButton btnCambiarMesa;
        private Label lbEmpleado;
        private Label lbSalaMesa;
        private ComboBox cmbCliente;
        private Panel grpCatalogo;
        private TextBox txtBuscarProd;
        private ComboBox cmbMetodoPago;
        private ComboBox cmbCondicion;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private FlowLayoutPanel flpCatalogo;
        private ComboBox cmbCategoria;
        private Panel grpDetalle;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnPrecuenta;
        private FontAwesome.Sharp.IconButton btnProcesar;
        private DataGridView dgvDetalle;
        private Label lblTotal;
        private Label lblImpuesto;
        private Label lblDescuento;
        private Label lblSubTotal;
    }
}