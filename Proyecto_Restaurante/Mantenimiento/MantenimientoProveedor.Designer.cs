namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoProveedor
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
            panelMantenimientoProveedor = new Panel();
            btnMaximizarProveedor = new FontAwesome.Sharp.IconButton();
            btnCerrarProveedor = new FontAwesome.Sharp.IconButton();
            btnMinimizarProveedor = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel1 = new Panel();
            guardar = new FontAwesome.Sharp.IconButton();
            Limpiar = new FontAwesome.Sharp.IconButton();
            btnConsultaProveedor = new FontAwesome.Sharp.IconButton();
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
            panelMantenimientoProveedor.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMantenimientoProveedor
            // 
            panelMantenimientoProveedor.BackColor = Color.White;
            panelMantenimientoProveedor.Controls.Add(btnMaximizarProveedor);
            panelMantenimientoProveedor.Controls.Add(btnCerrarProveedor);
            panelMantenimientoProveedor.Controls.Add(btnMinimizarProveedor);
            panelMantenimientoProveedor.Controls.Add(label1);
            panelMantenimientoProveedor.Dock = DockStyle.Top;
            panelMantenimientoProveedor.Location = new Point(0, 0);
            panelMantenimientoProveedor.Margin = new Padding(2);
            panelMantenimientoProveedor.Name = "panelMantenimientoProveedor";
            panelMantenimientoProveedor.Size = new Size(644, 58);
            panelMantenimientoProveedor.TabIndex = 0;
            panelMantenimientoProveedor.MouseDown += panelMantenimientoProveedor_MouseDown;
            // 
            // btnMaximizarProveedor
            // 
            btnMaximizarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarProveedor.BackColor = Color.CornflowerBlue;
            btnMaximizarProveedor.FlatAppearance.BorderSize = 0;
            btnMaximizarProveedor.FlatStyle = FlatStyle.Flat;
            btnMaximizarProveedor.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarProveedor.IconColor = Color.OldLace;
            btnMaximizarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarProveedor.IconSize = 20;
            btnMaximizarProveedor.Location = new Point(576, 0);
            btnMaximizarProveedor.Margin = new Padding(2);
            btnMaximizarProveedor.Name = "btnMaximizarProveedor";
            btnMaximizarProveedor.Size = new Size(36, 20);
            btnMaximizarProveedor.TabIndex = 12;
            btnMaximizarProveedor.UseVisualStyleBackColor = false;
            btnMaximizarProveedor.Click += btnMaximizarProveedor_Click;
            // 
            // btnCerrarProveedor
            // 
            btnCerrarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarProveedor.BackColor = Color.Tomato;
            btnCerrarProveedor.FlatAppearance.BorderSize = 0;
            btnCerrarProveedor.FlatStyle = FlatStyle.Flat;
            btnCerrarProveedor.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarProveedor.IconColor = Color.OldLace;
            btnCerrarProveedor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarProveedor.IconSize = 20;
            btnCerrarProveedor.Location = new Point(608, 0);
            btnCerrarProveedor.Margin = new Padding(2);
            btnCerrarProveedor.Name = "btnCerrarProveedor";
            btnCerrarProveedor.Size = new Size(36, 20);
            btnCerrarProveedor.TabIndex = 13;
            btnCerrarProveedor.UseVisualStyleBackColor = false;
            btnCerrarProveedor.Click += btnCerrarProveedor_Click;
            // 
            // btnMinimizarProveedor
            // 
            btnMinimizarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarProveedor.BackColor = Color.Turquoise;
            btnMinimizarProveedor.FlatAppearance.BorderSize = 0;
            btnMinimizarProveedor.FlatStyle = FlatStyle.Flat;
            btnMinimizarProveedor.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarProveedor.IconColor = Color.OldLace;
            btnMinimizarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarProveedor.IconSize = 20;
            btnMinimizarProveedor.Location = new Point(542, 0);
            btnMinimizarProveedor.Margin = new Padding(2);
            btnMinimizarProveedor.Name = "btnMinimizarProveedor";
            btnMinimizarProveedor.Size = new Size(36, 20);
            btnMinimizarProveedor.TabIndex = 11;
            btnMinimizarProveedor.UseVisualStyleBackColor = false;
            btnMinimizarProveedor.Click += btnMinimizarProveedor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(225, 36);
            label1.TabIndex = 1;
            label1.Text = "PROVEEDOR";
            // 
            // panel1
            // 
            panel1.Controls.Add(guardar);
            panel1.Controls.Add(Limpiar);
            panel1.Controls.Add(btnConsultaProveedor);
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
            panel1.Location = new Point(0, 58);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 466);
            panel1.TabIndex = 1;
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
            guardar.Location = new Point(70, 371);
            guardar.Name = "guardar";
            guardar.Size = new Size(148, 52);
            guardar.TabIndex = 52;
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
            Limpiar.Location = new Point(252, 371);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(143, 52);
            Limpiar.TabIndex = 51;
            Limpiar.Text = "    Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // btnConsultaProveedor
            // 
            btnConsultaProveedor.BackColor = Color.FromArgb(255, 161, 43);
            btnConsultaProveedor.FlatAppearance.BorderSize = 0;
            btnConsultaProveedor.FlatStyle = FlatStyle.Flat;
            btnConsultaProveedor.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultaProveedor.ForeColor = Color.White;
            btnConsultaProveedor.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            btnConsultaProveedor.IconColor = SystemColors.ControlLightLight;
            btnConsultaProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaProveedor.IconSize = 30;
            btnConsultaProveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaProveedor.Location = new Point(416, 371);
            btnConsultaProveedor.Margin = new Padding(2);
            btnConsultaProveedor.Name = "btnConsultaProveedor";
            btnConsultaProveedor.Size = new Size(149, 52);
            btnConsultaProveedor.TabIndex = 50;
            btnConsultaProveedor.Text = "    Consulta";
            btnConsultaProveedor.UseVisualStyleBackColor = false;
            btnConsultaProveedor.Click += btnConsultaProveedor_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(26, 244);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 44;
            label8.Text = "Estado";
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activo.ForeColor = SystemColors.ControlLightLight;
            activo.Location = new Point(114, 230);
            activo.Name = "activo";
            activo.Size = new Size(90, 24);
            activo.TabIndex = 42;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // desactivo
            // 
            desactivo.AutoSize = true;
            desactivo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desactivo.ForeColor = SystemColors.ControlLightLight;
            desactivo.Location = new Point(114, 260);
            desactivo.Name = "desactivo";
            desactivo.Size = new Size(109, 24);
            desactivo.TabIndex = 43;
            desactivo.Text = "Inactivo";
            desactivo.UseVisualStyleBackColor = true;
            // 
            // direccion
            // 
            direccion.BackColor = Color.FromArgb(255, 161, 43);
            direccion.Font = new Font("Verdana", 9F, FontStyle.Bold);
            direccion.ForeColor = Color.White;
            direccion.Location = new Point(350, 80);
            direccion.Multiline = true;
            direccion.Name = "direccion";
            direccion.Size = new Size(252, 111);
            direccion.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(416, 50);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 33;
            label5.Text = "Direccion";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(106, 189);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 2);
            panel4.TabIndex = 32;
            // 
            // email
            // 
            email.BackColor = Color.FromArgb(255, 161, 43);
            email.BorderStyle = BorderStyle.None;
            email.Font = new Font("Verdana", 9F, FontStyle.Bold);
            email.ForeColor = Color.White;
            email.Location = new Point(110, 170);
            email.Name = "email";
            email.Size = new Size(192, 19);
            email.TabIndex = 31;
            email.KeyPress += email_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 166);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 30;
            label4.Text = "E-mail";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(128, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 2);
            panel2.TabIndex = 29;
            // 
            // telefono
            // 
            telefono.BackColor = Color.FromArgb(255, 161, 43);
            telefono.BorderStyle = BorderStyle.None;
            telefono.Font = new Font("Verdana", 9F, FontStyle.Bold);
            telefono.ForeColor = Color.White;
            telefono.Location = new Point(133, 110);
            telefono.Name = "telefono";
            telefono.Size = new Size(158, 19);
            telefono.TabIndex = 28;
            telefono.KeyPress += telefono_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 107);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 27;
            label2.Text = "Telefono";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(128, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 2);
            panel3.TabIndex = 26;
            // 
            // nombre
            // 
            nombre.BackColor = Color.FromArgb(255, 161, 43);
            nombre.BorderStyle = BorderStyle.None;
            nombre.Font = new Font("Verdana", 9F, FontStyle.Bold);
            nombre.ForeColor = Color.White;
            nombre.Location = new Point(133, 50);
            nombre.Name = "nombre";
            nombre.Size = new Size(158, 19);
            nombre.TabIndex = 25;
            nombre.KeyPress += nombre_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 46);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 24;
            label3.Text = "Nombre";
            // 
            // MantenimientoProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(644, 524);
            Controls.Add(panel1);
            Controls.Add(panelMantenimientoProveedor);
            Margin = new Padding(2);
            Name = "MantenimientoProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoProveedor";
            Shown += MantenimientoProveedor_Shown;
            panelMantenimientoProveedor.ResumeLayout(false);
            panelMantenimientoProveedor.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMantenimientoProveedor;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizarProveedor;
        private FontAwesome.Sharp.IconButton btnCerrarProveedor;
        private FontAwesome.Sharp.IconButton btnMinimizarProveedor;
        private Panel panel3;
        protected TextBox nombre;
        protected Label label3;
        private Panel panel4;
        protected TextBox email;
        protected Label label4;
        private Panel panel2;
        protected TextBox telefono;
        protected Label label2;
        protected TextBox direccion;
        protected Label label5;
        private Label label8;
        protected RadioButton activo;
        protected RadioButton desactivo;
        private FontAwesome.Sharp.IconButton guardar;
        private FontAwesome.Sharp.IconButton Limpiar;
        private FontAwesome.Sharp.IconButton btnConsultaProveedor;
    }
}