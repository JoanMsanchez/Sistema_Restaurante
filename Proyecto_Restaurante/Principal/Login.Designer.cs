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
            panelLogin = new Panel();
            btnMaximizarLogin = new FontAwesome.Sharp.IconButton();
            btnCerrarLogin = new FontAwesome.Sharp.IconButton();
            btnMinimizarLogin = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogin.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 74);
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
            label2.Location = new Point(114, 176);
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
            usuario.Font = new Font("Verdana", 9F, FontStyle.Bold);
            usuario.ForeColor = Color.White;
            usuario.Location = new Point(51, 110);
            usuario.Margin = new Padding(4);
            usuario.Name = "usuario";
            usuario.Size = new Size(271, 22);
            usuario.TabIndex = 4;
            usuario.KeyPress += usuario_KeyPress;
            // 
            // contasena
            // 
            contasena.BackColor = Color.FromArgb(255, 161, 43);
            contasena.BorderStyle = BorderStyle.None;
            contasena.Font = new Font("Verdana", 9F, FontStyle.Bold);
            contasena.ForeColor = Color.White;
            contasena.Location = new Point(51, 211);
            contasena.Margin = new Padding(4);
            contasena.Name = "contasena";
            contasena.Size = new Size(271, 22);
            contasena.TabIndex = 5;
            contasena.UseSystemPasswordChar = true;
            contasena.KeyPress += contasena_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(47, 237);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 2);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(47, 136);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 2);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(390, 32);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(529, 364);
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
            btnAccederLogin.Location = new Point(93, 271);
            btnAccederLogin.Margin = new Padding(4);
            btnAccederLogin.Name = "btnAccederLogin";
            btnAccederLogin.Size = new Size(201, 94);
            btnAccederLogin.TabIndex = 9;
            btnAccederLogin.Text = "Acceder ";
            btnAccederLogin.UseVisualStyleBackColor = true;
            btnAccederLogin.Click += btnAccederLogin_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(btnMaximizarLogin);
            panelLogin.Controls.Add(btnCerrarLogin);
            panelLogin.Controls.Add(btnMinimizarLogin);
            panelLogin.Controls.Add(label3);
            panelLogin.Dock = DockStyle.Top;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(947, 68);
            panelLogin.TabIndex = 10;
            panelLogin.MouseDown += panelLogin_MouseDown;
            // 
            // btnMaximizarLogin
            // 
            btnMaximizarLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarLogin.BackColor = Color.CornflowerBlue;
            btnMaximizarLogin.FlatAppearance.BorderSize = 0;
            btnMaximizarLogin.FlatStyle = FlatStyle.Flat;
            btnMaximizarLogin.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarLogin.IconColor = Color.OldLace;
            btnMaximizarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarLogin.IconSize = 20;
            btnMaximizarLogin.Location = new Point(861, 0);
            btnMaximizarLogin.Margin = new Padding(2);
            btnMaximizarLogin.Name = "btnMaximizarLogin";
            btnMaximizarLogin.Size = new Size(45, 25);
            btnMaximizarLogin.TabIndex = 9;
            btnMaximizarLogin.UseVisualStyleBackColor = false;
            btnMaximizarLogin.Click += btnMaximizarLogin_Click;
            // 
            // btnCerrarLogin
            // 
            btnCerrarLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarLogin.BackColor = Color.Tomato;
            btnCerrarLogin.FlatAppearance.BorderSize = 0;
            btnCerrarLogin.FlatStyle = FlatStyle.Flat;
            btnCerrarLogin.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarLogin.IconColor = Color.OldLace;
            btnCerrarLogin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarLogin.IconSize = 20;
            btnCerrarLogin.Location = new Point(901, 0);
            btnCerrarLogin.Margin = new Padding(2);
            btnCerrarLogin.Name = "btnCerrarLogin";
            btnCerrarLogin.Size = new Size(45, 25);
            btnCerrarLogin.TabIndex = 10;
            btnCerrarLogin.UseVisualStyleBackColor = false;
            btnCerrarLogin.Click += btnCerrarLogin_Click;
            // 
            // btnMinimizarLogin
            // 
            btnMinimizarLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarLogin.BackColor = Color.Turquoise;
            btnMinimizarLogin.FlatAppearance.BorderSize = 0;
            btnMinimizarLogin.FlatStyle = FlatStyle.Flat;
            btnMinimizarLogin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarLogin.IconColor = Color.OldLace;
            btnMinimizarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarLogin.IconSize = 20;
            btnMinimizarLogin.Location = new Point(818, 0);
            btnMinimizarLogin.Margin = new Padding(2);
            btnMinimizarLogin.Name = "btnMinimizarLogin";
            btnMinimizarLogin.Size = new Size(45, 25);
            btnMinimizarLogin.TabIndex = 8;
            btnMinimizarLogin.UseVisualStyleBackColor = false;
            btnMinimizarLogin.Click += btnMinimizarLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 161, 43);
            label3.Location = new Point(13, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(403, 44);
            label3.TabIndex = 1;
            label3.Text = "INICIO DE SESION";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAccederLogin);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(contasena);
            panel4.Controls.Add(usuario);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(947, 443);
            panel4.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(947, 511);
            Controls.Add(panel4);
            Controls.Add(panelLogin);
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
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
        private Panel panelLogin;
        private Panel panel4;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnMaximizarLogin;
        private FontAwesome.Sharp.IconButton btnCerrarLogin;
        private FontAwesome.Sharp.IconButton btnMinimizarLogin;
    }
}
