using System.ComponentModel;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ProcesoFacturacion));
            tlpMain = new TableLayoutPanel();
            grpCatalogo = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            cmbCategoria = new ComboBox();
            flpCatalogo = new FlowLayoutPanel();
            txtBuscarProd = new TextBox();
            grpDetalle = new Panel();
            dgvDetalle = new DataGridView();
            txtITEBIS = new TextBox();
            label11 = new Label();
            txtVence = new TextBox();
            label10 = new Label();
            txtSaldoPendiente = new TextBox();
            label9 = new Label();
            txtSubTotal = new TextBox();
            txtTotal = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnPrecuenta = new FontAwesome.Sharp.IconButton();
            btnProcesar = new FontAwesome.Sharp.IconButton();
            Titulo = new Panel();
            panelFacturacion = new Panel();
            label14 = new Label();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            lbSalaMesa = new Label();
            label12 = new Label();
            txtCondicionPago = new TextBox();
            txtCreacion = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbMetodoPago = new ComboBox();
            btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            cmbCliente = new ComboBox();
            lbEmpleado = new Label();
            pictureBox1 = new PictureBox();
            tlpMain.SuspendLayout();
            grpCatalogo.SuspendLayout();
            grpDetalle.SuspendLayout();
            ((ISupportInitialize)dgvDetalle).BeginInit();
            Titulo.SuspendLayout();
            panelFacturacion.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.1272736F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.8727264F));
            tlpMain.Controls.Add(grpCatalogo, 0, 0);
            tlpMain.Controls.Add(grpDetalle, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 203);
            tlpMain.Margin = new Padding(2);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1340, 477);
            tlpMain.TabIndex = 2;
            // 
            // grpCatalogo
            // 
            grpCatalogo.Controls.Add(panel2);
            grpCatalogo.Controls.Add(label5);
            grpCatalogo.Controls.Add(label4);
            grpCatalogo.Controls.Add(cmbCategoria);
            grpCatalogo.Controls.Add(flpCatalogo);
            grpCatalogo.Controls.Add(txtBuscarProd);
            grpCatalogo.Dock = DockStyle.Fill;
            grpCatalogo.Location = new Point(2, 2);
            grpCatalogo.Margin = new Padding(2);
            grpCatalogo.Name = "grpCatalogo";
            grpCatalogo.Size = new Size(627, 473);
            grpCatalogo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(18, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 2);
            panel2.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(336, 7);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(269, 25);
            label5.TabIndex = 11;
            label5.Text = "Categoria de producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(36, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(211, 25);
            label4.TabIndex = 10;
            label4.Text = "Buscar producto: ";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(255, 161, 43);
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Verdana", 10.2F);
            cmbCategoria.ForeColor = Color.White;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(350, 39);
            cmbCategoria.Margin = new Padding(2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(230, 28);
            cmbCategoria.TabIndex = 8;
            // 
            // flpCatalogo
            // 
            flpCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCatalogo.AutoScroll = true;
            flpCatalogo.Location = new Point(2, 82);
            flpCatalogo.Margin = new Padding(2);
            flpCatalogo.Name = "flpCatalogo";
            flpCatalogo.Size = new Size(623, 389);
            flpCatalogo.TabIndex = 9;
            // 
            // txtBuscarProd
            // 
            txtBuscarProd.BackColor = Color.FromArgb(255, 161, 43);
            txtBuscarProd.BorderStyle = BorderStyle.None;
            txtBuscarProd.Font = new Font("Verdana", 10.2F);
            txtBuscarProd.ForeColor = Color.White;
            txtBuscarProd.Location = new Point(22, 39);
            txtBuscarProd.Margin = new Padding(2);
            txtBuscarProd.Name = "txtBuscarProd";
            txtBuscarProd.Size = new Size(241, 21);
            txtBuscarProd.TabIndex = 7;
            txtBuscarProd.KeyPress += txtBuscarProd_KeyPress;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(txtITEBIS);
            grpDetalle.Controls.Add(label11);
            grpDetalle.Controls.Add(txtVence);
            grpDetalle.Controls.Add(label10);
            grpDetalle.Controls.Add(txtSaldoPendiente);
            grpDetalle.Controls.Add(label9);
            grpDetalle.Controls.Add(txtSubTotal);
            grpDetalle.Controls.Add(txtTotal);
            grpDetalle.Controls.Add(label7);
            grpDetalle.Controls.Add(label6);
            grpDetalle.Controls.Add(btnCancelar);
            grpDetalle.Controls.Add(btnGuardar);
            grpDetalle.Controls.Add(btnPrecuenta);
            grpDetalle.Controls.Add(btnProcesar);
            grpDetalle.Dock = DockStyle.Fill;
            grpDetalle.Location = new Point(633, 2);
            grpDetalle.Margin = new Padding(2);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(705, 473);
            grpDetalle.TabIndex = 1;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(39, 20);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.Size = new Size(638, 207);
            dgvDetalle.TabIndex = 22;
            // 
            // txtITEBIS
            // 
            txtITEBIS.BackColor = Color.FromArgb(255, 161, 43);
            txtITEBIS.BorderStyle = BorderStyle.None;
            txtITEBIS.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtITEBIS.ForeColor = Color.White;
            txtITEBIS.Location = new Point(536, 295);
            txtITEBIS.Name = "txtITEBIS";
            txtITEBIS.Size = new Size(125, 21);
            txtITEBIS.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(395, 291);
            label11.Name = "label11";
            label11.Size = new Size(137, 25);
            label11.TabIndex = 20;
            label11.Text = "ITBIS 18%";
            // 
            // txtVence
            // 
            txtVence.BackColor = Color.FromArgb(255, 161, 43);
            txtVence.BorderStyle = BorderStyle.None;
            txtVence.Font = new Font("Verdana", 10.2F);
            txtVence.ForeColor = Color.White;
            txtVence.Location = new Point(215, 275);
            txtVence.Name = "txtVence";
            txtVence.ReadOnly = true;
            txtVence.Size = new Size(136, 21);
            txtVence.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(19, 325);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(192, 25);
            label10.TabIndex = 18;
            label10.Text = "Saldo pendiente";
            // 
            // txtSaldoPendiente
            // 
            txtSaldoPendiente.BackColor = Color.FromArgb(255, 161, 43);
            txtSaldoPendiente.BorderStyle = BorderStyle.None;
            txtSaldoPendiente.Font = new Font("Verdana", 10.2F);
            txtSaldoPendiente.ForeColor = Color.White;
            txtSaldoPendiente.Location = new Point(215, 329);
            txtSaldoPendiente.Margin = new Padding(2);
            txtSaldoPendiente.Name = "txtSaldoPendiente";
            txtSaldoPendiente.ReadOnly = true;
            txtSaldoPendiente.Size = new Size(136, 21);
            txtSaldoPendiente.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(131, 271);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 13;
            label9.Text = "Vence";
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.FromArgb(255, 161, 43);
            txtSubTotal.BorderStyle = BorderStyle.None;
            txtSubTotal.Font = new Font("Verdana", 10.2F);
            txtSubTotal.ForeColor = Color.White;
            txtSubTotal.Location = new Point(536, 250);
            txtSubTotal.Margin = new Padding(2);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(125, 21);
            txtSubTotal.TabIndex = 16;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(255, 161, 43);
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Verdana", 10.2F);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(536, 342);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 21);
            txtTotal.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(446, 338);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 14;
            label7.Text = "TOTAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(411, 246);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 13;
            label6.Text = "Sub-Total";
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
            btnCancelar.Location = new Point(183, 412);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 48);
            btnCancelar.TabIndex = 2;
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
            btnGuardar.Location = new Point(23, 412);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 48);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "    Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnPrecuenta
            // 
            btnPrecuenta.FlatAppearance.BorderSize = 0;
            btnPrecuenta.FlatStyle = FlatStyle.Flat;
            btnPrecuenta.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnPrecuenta.ForeColor = Color.White;
            btnPrecuenta.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnPrecuenta.IconColor = Color.White;
            btnPrecuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrecuenta.IconSize = 35;
            btnPrecuenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrecuenta.Location = new Point(351, 412);
            btnPrecuenta.Margin = new Padding(2);
            btnPrecuenta.Name = "btnPrecuenta";
            btnPrecuenta.Size = new Size(181, 48);
            btnPrecuenta.TabIndex = 6;
            btnPrecuenta.Text = "   Precuenta";
            btnPrecuenta.UseVisualStyleBackColor = true;
            btnPrecuenta.Click += btnPrecuenta_Click;
            // 
            // btnProcesar
            // 
            btnProcesar.FlatAppearance.BorderSize = 0;
            btnProcesar.FlatStyle = FlatStyle.Flat;
            btnProcesar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnProcesar.ForeColor = Color.White;
            btnProcesar.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnProcesar.IconColor = Color.White;
            btnProcesar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProcesar.IconSize = 35;
            btnProcesar.ImageAlign = ContentAlignment.MiddleLeft;
            btnProcesar.Location = new Point(530, 412);
            btnProcesar.Margin = new Padding(2);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(166, 48);
            btnProcesar.TabIndex = 5;
            btnProcesar.Text = "    Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            Titulo.Controls.Add(panelFacturacion);
            Titulo.Controls.Add(label12);
            Titulo.Controls.Add(txtCondicionPago);
            Titulo.Controls.Add(txtCreacion);
            Titulo.Controls.Add(label8);
            Titulo.Controls.Add(label3);
            Titulo.Controls.Add(label2);
            Titulo.Controls.Add(label1);
            Titulo.Controls.Add(cmbMetodoPago);
            Titulo.Controls.Add(btnBuscarCliente);
            Titulo.Controls.Add(cmbCliente);
            Titulo.Controls.Add(lbEmpleado);
            Titulo.Controls.Add(pictureBox1);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Margin = new Padding(2);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1340, 203);
            Titulo.TabIndex = 3;
            Titulo.Paint += Titulo_Paint;
            // 
            // panelFacturacion
            // 
            panelFacturacion.BackColor = Color.White;
            panelFacturacion.Controls.Add(label14);
            panelFacturacion.Controls.Add(btnMaximizar);
            panelFacturacion.Controls.Add(btnCerrar);
            panelFacturacion.Controls.Add(btnMinimizar);
            panelFacturacion.Controls.Add(label13);
            panelFacturacion.Controls.Add(lbSalaMesa);
            panelFacturacion.Dock = DockStyle.Top;
            panelFacturacion.Location = new Point(0, 0);
            panelFacturacion.Margin = new Padding(2);
            panelFacturacion.Name = "panelFacturacion";
            panelFacturacion.Size = new Size(1340, 56);
            panelFacturacion.TabIndex = 16;
            panelFacturacion.Paint += panel1_Paint;
            panelFacturacion.MouseDown += panelFacturacion_MouseDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.DarkOrange;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Enabled = false;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(278, 8);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(2, 43);
            label14.TabIndex = 17;
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
            btnMaximizar.Location = new Point(1274, 0);
            btnMaximizar.Margin = new Padding(2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(36, 20);
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
            btnCerrar.Location = new Point(1304, 0);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(36, 20);
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
            btnMinimizar.Location = new Point(1239, 0);
            btnMinimizar.Margin = new Padding(2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(36, 20);
            btnMinimizar.TabIndex = 14;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(255, 161, 43);
            label13.Location = new Point(12, 7);
            label13.Name = "label13";
            label13.Size = new Size(259, 36);
            label13.TabIndex = 3;
            label13.Text = "FACTURACION";
            // 
            // lbSalaMesa
            // 
            lbSalaMesa.BackColor = Color.White;
            lbSalaMesa.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lbSalaMesa.ForeColor = Color.FromArgb(255, 161, 43);
            lbSalaMesa.Location = new Point(284, 18);
            lbSalaMesa.Margin = new Padding(2, 0, 2, 0);
            lbSalaMesa.Name = "lbSalaMesa";
            lbSalaMesa.Size = new Size(248, 30);
            lbSalaMesa.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(38, 106);
            label12.Name = "label12";
            label12.Size = new Size(122, 25);
            label12.TabIndex = 15;
            label12.Text = "Empleado";
            // 
            // txtCondicionPago
            // 
            txtCondicionPago.BackColor = Color.FromArgb(255, 161, 43);
            txtCondicionPago.BorderStyle = BorderStyle.None;
            txtCondicionPago.Font = new Font("Verdana", 10.2F);
            txtCondicionPago.ForeColor = Color.White;
            txtCondicionPago.Location = new Point(945, 105);
            txtCondicionPago.Name = "txtCondicionPago";
            txtCondicionPago.Size = new Size(154, 21);
            txtCondicionPago.TabIndex = 14;
            // 
            // txtCreacion
            // 
            txtCreacion.BackColor = Color.FromArgb(255, 161, 43);
            txtCreacion.BorderStyle = BorderStyle.None;
            txtCreacion.Font = new Font("Verdana", 10.2F);
            txtCreacion.ForeColor = Color.White;
            txtCreacion.Location = new Point(352, 146);
            txtCreacion.Name = "txtCreacion";
            txtCreacion.ReadOnly = true;
            txtCreacion.Size = new Size(125, 21);
            txtCreacion.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(222, 142);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 12;
            label8.Text = "Creacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(709, 101);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(219, 25);
            label3.TabIndex = 9;
            label3.Text = "Condicion de Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(736, 154);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 8;
            label2.Text = "Metodo de Pago";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(242, 106);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 7;
            label1.Text = "Cliente";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.BackColor = Color.FromArgb(255, 161, 43);
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.FlatStyle = FlatStyle.Flat;
            cmbMetodoPago.Font = new Font("Verdana", 10.2F);
            cmbMetodoPago.ForeColor = Color.White;
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(945, 150);
            cmbMetodoPago.Margin = new Padding(2);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(154, 28);
            cmbMetodoPago.TabIndex = 6;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.ForeColor = Color.FromArgb(255, 161, 43);
            btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarCliente.IconColor = Color.White;
            btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarCliente.IconSize = 30;
            btnBuscarCliente.Location = new Point(563, 101);
            btnBuscarCliente.Margin = new Padding(2);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(41, 33);
            btnBuscarCliente.TabIndex = 4;
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
            cmbCliente.Location = new Point(352, 104);
            cmbCliente.Margin = new Padding(2);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(207, 28);
            cmbCliente.TabIndex = 3;
            // 
            // lbEmpleado
            // 
            lbEmpleado.BackColor = Color.FromArgb(255, 161, 43);
            lbEmpleado.FlatStyle = FlatStyle.Flat;
            lbEmpleado.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmpleado.ForeColor = Color.White;
            lbEmpleado.Location = new Point(15, 142);
            lbEmpleado.Margin = new Padding(2, 0, 2, 0);
            lbEmpleado.Name = "lbEmpleado";
            lbEmpleado.Size = new Size(158, 30);
            lbEmpleado.TabIndex = 1;
            lbEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1197, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // ProcesoFacturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(1340, 680);
            Controls.Add(tlpMain);
            Controls.Add(Titulo);
            Margin = new Padding(2);
            Name = "ProcesoFacturacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProcesoFacturacion";
            Shown += ProcesoFacturacion_Shown_1;
            Validating += ProcesoFacturacion_Validating;
            tlpMain.ResumeLayout(false);
            grpCatalogo.ResumeLayout(false);
            grpCatalogo.PerformLayout();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((ISupportInitialize)dgvDetalle).EndInit();
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            panelFacturacion.ResumeLayout(false);
            panelFacturacion.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void ProcesoFacturacion_Validating(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
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
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private FlowLayoutPanel flpCatalogo;
        private ComboBox cmbCategoria;
        private Panel grpDetalle;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnPrecuenta;
        private FontAwesome.Sharp.IconButton btnProcesar;
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
        private Label label8;
        private TextBox txtVence;
        private TextBox txtCondicionPago;
        private TextBox txtCreacion;
        private TextBox txtITEBIS;
        private Label label11;
        private Label label12;
        private Panel panel2;
        private Panel panelFacturacion;
        private Label label13;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Label label14;
        private DataGridView dgvDetalle;
        private PictureBox pictureBox1;
    }
}