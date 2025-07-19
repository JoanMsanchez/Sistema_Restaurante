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
            label1 = new Label();
            label2 = new Label();
            usuario = new TextBox();
            contasena = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // Acceder
            // 
            Acceder.FlatAppearance.BorderSize = 0;
            Acceder.FlatStyle = FlatStyle.Flat;
            Acceder.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Acceder.Location = new Point(74, 336);
            Acceder.Margin = new Padding(2);
            Acceder.Name = "Acceder";
            Acceder.Size = new Size(220, 58);
            Acceder.TabIndex = 0;
            Acceder.Text = "Acceder";
            Acceder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 69);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 210);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 3;
            label2.Text = "Contaseña";
            // 
            // usuario
            // 
            usuario.BackColor = SystemColors.Window;
            usuario.BorderStyle = BorderStyle.None;
            usuario.Location = new Point(77, 110);
            usuario.Name = "usuario";
            usuario.Size = new Size(217, 20);
            usuario.TabIndex = 4;
            // 
            // contasena
            // 
            contasena.BackColor = SystemColors.Window;
            contasena.BorderStyle = BorderStyle.None;
            contasena.Location = new Point(77, 250);
            contasena.Name = "contasena";
            contasena.Size = new Size(217, 20);
            contasena.TabIndex = 5;
            contasena.UseSystemPasswordChar = true;
            contasena.TextChanged += contasena_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(74, 271);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 2);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(74, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 2);
            panel3.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(374, 453);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(contasena);
            Controls.Add(usuario);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private TextBox usuario;
        private TextBox contasena;
        private Panel panel2;
        private Panel panel3;
    }
}
