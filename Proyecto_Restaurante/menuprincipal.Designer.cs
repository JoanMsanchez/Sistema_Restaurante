namespace Proyecto_Restaurante
{
    partial class menuprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuprincipal));
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
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // barra_menu
            // 
            resources.ApplyResources(barra_menu, "barra_menu");
            barra_menu.BackColor = SystemColors.ActiveCaption;
            barra_menu.ImageScalingSize = new Size(24, 24);
            barra_menu.Items.AddRange(new ToolStripItem[] { pes_restaurante, pes_inventario, pes_cxc });
            barra_menu.Name = "barra_menu";
            barra_menu.RenderMode = ToolStripRenderMode.System;
            // 
            // pes_restaurante
            // 
            resources.ApplyResources(pes_restaurante, "pes_restaurante");
            pes_restaurante.Name = "pes_restaurante";
            // 
            // pes_inventario
            // 
            resources.ApplyResources(pes_inventario, "pes_inventario");
            pes_inventario.Name = "pes_inventario";
            // 
            // pes_cxc
            // 
            resources.ApplyResources(pes_cxc, "pes_cxc");
            pes_cxc.Name = "pes_cxc";
            // 
            // menuprincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label1);
            Controls.Add(barra_menu);
            MainMenuStrip = barra_menu;
            Name = "menuprincipal";
            //Load += this.menu_Load;
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