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
            panel1 = new Panel();
            panel2 = new Panel();
            btnConsultaProducto = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            activo = new RadioButton();
            desactivo = new RadioButton();
            venta = new TextBox();
            label5 = new Label();
            costo = new TextBox();
            label6 = new Label();
            stockMinimo = new TextBox();
            label7 = new Label();
            stockActual = new TextBox();
            label4 = new Label();
            descripcion = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            nombre = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panelProducto.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panelProducto.Name = "panelProducto";
            panelProducto.Size = new Size(914, 72);
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
            btnMaximizarProducto.Location = new Point(829, 0);
            btnMaximizarProducto.Margin = new Padding(2);
            btnMaximizarProducto.Name = "btnMaximizarProducto";
            btnMaximizarProducto.Size = new Size(45, 25);
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
            btnCerrarProducto.Location = new Point(869, 0);
            btnCerrarProducto.Margin = new Padding(2);
            btnCerrarProducto.Name = "btnCerrarProducto";
            btnCerrarProducto.Size = new Size(45, 25);
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
            btnMinimizarProducto.Location = new Point(786, 0);
            btnMinimizarProducto.Margin = new Padding(2);
            btnMinimizarProducto.Name = "btnMinimizarProducto";
            btnMinimizarProducto.Size = new Size(45, 25);
            btnMinimizarProducto.TabIndex = 11;
            btnMinimizarProducto.UseVisualStyleBackColor = false;
            btnMinimizarProducto.Click += btnMinimizarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 44);
            label1.TabIndex = 1;
            label1.Text = "PRODUCTO";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnConsultaProducto);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(activo);
            panel1.Controls.Add(desactivo);
            panel1.Controls.Add(venta);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(costo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(stockMinimo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(stockActual);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(descripcion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(nombre);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 487);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(206, 146);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(124, 2);
            panel2.TabIndex = 44;
            // 
            // btnConsultaProducto
            // 
            btnConsultaProducto.BackColor = Color.DarkOrange;
            btnConsultaProducto.FlatAppearance.BorderSize = 0;
            btnConsultaProducto.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            btnConsultaProducto.IconColor = SystemColors.ControlLightLight;
            btnConsultaProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaProducto.Location = new Point(796, 379);
            btnConsultaProducto.Name = "btnConsultaProducto";
            btnConsultaProducto.Size = new Size(78, 78);
            btnConsultaProducto.TabIndex = 43;
            btnConsultaProducto.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(752, -10);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(25, 327);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 29);
            label8.TabIndex = 41;
            label8.Text = "Estado";
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10.2F);
            activo.Location = new Point(143, 315);
            activo.Margin = new Padding(4);
            activo.Name = "activo";
            activo.Size = new Size(101, 29);
            activo.TabIndex = 39;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // desactivo
            // 
            desactivo.AutoSize = true;
            desactivo.Font = new Font("Verdana", 10.2F);
            desactivo.Location = new Point(143, 352);
            desactivo.Margin = new Padding(4);
            desactivo.Name = "desactivo";
            desactivo.Size = new Size(121, 29);
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
            venta.Location = new Point(544, 204);
            venta.Margin = new Padding(4);
            venta.Name = "venta";
            venta.Size = new Size(191, 22);
            venta.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(360, 198);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(183, 29);
            label5.TabIndex = 36;
            label5.Text = "Precio Venta";
            // 
            // costo
            // 
            costo.BackColor = Color.FromArgb(255, 161, 43);
            costo.BorderStyle = BorderStyle.None;
            costo.Font = new Font("Verdana", 9F, FontStyle.Bold);
            costo.ForeColor = Color.White;
            costo.Location = new Point(198, 203);
            costo.Margin = new Padding(4);
            costo.Name = "costo";
            costo.Size = new Size(191, 22);
            costo.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 198);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 29);
            label6.TabIndex = 33;
            label6.Text = "Precio Costo";
            // 
            // stockMinimo
            // 
            stockMinimo.BackColor = Color.FromArgb(255, 161, 43);
            stockMinimo.BorderStyle = BorderStyle.None;
            stockMinimo.Font = new Font("Verdana", 9F, FontStyle.Bold);
            stockMinimo.ForeColor = Color.White;
            stockMinimo.Location = new Point(552, 122);
            stockMinimo.Margin = new Padding(4);
            stockMinimo.Name = "stockMinimo";
            stockMinimo.Size = new Size(191, 22);
            stockMinimo.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(359, 119);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(192, 29);
            label7.TabIndex = 30;
            label7.Text = "Stock Minimo";
            // 
            // stockActual
            // 
            stockActual.BackColor = Color.FromArgb(255, 161, 43);
            stockActual.BorderStyle = BorderStyle.None;
            stockActual.Font = new Font("Verdana", 9F, FontStyle.Bold);
            stockActual.ForeColor = Color.White;
            stockActual.Location = new Point(206, 125);
            stockActual.Margin = new Padding(4);
            stockActual.Name = "stockActual";
            stockActual.Size = new Size(191, 22);
            stockActual.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 119);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 29);
            label4.TabIndex = 27;
            label4.Text = "Stock Actual";
            // 
            // descripcion
            // 
            descripcion.BackColor = Color.FromArgb(255, 161, 43);
            descripcion.Font = new Font("Verdana", 9F, FontStyle.Bold);
            descripcion.ForeColor = Color.White;
            descripcion.Location = new Point(362, 314);
            descripcion.Margin = new Padding(4);
            descripcion.Multiline = true;
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(314, 124);
            descripcion.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(359, 263);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 29);
            label2.TabIndex = 24;
            label2.Text = "Descripcion";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(146, 68);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 2);
            panel3.TabIndex = 23;
            // 
            // nombre
            // 
            nombre.BackColor = Color.FromArgb(255, 161, 43);
            nombre.BorderStyle = BorderStyle.None;
            nombre.Font = new Font("Verdana", 9F, FontStyle.Bold);
            nombre.ForeColor = Color.White;
            nombre.Location = new Point(150, 47);
            nombre.Margin = new Padding(4);
            nombre.Name = "nombre";
            nombre.Size = new Size(191, 22);
            nombre.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 41);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 29);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(207, 225);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(124, 2);
            panel4.TabIndex = 45;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(552, 146);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(124, 2);
            panel5.TabIndex = 46;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(544, 224);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(124, 2);
            panel6.TabIndex = 47;
            // 
            // MantenimientoProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(914, 559);
            Controls.Add(panel1);
            Controls.Add(panelProducto);
            Name = "MantenimientoProducto";
            Text = "Producto";
            panelProducto.ResumeLayout(false);
            panelProducto.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        protected TextBox stockActual;
        protected Label label4;
        protected TextBox descripcion;
        protected TextBox venta;
        protected Label label5;
        protected TextBox costo;
        protected Label label6;
        protected TextBox stockMinimo;
        protected Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        protected RadioButton activo;
        protected RadioButton desactivo;
        private FontAwesome.Sharp.IconButton btnConsultaProducto;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
    }
}