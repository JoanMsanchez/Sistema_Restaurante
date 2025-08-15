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
            label5 = new Label();
            label4 = new Label();
            cmbCategoria = new ComboBox();
            flpCatalogo = new FlowLayoutPanel();
            txtBuscarProd = new TextBox();
            grpDetalle = new Panel();
            label10 = new Label();
            txtSaldoPendiente = new TextBox();
            label9 = new Label();
            txtSubTotal = new TextBox();
            txtTotal = new TextBox();
            label7 = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            label6 = new Label();
            dgvDetalle = new DataGridView();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnPrecuenta = new FontAwesome.Sharp.IconButton();
            btnProcesar = new FontAwesome.Sharp.IconButton();
            Titulo = new Panel();
            label8 = new Label();
            dtpFechaCreacion = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbMetodoPago = new ComboBox();
            cmbCondicion = new ComboBox();
            btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            cmbCliente = new ComboBox();
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
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5454559F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.4545441F));
            tlpMain.Controls.Add(grpCatalogo, 0, 0);
            tlpMain.Controls.Add(grpDetalle, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 179);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1336, 483);
            tlpMain.TabIndex = 2;
            // 
            // grpCatalogo
            // 
            grpCatalogo.Controls.Add(label5);
            grpCatalogo.Controls.Add(label4);
            grpCatalogo.Controls.Add(cmbCategoria);
            grpCatalogo.Controls.Add(flpCatalogo);
            grpCatalogo.Controls.Add(txtBuscarProd);
            grpCatalogo.Dock = DockStyle.Fill;
            grpCatalogo.Location = new Point(3, 3);
            grpCatalogo.Name = "grpCatalogo";
            grpCatalogo.Size = new Size(722, 477);
            grpCatalogo.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(439, 9);
            label5.Name = "label5";
            label5.Size = new Size(196, 25);
            label5.TabIndex = 11;
            label5.Text = "Categoria de producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 9);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 10;
            label4.Text = "Buscar producto: ";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(395, 47);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(286, 33);
            cmbCategoria.TabIndex = 8;
            // 
            // flpCatalogo
            // 
            flpCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCatalogo.AutoScroll = true;
            flpCatalogo.Location = new Point(3, 102);
            flpCatalogo.Name = "flpCatalogo";
            flpCatalogo.Size = new Size(719, 372);
            flpCatalogo.TabIndex = 9;
            // 
            // txtBuscarProd
            // 
            txtBuscarProd.Location = new Point(18, 49);
            txtBuscarProd.Name = "txtBuscarProd";
            txtBuscarProd.Size = new Size(300, 31);
            txtBuscarProd.TabIndex = 7;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(label10);
            grpDetalle.Controls.Add(txtSaldoPendiente);
            grpDetalle.Controls.Add(label9);
            grpDetalle.Controls.Add(txtSubTotal);
            grpDetalle.Controls.Add(txtTotal);
            grpDetalle.Controls.Add(label7);
            grpDetalle.Controls.Add(dtpFechaVencimiento);
            grpDetalle.Controls.Add(label6);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(btnCancelar);
            grpDetalle.Controls.Add(btnGuardar);
            grpDetalle.Controls.Add(btnPrecuenta);
            grpDetalle.Controls.Add(btnProcesar);
            grpDetalle.Dock = DockStyle.Fill;
            grpDetalle.Location = new Point(731, 3);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(602, 477);
            grpDetalle.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 340);
            label10.Name = "label10";
            label10.Size = new Size(145, 25);
            label10.TabIndex = 18;
            label10.Text = "Saldo pendiente:";
            // 
            // txtSaldoPendiente
            // 
            txtSaldoPendiente.Location = new Point(170, 334);
            txtSaldoPendiente.Name = "txtSaldoPendiente";
            txtSaldoPendiente.ReadOnly = true;
            txtSaldoPendiente.Size = new Size(106, 31);
            txtSaldoPendiente.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(71, 291);
            label9.Name = "label9";
            label9.Size = new Size(62, 25);
            label9.TabIndex = 13;
            label9.Text = "Vence:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(441, 334);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(106, 31);
            txtSubTotal.TabIndex = 16;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(441, 288);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(106, 31);
            txtTotal.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 291);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 14;
            label7.Text = "TOTAL:";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(139, 288);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(137, 31);
            dtpFechaVencimiento.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 337);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 13;
            label6.Text = "Sub-Total:";
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(6, 9);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.Size = new Size(587, 266);
            dgvDetalle.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(163, 408);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 60);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(15, 408);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 60);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnPrecuenta
            // 
            btnPrecuenta.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPrecuenta.IconColor = Color.Black;
            btnPrecuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrecuenta.Location = new Point(314, 408);
            btnPrecuenta.Name = "btnPrecuenta";
            btnPrecuenta.Size = new Size(130, 60);
            btnPrecuenta.TabIndex = 6;
            btnPrecuenta.Text = "Precuenta";
            btnPrecuenta.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            btnProcesar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProcesar.IconColor = Color.Black;
            btnProcesar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProcesar.Location = new Point(463, 408);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(130, 60);
            btnProcesar.TabIndex = 5;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            Titulo.Controls.Add(label8);
            Titulo.Controls.Add(dtpFechaCreacion);
            Titulo.Controls.Add(label3);
            Titulo.Controls.Add(label2);
            Titulo.Controls.Add(label1);
            Titulo.Controls.Add(cmbMetodoPago);
            Titulo.Controls.Add(cmbCondicion);
            Titulo.Controls.Add(btnBuscarCliente);
            Titulo.Controls.Add(cmbCliente);
            Titulo.Controls.Add(lbEmpleado);
            Titulo.Controls.Add(lbSalaMesa);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1336, 179);
            Titulo.TabIndex = 3;
            Titulo.Paint += Titulo_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 85);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 12;
            label8.Text = "Creacion:";
            // 
            // dtpFechaCreacion
            // 
            dtpFechaCreacion.Location = new Point(338, 79);
            dtpFechaCreacion.Name = "dtpFechaCreacion";
            dtpFechaCreacion.Size = new Size(137, 31);
            dtpFechaCreacion.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(885, 35);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 9;
            label3.Text = "Condicion de Pago:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(901, 101);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 8;
            label2.Text = "Metodo de Pago:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 40);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 7;
            label1.Text = "Cliente:";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(1066, 98);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(258, 33);
            cmbMetodoPago.TabIndex = 6;
            // 
            // cmbCondicion
            // 
            cmbCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Location = new Point(1066, 32);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(258, 33);
            cmbCondicion.TabIndex = 5;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarCliente.IconColor = Color.Black;
            btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarCliente.Location = new Point(634, 22);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(130, 60);
            btnBuscarCliente.TabIndex = 4;
            btnBuscarCliente.Text = "Buscar Cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(338, 29);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(258, 33);
            cmbCliente.TabIndex = 3;
            // 
            // lbEmpleado
            // 
            lbEmpleado.AutoSize = true;
            lbEmpleado.BorderStyle = BorderStyle.FixedSingle;
            lbEmpleado.Location = new Point(30, 101);
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
            ClientSize = new Size(1336, 662);
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
        private FontAwesome.Sharp.IconButton btnCancelar;
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
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private TextBox txtSubTotal;
        private TextBox txtTotal;
        private Label label10;
        private TextBox txtSaldoPendiente;
        private Label label9;
        private DateTimePicker dtpFechaVencimiento;
        private Label label8;
        private DateTimePicker dtpFechaCreacion;
    }
}