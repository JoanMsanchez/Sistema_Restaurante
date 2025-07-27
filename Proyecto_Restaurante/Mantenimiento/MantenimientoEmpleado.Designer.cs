namespace Proyecto_Restaurante
{
    partial class MantenimientoEmpleado
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoEmpleado));
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            contrasena = new TextBox();
            nombre = new TextBox();
            apellido = new TextBox();
            activo = new RadioButton();
            desactivo = new RadioButton();
            login = new TextBox();
            guardar = new FontAwesome.Sharp.IconButton();
            Limpiar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            label4 = new Label();
            busca = new TextBox();
            panel1 = new Panel();
            DGVEmpleado = new DataGridView();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            buscanombre = new RadioButton();
            buscausuario = new RadioButton();
            panelEmpleado = new Panel();
            btnMaximizarEmpleado = new FontAwesome.Sharp.IconButton();
            btnCerrarEmpleado = new FontAwesome.Sharp.IconButton();
            btnMinimizarEmpleado = new FontAwesome.Sharp.IconButton();
            btnMaximizarCategoria = new FontAwesome.Sharp.IconButton();
            btnCerrarCategoria = new FontAwesome.Sharp.IconButton();
            btnMinimizarCategoria = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVEmpleado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 166);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 29);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 219);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 29);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(341, 170);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 29);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(674, 173);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 29);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // contrasena
            // 
            contrasena.BackColor = Color.FromArgb(255, 161, 43);
            contrasena.BorderStyle = BorderStyle.None;
            contrasena.Font = new Font("Verdana", 9F, FontStyle.Bold);
            contrasena.ForeColor = Color.White;
            contrasena.Location = new Point(193, 227);
            contrasena.Margin = new Padding(4);
            contrasena.Name = "contrasena";
            contrasena.Size = new Size(191, 22);
            contrasena.TabIndex = 9;
            contrasena.UseSystemPasswordChar = true;
            contrasena.KeyPress += contrasena_KeyPress;
            // 
            // nombre
            // 
            nombre.BackColor = Color.FromArgb(255, 161, 43);
            nombre.BorderStyle = BorderStyle.None;
            nombre.Font = new Font("Verdana", 9F, FontStyle.Bold);
            nombre.ForeColor = Color.White;
            nombre.Location = new Point(475, 177);
            nombre.Margin = new Padding(4);
            nombre.Name = "nombre";
            nombre.Size = new Size(191, 22);
            nombre.TabIndex = 10;
            nombre.KeyPress += nombre_KeyPress;
            // 
            // apellido
            // 
            apellido.BackColor = Color.FromArgb(255, 161, 43);
            apellido.BorderStyle = BorderStyle.None;
            apellido.Font = new Font("Verdana", 9F, FontStyle.Bold);
            apellido.ForeColor = Color.White;
            apellido.Location = new Point(811, 178);
            apellido.Margin = new Padding(4);
            apellido.Name = "apellido";
            apellido.Size = new Size(191, 22);
            apellido.TabIndex = 11;
            apellido.KeyPress += apellido_KeyPress;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10.2F);
            activo.Location = new Point(523, 227);
            activo.Margin = new Padding(4);
            activo.Name = "activo";
            activo.Size = new Size(101, 29);
            activo.TabIndex = 17;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // desactivo
            // 
            desactivo.AutoSize = true;
            desactivo.Font = new Font("Verdana", 10.2F);
            desactivo.Location = new Point(523, 264);
            desactivo.Margin = new Padding(4);
            desactivo.Name = "desactivo";
            desactivo.Size = new Size(121, 29);
            desactivo.TabIndex = 18;
            desactivo.Text = "Inactivo";
            desactivo.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(255, 161, 43);
            login.BorderStyle = BorderStyle.None;
            login.Font = new Font("Verdana", 9F, FontStyle.Bold);
            login.ForeColor = Color.White;
            login.Location = new Point(143, 177);
            login.Margin = new Padding(4);
            login.Name = "login";
            login.Size = new Size(191, 22);
            login.TabIndex = 8;
            login.KeyPress += login_KeyPress;
            // 
            // guardar
            // 
            guardar.FlatAppearance.BorderSize = 0;
            guardar.FlatStyle = FlatStyle.Flat;
            guardar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            guardar.ForeColor = Color.White;
            guardar.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            guardar.IconColor = Color.White;
            guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            guardar.IconSize = 35;
            guardar.ImageAlign = ContentAlignment.MiddleLeft;
            guardar.Location = new Point(744, 293);
            guardar.Margin = new Padding(4);
            guardar.Name = "guardar";
            guardar.Size = new Size(185, 65);
            guardar.TabIndex = 25;
            guardar.Text = "    Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click_1;
            // 
            // Limpiar
            // 
            Limpiar.FlatAppearance.BorderSize = 0;
            Limpiar.FlatStyle = FlatStyle.Flat;
            Limpiar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            Limpiar.ForeColor = Color.White;
            Limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            Limpiar.IconColor = Color.White;
            Limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Limpiar.IconSize = 35;
            Limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            Limpiar.Location = new Point(937, 293);
            Limpiar.Margin = new Padding(4);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(179, 65);
            Limpiar.TabIndex = 24;
            Limpiar.Text = "    Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(405, 239);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 29);
            label7.TabIndex = 22;
            label7.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 386);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 29);
            label4.TabIndex = 22;
            label4.Text = "Buscar";
            // 
            // busca
            // 
            busca.BackColor = Color.FromArgb(255, 161, 43);
            busca.BorderStyle = BorderStyle.None;
            busca.Font = new Font("Verdana", 9F, FontStyle.Bold);
            busca.ForeColor = Color.White;
            busca.Location = new Point(15, 431);
            busca.Margin = new Padding(4);
            busca.Name = "busca";
            busca.Size = new Size(162, 22);
            busca.TabIndex = 23;
            busca.TextChanged += busca_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 161, 43);
            panel1.Controls.Add(DGVEmpleado);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(login);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(guardar);
            panel1.Controls.Add(activo);
            panel1.Controls.Add(contrasena);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(desactivo);
            panel1.Controls.Add(apellido);
            panel1.Controls.Add(nombre);
            panel1.Controls.Add(buscanombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Limpiar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(buscausuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(busca);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 824);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // DGVEmpleado
            // 
            DGVEmpleado.AllowUserToAddRows = false;
            DGVEmpleado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVEmpleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVEmpleado.BackgroundColor = Color.FromArgb(255, 161, 43);
            DGVEmpleado.BorderStyle = BorderStyle.None;
            DGVEmpleado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVEmpleado.ColumnHeadersHeight = 25;
            DGVEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVEmpleado.DefaultCellStyle = dataGridViewCellStyle3;
            DGVEmpleado.EnableHeadersVisualStyles = false;
            DGVEmpleado.Location = new Point(236, 386);
            DGVEmpleado.Margin = new Padding(4);
            DGVEmpleado.Name = "DGVEmpleado";
            DGVEmpleado.ReadOnly = true;
            DGVEmpleado.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVEmpleado.RowHeadersVisible = false;
            DGVEmpleado.RowHeadersWidth = 51;
            DGVEmpleado.Size = new Size(884, 384);
            DGVEmpleado.TabIndex = 27;
            DGVEmpleado.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(9, 456);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(169, 2);
            panel6.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(187, 254);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(198, 2);
            panel5.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(805, 204);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(198, 2);
            panel4.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(469, 204);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 2);
            panel3.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(137, 202);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 2);
            panel2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(976, 71);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // buscanombre
            // 
            buscanombre.AutoSize = true;
            buscanombre.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            buscanombre.Location = new Point(32, 506);
            buscanombre.Margin = new Padding(4);
            buscanombre.Name = "buscanombre";
            buscanombre.Size = new Size(135, 30);
            buscanombre.TabIndex = 1;
            buscanombre.Text = "Nombre";
            buscanombre.UseVisualStyleBackColor = true;
            // 
            // buscausuario
            // 
            buscausuario.AutoSize = true;
            buscausuario.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            buscausuario.Location = new Point(32, 466);
            buscausuario.Margin = new Padding(4);
            buscausuario.Name = "buscausuario";
            buscausuario.Size = new Size(133, 30);
            buscausuario.TabIndex = 0;
            buscausuario.Text = "Usuario";
            buscausuario.UseVisualStyleBackColor = true;
            // 
            // panelEmpleado
            // 
            panelEmpleado.BackColor = Color.White;
            panelEmpleado.Controls.Add(btnMaximizarEmpleado);
            panelEmpleado.Controls.Add(btnCerrarEmpleado);
            panelEmpleado.Controls.Add(btnMinimizarEmpleado);
            panelEmpleado.Controls.Add(btnMaximizarCategoria);
            panelEmpleado.Controls.Add(btnCerrarCategoria);
            panelEmpleado.Controls.Add(btnMinimizarCategoria);
            panelEmpleado.Controls.Add(label8);
            panelEmpleado.Dock = DockStyle.Top;
            panelEmpleado.Location = new Point(0, 0);
            panelEmpleado.Name = "panelEmpleado";
            panelEmpleado.Size = new Size(1120, 72);
            panelEmpleado.TabIndex = 22;
            panelEmpleado.MouseDown += panelEmpleado_MouseDown;
            // 
            // btnMaximizarEmpleado
            // 
            btnMaximizarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarEmpleado.BackColor = Color.CornflowerBlue;
            btnMaximizarEmpleado.FlatAppearance.BorderSize = 0;
            btnMaximizarEmpleado.FlatStyle = FlatStyle.Flat;
            btnMaximizarEmpleado.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarEmpleado.IconColor = Color.OldLace;
            btnMaximizarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarEmpleado.IconSize = 20;
            btnMaximizarEmpleado.Location = new Point(1035, 0);
            btnMaximizarEmpleado.Margin = new Padding(2);
            btnMaximizarEmpleado.Name = "btnMaximizarEmpleado";
            btnMaximizarEmpleado.Size = new Size(45, 25);
            btnMaximizarEmpleado.TabIndex = 9;
            btnMaximizarEmpleado.UseVisualStyleBackColor = false;
            btnMaximizarEmpleado.Click += btnMaximizarEmpleado_Click;
            // 
            // btnCerrarEmpleado
            // 
            btnCerrarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarEmpleado.BackColor = Color.Tomato;
            btnCerrarEmpleado.FlatAppearance.BorderSize = 0;
            btnCerrarEmpleado.FlatStyle = FlatStyle.Flat;
            btnCerrarEmpleado.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarEmpleado.IconColor = Color.OldLace;
            btnCerrarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarEmpleado.IconSize = 20;
            btnCerrarEmpleado.Location = new Point(1075, 0);
            btnCerrarEmpleado.Margin = new Padding(2);
            btnCerrarEmpleado.Name = "btnCerrarEmpleado";
            btnCerrarEmpleado.Size = new Size(45, 25);
            btnCerrarEmpleado.TabIndex = 10;
            btnCerrarEmpleado.UseVisualStyleBackColor = false;
            btnCerrarEmpleado.Click += btnCerrarEmpleado_Click;
            // 
            // btnMinimizarEmpleado
            // 
            btnMinimizarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarEmpleado.BackColor = Color.Turquoise;
            btnMinimizarEmpleado.FlatAppearance.BorderSize = 0;
            btnMinimizarEmpleado.FlatStyle = FlatStyle.Flat;
            btnMinimizarEmpleado.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarEmpleado.IconColor = Color.OldLace;
            btnMinimizarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarEmpleado.IconSize = 20;
            btnMinimizarEmpleado.Location = new Point(992, 0);
            btnMinimizarEmpleado.Margin = new Padding(2);
            btnMinimizarEmpleado.Name = "btnMinimizarEmpleado";
            btnMinimizarEmpleado.Size = new Size(45, 25);
            btnMinimizarEmpleado.TabIndex = 8;
            btnMinimizarEmpleado.UseVisualStyleBackColor = false;
            btnMinimizarEmpleado.Click += btnMinimizarEmpleado_Click;
            // 
            // btnMaximizarCategoria
            // 
            btnMaximizarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarCategoria.BackColor = Color.CornflowerBlue;
            btnMaximizarCategoria.FlatAppearance.BorderSize = 0;
            btnMaximizarCategoria.FlatStyle = FlatStyle.Flat;
            btnMaximizarCategoria.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarCategoria.IconColor = Color.OldLace;
            btnMaximizarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarCategoria.IconSize = 20;
            btnMaximizarCategoria.Location = new Point(1697, 0);
            btnMaximizarCategoria.Margin = new Padding(2);
            btnMaximizarCategoria.Name = "btnMaximizarCategoria";
            btnMaximizarCategoria.Size = new Size(45, 25);
            btnMaximizarCategoria.TabIndex = 6;
            btnMaximizarCategoria.UseVisualStyleBackColor = false;
            btnMaximizarCategoria.Visible = false;
            // 
            // btnCerrarCategoria
            // 
            btnCerrarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarCategoria.BackColor = Color.Tomato;
            btnCerrarCategoria.FlatAppearance.BorderSize = 0;
            btnCerrarCategoria.FlatStyle = FlatStyle.Flat;
            btnCerrarCategoria.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarCategoria.IconColor = Color.OldLace;
            btnCerrarCategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarCategoria.IconSize = 20;
            btnCerrarCategoria.Location = new Point(1737, 0);
            btnCerrarCategoria.Margin = new Padding(2);
            btnCerrarCategoria.Name = "btnCerrarCategoria";
            btnCerrarCategoria.Size = new Size(45, 25);
            btnCerrarCategoria.TabIndex = 7;
            btnCerrarCategoria.UseVisualStyleBackColor = false;
            btnCerrarCategoria.Visible = false;
            // 
            // btnMinimizarCategoria
            // 
            btnMinimizarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarCategoria.BackColor = Color.Turquoise;
            btnMinimizarCategoria.FlatAppearance.BorderSize = 0;
            btnMinimizarCategoria.FlatStyle = FlatStyle.Flat;
            btnMinimizarCategoria.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarCategoria.IconColor = Color.OldLace;
            btnMinimizarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarCategoria.IconSize = 20;
            btnMinimizarCategoria.Location = new Point(1654, 0);
            btnMinimizarCategoria.Margin = new Padding(2);
            btnMinimizarCategoria.Name = "btnMinimizarCategoria";
            btnMinimizarCategoria.Size = new Size(45, 25);
            btnMinimizarCategoria.TabIndex = 5;
            btnMinimizarCategoria.UseVisualStyleBackColor = false;
            btnMinimizarCategoria.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 161, 43);
            label8.Location = new Point(32, 18);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(241, 44);
            label8.TabIndex = 0;
            label8.Text = "EMPLEADO";
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(1120, 824);
            Controls.Add(panelEmpleado);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Empleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVEmpleado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEmpleado.ResumeLayout(false);
            panelEmpleado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        protected Label label2;
        protected Label label3;
        protected Label label5;
        protected Label label6;
        protected TextBox contrasena;
        protected TextBox nombre;
        protected TextBox apellido;
        protected TextBox textBox3;
        protected TextBox textBox4;
        protected RadioButton activo;
        protected RadioButton desactivo;
        protected TextBox login;
        //private FontAwesome.Sharp.IconButton Guardar;
        private FontAwesome.Sharp.IconButton Limpiar;
        private Label label4;
        private TextBox busca;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton buscanombre;
        private RadioButton buscausuario;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnCerrarEmpleado;
        private FontAwesome.Sharp.IconButton guardar;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private DataGridView DGVEmpleado;
        private Panel panelEmpleado;
        private FontAwesome.Sharp.IconButton btnMaximizarCategoria;
        private FontAwesome.Sharp.IconButton btnCerrarCategoria;
        private FontAwesome.Sharp.IconButton btnMinimizarCategoria;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnMaximizarEmpleado;
        private FontAwesome.Sharp.IconButton btnMinimizarEmpleado;
    }
}