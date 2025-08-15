namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProducto));
            panelProducto = new Panel();
            btnMaximizarProducto = new FontAwesome.Sharp.IconButton();
            btnCerrarProducto = new FontAwesome.Sharp.IconButton();
            btnMinimizarProducto = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label12 = new Label();
            comboProveedor = new ComboBox();
            label11 = new Label();
            imagenproducto = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            comboUnidad = new ComboBox();
            comboCategoria = new ComboBox();
            guardar = new FontAwesome.Sharp.IconButton();
            Limpiar = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            panel5 = new Panel();
            btnConsultaProducto = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            activo = new RadioButton();
            desactivo = new RadioButton();
            venta = new TextBox();
            label5 = new Label();
            costo = new TextBox();
            label6 = new Label();
            txtstockMinimo = new TextBox();
            label7 = new Label();
            txtstockActual = new TextBox();
            label4 = new Label();
            descripcion = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            nombre = new TextBox();
            label3 = new Label();
            panelProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).BeginInit();
            SuspendLayout();
            // 
            // panelProducto
            // 
            panelProducto.BackColor = Color.White;
            panelProducto.Controls.Add(btnMaximizarProducto);
            panelProducto.Controls.Add(btnCerrarProducto);
            panelProducto.Controls.Add(btnMinimizarProducto);
            panelProducto.Controls.Add(label1);
            panelProducto.Dock = DockStyle.Top;
            panelProducto.Location = new Point(0, 0);
            panelProducto.Margin = new Padding(2);
            panelProducto.Name = "panelProducto";
            panelProducto.Size = new Size(848, 58);
            panelProducto.TabIndex = 0;
            panelProducto.MouseDown += panelProducto_MouseDown;
            // 
            // btnMaximizarProducto
            // 
            btnMaximizarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarProducto.BackColor = Color.CornflowerBlue;
            btnMaximizarProducto.FlatAppearance.BorderSize = 0;
            btnMaximizarProducto.FlatStyle = FlatStyle.Flat;
            btnMaximizarProducto.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarProducto.IconColor = Color.OldLace;
            btnMaximizarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarProducto.IconSize = 20;
            btnMaximizarProducto.Location = new Point(780, 0);
            btnMaximizarProducto.Margin = new Padding(2);
            btnMaximizarProducto.Name = "btnMaximizarProducto";
            btnMaximizarProducto.Size = new Size(36, 20);
            btnMaximizarProducto.TabIndex = 12;
            btnMaximizarProducto.UseVisualStyleBackColor = false;
            btnMaximizarProducto.Click += btnMaximizarProducto_Click;
            // 
            // btnCerrarProducto
            // 
            btnCerrarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarProducto.BackColor = Color.Tomato;
            btnCerrarProducto.FlatAppearance.BorderSize = 0;
            btnCerrarProducto.FlatStyle = FlatStyle.Flat;
            btnCerrarProducto.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarProducto.IconColor = Color.OldLace;
            btnCerrarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarProducto.IconSize = 20;
            btnCerrarProducto.Location = new Point(812, 0);
            btnCerrarProducto.Margin = new Padding(2);
            btnCerrarProducto.Name = "btnCerrarProducto";
            btnCerrarProducto.Size = new Size(36, 20);
            btnCerrarProducto.TabIndex = 13;
            btnCerrarProducto.UseVisualStyleBackColor = false;
            btnCerrarProducto.Click += btnCerrarProducto_Click;
            // 
            // btnMinimizarProducto
            // 
            btnMinimizarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarProducto.BackColor = Color.Turquoise;
            btnMinimizarProducto.FlatAppearance.BorderSize = 0;
            btnMinimizarProducto.FlatStyle = FlatStyle.Flat;
            btnMinimizarProducto.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarProducto.IconColor = Color.OldLace;
            btnMinimizarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarProducto.IconSize = 20;
            btnMinimizarProducto.Location = new Point(746, 0);
            btnMinimizarProducto.Margin = new Padding(2);
            btnMinimizarProducto.Name = "btnMinimizarProducto";
            btnMinimizarProducto.Size = new Size(36, 20);
            btnMinimizarProducto.TabIndex = 11;
            btnMinimizarProducto.UseVisualStyleBackColor = false;
            btnMinimizarProducto.Click += btnMinimizarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(203, 36);
            label1.TabIndex = 1;
            label1.Text = "PRODUCTO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(706, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Controls.Add(comboProveedor);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(imagenproducto);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(comboUnidad);
            panel1.Controls.Add(comboCategoria);
            panel1.Controls.Add(guardar);
            panel1.Controls.Add(Limpiar);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnConsultaProducto);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(activo);
            panel1.Controls.Add(desactivo);
            panel1.Controls.Add(venta);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(costo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtstockMinimo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtstockActual);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(descripcion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(nombre);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 58);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 603);
            panel1.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(175, 375);
            label12.Name = "label12";
            label12.Size = new Size(128, 25);
            label12.TabIndex = 58;
            label12.Text = "Proveedor";
            // 
            // comboProveedor
            // 
            comboProveedor.BackColor = Color.FromArgb(255, 161, 43);
            comboProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProveedor.FlatStyle = FlatStyle.Flat;
            comboProveedor.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProveedor.ForeColor = Color.White;
            comboProveedor.FormattingEnabled = true;
            comboProveedor.Location = new Point(156, 403);
            comboProveedor.Name = "comboProveedor";
            comboProveedor.Size = new Size(175, 28);
            comboProveedor.TabIndex = 57;
            comboProveedor.MouseEnter += comboProveedor_MouseEnter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(641, 332);
            label11.Name = "label11";
            label11.Size = new Size(98, 25);
            label11.TabIndex = 55;
            label11.Text = "Imagen";
            // 
            // imagenproducto
            // 
            imagenproducto.InitialImage = null;
            imagenproducto.Location = new Point(534, 360);
            imagenproducto.Name = "imagenproducto";
            imagenproducto.Size = new Size(293, 231);
            imagenproducto.SizeMode = PictureBoxSizeMode.Zoom;
            imagenproducto.TabIndex = 54;
            imagenproducto.TabStop = false;
            imagenproducto.MouseDoubleClick += imagenproducto_MouseDoubleClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(280, 252);
            label10.Name = "label10";
            label10.Size = new Size(211, 25);
            label10.TabIndex = 53;
            label10.Text = "Unidad de Medida";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(34, 252);
            label9.Name = "label9";
            label9.Size = new Size(119, 25);
            label9.TabIndex = 52;
            label9.Text = "Categoria";
            // 
            // comboUnidad
            // 
            comboUnidad.BackColor = Color.FromArgb(255, 161, 43);
            comboUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUnidad.FlatStyle = FlatStyle.Flat;
            comboUnidad.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboUnidad.ForeColor = SystemColors.ControlLightLight;
            comboUnidad.FormattingEnabled = true;
            comboUnidad.Location = new Point(280, 289);
            comboUnidad.Margin = new Padding(2);
            comboUnidad.Name = "comboUnidad";
            comboUnidad.Size = new Size(194, 28);
            comboUnidad.TabIndex = 51;
            comboUnidad.MouseEnter += comboUnidad_MouseEnter;
            // 
            // comboCategoria
            // 
            comboCategoria.BackColor = Color.FromArgb(255, 161, 43);
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.FlatStyle = FlatStyle.Flat;
            comboCategoria.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCategoria.ForeColor = SystemColors.ControlLightLight;
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(18, 289);
            comboCategoria.Margin = new Padding(2);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(194, 28);
            comboCategoria.TabIndex = 50;
            comboCategoria.MouseEnter += comboUnidad_MouseEnter;
            // 
            // guardar
            // 
            guardar.FlatAppearance.BorderSize = 0;
            guardar.FlatStyle = FlatStyle.Flat;
            guardar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            guardar.ForeColor = Color.White;
            guardar.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            guardar.IconColor = Color.White;
            guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            guardar.IconSize = 35;
            guardar.ImageAlign = ContentAlignment.MiddleLeft;
            guardar.Location = new Point(18, 539);
            guardar.Name = "guardar";
            guardar.Size = new Size(148, 52);
            guardar.TabIndex = 49;
            guardar.Text = "    Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // Limpiar
            // 
            Limpiar.FlatAppearance.BorderSize = 0;
            Limpiar.FlatStyle = FlatStyle.Flat;
            Limpiar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            Limpiar.ForeColor = Color.White;
            Limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            Limpiar.IconColor = Color.White;
            Limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Limpiar.IconSize = 35;
            Limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            Limpiar.Location = new Point(172, 539);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(143, 52);
            Limpiar.TabIndex = 48;
            Limpiar.Text = "    Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(412, 185);
            panel6.Name = "panel6";
            panel6.Size = new Size(100, 2);
            panel6.TabIndex = 47;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(172, 197);
            panel5.Name = "panel5";
            panel5.Size = new Size(100, 2);
            panel5.TabIndex = 46;
            // 
            // btnConsultaProducto
            // 
            btnConsultaProducto.BackColor = Color.FromArgb(255, 161, 43);
            btnConsultaProducto.FlatAppearance.BorderSize = 0;
            btnConsultaProducto.FlatStyle = FlatStyle.Flat;
            btnConsultaProducto.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultaProducto.ForeColor = Color.White;
            btnConsultaProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnConsultaProducto.IconColor = SystemColors.ControlLightLight;
            btnConsultaProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaProducto.IconSize = 30;
            btnConsultaProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaProducto.Location = new Point(282, 25);
            btnConsultaProducto.Margin = new Padding(2);
            btnConsultaProducto.Name = "btnConsultaProducto";
            btnConsultaProducto.Size = new Size(39, 43);
            btnConsultaProducto.TabIndex = 43;
            btnConsultaProducto.UseVisualStyleBackColor = false;
            btnConsultaProducto.Click += btnConsultaProducto_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(414, 114);
            panel4.Name = "panel4";
            panel4.Size = new Size(100, 2);
            panel4.TabIndex = 45;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(165, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 2);
            panel2.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(582, 273);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 41;
            label8.Text = "Estado";
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Checked = true;
            activo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activo.ForeColor = SystemColors.ControlLightLight;
            activo.Location = new Point(676, 259);
            activo.Name = "activo";
            activo.Size = new Size(90, 24);
            activo.TabIndex = 39;
            activo.TabStop = true;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // desactivo
            // 
            desactivo.AutoSize = true;
            desactivo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desactivo.ForeColor = SystemColors.ControlLightLight;
            desactivo.Location = new Point(674, 289);
            desactivo.Name = "desactivo";
            desactivo.Size = new Size(109, 24);
            desactivo.TabIndex = 40;
            desactivo.Text = "Inactivo";
            desactivo.UseVisualStyleBackColor = true;
            // 
            // venta
            // 
            venta.BackColor = Color.FromArgb(255, 161, 43);
            venta.BorderStyle = BorderStyle.None;
            venta.Font = new Font("Verdana", 9F, FontStyle.Bold);
            venta.ForeColor = Color.White;
            venta.Location = new Point(416, 165);
            venta.Name = "venta";
            venta.Size = new Size(100, 19);
            venta.TabIndex = 37;
            venta.KeyPress += venta_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(256, 159);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 36;
            label5.Text = "Precio Venta";
            // 
            // costo
            // 
            costo.BackColor = Color.FromArgb(255, 161, 43);
            costo.BorderStyle = BorderStyle.None;
            costo.Font = new Font("Verdana", 9F, FontStyle.Bold);
            costo.ForeColor = Color.White;
            costo.Location = new Point(416, 94);
            costo.Name = "costo";
            costo.Size = new Size(100, 19);
            costo.TabIndex = 34;
            costo.KeyPress += costo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(257, 88);
            label6.Name = "label6";
            label6.Size = new Size(153, 25);
            label6.TabIndex = 33;
            label6.Text = "Precio Costo";
            // 
            // txtstockMinimo
            // 
            txtstockMinimo.BackColor = Color.FromArgb(255, 161, 43);
            txtstockMinimo.BorderStyle = BorderStyle.None;
            txtstockMinimo.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtstockMinimo.ForeColor = Color.White;
            txtstockMinimo.Location = new Point(175, 177);
            txtstockMinimo.Name = "txtstockMinimo";
            txtstockMinimo.Size = new Size(100, 19);
            txtstockMinimo.TabIndex = 31;
            txtstockMinimo.KeyPress += txtstockMinimo_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(11, 174);
            label7.Name = "label7";
            label7.Size = new Size(163, 25);
            label7.TabIndex = 30;
            label7.Text = "Stock Minimo";
            // 
            // txtstockActual
            // 
            txtstockActual.BackColor = Color.FromArgb(255, 161, 43);
            txtstockActual.BorderStyle = BorderStyle.None;
            txtstockActual.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtstockActual.ForeColor = Color.White;
            txtstockActual.Location = new Point(169, 114);
            txtstockActual.Name = "txtstockActual";
            txtstockActual.Size = new Size(100, 19);
            txtstockActual.TabIndex = 28;
            txtstockActual.KeyPress += txtstockActual_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 111);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 27;
            label4.Text = "Stock Actual";
            // 
            // descripcion
            // 
            descripcion.BackColor = Color.FromArgb(255, 161, 43);
            descripcion.Font = new Font("Verdana", 9F, FontStyle.Bold);
            descripcion.ForeColor = Color.White;
            descripcion.Location = new Point(554, 146);
            descripcion.Multiline = true;
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(252, 111);
            descripcion.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(611, 114);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 24;
            label2.Text = "Descripcion";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(114, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 2);
            panel3.TabIndex = 23;
            // 
            // nombre
            // 
            nombre.BackColor = Color.FromArgb(255, 161, 43);
            nombre.BorderStyle = BorderStyle.None;
            nombre.Font = new Font("Verdana", 9F, FontStyle.Bold);
            nombre.ForeColor = Color.White;
            nombre.Location = new Point(119, 46);
            nombre.Name = "nombre";
            nombre.Size = new Size(158, 19);
            nombre.TabIndex = 22;
            nombre.KeyPress += nombre_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 43);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // MantenimientoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(848, 661);
            Controls.Add(panel1);
            Controls.Add(panelProducto);
            Margin = new Padding(2);
            Name = "MantenimientoProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            Load += MantenimientoProducto_Load;
            panelProducto.ResumeLayout(false);
            panelProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProducto;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizarProducto;
        private FontAwesome.Sharp.IconButton btnCerrarProducto;
        private FontAwesome.Sharp.IconButton btnMinimizarProducto;
        protected Label label3;
        protected Label label2;
        private Panel panel3;
        protected TextBox nombre;
        protected TextBox txtstockActual;
        protected Label label4;
        protected TextBox descripcion;
        protected TextBox venta;
        protected Label label5;
        protected TextBox costo;
        protected Label label6;
        protected TextBox txtstockMinimo;
        protected Label label7;
        private Label label8;
        protected RadioButton activo;
        protected RadioButton desactivo;
        private FontAwesome.Sharp.IconButton btnConsultaProducto;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton guardar;
        private FontAwesome.Sharp.IconButton Limpiar;
        private ComboBox comboUnidad;
        private ComboBox comboCategoria;
        protected Label label10;
        protected Label label9;
        private PictureBox imagenproducto;
        private Label label11;
        private PictureBox pictureBox1;
        protected Label label12;
        private ComboBox comboProveedor;
    }
}