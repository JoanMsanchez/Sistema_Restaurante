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
            panel2 = new Panel();
            btnPasarADistribucion = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            txtTotalAplicado = new TextBox();
            txtDiferenciaValor = new TextBox();
            txtAplicadoValor = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            dgvOrdenesPendientes = new DataGridView();
            label9 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            btnQuitarSeleccion = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnAplicarAuto = new FontAwesome.Sharp.IconButton();
            txtTotalCobrarValor = new TextBox();
            label11 = new Label();
            observaciones = new TextBox();
            dgvDistribucion = new DataGridView();
            label10 = new Label();
            label7 = new Label();
            Cabecera = new Panel();
            txtNota = new TextBox();
            label4 = new Label();
            txtMontoTotal = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cboMetodoPago = new ComboBox();
            label12 = new Label();
            txtEmpleado = new Label();
            txtFechaPago = new TextBox();
            label8 = new Label();
            label1 = new Label();
            btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            cboClienteFiltro = new ComboBox();
            Titulo = new Panel();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesPendientes).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistribucion).BeginInit();
            Cabecera.SuspendLayout();
            Titulo.SuspendLayout();
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
            // panel2
            // 
            panel2.Controls.Add(btnPasarADistribucion);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(dgvOrdenesPendientes);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(859, 873);
            panel2.TabIndex = 0;
            // 
            // btnPasarADistribucion
            // 
            btnPasarADistribucion.FlatAppearance.BorderSize = 0;
            btnPasarADistribucion.FlatStyle = FlatStyle.Flat;
            btnPasarADistribucion.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnPasarADistribucion.ForeColor = Color.White;
            btnPasarADistribucion.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            btnPasarADistribucion.IconColor = Color.White;
            btnPasarADistribucion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPasarADistribucion.IconSize = 35;
            btnPasarADistribucion.ImageAlign = ContentAlignment.MiddleLeft;
            btnPasarADistribucion.Location = new Point(656, 256);
            btnPasarADistribucion.Margin = new Padding(2);
            btnPasarADistribucion.Name = "btnPasarADistribucion";
            btnPasarADistribucion.Size = new Size(192, 60);
            btnPasarADistribucion.TabIndex = 35;
            btnPasarADistribucion.Text = "Agregar";
            btnPasarADistribucion.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Tan;
            panel4.Controls.Add(txtTotalAplicado);
            panel4.Controls.Add(txtDiferenciaValor);
            panel4.Controls.Add(txtAplicadoValor);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(10, 652);
            panel4.Name = "panel4";
            panel4.Size = new Size(838, 203);
            panel4.TabIndex = 29;
            // 
            // txtTotalAplicado
            // 
            txtTotalAplicado.BackColor = Color.White;
            txtTotalAplicado.Font = new Font("Verdana", 10.2F);
            txtTotalAplicado.ForeColor = Color.Black;
            txtTotalAplicado.Location = new Point(576, 155);
            txtTotalAplicado.Margin = new Padding(2);
            txtTotalAplicado.Name = "txtTotalAplicado";
            txtTotalAplicado.ReadOnly = true;
            txtTotalAplicado.Size = new Size(190, 32);
            txtTotalAplicado.TabIndex = 24;
            // 
            // txtDiferenciaValor
            // 
            txtDiferenciaValor.BackColor = Color.White;
            txtDiferenciaValor.Font = new Font("Verdana", 10.2F);
            txtDiferenciaValor.ForeColor = Color.Black;
            txtDiferenciaValor.Location = new Point(576, 91);
            txtDiferenciaValor.Margin = new Padding(2);
            txtDiferenciaValor.Name = "txtDiferenciaValor";
            txtDiferenciaValor.ReadOnly = true;
            txtDiferenciaValor.Size = new Size(190, 32);
            txtDiferenciaValor.TabIndex = 23;
            // 
            // txtAplicadoValor
            // 
            txtAplicadoValor.BackColor = Color.White;
            txtAplicadoValor.Font = new Font("Verdana", 10.2F);
            txtAplicadoValor.ForeColor = Color.Black;
            txtAplicadoValor.Location = new Point(576, 28);
            txtAplicadoValor.Margin = new Padding(2);
            txtAplicadoValor.Name = "txtAplicadoValor";
            txtAplicadoValor.ReadOnly = true;
            txtAplicadoValor.Size = new Size(190, 32);
            txtAplicadoValor.TabIndex = 22;
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
            // dgvOrdenesPendientes
            // 
            dgvOrdenesPendientes.BackgroundColor = Color.White;
            dgvOrdenesPendientes.BorderStyle = BorderStyle.Fixed3D;
            dgvOrdenesPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenesPendientes.Location = new Point(10, 317);
            dgvOrdenesPendientes.Margin = new Padding(4);
            dgvOrdenesPendientes.Name = "dgvOrdenesPendientes";
            dgvOrdenesPendientes.RowHeadersWidth = 51;
            dgvOrdenesPendientes.Size = new Size(838, 255);
            dgvOrdenesPendientes.TabIndex = 28;
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
            // panel3
            // 
            panel3.Controls.Add(btnQuitarSeleccion);
            panel3.Controls.Add(btnLimpiar);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(btnAplicarAuto);
            panel3.Controls.Add(txtTotalCobrarValor);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(observaciones);
            panel3.Controls.Add(dgvDistribucion);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(868, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(860, 873);
            panel3.TabIndex = 1;
            // 
            // btnQuitarSeleccion
            // 
            btnQuitarSeleccion.FlatAppearance.BorderSize = 0;
            btnQuitarSeleccion.FlatStyle = FlatStyle.Flat;
            btnQuitarSeleccion.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnQuitarSeleccion.ForeColor = Color.White;
            btnQuitarSeleccion.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnQuitarSeleccion.IconColor = Color.White;
            btnQuitarSeleccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitarSeleccion.IconSize = 35;
            btnQuitarSeleccion.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuitarSeleccion.Location = new Point(658, 256);
            btnQuitarSeleccion.Margin = new Padding(2);
            btnQuitarSeleccion.Name = "btnQuitarSeleccion";
            btnQuitarSeleccion.Size = new Size(192, 60);
            btnQuitarSeleccion.TabIndex = 36;
            btnQuitarSeleccion.Text = "Quitar";
            btnQuitarSeleccion.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 35;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(685, 804);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(154, 60);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = true;
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
            btnCancelar.Location = new Point(218, 807);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 60);
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
            btnGuardar.Location = new Point(26, 804);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(165, 60);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "    Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAplicarAuto
            // 
            btnAplicarAuto.FlatAppearance.BorderSize = 0;
            btnAplicarAuto.FlatStyle = FlatStyle.Flat;
            btnAplicarAuto.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnAplicarAuto.ForeColor = Color.White;
            btnAplicarAuto.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAplicarAuto.IconColor = Color.White;
            btnAplicarAuto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAplicarAuto.Location = new Point(537, 805);
            btnAplicarAuto.Margin = new Padding(2);
            btnAplicarAuto.Name = "btnAplicarAuto";
            btnAplicarAuto.Size = new Size(126, 60);
            btnAplicarAuto.TabIndex = 33;
            btnAplicarAuto.Text = "Aplicar";
            btnAplicarAuto.UseVisualStyleBackColor = true;
            // 
            // txtTotalCobrarValor
            // 
            txtTotalCobrarValor.BackColor = Color.FromArgb(255, 161, 43);
            txtTotalCobrarValor.Font = new Font("Verdana", 10.2F);
            txtTotalCobrarValor.ForeColor = Color.White;
            txtTotalCobrarValor.Location = new Point(553, 652);
            txtTotalCobrarValor.Margin = new Padding(2);
            txtTotalCobrarValor.Name = "txtTotalCobrarValor";
            txtTotalCobrarValor.ReadOnly = true;
            txtTotalCobrarValor.Size = new Size(199, 32);
            txtTotalCobrarValor.TabIndex = 30;
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
            // dgvDistribucion
            // 
            dgvDistribucion.BackgroundColor = Color.White;
            dgvDistribucion.BorderStyle = BorderStyle.Fixed3D;
            dgvDistribucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistribucion.Location = new Point(13, 317);
            dgvDistribucion.Margin = new Padding(4);
            dgvDistribucion.Name = "dgvDistribucion";
            dgvDistribucion.RowHeadersWidth = 51;
            dgvDistribucion.Size = new Size(837, 255);
            dgvDistribucion.TabIndex = 27;
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
            // Cabecera
            // 
            Cabecera.BackColor = Color.FromArgb(255, 161, 43);
            Cabecera.BorderStyle = BorderStyle.Fixed3D;
            Cabecera.Controls.Add(txtNota);
            Cabecera.Controls.Add(label4);
            Cabecera.Controls.Add(txtMontoTotal);
            Cabecera.Controls.Add(label3);
            Cabecera.Controls.Add(label2);
            Cabecera.Controls.Add(cboMetodoPago);
            Cabecera.Controls.Add(label12);
            Cabecera.Controls.Add(txtEmpleado);
            Cabecera.Controls.Add(txtFechaPago);
            Cabecera.Controls.Add(label8);
            Cabecera.Controls.Add(label1);
            Cabecera.Controls.Add(btnBuscarCliente);
            Cabecera.Controls.Add(cboClienteFiltro);
            Cabecera.Controls.Add(Titulo);
            Cabecera.Dock = DockStyle.Top;
            Cabecera.Location = new Point(0, 0);
            Cabecera.Name = "Cabecera";
            Cabecera.Size = new Size(1731, 260);
            Cabecera.TabIndex = 1;
            // 
            // txtNota
            // 
            txtNota.BackColor = Color.FromArgb(255, 161, 43);
            txtNota.Font = new Font("Verdana", 10.2F);
            txtNota.ForeColor = Color.White;
            txtNota.Location = new Point(881, 207);
            txtNota.Margin = new Padding(2);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(536, 32);
            txtNota.TabIndex = 23;
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
            // txtMontoTotal
            // 
            txtMontoTotal.BackColor = Color.FromArgb(255, 161, 43);
            txtMontoTotal.Font = new Font("Verdana", 10.2F);
            txtMontoTotal.ForeColor = Color.White;
            txtMontoTotal.Location = new Point(1247, 125);
            txtMontoTotal.Margin = new Padding(2);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(170, 32);
            txtMontoTotal.TabIndex = 21;
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
            // cboMetodoPago
            // 
            cboMetodoPago.BackColor = Color.FromArgb(255, 161, 43);
            cboMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetodoPago.FlatStyle = FlatStyle.Flat;
            cboMetodoPago.Font = new Font("Verdana", 10.2F);
            cboMetodoPago.ForeColor = Color.White;
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.Location = new Point(881, 122);
            cboMetodoPago.Margin = new Padding(2);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(192, 33);
            cboMetodoPago.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(304, 171);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(161, 29);
            label12.TabIndex = 17;
            label12.Text = "Enmpleado";
            // 
            // txtEmpleado
            // 
            txtEmpleado.BackColor = Color.FromArgb(255, 161, 43);
            txtEmpleado.FlatStyle = FlatStyle.Flat;
            txtEmpleado.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmpleado.ForeColor = Color.White;
            txtEmpleado.Location = new Point(291, 207);
            txtEmpleado.Margin = new Padding(2, 0, 2, 0);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(198, 31);
            txtEmpleado.TabIndex = 16;
            txtEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFechaPago
            // 
            txtFechaPago.BackColor = Color.FromArgb(255, 161, 43);
            txtFechaPago.Font = new Font("Verdana", 10.2F);
            txtFechaPago.ForeColor = Color.White;
            txtFechaPago.Location = new Point(18, 206);
            txtFechaPago.Margin = new Padding(4);
            txtFechaPago.Name = "txtFechaPago";
            txtFechaPago.ReadOnly = true;
            txtFechaPago.Size = new Size(215, 32);
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
            // cboClienteFiltro
            // 
            cboClienteFiltro.BackColor = Color.FromArgb(255, 161, 43);
            cboClienteFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClienteFiltro.FlatStyle = FlatStyle.Flat;
            cboClienteFiltro.Font = new Font("Verdana", 10.2F);
            cboClienteFiltro.ForeColor = Color.White;
            cboClienteFiltro.FormattingEnabled = true;
            cboClienteFiltro.Location = new Point(156, 99);
            cboClienteFiltro.Margin = new Padding(2);
            cboClienteFiltro.Name = "cboClienteFiltro";
            cboClienteFiltro.Size = new Size(258, 33);
            cboClienteFiltro.TabIndex = 8;
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.White;
            Titulo.Controls.Add(btnMaximizar);
            Titulo.Controls.Add(btnCerrar);
            Titulo.Controls.Add(btnMinimizar);
            Titulo.Controls.Add(label6);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1727, 70);
            Titulo.TabIndex = 0;
            Titulo.MouseDown += Titulo_MouseDown;
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
            btnMaximizar.Location = new Point(1645, 0);
            btnMaximizar.Margin = new Padding(2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(45, 25);
            btnMaximizar.TabIndex = 15;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
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
            btnCerrar.Location = new Point(1682, 0);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 25);
            btnCerrar.TabIndex = 16;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
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
            btnMinimizar.Location = new Point(1601, 0);
            btnMinimizar.Margin = new Padding(2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 25);
            btnMinimizar.TabIndex = 14;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
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
            // ProcesoRegistroPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1731, 879);
            Controls.Add(Cabecera);
            Controls.Add(tableLayoutPanel1);
            Name = "ProcesoRegistroPago";
            Text = "ProcesoRegistroPago";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesPendientes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistribucion).EndInit();
            Cabecera.ResumeLayout(false);
            Cabecera.PerformLayout();
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel Cabecera;
        private Panel Titulo;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private ComboBox cboClienteFiltro;
        private Label label8;
        private Label label12;
        private Label txtEmpleado;
        private Label label2;
        private ComboBox cboMetodoPago;
        private Label label3;
        private Label label4;
        private TextBox txtMontoTotal;
        private TextBox txtNota;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label9;
        private Label label10;
        private Label label7;
        private Panel panel4;
        private DataGridView dgvOrdenesPendientes;
        private DataGridView dgvDistribucion;
        private TextBox txtTotalCobrarValor;
        private Label label11;
        private TextBox observaciones;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnAplicarAuto;
        private TextBox txtTotalAplicado;
        private TextBox txtDiferenciaValor;
        private TextBox txtAplicadoValor;
        private Label label15;
        private Label label14;
        private Label label13;
        private FontAwesome.Sharp.IconButton btnPasarADistribucion;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnQuitarSeleccion;
        private TextBox txtFechaPago;
    }
}