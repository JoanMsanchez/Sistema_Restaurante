namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoMesa
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
            panelMesa = new Panel();
            btnMaximizarMesa = new FontAwesome.Sharp.IconButton();
            btnCerrarMesa = new FontAwesome.Sharp.IconButton();
            btnMinimizarMesa = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel2 = new Panel();
            panelMesa.SuspendLayout();
            SuspendLayout();
            // 
            // panelMesa
            // 
            panelMesa.BackColor = Color.White;
            panelMesa.Controls.Add(btnMaximizarMesa);
            panelMesa.Controls.Add(btnCerrarMesa);
            panelMesa.Controls.Add(btnMinimizarMesa);
            panelMesa.Controls.Add(label1);
            panelMesa.Dock = DockStyle.Top;
            panelMesa.Location = new Point(0, 0);
            panelMesa.Name = "panelMesa";
            panelMesa.Size = new Size(761, 68);
            panelMesa.TabIndex = 0;
            panelMesa.MouseDown += panelMesa_MouseDown;
            // 
            // btnMaximizarMesa
            // 
            btnMaximizarMesa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarMesa.BackColor = Color.CornflowerBlue;
            btnMaximizarMesa.FlatAppearance.BorderSize = 0;
            btnMaximizarMesa.FlatStyle = FlatStyle.Flat;
            btnMaximizarMesa.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarMesa.IconColor = Color.OldLace;
            btnMaximizarMesa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarMesa.IconSize = 20;
            btnMaximizarMesa.Location = new Point(676, 0);
            btnMaximizarMesa.Margin = new Padding(2);
            btnMaximizarMesa.Name = "btnMaximizarMesa";
            btnMaximizarMesa.Size = new Size(45, 25);
            btnMaximizarMesa.TabIndex = 9;
            btnMaximizarMesa.UseVisualStyleBackColor = false;
            btnMaximizarMesa.Click += btnMaximizarMesa_Click;
            // 
            // btnCerrarMesa
            // 
            btnCerrarMesa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarMesa.BackColor = Color.Tomato;
            btnCerrarMesa.FlatAppearance.BorderSize = 0;
            btnCerrarMesa.FlatStyle = FlatStyle.Flat;
            btnCerrarMesa.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarMesa.IconColor = Color.OldLace;
            btnCerrarMesa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarMesa.IconSize = 20;
            btnCerrarMesa.Location = new Point(716, 0);
            btnCerrarMesa.Margin = new Padding(2);
            btnCerrarMesa.Name = "btnCerrarMesa";
            btnCerrarMesa.Size = new Size(45, 25);
            btnCerrarMesa.TabIndex = 10;
            btnCerrarMesa.UseVisualStyleBackColor = false;
            btnCerrarMesa.Click += btnCerrarMesa_Click;
            // 
            // btnMinimizarMesa
            // 
            btnMinimizarMesa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarMesa.BackColor = Color.Turquoise;
            btnMinimizarMesa.FlatAppearance.BorderSize = 0;
            btnMinimizarMesa.FlatStyle = FlatStyle.Flat;
            btnMinimizarMesa.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarMesa.IconColor = Color.OldLace;
            btnMinimizarMesa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarMesa.IconSize = 20;
            btnMinimizarMesa.Location = new Point(632, 0);
            btnMinimizarMesa.Margin = new Padding(2);
            btnMinimizarMesa.Name = "btnMinimizarMesa";
            btnMinimizarMesa.Size = new Size(45, 25);
            btnMinimizarMesa.TabIndex = 8;
            btnMinimizarMesa.UseVisualStyleBackColor = false;
            btnMinimizarMesa.Click += btnMinimizarMesa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 44);
            label1.TabIndex = 1;
            label1.Text = "MESA";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(761, 521);
            panel2.TabIndex = 1;
            // 
            // MantenimientoMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(761, 589);
            Controls.Add(panel2);
            Controls.Add(panelMesa);
            Margin = new Padding(4);
            Name = "MantenimientoMesa";
            Text = "MantenimientoMesa";
            panelMesa.ResumeLayout(false);
            panelMesa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMesa;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizarMesa;
        private FontAwesome.Sharp.IconButton btnCerrarMesa;
        private FontAwesome.Sharp.IconButton btnMinimizarMesa;
    }
}