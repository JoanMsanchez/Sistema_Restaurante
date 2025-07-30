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
            label1 = new Label();
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
            comboCondicion = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboCondicion);
            panel1.Controls.Add(label1);
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 533);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 223);
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
            guardar.Location = new Point(60, 372);
            guardar.Name = "guardar";
            guardar.Size = new Size(148, 52);
            guardar.TabIndex = 69;
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
            Limpiar.Location = new Point(242, 372);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(143, 52);
            Limpiar.TabIndex = 68;
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
            btnConsultaProveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnConsultaProveedor.IconColor = SystemColors.ControlLightLight;
            btnConsultaProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaProveedor.IconSize = 30;
            btnConsultaProveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaProveedor.Location = new Point(406, 372);
            btnConsultaProveedor.Margin = new Padding(2);
            btnConsultaProveedor.Name = "btnConsultaProveedor";
            btnConsultaProveedor.Size = new Size(149, 52);
            btnConsultaProveedor.TabIndex = 67;
            btnConsultaProveedor.Text = "    Consulta";
            btnConsultaProveedor.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(346, 237);
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
            activo.Location = new Point(434, 223);
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
            desactivo.Location = new Point(434, 253);
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
            direccion.Location = new Point(340, 81);
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
            label5.Location = new Point(406, 51);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 62;
            label5.Text = "Direccion";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(96, 190);
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
            email.Location = new Point(100, 171);
            email.Name = "email";
            email.Size = new Size(192, 19);
            email.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 167);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 59;
            label4.Text = "E-mail";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(118, 130);
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
            telefono.Location = new Point(123, 111);
            telefono.Name = "telefono";
            telefono.Size = new Size(158, 19);
            telefono.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 108);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 56;
            label2.Text = "Telefono";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(118, 69);
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
            nombre.Location = new Point(123, 51);
            nombre.Name = "nombre";
            nombre.Size = new Size(158, 19);
            nombre.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 47);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 53;
            label3.Text = "Nombre";
            // 
            // comboCondicion
            // 
            comboCondicion.BackColor = Color.FromArgb(255, 161, 43);
            comboCondicion.FormattingEnabled = true;
            comboCondicion.Location = new Point(60, 253);
            comboCondicion.Name = "comboCondicion";
            comboCondicion.Size = new Size(151, 28);
            comboCondicion.TabIndex = 72;
            // 
            // MantenimientoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(636, 533);
            Controls.Add(panel1);
            Name = "MantenimientoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton guardar;
        private FontAwesome.Sharp.IconButton Limpiar;
        private FontAwesome.Sharp.IconButton btnConsultaProveedor;
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
    }
}