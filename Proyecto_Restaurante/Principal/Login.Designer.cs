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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            usuario = new TextBox();
            contasena = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnAccederLogin = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(171, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(159, 244);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 3;
            label2.Text = "Contaseña";
            // 
            // usuario
            // 
            usuario.BackColor = Color.FromArgb(255, 161, 43);
            usuario.BorderStyle = BorderStyle.None;
            usuario.ForeColor = Color.White;
            usuario.Location = new Point(96, 178);
            usuario.Margin = new Padding(4);
            usuario.Name = "usuario";
            usuario.Size = new Size(271, 24);
            usuario.TabIndex = 4;
            // 
            // contasena
            // 
            contasena.BackColor = Color.FromArgb(255, 161, 43);
            contasena.BorderStyle = BorderStyle.None;
            contasena.ForeColor = Color.White;
            contasena.Location = new Point(96, 279);
            contasena.Margin = new Padding(4);
            contasena.Name = "contasena";
            contasena.Size = new Size(271, 24);
            contasena.TabIndex = 5;
            contasena.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(92, 305);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 2);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(92, 204);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 2);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(390, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(608, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnAccederLogin
            // 
            btnAccederLogin.FlatAppearance.BorderSize = 0;
            btnAccederLogin.FlatStyle = FlatStyle.Flat;
            btnAccederLogin.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccederLogin.ForeColor = Color.White;
            btnAccederLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAccederLogin.IconColor = Color.FromArgb(255, 161, 43);
            btnAccederLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAccederLogin.Location = new Point(138, 339);
            btnAccederLogin.Margin = new Padding(4);
            btnAccederLogin.Name = "btnAccederLogin";
            btnAccederLogin.Size = new Size(201, 94);
            btnAccederLogin.TabIndex = 9;
            btnAccederLogin.Text = "Acceder ";
            btnAccederLogin.UseVisualStyleBackColor = true;
            btnAccederLogin.Click += btnAccederLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(1012, 511);
            Controls.Add(btnAccederLogin);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(contasena);
            Controls.Add(usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox usuario;
        private TextBox contasena;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnAccederLogin;
    }
}
