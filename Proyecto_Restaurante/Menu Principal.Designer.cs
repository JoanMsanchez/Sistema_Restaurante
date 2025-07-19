namespace Proyecto_Restaurante
{
    partial class menu
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
            barra_menu = new MenuStrip();
            pes_restaurante = new ToolStripMenuItem();
            pes_inventario = new ToolStripMenuItem();
            pes_cxc = new ToolStripMenuItem();
            barra_menu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 66);
            label1.Name = "label1";
            label1.Size = new Size(375, 45);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL";
            // 
            // barra_menu
            // 
            barra_menu.ImageScalingSize = new Size(24, 24);
            barra_menu.Items.AddRange(new ToolStripItem[] { pes_restaurante, pes_inventario, pes_cxc });
            barra_menu.Location = new Point(0, 0);
            barra_menu.Name = "barra_menu";
            barra_menu.RenderMode = ToolStripRenderMode.System;
            barra_menu.Size = new Size(1044, 34);
            barra_menu.TabIndex = 1;
            barra_menu.Text = "MENU PRINCIPAL";
            // 
            // pes_restaurante
            // 
            pes_restaurante.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pes_restaurante.Name = "pes_restaurante";
            pes_restaurante.Size = new Size(203, 30);
            pes_restaurante.Text = "RESTAURANTE";
            // 
            // pes_inventario
            // 
            pes_inventario.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            pes_inventario.Name = "pes_inventario";
            pes_inventario.Size = new Size(179, 30);
            pes_inventario.Text = "INVENTARIO";
            // 
            // pes_cxc
            // 
            pes_cxc.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            pes_cxc.Name = "pes_cxc";
            pes_cxc.Size = new Size(269, 30);
            pes_cxc.Text = "CUENTAS X COBRAR";
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1044, 523);
            Controls.Add(label1);
            Controls.Add(barra_menu);
            MainMenuStrip = barra_menu;
            Name = "menu";
            Text = "Form1";
            barra_menu.ResumeLayout(false);
            barra_menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip barra_menu;
        private ToolStripMenuItem pes_restaurante;
        private ToolStripMenuItem pes_inventario;
        private ToolStripMenuItem pes_cxc;
    }
}