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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 114);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(127, 195);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 3;
            label2.Text = "Contaseña";
            // 
            // usuario
            // 
            usuario.BackColor = Color.FromArgb(255, 161, 43);
            usuario.BorderStyle = BorderStyle.None;
            usuario.ForeColor = Color.White;
            usuario.Location = new Point(77, 142);
            usuario.Name = "usuario";
            usuario.Size = new Size(217, 20);
            usuario.TabIndex = 4;
            // 
            // contasena
            // 
            contasena.BackColor = Color.FromArgb(255, 161, 43);
            contasena.BorderStyle = BorderStyle.None;
            contasena.ForeColor = Color.White;
            contasena.Location = new Point(77, 223);
            contasena.Name = "contasena";
            contasena.Size = new Size(217, 20);
            contasena.TabIndex = 5;
            contasena.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(74, 244);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 2);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(74, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 2);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 385);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.FromArgb(255, 161, 43);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(110, 271);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(161, 75);
            iconButton1.TabIndex = 9;
            iconButton1.Text = "Acceder ";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(810, 409);
            Controls.Add(iconButton1);
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
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
