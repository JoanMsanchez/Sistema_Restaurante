namespace Proyecto_Restaurante
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Acceder = new Button();
            Usuario = new Label();
            contasena = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // Acceder
            // 
            Acceder.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Acceder.Location = new Point(109, 337);
            Acceder.Margin = new Padding(2);
            Acceder.Name = "Acceder";
            Acceder.Size = new Size(136, 58);
            Acceder.TabIndex = 0;
            Acceder.Text = "Acceder";
            Acceder.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Usuario.Location = new Point(42, 41);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(90, 25);
            Usuario.TabIndex = 2;
            Usuario.Text = "Usuario";
            // 
            // contasena
            // 
            contasena.AutoSize = true;
            contasena.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contasena.Location = new Point(42, 176);
            contasena.Name = "contasena";
            contasena.Size = new Size(119, 25);
            contasena.TabIndex = 3;
            contasena.Text = "Contaseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 498);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(contasena);
            Controls.Add(Usuario);
            Controls.Add(Acceder);
            Margin = new Padding(2);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Acceder;
        private Label Usuario;
        private Label contasena;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
