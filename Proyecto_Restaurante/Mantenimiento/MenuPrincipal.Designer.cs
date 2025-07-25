namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MenuPrincipal
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
            panelMenu = new Panel();
            btnCxc = new FontAwesome.Sharp.IconButton();
            btnInventario = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            btnRestaurante = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnBarraMenu = new FontAwesome.Sharp.IconButton();
            btnAccesoEmpleado = new FontAwesome.Sharp.IconButton();
            panelTitulo = new Panel();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panelEscritorio = new Panel();
            btnMenuBarAdd = new ContextMenuStrip(components);
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitulo.SuspendLayout();
            panelEscritorio.SuspendLayout();
            btnMenuBarAdd.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(255, 161, 43);
            panelMenu.Controls.Add(btnCxc);
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(iconButton5);
            panelMenu.Controls.Add(btnRestaurante);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(263, 628);
            panelMenu.TabIndex = 0;
            // 
            // btnCxc
            // 
            btnCxc.Dock = DockStyle.Top;
            btnCxc.FlatAppearance.BorderSize = 0;
            btnCxc.FlatStyle = FlatStyle.Flat;
            btnCxc.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCxc.ForeColor = Color.OldLace;
            btnCxc.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnCxc.IconColor = Color.OldLace;
            btnCxc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCxc.Location = new Point(0, 322);
            btnCxc.Name = "btnCxc";
            btnCxc.Size = new Size(263, 99);
            btnCxc.TabIndex = 2;
            btnCxc.Tag = "CUENTAS POR              COBRAR";
            btnCxc.Text = "iconButton2";
            btnCxc.TextAlign = ContentAlignment.MiddleLeft;
            btnCxc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCxc.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.OldLace;
            btnInventario.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btnInventario.IconColor = Color.OldLace;
            btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventario.Location = new Point(0, 223);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(263, 99);
            btnInventario.TabIndex = 6;
            btnInventario.Tag = "INVENTARIO";
            btnInventario.Text = "iconButton1";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            iconButton5.Dock = DockStyle.Bottom;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton5.ForeColor = Color.OldLace;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconButton5.IconColor = Color.OldLace;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 46;
            iconButton5.Location = new Point(0, 554);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(263, 74);
            iconButton5.TabIndex = 5;
            iconButton5.Tag = "LOGOUT";
            iconButton5.Text = "iconButton5";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // btnRestaurante
            // 
            btnRestaurante.Dock = DockStyle.Top;
            btnRestaurante.FlatAppearance.BorderSize = 0;
            btnRestaurante.FlatStyle = FlatStyle.Flat;
            btnRestaurante.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestaurante.ForeColor = Color.OldLace;
            btnRestaurante.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            btnRestaurante.IconColor = Color.OldLace;
            btnRestaurante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRestaurante.Location = new Point(0, 124);
            btnRestaurante.Name = "btnRestaurante";
            btnRestaurante.Size = new Size(263, 99);
            btnRestaurante.TabIndex = 3;
            btnRestaurante.Tag = "RESTAURANTE";
            btnRestaurante.Text = "iconButton3";
            btnRestaurante.TextAlign = ContentAlignment.MiddleLeft;
            btnRestaurante.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRestaurante.UseVisualStyleBackColor = true;
            btnRestaurante.Click += iconButton3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 161, 43);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBarraMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 124);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 161, 43);
            pictureBox1.ErrorImage = Properties.Resources.La_esquinita;
            pictureBox1.ForeColor = SystemColors.ControlText;
            pictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            pictureBox1.IconColor = SystemColors.ControlText;
            pictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureBox1.IconSize = 120;
            pictureBox1.InitialImage = Properties.Resources.La_esquinita;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnBarraMenu
            // 
            btnBarraMenu.FlatAppearance.BorderSize = 0;
            btnBarraMenu.FlatStyle = FlatStyle.Flat;
            btnBarraMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnBarraMenu.IconColor = Color.OldLace;
            btnBarraMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBarraMenu.IconSize = 35;
            btnBarraMenu.Location = new Point(199, 0);
            btnBarraMenu.Name = "btnBarraMenu";
            btnBarraMenu.Size = new Size(64, 61);
            btnBarraMenu.TabIndex = 1;
            btnBarraMenu.UseVisualStyleBackColor = true;
            btnBarraMenu.Click += btnBarraMenu_Click;
            // 
            // btnAccesoEmpleado
            // 
            btnAccesoEmpleado.BackColor = Color.DarkOrange;
            btnAccesoEmpleado.FlatAppearance.BorderSize = 0;
            btnAccesoEmpleado.FlatStyle = FlatStyle.Flat;
            btnAccesoEmpleado.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccesoEmpleado.ForeColor = Color.OldLace;
            btnAccesoEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnAccesoEmpleado.IconColor = Color.OldLace;
            btnAccesoEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAccesoEmpleado.Location = new Point(273, 282);
            btnAccesoEmpleado.Name = "btnAccesoEmpleado";
            btnAccesoEmpleado.Size = new Size(263, 99);
            btnAccesoEmpleado.TabIndex = 1;
            btnAccesoEmpleado.Text = "   Empleado";
            btnAccesoEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnAccesoEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccesoEmpleado.UseVisualStyleBackColor = false;
            btnAccesoEmpleado.Click += iconButton1_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.White;
            panelTitulo.Controls.Add(btnMaximizar);
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Controls.Add(btnMinimizar);
            panelTitulo.Controls.Add(label1);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(263, 0);
            panelTitulo.Margin = new Padding(2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(942, 66);
            panelTitulo.TabIndex = 0;
            panelTitulo.MouseDown += panelTitulo_MouseDown;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.CornflowerBlue;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizar.IconColor = Color.OldLace;
            btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizar.IconSize = 20;
            btnMaximizar.Location = new Point(854, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(45, 25);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.Tomato;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrar.IconColor = Color.OldLace;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrar.IconSize = 20;
            btnCerrar.Location = new Point(896, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 25);
            btnCerrar.TabIndex = 4;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.Turquoise;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizar.IconColor = Color.OldLace;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizar.IconSize = 20;
            btnMinimizar.Location = new Point(811, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 25);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(42, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(429, 48);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE SISTEMA";
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = Color.OldLace;
            panelEscritorio.Controls.Add(btnAccesoEmpleado);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(263, 66);
            panelEscritorio.Margin = new Padding(2);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(942, 562);
            panelEscritorio.TabIndex = 1;
            panelEscritorio.Paint += panelEscritorio_Paint;
            // 
            // btnMenuBarAdd
            // 
            btnMenuBarAdd.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnMenuBarAdd.ImageScalingSize = new Size(27, 27);
            btnMenuBarAdd.Items.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            btnMenuBarAdd.Name = "contextMenuStrip1";
            btnMenuBarAdd.Size = new Size(198, 34);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(197, 30);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 233, 233);
            ClientSize = new Size(1205, 628);
            Controls.Add(panelEscritorio);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            Margin = new Padding(2);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Resize += MenuPrincipal_Resize;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelEscritorio.ResumeLayout(false);
            btnMenuBarAdd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitulo;
        private Panel panelEscritorio;
        private Panel panel1;
        private ContextMenuStrip btnMenuBarAdd;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBarraMenu;
        private FontAwesome.Sharp.IconPictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnAccesoEmpleado;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btnRestaurante;
        private FontAwesome.Sharp.IconButton btnCxc;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnInventario;
    }
}