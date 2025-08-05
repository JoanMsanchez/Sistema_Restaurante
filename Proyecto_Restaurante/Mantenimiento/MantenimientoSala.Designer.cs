namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoSala
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
            panelSala = new Panel();
            btnMaximizarSala = new FontAwesome.Sharp.IconButton();
            btnCerrarSala = new FontAwesome.Sharp.IconButton();
            btnMinimizarSala = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panelSala.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 542);
            panel1.TabIndex = 0;
            // 
            // panelSala
            // 
            panelSala.BackColor = Color.White;
            panelSala.Controls.Add(btnMaximizarSala);
            panelSala.Controls.Add(btnCerrarSala);
            panelSala.Controls.Add(btnMinimizarSala);
            panelSala.Controls.Add(label1);
            panelSala.Dock = DockStyle.Top;
            panelSala.Location = new Point(0, 0);
            panelSala.Name = "panelSala";
            panelSala.Size = new Size(869, 68);
            panelSala.TabIndex = 1;
            panelSala.MouseDown += panelSala_MouseDown;
            // 
            // btnMaximizarSala
            // 
            btnMaximizarSala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarSala.BackColor = Color.CornflowerBlue;
            btnMaximizarSala.FlatAppearance.BorderSize = 0;
            btnMaximizarSala.FlatStyle = FlatStyle.Flat;
            btnMaximizarSala.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarSala.IconColor = Color.OldLace;
            btnMaximizarSala.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarSala.IconSize = 20;
            btnMaximizarSala.Location = new Point(784, 0);
            btnMaximizarSala.Margin = new Padding(2);
            btnMaximizarSala.Name = "btnMaximizarSala";
            btnMaximizarSala.Size = new Size(45, 25);
            btnMaximizarSala.TabIndex = 9;
            btnMaximizarSala.UseVisualStyleBackColor = false;
            btnMaximizarSala.Click += btnMaximizarSala_Click;
            // 
            // btnCerrarSala
            // 
            btnCerrarSala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSala.BackColor = Color.Tomato;
            btnCerrarSala.FlatAppearance.BorderSize = 0;
            btnCerrarSala.FlatStyle = FlatStyle.Flat;
            btnCerrarSala.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarSala.IconColor = Color.OldLace;
            btnCerrarSala.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarSala.IconSize = 20;
            btnCerrarSala.Location = new Point(824, 0);
            btnCerrarSala.Margin = new Padding(2);
            btnCerrarSala.Name = "btnCerrarSala";
            btnCerrarSala.Size = new Size(45, 25);
            btnCerrarSala.TabIndex = 10;
            btnCerrarSala.UseVisualStyleBackColor = false;
            btnCerrarSala.Click += btnCerrarSala_Click;
            // 
            // btnMinimizarSala
            // 
            btnMinimizarSala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarSala.BackColor = Color.Turquoise;
            btnMinimizarSala.FlatAppearance.BorderSize = 0;
            btnMinimizarSala.FlatStyle = FlatStyle.Flat;
            btnMinimizarSala.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarSala.IconColor = Color.OldLace;
            btnMinimizarSala.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarSala.IconSize = 20;
            btnMinimizarSala.Location = new Point(740, 0);
            btnMinimizarSala.Margin = new Padding(2);
            btnMinimizarSala.Name = "btnMinimizarSala";
            btnMinimizarSala.Size = new Size(45, 25);
            btnMinimizarSala.TabIndex = 8;
            btnMinimizarSala.UseVisualStyleBackColor = false;
            btnMinimizarSala.Click += btnMinimizarSala_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 44);
            label1.TabIndex = 1;
            label1.Text = "SALA";
            // 
            // MantenimientoSala
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(869, 542);
            Controls.Add(panelSala);
            Controls.Add(panel1);
            Name = "MantenimientoSala";
            Text = "MantenimientoSala";
            panelSala.ResumeLayout(false);
            panelSala.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelSala;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizarSala;
        private FontAwesome.Sharp.IconButton btnCerrarSala;
        private FontAwesome.Sharp.IconButton btnMinimizarSala;
    }
}