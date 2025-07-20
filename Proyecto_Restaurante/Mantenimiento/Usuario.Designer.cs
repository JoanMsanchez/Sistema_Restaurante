namespace Proyecto_Restaurante
{
    partial class Usuario
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
            label7 = new Label();
            this.login = new TextBox();
            this.contrasena = new TextBox();
            this.nombre = new TextBox();
            this.apellido = new TextBox();
            mail = new TextBox();
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            Estado = new GroupBox();
            Rol = new GroupBox();
            Estado.SuspendLayout();
            Rol.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 18);
            label1.Name = "label1";
            label1.Size = new Size(128, 29);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(46, 79);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(46, 136);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(46, 240);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(46, 292);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(46, 345);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 6;
            label7.Text = "Mail";
            // 
            // login
            // 
            this.login.Location = new Point(219, 79);
            this.login.Name = "login";
            this.login.Size = new Size(125, 27);
            this.login.TabIndex = 8;
            // 
            // contrasena
            // 
            this.contrasena.Location = new Point(219, 132);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new Size(125, 27);
            this.contrasena.TabIndex = 9;
            // 
            // nombre
            // 
            this.nombre.Location = new Point(219, 240);
            this.nombre.Name = "nombre";
            this.nombre.Size = new Size(125, 27);
            this.nombre.TabIndex = 10;
            // 
            // apellido
            // 
            this.apellido.Location = new Point(219, 292);
            this.apellido.Name = "apellido";
            this.apellido.Size = new Size(125, 27);
            this.apellido.TabIndex = 11;
            // 
            // mail
            // 
            mail.Location = new Point(219, 345);
            mail.Name = "mail";
            mail.Size = new Size(125, 27);
            mail.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(99, 468);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "GUARDAR ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(264, 468);
            button2.Name = "button2";
            button2.Size = new Size(95, 29);
            button2.TabIndex = 14;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(173, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 27);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Admin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(264, 0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(114, 27);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Empleado";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(173, 0);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(86, 27);
            radioButton3.TabIndex = 17;
            radioButton3.TabStop = true;
            radioButton3.Text = "Activo";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(265, 0);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(114, 27);
            radioButton4.TabIndex = 18;
            radioButton4.TabStop = true;
            radioButton4.Text = "Desactivo";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Estado
            // 
            Estado.Controls.Add(radioButton4);
            Estado.Controls.Add(radioButton3);
            Estado.FlatStyle = FlatStyle.Flat;
            Estado.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Estado.Location = new Point(46, 393);
            Estado.Name = "Estado";
            Estado.Size = new Size(378, 32);
            Estado.TabIndex = 19;
            Estado.TabStop = false;
            Estado.Text = "Estado";
            // 
            // Rol
            // 
            Rol.Controls.Add(radioButton1);
            Rol.Controls.Add(radioButton2);
            Rol.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rol.Location = new Point(46, 182);
            Rol.Name = "Rol";
            Rol.Size = new Size(388, 41);
            Rol.TabIndex = 20;
            Rol.TabStop = false;
            Rol.Text = "Rol";
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 535);
            Controls.Add(Rol);
            Controls.Add(Estado);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(mail);
            Controls.Add(this.apellido);
            Controls.Add(this.nombre);
            Controls.Add(this.contrasena);
            Controls.Add(this.login);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Usuario";
            Text = "Form1";
            Estado.ResumeLayout(false);
            Estado.PerformLayout();
            Rol.ResumeLayout(false);
            Rol.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox mail;
        private Button button1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox Estado;
        private GroupBox Rol;
    }
}