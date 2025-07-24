namespace Proyecto_Restaurante.Mantenimiento
{
    partial class FormPadre
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPadre));
            panelMenu = new Panel();
            button4 = new Button();
            panel1 = new Panel();
            btnMenuBar = new Button();
            pictureBox1 = new PictureBox();
            panelTitulo = new Panel();
            label1 = new Label();
            panelEscritorio = new Panel();
            btnMenuBarAdd = new ContextMenuStrip(components);
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitulo.SuspendLayout();
            btnMenuBarAdd.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(255, 201, 0);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2, 2, 2, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(203, 502);
            panelMenu.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(17, 118);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(173, 59);
            button4.TabIndex = 5;
            button4.Text = "Empleado";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMenuBar);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 98);
            panel1.TabIndex = 0;
            // 
            // btnMenuBar
            // 
            btnMenuBar.FlatAppearance.BorderSize = 0;
            btnMenuBar.FlatStyle = FlatStyle.Flat;
            btnMenuBar.Image = (Image)resources.GetObject("btnMenuBar.Image");
            btnMenuBar.Location = new Point(145, 0);
            btnMenuBar.Margin = new Padding(2, 2, 2, 2);
            btnMenuBar.Name = "btnMenuBar";
            btnMenuBar.Size = new Size(58, 67);
            btnMenuBar.TabIndex = 1;
            btnMenuBar.UseVisualStyleBackColor = true;
            btnMenuBar.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 67);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.White;
            panelTitulo.Controls.Add(label1);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(203, 0);
            panelTitulo.Margin = new Padding(2, 2, 2, 2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(761, 67);
            panelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold);
            label1.Location = new Point(202, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(364, 42);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE SISTEMA";
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = Color.FromArgb(233, 233, 233);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(203, 67);
            panelEscritorio.Margin = new Padding(2, 2, 2, 2);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(761, 435);
            panelEscritorio.TabIndex = 1;
            // 
            // btnMenuBarAdd
            // 
            btnMenuBarAdd.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnMenuBarAdd.ImageScalingSize = new Size(27, 27);
            btnMenuBarAdd.Items.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            btnMenuBarAdd.Name = "contextMenuStrip1";
            btnMenuBarAdd.Size = new Size(183, 28);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(182, 24);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // FormPadre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 233, 233);
            ClientSize = new Size(964, 502);
            Controls.Add(panelEscritorio);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormPadre";
            Text = "FormularioPadre";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            btnMenuBarAdd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitulo;
        private Panel panelEscritorio;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button btnMenuBar;
        private ContextMenuStrip btnMenuBarAdd;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private Label label1;
    }
}