namespace Proyecto_Restaurante
{
    partial class Empleado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            contrasena = new TextBox();
            nombre = new TextBox();
            apellido = new TextBox();
            activo = new RadioButton();
            desactivo = new RadioButton();
            Estado = new GroupBox();
            login = new TextBox();
            datosempleado = new Panel();
            Guardar = new FontAwesome.Sharp.IconButton();
            Limpiar = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Estado.SuspendLayout();
            datosempleado.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 22);
            label1.Name = "label1";
            label1.Size = new Size(159, 29);
            label1.TabIndex = 0;
            label1.Text = "EMPLEADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(19, 88);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(19, 121);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(21, 154);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(21, 187);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // contrasena
            // 
            contrasena.Location = new Point(133, 117);
            contrasena.Name = "contrasena";
            contrasena.Size = new Size(153, 27);
            contrasena.TabIndex = 9;
            contrasena.UseSystemPasswordChar = true;
            // 
            // nombre
            // 
            nombre.Location = new Point(133, 150);
            nombre.Name = "nombre";
            nombre.Size = new Size(153, 27);
            nombre.TabIndex = 10;
            // 
            // apellido
            // 
            apellido.Location = new Point(133, 183);
            apellido.Name = "apellido";
            apellido.Size = new Size(153, 27);
            apellido.TabIndex = 11;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Location = new Point(173, 0);
            activo.Name = "activo";
            activo.Size = new Size(86, 27);
            activo.TabIndex = 17;
            activo.TabStop = true;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // desactivo
            // 
            desactivo.AutoSize = true;
            desactivo.Location = new Point(265, 0);
            desactivo.Name = "desactivo";
            desactivo.Size = new Size(114, 27);
            desactivo.TabIndex = 18;
            desactivo.TabStop = true;
            desactivo.Text = "Desactivo";
            desactivo.UseVisualStyleBackColor = true;
            // 
            // Estado
            // 
            Estado.Controls.Add(desactivo);
            Estado.Controls.Add(activo);
            Estado.FlatStyle = FlatStyle.Flat;
            Estado.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Estado.Location = new Point(334, 88);
            Estado.Name = "Estado";
            Estado.Size = new Size(378, 32);
            Estado.TabIndex = 19;
            Estado.TabStop = false;
            Estado.Text = "Estado";
            // 
            // login
            // 
            login.Location = new Point(133, 84);
            login.Name = "login";
            login.Size = new Size(153, 27);
            login.TabIndex = 8;
            // 
            // datosempleado
            // 
            datosempleado.BackColor = Color.FromArgb(255, 161, 43);
            datosempleado.Controls.Add(Guardar);
            datosempleado.Controls.Add(Limpiar);
            datosempleado.Controls.Add(label2);
            datosempleado.Controls.Add(Estado);
            datosempleado.Controls.Add(label1);
            datosempleado.Controls.Add(login);
            datosempleado.Controls.Add(label3);
            datosempleado.Controls.Add(apellido);
            datosempleado.Controls.Add(contrasena);
            datosempleado.Controls.Add(label6);
            datosempleado.Controls.Add(nombre);
            datosempleado.Controls.Add(label5);
            datosempleado.Location = new Point(12, 12);
            datosempleado.Name = "datosempleado";
            datosempleado.Size = new Size(831, 263);
            datosempleado.TabIndex = 20;
            // 
            // Guardar
            // 
            Guardar.IconChar = FontAwesome.Sharp.IconChar.None;
            Guardar.IconColor = Color.Black;
            Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Guardar.Location = new Point(355, 166);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(94, 29);
            Guardar.TabIndex = 21;
            Guardar.Text = "GUARDAR";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // Limpiar
            // 
            Limpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            Limpiar.IconColor = Color.Black;
            Limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Limpiar.Location = new Point(467, 166);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(94, 29);
            Limpiar.TabIndex = 20;
            Limpiar.Text = "LIMPIAR";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 16);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 22;
            label4.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 161, 43);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 299);
            panel1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(150, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 269);
            dataGridView1.TabIndex = 24;
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 606);
            Controls.Add(panel1);
            Controls.Add(datosempleado);
            Name = "Empleado";
            Text = "Empleado";
            Estado.ResumeLayout(false);
            Estado.PerformLayout();
            datosempleado.ResumeLayout(false);
            datosempleado.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Label label1;
        protected Label label2;
        protected Label label3;
        protected Label label5;
        protected Label label6;
        protected TextBox contrasena;
        protected TextBox nombre;
        protected TextBox apellido;
        protected TextBox textBox2;
        protected TextBox textBox3;
        protected TextBox textBox4;
        protected RadioButton activo;
        protected RadioButton desactivo;
        protected GroupBox Estado;
        protected TextBox login;
        private Panel datosempleado;
        private FontAwesome.Sharp.IconButton Guardar;
        private FontAwesome.Sharp.IconButton Limpiar;
        private Label label4;
        private TextBox textBox1;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}