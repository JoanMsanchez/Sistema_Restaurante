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
            login = new TextBox();
            contrasena = new TextBox();
            nombre = new TextBox();
            apellido = new TextBox();
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
            label1.Location = new Point(221, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 35);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(58, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 26);
            label2.TabIndex = 1;
            label2.Text = "Nombre Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(58, 170);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 26);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(58, 300);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 26);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(58, 365);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 26);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(58, 431);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 26);
            label7.TabIndex = 6;
            label7.Text = "Mail";
            // 
            // login
            // 
            login.Location = new Point(274, 99);
            login.Margin = new Padding(4, 4, 4, 4);
            login.Name = "login";
            login.Size = new Size(155, 31);
            login.TabIndex = 8;
            // 
            // contrasena
            // 
            contrasena.Location = new Point(274, 165);
            contrasena.Margin = new Padding(4, 4, 4, 4);
            contrasena.Name = "contrasena";
            contrasena.Size = new Size(155, 31);
            contrasena.TabIndex = 9;
            contrasena.UseSystemPasswordChar = true;
            // 
            // nombre
            // 
            nombre.Location = new Point(274, 300);
            nombre.Margin = new Padding(4, 4, 4, 4);
            nombre.Name = "nombre";
            nombre.Size = new Size(155, 31);
            nombre.TabIndex = 10;
            // 
            // apellido
            // 
            apellido.Location = new Point(274, 365);
            apellido.Margin = new Padding(4, 4, 4, 4);
            apellido.Name = "apellido";
            apellido.Size = new Size(155, 31);
            apellido.TabIndex = 11;
            // 
            // mail
            // 
            mail.Location = new Point(274, 431);
            mail.Margin = new Padding(4, 4, 4, 4);
            mail.Name = "mail";
            mail.Size = new Size(155, 31);
            mail.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(124, 585);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 13;
            button1.Text = "GUARDAR ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(330, 585);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(119, 36);
            button2.TabIndex = 14;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(216, 0);
            radioButton1.Margin = new Padding(4, 4, 4, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(106, 30);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Admin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(330, 0);
            radioButton2.Margin = new Padding(4, 4, 4, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(140, 30);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Empleado";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(216, 0);
            radioButton3.Margin = new Padding(4, 4, 4, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(103, 30);
            radioButton3.TabIndex = 17;
            radioButton3.TabStop = true;
            radioButton3.Text = "Activo";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(331, 0);
            radioButton4.Margin = new Padding(4, 4, 4, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(135, 30);
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
            Estado.Location = new Point(58, 491);
            Estado.Margin = new Padding(4, 4, 4, 4);
            Estado.Name = "Estado";
            Estado.Padding = new Padding(4, 4, 4, 4);
            Estado.Size = new Size(472, 40);
            Estado.TabIndex = 19;
            Estado.TabStop = false;
            Estado.Text = "Estado";
            // 
            // Rol
            // 
            Rol.Controls.Add(radioButton1);
            Rol.Controls.Add(radioButton2);
            Rol.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rol.Location = new Point(58, 228);
            Rol.Margin = new Padding(4, 4, 4, 4);
            Rol.Name = "Rol";
            Rol.Padding = new Padding(4, 4, 4, 4);
            Rol.Size = new Size(485, 51);
            Rol.TabIndex = 20;
            Rol.TabStop = false;
            Rol.Text = "Rol";
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 669);
            Controls.Add(Rol);
            Controls.Add(Estado);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(mail);
            Controls.Add(apellido);
            Controls.Add(nombre);
            Controls.Add(contrasena);
            Controls.Add(login);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
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

        protected Label label1;
        protected Label label2;
        protected Label label3;
        protected Label label4;
        protected Label label5;
        protected Label label6;
        protected Label label7;
        protected TextBox login;
        protected TextBox contrasena;
        protected TextBox nombre;
        protected TextBox apellido;
        protected TextBox textBox1;
        protected TextBox textBox2;
        protected TextBox textBox3;
        protected TextBox textBox4;
        protected TextBox mail;
        protected Button button1;
        protected Button button2;
        protected RadioButton radioButton1;
        protected RadioButton radioButton2;
        protected RadioButton radioButton3;
        protected RadioButton radioButton4;
        protected GroupBox Estado;
        protected GroupBox Rol;
    }
}