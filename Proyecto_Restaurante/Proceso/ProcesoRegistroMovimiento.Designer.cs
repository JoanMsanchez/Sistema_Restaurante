
namespace Proyecto_Restaurante.Proceso
{
    partial class ProcesoRegistroMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesoRegistroMovimiento));
            panel2 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            btnConsultaProducto = new FontAwesome.Sharp.IconButton();
            comboProveedor = new ComboBox();
            pictureBox1 = new PictureBox();
            limpiar = new FontAwesome.Sharp.IconButton();
            guardar = new FontAwesome.Sharp.IconButton();
            inactivo = new RadioButton();
            activo = new RadioButton();
            label9 = new Label();
            observaciones = new TextBox();
            fecha = new TextBox();
            txtstockatual = new TextBox();
            txtcantidad = new TextBox();
            producto = new TextBox();
            comboTipoMovimiento = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelMovimiento = new Panel();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMovimiento.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 161, 43);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnConsultaProducto);
            panel2.Controls.Add(comboProveedor);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(limpiar);
            panel2.Controls.Add(guardar);
            panel2.Controls.Add(inactivo);
            panel2.Controls.Add(activo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(observaciones);
            panel2.Controls.Add(fecha);
            panel2.Controls.Add(txtstockatual);
            panel2.Controls.Add(txtcantidad);
            panel2.Controls.Add(producto);
            panel2.Controls.Add(comboTipoMovimiento);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 571);
            panel2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(272, 350);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(198, 2);
            panel5.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(35, 350);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(198, 2);
            panel4.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(176, 152);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 2);
            panel3.TabIndex = 73;
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
            btnConsultaProducto.Location = new Point(394, 106);
            btnConsultaProducto.Margin = new Padding(2);
            btnConsultaProducto.Name = "btnConsultaProducto";
            btnConsultaProducto.Size = new Size(49, 54);
            btnConsultaProducto.TabIndex = 72;
            btnConsultaProducto.UseVisualStyleBackColor = false;
            btnConsultaProducto.Click += btnConsultaProducto_Click;
            // 
            // comboProveedor
            // 
            comboProveedor.BackColor = Color.FromArgb(255, 161, 43);
            comboProveedor.FlatStyle = FlatStyle.Flat;
            comboProveedor.FormattingEnabled = true;
            comboProveedor.Location = new Point(358, 379);
            comboProveedor.Margin = new Padding(4);
            comboProveedor.Name = "comboProveedor";
            comboProveedor.Size = new Size(188, 33);
            comboProveedor.TabIndex = 71;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(828, 61);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // limpiar
            // 
            limpiar.FlatAppearance.BorderSize = 0;
            limpiar.FlatStyle = FlatStyle.Flat;
            limpiar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            limpiar.ForeColor = Color.White;
            limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            limpiar.IconColor = Color.White;
            limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            limpiar.IconSize = 35;
            limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            limpiar.Location = new Point(732, 489);
            limpiar.Margin = new Padding(4);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(175, 70);
            limpiar.TabIndex = 69;
            limpiar.Text = "     Limpiar";
            limpiar.UseVisualStyleBackColor = true;
            limpiar.Click += limpiar_Click;
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
            guardar.Location = new Point(544, 489);
            guardar.Margin = new Padding(4);
            guardar.Name = "guardar";
            guardar.Size = new Size(181, 70);
            guardar.TabIndex = 68;
            guardar.Text = "     Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // inactivo
            // 
            inactivo.AutoSize = true;
            inactivo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inactivo.ForeColor = Color.White;
            inactivo.Location = new Point(745, 388);
            inactivo.Margin = new Padding(4);
            inactivo.Name = "inactivo";
            inactivo.Size = new Size(130, 29);
            inactivo.TabIndex = 67;
            inactivo.Text = "Inactivo";
            inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Checked = true;
            activo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activo.ForeColor = Color.White;
            activo.Location = new Point(745, 350);
            activo.Margin = new Padding(4);
            activo.Name = "activo";
            activo.Size = new Size(108, 29);
            activo.TabIndex = 66;
            activo.TabStop = true;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(632, 370);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(103, 29);
            label9.TabIndex = 65;
            label9.Text = "Estado";
            // 
            // observaciones
            // 
            observaciones.BackColor = Color.FromArgb(255, 161, 43);
            observaciones.Location = new Point(614, 234);
            observaciones.Margin = new Padding(4);
            observaciones.Multiline = true;
            observaciones.Name = "observaciones";
            observaciones.Size = new Size(266, 99);
            observaciones.TabIndex = 14;
            // 
            // fecha
            // 
            fecha.BackColor = Color.FromArgb(255, 161, 43);
            fecha.Location = new Point(185, 442);
            fecha.Margin = new Padding(4);
            fecha.Name = "fecha";
            fecha.Size = new Size(188, 31);
            fecha.TabIndex = 13;
            // 
            // txtstockatual
            // 
            txtstockatual.BackColor = Color.FromArgb(255, 161, 43);
            txtstockatual.Location = new Point(286, 316);
            txtstockatual.Margin = new Padding(4);
            txtstockatual.Name = "txtstockatual";
            txtstockatual.Size = new Size(155, 31);
            txtstockatual.TabIndex = 11;
            // 
            // txtcantidad
            // 
            txtcantidad.BackColor = Color.FromArgb(255, 161, 43);
            txtcantidad.Location = new Point(70, 316);
            txtcantidad.Margin = new Padding(4);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(153, 31);
            txtcantidad.TabIndex = 10;
            // 
            // producto
            // 
            producto.BackColor = Color.FromArgb(255, 161, 43);
            producto.Location = new Point(185, 118);
            producto.Margin = new Padding(4);
            producto.Name = "producto";
            producto.Size = new Size(188, 31);
            producto.TabIndex = 9;
            // 
            // comboTipoMovimiento
            // 
            comboTipoMovimiento.BackColor = Color.FromArgb(255, 161, 43);
            comboTipoMovimiento.FlatStyle = FlatStyle.Flat;
            comboTipoMovimiento.FormattingEnabled = true;
            comboTipoMovimiento.Location = new Point(358, 195);
            comboTipoMovimiento.Margin = new Padding(4);
            comboTipoMovimiento.Name = "comboTipoMovimiento";
            comboTipoMovimiento.Size = new Size(188, 33);
            comboTipoMovimiento.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(638, 199);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(209, 29);
            label8.TabIndex = 6;
            label8.Text = "Observaciones";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(78, 445);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 29);
            label7.TabIndex = 5;
            label7.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(35, 376);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(298, 29);
            label5.TabIndex = 4;
            label5.Text = "Proveedor (opcional)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(272, 281);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(177, 29);
            label4.TabIndex = 3;
            label4.Text = "Stock actual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(78, 281);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 29);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 199);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(275, 29);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Movimiento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // panelMovimiento
            // 
            panelMovimiento.Controls.Add(btnMaximizar);
            panelMovimiento.Controls.Add(btnCerrar);
            panelMovimiento.Controls.Add(btnMinimizar);
            panelMovimiento.Controls.Add(label6);
            panelMovimiento.Dock = DockStyle.Top;
            panelMovimiento.Location = new Point(0, 0);
            panelMovimiento.Name = "panelMovimiento";
            panelMovimiento.Size = new Size(1006, 68);
            panelMovimiento.TabIndex = 4;
            panelMovimiento.MouseDown += panelMovimiento_MouseDown;
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
            btnMaximizar.Location = new Point(922, 0);
            btnMaximizar.Margin = new Padding(2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(45, 25);
            btnMaximizar.TabIndex = 12;
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
            btnCerrar.Location = new Point(960, 0);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 25);
            btnCerrar.TabIndex = 13;
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
            btnMinimizar.Location = new Point(878, 0);
            btnMinimizar.Margin = new Padding(2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 25);
            btnMinimizar.TabIndex = 11;
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
            label6.Size = new Size(798, 44);
            label6.TabIndex = 2;
            label6.Text = "REGISTRO MOVIMIENTO INVENTARIO";
            // 
            // ProcesoRegistroMovimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 571);
            Controls.Add(panelMovimiento);
            Controls.Add(panel2);
            Margin = new Padding(4);
            Name = "ProcesoRegistroMovimiento";
            Text = "ProcesoRegistroMovimiento";
            Load += ProcesoRegistroMovimiento_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMovimiento.ResumeLayout(false);
            panelMovimiento.PerformLayout();
            ResumeLayout(false);
        }

        private void btnMinimizarSala_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCerrarSala_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnMaximizarSala_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox observaciones;
        private TextBox fecha;
        private TextBox txtstockatual;
        private TextBox txtcantidad;
        private TextBox producto;
        private ComboBox comboTipoMovimiento;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton limpiar;
        private FontAwesome.Sharp.IconButton guardar;
        private RadioButton inactivo;
        private RadioButton activo;
        private Label label9;
        private PictureBox pictureBox1;
        private ComboBox comboProveedor;
        private FontAwesome.Sharp.IconButton btnConsultaProducto;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panelMovimiento;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
    }
}