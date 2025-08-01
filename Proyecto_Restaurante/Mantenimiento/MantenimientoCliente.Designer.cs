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
            btnMaximizarCategoria = new FontAwesome.Sharp.IconButton();
            btnCerrarCategoria = new FontAwesome.Sharp.IconButton();
            btnMinimizarCategoria = new FontAwesome.Sharp.IconButton();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 469);
            panel1.TabIndex = 0;
            // 
            // comboCondicion
            // 
            comboCondicion.BackColor = Color.FromArgb(255, 161, 43);
            comboCondicion.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCondicion.ForeColor = Color.White;
            comboCondicion.FormattingEnabled = true;
            comboCondicion.Location = new Point(58, 291);
            comboCondicion.Name = "comboCondicion";
            comboCondicion.Size = new Size(151, 26);
            comboCondicion.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 262);
            label1.Name = "label1";
            label1.Size = new Size(219, 25);
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
            guardar.Location = new Point(76, 387);
            guardar.Name = "guardar";
            guardar.Size = new Size(154, 52);
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
            Limpiar.Location = new Point(258, 387);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(143, 52);
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
            btnConsultaCliente.Location = new Point(437, 387);
            btnConsultaCliente.Margin = new Padding(2);
            btnConsultaCliente.Name = "btnConsultaCliente";
            btnConsultaCliente.Size = new Size(149, 52);
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
            label8.Location = new Point(397, 271);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 66;
            label8.Text = "Estado";
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activo.ForeColor = SystemColors.ControlLightLight;
            activo.Location = new Point(485, 258);
            activo.Name = "activo";
            activo.Size = new Size(90, 24);
            activo.TabIndex = 64;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // desactivo
            // 
            desactivo.AutoSize = true;
            desactivo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desactivo.ForeColor = SystemColors.ControlLightLight;
            desactivo.Location = new Point(485, 287);
            desactivo.Name = "desactivo";
            desactivo.Size = new Size(109, 24);
            desactivo.TabIndex = 65;
            desactivo.Text = "Inactivo";
            desactivo.UseVisualStyleBackColor = true;
            // 
            // direccion
            // 
            direccion.BackColor = Color.FromArgb(255, 161, 43);
            direccion.Font = new Font("Verdana", 9F, FontStyle.Bold);
            direccion.ForeColor = Color.White;
            direccion.Location = new Point(370, 114);
            direccion.Multiline = true;
            direccion.Name = "direccion";
            direccion.Size = new Size(252, 111);
            direccion.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(437, 84);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 62;
            label5.Text = "Direccion";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(94, 229);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 2);
            panel4.TabIndex = 61;
            // 
            // email
            // 
            email.BackColor = Color.FromArgb(255, 161, 43);
            email.BorderStyle = BorderStyle.None;
            email.Font = new Font("Verdana", 9F, FontStyle.Bold);
            email.ForeColor = Color.White;
            email.Location = new Point(98, 210);
            email.Name = "email";
            email.Size = new Size(192, 19);
            email.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 206);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 59;
            label4.Text = "E-mail";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(117, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 2);
            panel2.TabIndex = 58;
            // 
            // telefono
            // 
            telefono.BackColor = Color.FromArgb(255, 161, 43);
            telefono.BorderStyle = BorderStyle.None;
            telefono.Font = new Font("Verdana", 9F, FontStyle.Bold);
            telefono.ForeColor = Color.White;
            telefono.Location = new Point(122, 150);
            telefono.Name = "telefono";
            telefono.Size = new Size(158, 19);
            telefono.TabIndex = 57;
            telefono.KeyPress += telefono_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 146);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 56;
            label2.Text = "Telefono";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(117, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 2);
            panel3.TabIndex = 55;
            // 
            // nombre
            // 
            nombre.BackColor = Color.FromArgb(255, 161, 43);
            nombre.BorderStyle = BorderStyle.None;
            nombre.Font = new Font("Verdana", 9F, FontStyle.Bold);
            nombre.ForeColor = Color.White;
            nombre.Location = new Point(122, 90);
            nombre.Name = "nombre";
            nombre.Size = new Size(158, 19);
            nombre.TabIndex = 54;
            nombre.KeyPress += nombre_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 86);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 53;
            label3.Text = "Nombre";
            // 
            // panelMantenimientoCliente
            // 
            panelMantenimientoCliente.BackColor = Color.White;
            panelMantenimientoCliente.Controls.Add(btnMaximizarCategoria);
            panelMantenimientoCliente.Controls.Add(btnCerrarCategoria);
            panelMantenimientoCliente.Controls.Add(btnMinimizarCategoria);
            panelMantenimientoCliente.Controls.Add(label6);
            panelMantenimientoCliente.Dock = DockStyle.Top;
            panelMantenimientoCliente.Location = new Point(0, 0);
            panelMantenimientoCliente.Margin = new Padding(2);
            panelMantenimientoCliente.Name = "panelMantenimientoCliente";
            panelMantenimientoCliente.Size = new Size(668, 54);
            panelMantenimientoCliente.TabIndex = 1;
            panelMantenimientoCliente.MouseDown += panelMantenimientoCliente_MouseDown;
            // 
            // btnMaximizarCategoria
            // 
            btnMaximizarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarCategoria.BackColor = Color.CornflowerBlue;
            btnMaximizarCategoria.FlatAppearance.BorderSize = 0;
            btnMaximizarCategoria.FlatStyle = FlatStyle.Flat;
            btnMaximizarCategoria.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarCategoria.IconColor = Color.OldLace;
            btnMaximizarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarCategoria.IconSize = 20;
            btnMaximizarCategoria.Location = new Point(600, 0);
            btnMaximizarCategoria.Margin = new Padding(2);
            btnMaximizarCategoria.Name = "btnMaximizarCategoria";
            btnMaximizarCategoria.Size = new Size(36, 20);
            btnMaximizarCategoria.TabIndex = 9;
            btnMaximizarCategoria.UseVisualStyleBackColor = false;
            btnMaximizarCategoria.Click += btnMaximizarCategoria_Click;
            // 
            // btnCerrarCategoria
            // 
            btnCerrarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarCategoria.BackColor = Color.Tomato;
            btnCerrarCategoria.FlatAppearance.BorderSize = 0;
            btnCerrarCategoria.FlatStyle = FlatStyle.Flat;
            btnCerrarCategoria.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarCategoria.IconColor = Color.OldLace;
            btnCerrarCategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarCategoria.IconSize = 20;
            btnCerrarCategoria.Location = new Point(632, 0);
            btnCerrarCategoria.Margin = new Padding(2);
            btnCerrarCategoria.Name = "btnCerrarCategoria";
            btnCerrarCategoria.Size = new Size(36, 20);
            btnCerrarCategoria.TabIndex = 10;
            btnCerrarCategoria.UseVisualStyleBackColor = false;
            btnCerrarCategoria.Click += btnCerrarCategoria_Click;
            // 
            // btnMinimizarCategoria
            // 
            btnMinimizarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarCategoria.BackColor = Color.Turquoise;
            btnMinimizarCategoria.FlatAppearance.BorderSize = 0;
            btnMinimizarCategoria.FlatStyle = FlatStyle.Flat;
            btnMinimizarCategoria.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarCategoria.IconColor = Color.OldLace;
            btnMinimizarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarCategoria.IconSize = 20;
            btnMinimizarCategoria.Location = new Point(566, 0);
            btnMinimizarCategoria.Margin = new Padding(2);
            btnMinimizarCategoria.Name = "btnMinimizarCategoria";
            btnMinimizarCategoria.Size = new Size(36, 20);
            btnMinimizarCategoria.TabIndex = 8;
            btnMinimizarCategoria.UseVisualStyleBackColor = false;
            btnMinimizarCategoria.Click += btnMinimizarCategoria_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 161, 43);
            label6.Location = new Point(10, 7);
            label6.Name = "label6";
            label6.Size = new Size(159, 36);
            label6.TabIndex = 1;
            label6.Text = "CLIENTE";
            // 
            // MantenimientoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(668, 469);
            Controls.Add(panelMantenimientoCliente);
            Controls.Add(panel1);
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
        private FontAwesome.Sharp.IconButton btnMaximizarCategoria;
        private FontAwesome.Sharp.IconButton btnCerrarCategoria;
        private FontAwesome.Sharp.IconButton btnMinimizarCategoria;
    }
}