namespace Proyecto_Restaurante.Proceso
{
    partial class ProcesoRegistroPago
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Titulo = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            cmbCliente = new ComboBox();
            txtFechaPago = new TextBox();
            label8 = new Label();
            label12 = new Label();
            lbEmpleado = new Label();
            label2 = new Label();
            cmbMetodoPago = new ComboBox();
            label3 = new Label();
            txtTotal = new TextBox();
            label4 = new Label();
            txtNota = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            dgvDistribucionPago = new DataGridView();
            dgvOrdenesSaldoPendiente = new DataGridView();
            panel4 = new Panel();
            observaciones = new TextBox();
            label11 = new Label();
            CobroTotal = new TextBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnAplicar = new FontAwesome.Sharp.IconButton();
            btnRecibo = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtAplicado = new TextBox();
            txtDiferencia = new TextBox();
            txtTotalAplicado = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            Titulo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistribucionPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesSaldoPendiente).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 161, 43);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1731, 879);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.FromArgb(255, 161, 43);
            Titulo.Controls.Add(txtNota);
            Titulo.Controls.Add(label4);
            Titulo.Controls.Add(txtTotal);
            Titulo.Controls.Add(label3);
            Titulo.Controls.Add(label2);
            Titulo.Controls.Add(cmbMetodoPago);
            Titulo.Controls.Add(label12);
            Titulo.Controls.Add(lbEmpleado);
            Titulo.Controls.Add(txtFechaPago);
            Titulo.Controls.Add(label8);
            Titulo.Controls.Add(label1);
            Titulo.Controls.Add(btnBuscarCliente);
            Titulo.Controls.Add(cmbCliente);
            Titulo.Controls.Add(panel1);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1731, 260);
            Titulo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1731, 70);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 161, 43);
            label6.Location = new Point(13, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(424, 44);
            label6.TabIndex = 3;
            label6.Text = "REGISTRO DE PAGO";
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.CornflowerBlue;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizar.IconColor = Color.OldLace;
            btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizar.IconSize = 20;
            btnMaximizar.Location = new Point(1649, 0);
            btnMaximizar.Margin = new Padding(2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(45, 25);
            btnMaximizar.TabIndex = 15;
            btnMaximizar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.Tomato;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrar.IconColor = Color.OldLace;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrar.IconSize = 20;
            btnCerrar.Location = new Point(1686, 0);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 25);
            btnCerrar.TabIndex = 16;
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.Turquoise;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizar.IconColor = Color.OldLace;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizar.IconSize = 20;
            btnMinimizar.Location = new Point(1605, 0);
            btnMinimizar.Margin = new Padding(2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 25);
            btnMinimizar.TabIndex = 14;
            btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(18, 101);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 29);
            label1.TabIndex = 10;
            label1.Text = "Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.ForeColor = Color.FromArgb(255, 161, 43);
            btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarCliente.IconColor = Color.White;
            btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarCliente.IconSize = 30;
            btnBuscarCliente.Location = new Point(420, 95);
            btnBuscarCliente.Margin = new Padding(2);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(51, 41);
            btnBuscarCliente.TabIndex = 9;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // cmbCliente
            // 
            cmbCliente.BackColor = Color.FromArgb(255, 161, 43);
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FlatStyle = FlatStyle.Flat;
            cmbCliente.Font = new Font("Verdana", 10.2F);
            cmbCliente.ForeColor = Color.White;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(156, 99);
            cmbCliente.Margin = new Padding(2);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(258, 33);
            cmbCliente.TabIndex = 8;
            // 
            // txtFechaPago
            // 
            txtFechaPago.BackColor = Color.FromArgb(255, 161, 43);
            txtFechaPago.BorderStyle = BorderStyle.FixedSingle;
            txtFechaPago.Font = new Font("Verdana", 10.2F);
            txtFechaPago.ForeColor = Color.White;
            txtFechaPago.Location = new Point(18, 205);
            txtFechaPago.Margin = new Padding(4);
            txtFechaPago.Name = "txtFechaPago";
            txtFechaPago.ReadOnly = true;
            txtFechaPago.Size = new Size(156, 32);
            txtFechaPago.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(18, 171);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(215, 29);
            label8.TabIndex = 14;
            label8.Text = "Fecha del pago";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(267, 171);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(161, 29);
            label12.TabIndex = 17;
            label12.Text = "Enmpleado";
            // 
            // lbEmpleado
            // 
            lbEmpleado.BackColor = Color.FromArgb(255, 161, 43);
            lbEmpleado.FlatStyle = FlatStyle.Flat;
            lbEmpleado.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmpleado.ForeColor = Color.White;
            lbEmpleado.Location = new Point(267, 206);
            lbEmpleado.Margin = new Padding(2, 0, 2, 0);
            lbEmpleado.Name = "lbEmpleado";
            lbEmpleado.Size = new Size(198, 31);
            lbEmpleado.TabIndex = 16;
            lbEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(881, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(228, 29);
            label2.TabIndex = 19;
            label2.Text = "Metodo de Pago";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.BackColor = Color.FromArgb(255, 161, 43);
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.FlatStyle = FlatStyle.Flat;
            cmbMetodoPago.Font = new Font("Verdana", 10.2F);
            cmbMetodoPago.ForeColor = Color.White;
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(881, 122);
            cmbMetodoPago.Margin = new Padding(2);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(192, 33);
            cmbMetodoPago.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(1247, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 29);
            label3.TabIndex = 20;
            label3.Text = "Monto Total";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(255, 161, 43);
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Verdana", 10.2F);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(1247, 125);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(156, 25);
            txtTotal.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(881, 171);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 29);
            label4.TabIndex = 22;
            label4.Text = "Nota";
            // 
            // txtNota
            // 
            txtNota.BackColor = Color.FromArgb(255, 161, 43);
            txtNota.BorderStyle = BorderStyle.None;
            txtNota.Font = new Font("Verdana", 10.2F);
            txtNota.ForeColor = Color.White;
            txtNota.Location = new Point(881, 202);
            txtNota.Margin = new Padding(2);
            txtNota.Name = "txtNota";
            txtNota.ReadOnly = true;
            txtNota.Size = new Size(156, 25);
            txtNota.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(dgvOrdenesSaldoPendiente);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(859, 873);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(btnAplicar);
            panel3.Controls.Add(btnRecibo);
            panel3.Controls.Add(CobroTotal);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(observaciones);
            panel3.Controls.Add(dgvDistribucionPago);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(868, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(860, 873);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(4, 272);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(402, 29);
            label5.TabIndex = 24;
            label5.Text = "Ordenes con saldo pendiente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(13, 272);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(310, 29);
            label7.TabIndex = 25;
            label7.Text = "Dristribucion del pago";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(10, 610);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(167, 29);
            label9.TabIndex = 25;
            label9.Text = "Resumenes";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(13, 610);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(209, 29);
            label10.TabIndex = 26;
            label10.Text = "Observaciones";
            // 
            // dgvDistribucionPago
            // 
            dgvDistribucionPago.BackgroundColor = Color.White;
            dgvDistribucionPago.BorderStyle = BorderStyle.None;
            dgvDistribucionPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistribucionPago.Location = new Point(13, 317);
            dgvDistribucionPago.Margin = new Padding(4);
            dgvDistribucionPago.Name = "dgvDistribucionPago";
            dgvDistribucionPago.RowHeadersWidth = 51;
            dgvDistribucionPago.Size = new Size(837, 255);
            dgvDistribucionPago.TabIndex = 27;
            // 
            // dgvOrdenesSaldoPendiente
            // 
            dgvOrdenesSaldoPendiente.BackgroundColor = Color.White;
            dgvOrdenesSaldoPendiente.BorderStyle = BorderStyle.None;
            dgvOrdenesSaldoPendiente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenesSaldoPendiente.Location = new Point(10, 317);
            dgvOrdenesSaldoPendiente.Margin = new Padding(4);
            dgvOrdenesSaldoPendiente.Name = "dgvOrdenesSaldoPendiente";
            dgvOrdenesSaldoPendiente.RowHeadersWidth = 51;
            dgvOrdenesSaldoPendiente.Size = new Size(838, 255);
            dgvOrdenesSaldoPendiente.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Tan;
            panel4.Controls.Add(txtTotalAplicado);
            panel4.Controls.Add(txtDiferencia);
            panel4.Controls.Add(txtAplicado);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(10, 652);
            panel4.Name = "panel4";
            panel4.Size = new Size(838, 203);
            panel4.TabIndex = 29;
            // 
            // observaciones
            // 
            observaciones.BackColor = Color.FromArgb(255, 161, 43);
            observaciones.Font = new Font("Verdana", 10.2F);
            observaciones.ForeColor = Color.White;
            observaciones.Location = new Point(13, 652);
            observaciones.Margin = new Padding(4);
            observaciones.Multiline = true;
            observaciones.Name = "observaciones";
            observaciones.Size = new Size(299, 116);
            observaciones.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(553, 610);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(199, 29);
            label11.TabIndex = 29;
            label11.Text = "Total a cobrar";
            // 
            // CobroTotal
            // 
            CobroTotal.BackColor = Color.FromArgb(255, 161, 43);
            CobroTotal.BorderStyle = BorderStyle.None;
            CobroTotal.Font = new Font("Verdana", 10.2F);
            CobroTotal.ForeColor = Color.White;
            CobroTotal.Location = new Point(553, 652);
            CobroTotal.Margin = new Padding(2);
            CobroTotal.Name = "CobroTotal";
            CobroTotal.ReadOnly = true;
            CobroTotal.Size = new Size(156, 25);
            CobroTotal.TabIndex = 30;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 35;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(228, 795);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(192, 60);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "    Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 35;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(23, 795);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 60);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "    Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAplicar.IconColor = Color.White;
            btnAplicar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAplicar.Location = new Point(444, 795);
            btnAplicar.Margin = new Padding(2);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(190, 60);
            btnAplicar.TabIndex = 33;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            // 
            // btnRecibo
            // 
            btnRecibo.FlatAppearance.BorderSize = 0;
            btnRecibo.FlatStyle = FlatStyle.Flat;
            btnRecibo.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnRecibo.ForeColor = Color.White;
            btnRecibo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRecibo.IconColor = Color.White;
            btnRecibo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRecibo.Location = new Point(661, 795);
            btnRecibo.Margin = new Padding(2);
            btnRecibo.Name = "btnRecibo";
            btnRecibo.Size = new Size(176, 60);
            btnRecibo.TabIndex = 32;
            btnRecibo.Text = "Recibo";
            btnRecibo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(21, 24);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(128, 29);
            label13.TabIndex = 11;
            label13.Text = "Aplicado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(21, 87);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(394, 29);
            label14.TabIndex = 12;
            label14.Text = "Diferencia (Total - Aplicado)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label15.ForeColor = Color.WhiteSmoke;
            label15.Location = new Point(21, 152);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(200, 29);
            label15.TabIndex = 13;
            label15.Text = "Total aplicado";
            // 
            // txtAplicado
            // 
            txtAplicado.BackColor = Color.White;
            txtAplicado.BorderStyle = BorderStyle.None;
            txtAplicado.Font = new Font("Verdana", 10.2F);
            txtAplicado.ForeColor = Color.Black;
            txtAplicado.Location = new Point(576, 28);
            txtAplicado.Margin = new Padding(2);
            txtAplicado.Name = "txtAplicado";
            txtAplicado.ReadOnly = true;
            txtAplicado.Size = new Size(190, 25);
            txtAplicado.TabIndex = 22;
            // 
            // txtDiferencia
            // 
            txtDiferencia.BackColor = Color.White;
            txtDiferencia.BorderStyle = BorderStyle.None;
            txtDiferencia.Font = new Font("Verdana", 10.2F);
            txtDiferencia.ForeColor = Color.Black;
            txtDiferencia.Location = new Point(576, 91);
            txtDiferencia.Margin = new Padding(2);
            txtDiferencia.Name = "txtDiferencia";
            txtDiferencia.ReadOnly = true;
            txtDiferencia.Size = new Size(190, 25);
            txtDiferencia.TabIndex = 23;
            // 
            // txtTotalAplicado
            // 
            txtTotalAplicado.BackColor = Color.White;
            txtTotalAplicado.BorderStyle = BorderStyle.None;
            txtTotalAplicado.Font = new Font("Verdana", 10.2F);
            txtTotalAplicado.ForeColor = Color.Black;
            txtTotalAplicado.Location = new Point(576, 155);
            txtTotalAplicado.Margin = new Padding(2);
            txtTotalAplicado.Name = "txtTotalAplicado";
            txtTotalAplicado.ReadOnly = true;
            txtTotalAplicado.Size = new Size(190, 25);
            txtTotalAplicado.TabIndex = 24;
            // 
            // ProcesoRegistroPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1731, 879);
            Controls.Add(Titulo);
            Controls.Add(tableLayoutPanel1);
            Name = "ProcesoRegistroPago";
            Text = "ProcesoRegistroPago";
            tableLayoutPanel1.ResumeLayout(false);
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistribucionPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesSaldoPendiente).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel Titulo;
        private Panel panel1;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private ComboBox cmbCliente;
        private TextBox txtFechaPago;
        private Label label8;
        private Label label12;
        private Label lbEmpleado;
        private Label label2;
        private ComboBox cmbMetodoPago;
        private Label label3;
        private Label label4;
        private TextBox txtTotal;
        private TextBox txtNota;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label9;
        private Label label10;
        private Label label7;
        private Panel panel4;
        private DataGridView dgvOrdenesSaldoPendiente;
        private DataGridView dgvDistribucionPago;
        private TextBox CobroTotal;
        private Label label11;
        private TextBox observaciones;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnAplicar;
        private FontAwesome.Sharp.IconButton btnRecibo;
        private TextBox txtTotalAplicado;
        private TextBox txtDiferencia;
        private TextBox txtAplicado;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}