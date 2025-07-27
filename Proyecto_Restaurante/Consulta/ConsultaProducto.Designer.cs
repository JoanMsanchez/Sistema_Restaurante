namespace Proyecto_Restaurante.Consulta
{
    partial class Productos
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
            panel2 = new Panel();
            label1 = new Label();
            btnMaximizarProducto = new FontAwesome.Sharp.IconButton();
            btnCerrarProducto = new FontAwesome.Sharp.IconButton();
            btnMinimizarProducto = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnMaximizarProducto);
            panel1.Controls.Add(btnCerrarProducto);
            panel1.Controls.Add(btnMinimizarProducto);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 72);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 501);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(23, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 44);
            label1.TabIndex = 2;
            label1.Text = "PRODUCTO";
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
            btnMaximizarProducto.Location = new Point(863, 0);
            btnMaximizarProducto.Margin = new Padding(2);
            btnMaximizarProducto.Name = "btnMaximizarProducto";
            btnMaximizarProducto.Size = new Size(45, 25);
            btnMaximizarProducto.TabIndex = 15;
            btnMaximizarProducto.UseVisualStyleBackColor = false;
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
            btnCerrarProducto.Location = new Point(903, 0);
            btnCerrarProducto.Margin = new Padding(2);
            btnCerrarProducto.Name = "btnCerrarProducto";
            btnCerrarProducto.Size = new Size(45, 25);
            btnCerrarProducto.TabIndex = 16;
            btnCerrarProducto.UseVisualStyleBackColor = false;
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
            btnMinimizarProducto.Location = new Point(820, 0);
            btnMinimizarProducto.Margin = new Padding(2);
            btnMinimizarProducto.Name = "btnMinimizarProducto";
            btnMinimizarProducto.Size = new Size(45, 25);
            btnMinimizarProducto.TabIndex = 14;
            btnMinimizarProducto.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(948, 573);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Productos";
            Text = "Productos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizarProducto;
        private FontAwesome.Sharp.IconButton btnCerrarProducto;
        private FontAwesome.Sharp.IconButton btnMinimizarProducto;
    }
}