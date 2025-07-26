namespace Proyecto_Restaurante.Mantenimiento
{
    partial class Producto
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
            panelProducto = new Panel();
            btnMaximizarProducto = new FontAwesome.Sharp.IconButton();
            btnCerrarProducto = new FontAwesome.Sharp.IconButton();
            btnMinimizarProducto = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel1 = new Panel();
            panelProducto.SuspendLayout();
            SuspendLayout();
            // 
            // panelProducto
            // 
            panelProducto.BackColor = Color.FromArgb(233, 233, 233);
            panelProducto.Controls.Add(btnMaximizarProducto);
            panelProducto.Controls.Add(btnCerrarProducto);
            panelProducto.Controls.Add(btnMinimizarProducto);
            panelProducto.Controls.Add(label1);
            panelProducto.Dock = DockStyle.Top;
            panelProducto.Location = new Point(0, 0);
            panelProducto.Name = "panelProducto";
            panelProducto.Size = new Size(1005, 72);
            panelProducto.TabIndex = 0;
            panelProducto.MouseDown += panelProducto_MouseDown;
            // 
            // btnMaximizarProducto
            // 
            btnMaximizarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarProducto.BackColor = Color.CornflowerBlue;
            btnMaximizarProducto.FlatAppearance.BorderSize = 0;
            btnMaximizarProducto.FlatStyle = FlatStyle.Flat;
            btnMaximizarProducto.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarProducto.IconColor = Color.OldLace;
            btnMaximizarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarProducto.IconSize = 20;
            btnMaximizarProducto.Location = new Point(920, 0);
            btnMaximizarProducto.Margin = new Padding(2);
            btnMaximizarProducto.Name = "btnMaximizarProducto";
            btnMaximizarProducto.Size = new Size(45, 25);
            btnMaximizarProducto.TabIndex = 12;
            btnMaximizarProducto.UseVisualStyleBackColor = false;
            btnMaximizarProducto.Click += btnMaximizarProducto_Click;
            // 
            // btnCerrarProducto
            // 
            btnCerrarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarProducto.BackColor = Color.Tomato;
            btnCerrarProducto.FlatAppearance.BorderSize = 0;
            btnCerrarProducto.FlatStyle = FlatStyle.Flat;
            btnCerrarProducto.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarProducto.IconColor = Color.OldLace;
            btnCerrarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarProducto.IconSize = 20;
            btnCerrarProducto.Location = new Point(960, 0);
            btnCerrarProducto.Margin = new Padding(2);
            btnCerrarProducto.Name = "btnCerrarProducto";
            btnCerrarProducto.Size = new Size(45, 25);
            btnCerrarProducto.TabIndex = 13;
            btnCerrarProducto.UseVisualStyleBackColor = false;
            btnCerrarProducto.Click += btnCerrarProducto_Click;
            // 
            // btnMinimizarProducto
            // 
            btnMinimizarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarProducto.BackColor = Color.Turquoise;
            btnMinimizarProducto.FlatAppearance.BorderSize = 0;
            btnMinimizarProducto.FlatStyle = FlatStyle.Flat;
            btnMinimizarProducto.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarProducto.IconColor = Color.OldLace;
            btnMinimizarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarProducto.IconSize = 20;
            btnMinimizarProducto.Location = new Point(877, 0);
            btnMinimizarProducto.Margin = new Padding(2);
            btnMinimizarProducto.Name = "btnMinimizarProducto";
            btnMinimizarProducto.Size = new Size(45, 25);
            btnMinimizarProducto.TabIndex = 11;
            btnMinimizarProducto.UseVisualStyleBackColor = false;
            btnMinimizarProducto.Click += btnMinimizarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 44);
            label1.TabIndex = 1;
            label1.Text = "PRODUCTO";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 440);
            panel1.TabIndex = 1;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(1005, 512);
            Controls.Add(panel1);
            Controls.Add(panelProducto);
            Name = "Producto";
            Text = "Producto";
            panelProducto.ResumeLayout(false);
            panelProducto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProducto;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizarProducto;
        private FontAwesome.Sharp.IconButton btnCerrarProducto;
        private FontAwesome.Sharp.IconButton btnMinimizarProducto;
    }
}