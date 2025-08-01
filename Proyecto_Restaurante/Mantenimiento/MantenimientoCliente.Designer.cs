namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoCliente
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
            panel1 = new Panel();
            comboCondicion = new ComboBox();
            label1 = new Label();
            guardar = new FontAwesome.Sharp.IconButton();
            Limpiar = new FontAwesome.Sharp.IconButton();
            btnConsultaCliente = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            activo = new RadioButton();
            desactivo = new RadioButton();
            direccion = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            email = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            telefono = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            nombre = new TextBox();
            label3 = new Label();
            panelMantenimientoCliente = new Panel();
            btnMaximizarMetodo = new FontAwesome.Sharp.IconButton();
            btnCerrarMetodo = new FontAwesome.Sharp.IconButton();
            btnMinimizarMetodo = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            panel1.SuspendLayout();
            panelMantenimientoCliente.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboCondicion);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guardar);
            panel1.Controls.Add(Limpiar);
            panel1.Controls.Add(btnConsultaCliente);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(activo);
            panel1.Controls.Add(desactivo);
            panel1.Controls.Add(direccion);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(email);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(telefono);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(nombre);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 586);
            panel1.TabIndex = 0;
            // 
            // comboCondicion
            // 
            comboCondicion.BackColor = Color.FromArgb(255, 161, 43);
            comboCondicion.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCondicion.ForeColor = Color.White;
            comboCondicion.FormattingEnabled = true;
            comboCondicion.Location = new Point(72, 364);
            comboCondicion.Margin = new Padding(4, 4, 4, 4);
            comboCondicion.Name = "comboCondicion";
            comboCondicion.Size = new Size(188, 30);
            comboCondicion.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 328);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 29);
            label1.TabIndex = 71;
            label1.Text = "Condición de Pago";
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
            guardar.Location = new Point(95, 484);
            guardar.Margin = new Padding(4, 4, 4, 4);
            guardar.Name = "guardar";
            guardar.Size = new Size(192, 65);
            guardar.TabIndex = 69;
            guardar.Text = "      Guardar";
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
            Limpiar.Location = new Point(322, 484);
            Limpiar.Margin = new Padding(4, 4, 4, 4);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(179, 65);
            Limpiar.TabIndex = 68;
            Limpiar.Text = "    Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // btnConsultaCliente
            // 
            btnConsultaCliente.BackColor = Color.FromArgb(255, 161, 43);
            btnConsultaCliente.FlatAppearance.BorderSize = 0;
            btnConsultaCliente.FlatStyle = FlatStyle.Flat;
            btnConsultaCliente.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultaCliente.ForeColor = Color.White;
            btnConsultaCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnConsultaCliente.IconColor = SystemColors.ControlLightLight;
            btnConsultaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaCliente.IconSize = 30;
            btnConsultaCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaCliente.Location = new Point(546, 484);
            btnConsultaCliente.Margin = new Padding(2);
            btnConsultaCliente.Name = "btnConsultaCliente";
            btnConsultaCliente.Size = new Size(186, 65);
            btnConsultaCliente.TabIndex = 67;
            btnConsultaCliente.Text = "    Consulta";
            btnConsultaCliente.UseVisualStyleBackColor = false;
            btnConsultaCliente.Click += btnConsultaCliente_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(496, 339);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 29);
            label8.TabIndex = 66;
            label8.Text = "Estado";
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activo.ForeColor = SystemColors.ControlLightLight;
            activo.Location = new Point(606, 322);
            activo.Margin = new Padding(4, 4, 4, 4);
            activo.Name = "activo";
            activo.Size = new Size(108, 29);
            activo.TabIndex = 64;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // desactivo
            // 
            desactivo.AutoSize = true;
            desactivo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desactivo.ForeColor = SystemColors.ControlLightLight;
            desactivo.Location = new Point(606, 359);
            desactivo.Margin = new Padding(4, 4, 4, 4);
            desactivo.Name = "desactivo";
            desactivo.Size = new Size(130, 29);
            desactivo.TabIndex = 65;
            desactivo.Text = "Inactivo";
            desactivo.UseVisualStyleBackColor = true;
            // 
            // direccion
            // 
            direccion.BackColor = Color.FromArgb(255, 161, 43);
            direccion.Font = new Font("Verdana", 9F, FontStyle.Bold);
            direccion.ForeColor = Color.White;
            direccion.Location = new Point(462, 142);
            direccion.Margin = new Padding(4, 4, 4, 4);
            direccion.Multiline = true;
            direccion.Name = "direccion";
            direccion.Size = new Size(314, 138);
            direccion.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(546, 105);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 29);
            label5.TabIndex = 62;
            label5.Text = "Direccion";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(118, 286);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 2);
            panel4.TabIndex = 61;
            // 
            // email
            // 
            email.BackColor = Color.FromArgb(255, 161, 43);
            email.BorderStyle = BorderStyle.None;
            email.Font = new Font("Verdana", 9F, FontStyle.Bold);
            email.ForeColor = Color.White;
            email.Location = new Point(122, 262);
            email.Margin = new Padding(4, 4, 4, 4);
            email.Name = "email";
            email.Size = new Size(240, 22);
            email.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 258);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 29);
            label4.TabIndex = 59;
            label4.Text = "E-mail";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(146, 210);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 2);
            panel2.TabIndex = 58;
            // 
            // telefono
            // 
            telefono.BackColor = Color.FromArgb(255, 161, 43);
            telefono.BorderStyle = BorderStyle.None;
            telefono.Font = new Font("Verdana", 9F, FontStyle.Bold);
            telefono.ForeColor = Color.White;
            telefono.Location = new Point(152, 188);
            telefono.Margin = new Padding(4, 4, 4, 4);
            telefono.Name = "telefono";
            telefono.Size = new Size(198, 22);
            telefono.TabIndex = 57;
            telefono.KeyPress += telefono_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 182);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 29);
            label2.TabIndex = 56;
            label2.Text = "Telefono";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(146, 134);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 2);
            panel3.TabIndex = 55;
            // 
            // nombre
            // 
            nombre.BackColor = Color.FromArgb(255, 161, 43);
            nombre.BorderStyle = BorderStyle.None;
            nombre.Font = new Font("Verdana", 9F, FontStyle.Bold);
            nombre.ForeColor = Color.White;
            nombre.Location = new Point(152, 112);
            nombre.Margin = new Padding(4, 4, 4, 4);
            nombre.Name = "nombre";
            nombre.Size = new Size(198, 22);
            nombre.TabIndex = 54;
            nombre.KeyPress += nombre_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 108);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 29);
            label3.TabIndex = 53;
            label3.Text = "Nombre";
            // 
            // panelMantenimientoCliente
            // 
            panelMantenimientoCliente.BackColor = Color.White;
            panelMantenimientoCliente.Controls.Add(btnMaximizarMetodo);
            panelMantenimientoCliente.Controls.Add(btnCerrarMetodo);
            panelMantenimientoCliente.Controls.Add(btnMinimizarMetodo);
            panelMantenimientoCliente.Controls.Add(label6);
            panelMantenimientoCliente.Dock = DockStyle.Top;
            panelMantenimientoCliente.Location = new Point(0, 0);
            panelMantenimientoCliente.Margin = new Padding(2);
            panelMantenimientoCliente.Name = "panelMantenimientoCliente";
            panelMantenimientoCliente.Size = new Size(835, 68);
            panelMantenimientoCliente.TabIndex = 1;
            panelMantenimientoCliente.MouseDown += panelMantenimientoCliente_MouseDown;
            // 
            // btnMaximizarMetodo
            // 
            btnMaximizarMetodo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarMetodo.BackColor = Color.CornflowerBlue;
            btnMaximizarMetodo.FlatAppearance.BorderSize = 0;
            btnMaximizarMetodo.FlatStyle = FlatStyle.Flat;
            btnMaximizarMetodo.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarMetodo.IconColor = Color.OldLace;
            btnMaximizarMetodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarMetodo.IconSize = 20;
            btnMaximizarMetodo.Location = new Point(750, 0);
            btnMaximizarMetodo.Margin = new Padding(2);
            btnMaximizarMetodo.Name = "btnMaximizarMetodo";
            btnMaximizarMetodo.Size = new Size(45, 25);
            btnMaximizarMetodo.TabIndex = 9;
            btnMaximizarMetodo.UseVisualStyleBackColor = false;
            btnMaximizarMetodo.Click += btnMaximizarCategoria_Click;
            // 
            // btnCerrarMetodo
            // 
            btnCerrarMetodo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarMetodo.BackColor = Color.Tomato;
            btnCerrarMetodo.FlatAppearance.BorderSize = 0;
            btnCerrarMetodo.FlatStyle = FlatStyle.Flat;
            btnCerrarMetodo.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarMetodo.IconColor = Color.OldLace;
            btnCerrarMetodo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarMetodo.IconSize = 20;
            btnCerrarMetodo.Location = new Point(790, 0);
            btnCerrarMetodo.Margin = new Padding(2);
            btnCerrarMetodo.Name = "btnCerrarMetodo";
            btnCerrarMetodo.Size = new Size(45, 25);
            btnCerrarMetodo.TabIndex = 10;
            btnCerrarMetodo.UseVisualStyleBackColor = false;
            btnCerrarMetodo.Click += btnCerrarCategoria_Click;
            // 
            // btnMinimizarMetodo
            // 
            btnMinimizarMetodo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarMetodo.BackColor = Color.Turquoise;
            btnMinimizarMetodo.FlatAppearance.BorderSize = 0;
            btnMinimizarMetodo.FlatStyle = FlatStyle.Flat;
            btnMinimizarMetodo.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarMetodo.IconColor = Color.OldLace;
            btnMinimizarMetodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarMetodo.IconSize = 20;
            btnMinimizarMetodo.Location = new Point(708, 0);
            btnMinimizarMetodo.Margin = new Padding(2);
            btnMinimizarMetodo.Name = "btnMinimizarMetodo";
            btnMinimizarMetodo.Size = new Size(45, 25);
            btnMinimizarMetodo.TabIndex = 8;
            btnMinimizarMetodo.UseVisualStyleBackColor = false;
            btnMinimizarMetodo.Click += btnMinimizarCategoria_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 161, 43);
            label6.Location = new Point(12, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(193, 44);
            label6.TabIndex = 1;
            label6.Text = "CLIENTE";
            // 
            // MantenimientoCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(835, 586);
            Controls.Add(panelMantenimientoCliente);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MantenimientoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoCliente";
            Load += MantenimientoCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMantenimientoCliente.ResumeLayout(false);
            panelMantenimientoCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton guardar;
        private FontAwesome.Sharp.IconButton Limpiar;
        private FontAwesome.Sharp.IconButton btnConsultaCliente;
        private Label label8;
        protected RadioButton activo;
        protected RadioButton desactivo;
        protected TextBox direccion;
        protected Label label5;
        private Panel panel4;
        protected TextBox email;
        protected Label label4;
        private Panel panel2;
        protected TextBox telefono;
        protected Label label2;
        private Panel panel3;
        protected TextBox nombre;
        protected Label label3;
        private Label label1;
        private RadioButton contado;
        private RadioButton credito;
        private ComboBox comboCondicion;
        private Panel panelMantenimientoCliente;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnMaximizarMetodo;
        private FontAwesome.Sharp.IconButton btnCerrarMetodo;
        private FontAwesome.Sharp.IconButton btnMinimizarMetodo;
    }
}