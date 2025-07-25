﻿namespace Proyecto_Restaurante.Mantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            panelMenu = new Panel();
            btnCxc = new FontAwesome.Sharp.IconButton();
            btnInventario = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            btnRestaurante = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnBarraMenu = new FontAwesome.Sharp.IconButton();
            panelTitulo = new Panel();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panelEscritorio = new Panel();
            DropMenu_restaurante = new ContextMenuStrip(components);
            procesosRestaurante = new FontAwesome.Sharp.IconMenuItem();
            FacturacionRestaurante = new FontAwesome.Sharp.IconMenuItem();
            MantenimientoRestaurante = new FontAwesome.Sharp.IconMenuItem();
            MantenimientoMesas = new FontAwesome.Sharp.IconMenuItem();
            MantenimientoEmpleados = new FontAwesome.Sharp.IconMenuItem();
            DropMenu_inventario = new ContextMenuStrip(components);
            MantenimientoInventario = new FontAwesome.Sharp.IconMenuItem();
            MantenimientoProductos = new FontAwesome.Sharp.IconMenuItem();
            MantenimientoCategoria = new FontAwesome.Sharp.IconMenuItem();
            MantenimientoUnidades = new FontAwesome.Sharp.IconMenuItem();
            MantenimientoProveedores = new FontAwesome.Sharp.IconMenuItem();
            MantenimientoTipoDeMovimiento = new FontAwesome.Sharp.IconMenuItem();
            ProcesosInventario = new FontAwesome.Sharp.IconMenuItem();
            RegistroDeMovimientoInventario = new FontAwesome.Sharp.IconMenuItem();
            ConsultasInventario = new FontAwesome.Sharp.IconMenuItem();
            ConsultaProducto = new FontAwesome.Sharp.IconMenuItem();
            ResportesInventario = new FontAwesome.Sharp.IconMenuItem();
            StockAnualInventario = new FontAwesome.Sharp.IconMenuItem();
            EntradasSalidasInventario = new FontAwesome.Sharp.IconMenuItem();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitulo.SuspendLayout();
            DropMenu_restaurante.SuspendLayout();
            DropMenu_inventario.SuspendLayout();
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
            panelMenu.Size = new Size(262, 628);
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
            btnCxc.Margin = new Padding(2);
            btnCxc.Name = "btnCxc";
            btnCxc.Size = new Size(262, 99);
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
            btnInventario.Margin = new Padding(2);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(262, 99);
            btnInventario.TabIndex = 6;
            btnInventario.Tag = "INVENTARIO";
            btnInventario.Text = "iconButton1";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
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
            iconButton5.Margin = new Padding(2);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(262, 74);
            iconButton5.TabIndex = 5;
            iconButton5.Tag = "LOGOUT";
            iconButton5.Text = "iconButton5";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
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
            btnRestaurante.Margin = new Padding(2);
            btnRestaurante.Name = "btnRestaurante";
            btnRestaurante.Size = new Size(262, 99);
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
            panel1.Size = new Size(262, 124);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
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
            btnBarraMenu.Margin = new Padding(2);
            btnBarraMenu.Name = "btnBarraMenu";
            btnBarraMenu.Size = new Size(64, 61);
            btnBarraMenu.TabIndex = 1;
            btnBarraMenu.UseVisualStyleBackColor = true;
            btnBarraMenu.Click += btnBarraMenu_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.White;
            panelTitulo.Controls.Add(btnMaximizar);
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Controls.Add(btnMinimizar);
            panelTitulo.Controls.Add(label1);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(262, 0);
            panelTitulo.Margin = new Padding(2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(943, 71);
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
            btnMaximizar.Location = new Point(856, 0);
            btnMaximizar.Margin = new Padding(2);
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
            btnCerrar.Location = new Point(898, 0);
            btnCerrar.Margin = new Padding(2);
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
            btnMinimizar.Location = new Point(813, 0);
            btnMinimizar.Margin = new Padding(2);
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
            label1.Size = new Size(347, 48);
            label1.TabIndex = 0;
            label1.Text = "LA ESQUINITA";
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = Color.OldLace;
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(262, 71);
            panelEscritorio.Margin = new Padding(2);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(943, 557);
            panelEscritorio.TabIndex = 1;
            panelEscritorio.Paint += panelEscritorio_Paint;
            // 
            // DropMenu_restaurante
            // 
            DropMenu_restaurante.ImageScalingSize = new Size(24, 24);
            DropMenu_restaurante.Items.AddRange(new ToolStripItem[] { MantenimientoRestaurante, procesosRestaurante });
            DropMenu_restaurante.Name = "DropMenu_restaurante";
            DropMenu_restaurante.Size = new Size(272, 68);
            // 
            // procesosRestaurante
            // 
            procesosRestaurante.BackColor = Color.Orange;
            procesosRestaurante.DropDownItems.AddRange(new ToolStripItem[] { FacturacionRestaurante });
            procesosRestaurante.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            procesosRestaurante.ForeColor = SystemColors.ButtonHighlight;
            procesosRestaurante.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            procesosRestaurante.IconColor = Color.White;
            procesosRestaurante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            procesosRestaurante.Name = "procesosRestaurante";
            procesosRestaurante.Size = new Size(271, 32);
            procesosRestaurante.Text = "Procesos";
            // 
            // FacturacionRestaurante
            // 
            FacturacionRestaurante.BackColor = Color.DarkOrange;
            FacturacionRestaurante.ForeColor = SystemColors.ButtonHighlight;
            FacturacionRestaurante.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            FacturacionRestaurante.IconColor = Color.White;
            FacturacionRestaurante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            FacturacionRestaurante.Name = "FacturacionRestaurante";
            FacturacionRestaurante.Size = new Size(270, 34);
            FacturacionRestaurante.Text = "Facturacion";
            // 
            // MantenimientoRestaurante
            // 
            MantenimientoRestaurante.BackColor = Color.Orange;
            MantenimientoRestaurante.DropDownItems.AddRange(new ToolStripItem[] { MantenimientoMesas, MantenimientoEmpleados });
            MantenimientoRestaurante.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MantenimientoRestaurante.ForeColor = SystemColors.ControlLightLight;
            MantenimientoRestaurante.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            MantenimientoRestaurante.IconColor = Color.White;
            MantenimientoRestaurante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MantenimientoRestaurante.Name = "MantenimientoRestaurante";
            MantenimientoRestaurante.Size = new Size(271, 32);
            MantenimientoRestaurante.Text = "Mantenimientos";
            // 
            // MantenimientoMesas
            // 
            MantenimientoMesas.BackColor = Color.DarkOrange;
            MantenimientoMesas.ForeColor = SystemColors.ControlLightLight;
            MantenimientoMesas.IconChar = FontAwesome.Sharp.IconChar.Chair;
            MantenimientoMesas.IconColor = Color.White;
            MantenimientoMesas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MantenimientoMesas.Name = "MantenimientoMesas";
            MantenimientoMesas.Size = new Size(270, 34);
            MantenimientoMesas.Text = "Mesas";
            // 
            // MantenimientoEmpleados
            // 
            MantenimientoEmpleados.BackColor = Color.DarkOrange;
            MantenimientoEmpleados.ForeColor = SystemColors.ControlLightLight;
            MantenimientoEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            MantenimientoEmpleados.IconColor = Color.White;
            MantenimientoEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MantenimientoEmpleados.Name = "MantenimientoEmpleados";
            MantenimientoEmpleados.Size = new Size(270, 34);
            MantenimientoEmpleados.Text = "Empleados";
            MantenimientoEmpleados.Click += MantenimientoEmpleados_Click;
            // 
            // DropMenu_inventario
            // 
            DropMenu_inventario.ImageScalingSize = new Size(24, 24);
            DropMenu_inventario.Items.AddRange(new ToolStripItem[] { MantenimientoInventario, ProcesosInventario, ConsultasInventario, ResportesInventario });
            DropMenu_inventario.Name = "DropMenu_inventario";
            DropMenu_inventario.Size = new Size(272, 132);
            // 
            // MantenimientoInventario
            // 
            MantenimientoInventario.BackColor = Color.Orange;
            MantenimientoInventario.DropDownItems.AddRange(new ToolStripItem[] { MantenimientoProductos, MantenimientoCategoria, MantenimientoUnidades, MantenimientoProveedores, MantenimientoTipoDeMovimiento });
            MantenimientoInventario.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MantenimientoInventario.ForeColor = SystemColors.ControlLightLight;
            MantenimientoInventario.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            MantenimientoInventario.IconColor = Color.White;
            MantenimientoInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MantenimientoInventario.Name = "MantenimientoInventario";
            MantenimientoInventario.Size = new Size(271, 32);
            MantenimientoInventario.Text = "Mantenimientos";
            // 
            // MantenimientoProductos
            // 
            MantenimientoProductos.BackColor = Color.DarkOrange;
            MantenimientoProductos.ForeColor = SystemColors.ControlLightLight;
            MantenimientoProductos.IconChar = FontAwesome.Sharp.IconChar.Burger;
            MantenimientoProductos.IconColor = Color.White;
            MantenimientoProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MantenimientoProductos.Name = "MantenimientoProductos";
            MantenimientoProductos.Size = new Size(338, 34);
            MantenimientoProductos.Text = "Productos";
            MantenimientoProductos.Click += MantenimientoProductos_Click;
            // 
            // MantenimientoCategoria
            // 
            MantenimientoCategoria.BackColor = Color.DarkOrange;
            MantenimientoCategoria.ForeColor = SystemColors.ControlLightLight;
            MantenimientoCategoria.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            MantenimientoCategoria.IconColor = Color.White;
            MantenimientoCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MantenimientoCategoria.Name = "MantenimientoCategoria";
            MantenimientoCategoria.Size = new Size(338, 34);
            MantenimientoCategoria.Text = "Categorias";
            MantenimientoCategoria.Click += MantenimientoCategoria_Click;
            // 
            // MantenimientoUnidades
            // 
            MantenimientoUnidades.BackColor = Color.DarkOrange;
            MantenimientoUnidades.ForeColor = SystemColors.ControlLightLight;
            MantenimientoUnidades.IconChar = FontAwesome.Sharp.IconChar.ScaleBalanced;
            MantenimientoUnidades.IconColor = Color.White;
            MantenimientoUnidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MantenimientoUnidades.Name = "MantenimientoUnidades";
            MantenimientoUnidades.Size = new Size(338, 34);
            MantenimientoUnidades.Text = "Unidades de Medida";
            MantenimientoUnidades.Click += MantenimientoUnidades_Click;
            // 
            // MantenimientoProveedores
            // 
            MantenimientoProveedores.BackColor = Color.DarkOrange;
            MantenimientoProveedores.ForeColor = SystemColors.ControlLightLight;
            MantenimientoProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            MantenimientoProveedores.IconColor = Color.White;
            MantenimientoProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MantenimientoProveedores.Name = "MantenimientoProveedores";
            MantenimientoProveedores.Size = new Size(338, 34);
            MantenimientoProveedores.Text = "Proveedores";
            // 
            // MantenimientoTipoDeMovimiento
            // 
            MantenimientoTipoDeMovimiento.BackColor = Color.DarkOrange;
            MantenimientoTipoDeMovimiento.ForeColor = SystemColors.ControlLightLight;
            MantenimientoTipoDeMovimiento.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
            MantenimientoTipoDeMovimiento.IconColor = Color.White;
            MantenimientoTipoDeMovimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MantenimientoTipoDeMovimiento.Name = "MantenimientoTipoDeMovimiento";
            MantenimientoTipoDeMovimiento.Size = new Size(338, 34);
            MantenimientoTipoDeMovimiento.Text = "Tipo de Movimiento";
            // 
            // ProcesosInventario
            // 
            ProcesosInventario.BackColor = Color.FromArgb(255, 161, 43);
            ProcesosInventario.DropDownItems.AddRange(new ToolStripItem[] { RegistroDeMovimientoInventario });
            ProcesosInventario.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProcesosInventario.ForeColor = SystemColors.ControlLightLight;
            ProcesosInventario.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            ProcesosInventario.IconColor = Color.White;
            ProcesosInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ProcesosInventario.Name = "ProcesosInventario";
            ProcesosInventario.Size = new Size(271, 32);
            ProcesosInventario.Text = "Procesos";
            // 
            // RegistroDeMovimientoInventario
            // 
            RegistroDeMovimientoInventario.BackColor = Color.DarkOrange;
            RegistroDeMovimientoInventario.ForeColor = SystemColors.ControlLightLight;
            RegistroDeMovimientoInventario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            RegistroDeMovimientoInventario.IconColor = Color.White;
            RegistroDeMovimientoInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RegistroDeMovimientoInventario.Name = "RegistroDeMovimientoInventario";
            RegistroDeMovimientoInventario.Size = new Size(381, 34);
            RegistroDeMovimientoInventario.Text = "Registro de Movimiento";
            // 
            // ConsultasInventario
            // 
            ConsultasInventario.BackColor = Color.FromArgb(255, 161, 43);
            ConsultasInventario.DropDownItems.AddRange(new ToolStripItem[] { ConsultaProducto });
            ConsultasInventario.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConsultasInventario.ForeColor = SystemColors.ControlLightLight;
            ConsultasInventario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassChart;
            ConsultasInventario.IconColor = Color.White;
            ConsultasInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ConsultasInventario.Name = "ConsultasInventario";
            ConsultasInventario.Size = new Size(271, 32);
            ConsultasInventario.Text = "Consultas";
            // 
            // ConsultaProducto
            // 
            ConsultaProducto.BackColor = Color.DarkOrange;
            ConsultaProducto.ForeColor = SystemColors.ControlLightLight;
            ConsultaProducto.IconChar = FontAwesome.Sharp.IconChar.Burger;
            ConsultaProducto.IconColor = Color.White;
            ConsultaProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ConsultaProducto.Name = "ConsultaProducto";
            ConsultaProducto.Size = new Size(270, 34);
            ConsultaProducto.Text = "Productos";
            // 
            // ResportesInventario
            // 
            ResportesInventario.BackColor = Color.FromArgb(255, 161, 43);
            ResportesInventario.DropDownItems.AddRange(new ToolStripItem[] { StockAnualInventario, EntradasSalidasInventario });
            ResportesInventario.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResportesInventario.ForeColor = SystemColors.ControlLightLight;
            ResportesInventario.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            ResportesInventario.IconColor = Color.White;
            ResportesInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ResportesInventario.Name = "ResportesInventario";
            ResportesInventario.Size = new Size(271, 32);
            ResportesInventario.Text = "Reportes";
            // 
            // StockAnualInventario
            // 
            StockAnualInventario.BackColor = Color.DarkOrange;
            StockAnualInventario.ForeColor = SystemColors.ControlLightLight;
            StockAnualInventario.IconChar = FontAwesome.Sharp.IconChar.CubesStacked;
            StockAnualInventario.IconColor = Color.White;
            StockAnualInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            StockAnualInventario.Name = "StockAnualInventario";
            StockAnualInventario.Size = new Size(320, 34);
            StockAnualInventario.Text = "Stock Anual";
            // 
            // EntradasSalidasInventario
            // 
            EntradasSalidasInventario.BackColor = Color.DarkOrange;
            EntradasSalidasInventario.ForeColor = SystemColors.ControlLightLight;
            EntradasSalidasInventario.IconChar = FontAwesome.Sharp.IconChar.ArrowRightArrowLeft;
            EntradasSalidasInventario.IconColor = Color.White;
            EntradasSalidasInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EntradasSalidasInventario.Name = "EntradasSalidasInventario";
            EntradasSalidasInventario.Size = new Size(320, 34);
            EntradasSalidasInventario.Text = "Entradas y Salidas";
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            Resize += MenuPrincipal_Resize;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            DropMenu_restaurante.ResumeLayout(false);
            DropMenu_inventario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitulo;
        private Panel panelEscritorio;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBarraMenu;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btnRestaurante;
        private FontAwesome.Sharp.IconButton btnCxc;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnInventario;
        private ContextMenuStrip DropMenu_restaurante;
        private FontAwesome.Sharp.IconMenuItem procesosRestaurante;
        private FontAwesome.Sharp.IconMenuItem FacturacionRestaurante;
        private FontAwesome.Sharp.IconMenuItem MantenimientoRestaurante;
        private FontAwesome.Sharp.IconMenuItem MantenimientoMesas;
        private FontAwesome.Sharp.IconMenuItem MantenimientoEmpleados;
        private ContextMenuStrip DropMenu_inventario;
        private FontAwesome.Sharp.IconMenuItem MantenimientoInventario;
        private FontAwesome.Sharp.IconMenuItem MantenimientoProductos;
        private FontAwesome.Sharp.IconMenuItem MantenimientoCategoria;
        private FontAwesome.Sharp.IconMenuItem MantenimientoUnidades;
        private FontAwesome.Sharp.IconMenuItem MantenimientoProveedores;
        private FontAwesome.Sharp.IconMenuItem MantenimientoTipoDeMovimiento;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem ProcesosInventario;
        private FontAwesome.Sharp.IconMenuItem RegistroDeMovimientoInventario;
        private FontAwesome.Sharp.IconMenuItem ConsultasInventario;
        private FontAwesome.Sharp.IconMenuItem ConsultaProducto;
        private FontAwesome.Sharp.IconMenuItem ResportesInventario;
        private FontAwesome.Sharp.IconMenuItem StockAnualInventario;
        private FontAwesome.Sharp.IconMenuItem EntradasSalidasInventario;
    }
}