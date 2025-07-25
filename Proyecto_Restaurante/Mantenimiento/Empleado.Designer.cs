namespace Proyecto_Restaurante
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            label1 = new Label();
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
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            buscanombre = new RadioButton();
            buscausuario = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(187, 51);
            label1.Name = "label1";
            label1.Size = new Size(188, 34);
            label1.TabIndex = 0;
            label1.Text = "EMPLEADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 134);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 177);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(274, 138);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(540, 140);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // contrasena
            // 
            contrasena.BackColor = Color.FromArgb(255, 161, 43);
            contrasena.BorderStyle = BorderStyle.None;
            contrasena.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contrasena.ForeColor = Color.White;
            contrasena.Location = new Point(155, 183);
            contrasena.Name = "contrasena";
            contrasena.Size = new Size(153, 19);
            contrasena.TabIndex = 9;
            contrasena.UseSystemPasswordChar = true;
            contrasena.KeyPress += contrasena_KeyPress;
            // 
            // nombre
            // 
            nombre.BackColor = Color.FromArgb(255, 161, 43);
            nombre.BorderStyle = BorderStyle.None;
            nombre.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombre.ForeColor = Color.White;
            nombre.Location = new Point(381, 143);
            nombre.Name = "nombre";
            nombre.Size = new Size(153, 19);
            nombre.TabIndex = 10;
            nombre.KeyPress += nombre_KeyPress;
            // 
            // apellido
            // 
            apellido.BackColor = Color.FromArgb(255, 161, 43);
            apellido.BorderStyle = BorderStyle.None;
            apellido.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apellido.ForeColor = Color.White;
            apellido.Location = new Point(650, 144);
            apellido.Name = "apellido";
            apellido.Size = new Size(153, 19);
            apellido.TabIndex = 11;
            apellido.KeyPress += apellido_KeyPress;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10.2F);
            activo.Location = new Point(419, 183);
            activo.Name = "activo";
            activo.Size = new Size(83, 24);
            activo.TabIndex = 17;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // desactivo
            // 
            desactivo.AutoSize = true;
            desactivo.Font = new Font("Verdana", 10.2F);
            desactivo.Location = new Point(419, 213);
            desactivo.Name = "desactivo";
            desactivo.Size = new Size(100, 24);
            desactivo.TabIndex = 18;
            desactivo.Text = "Inactivo";
            desactivo.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(255, 161, 43);
            login.BorderStyle = BorderStyle.None;
            login.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.ForeColor = Color.White;
            login.Location = new Point(115, 143);
            login.Name = "login";
            login.Size = new Size(153, 19);
            login.TabIndex = 8;
            login.KeyPress += login_KeyPress;
            // 
            // guardar
            // 
            guardar.FlatAppearance.BorderSize = 0;
            guardar.FlatStyle = FlatStyle.Flat;
            guardar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            guardar.ForeColor = Color.White;
            guardar.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            guardar.IconColor = Color.White;
            guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            guardar.IconSize = 30;
            guardar.ImageAlign = ContentAlignment.MiddleLeft;
            guardar.Location = new Point(551, 229);
            guardar.Name = "guardar";
            guardar.Size = new Size(136, 52);
            guardar.TabIndex = 25;
            guardar.Text = "    Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click_1;
            // 
            // Limpiar
            // 
            Limpiar.FlatAppearance.BorderSize = 0;
            Limpiar.FlatStyle = FlatStyle.Flat;
            Limpiar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            Limpiar.ForeColor = Color.White;
            Limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            Limpiar.IconColor = Color.White;
            Limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Limpiar.IconSize = 30;
            Limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            Limpiar.Location = new Point(693, 229);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(135, 52);
            Limpiar.TabIndex = 24;
            Limpiar.Text = "   Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(325, 181);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 22;
            label7.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(49, 324);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 22;
            label4.Text = "Buscar";
            // 
            // busca
            // 
            busca.BackColor = Color.FromArgb(255, 161, 43);
            busca.BorderStyle = BorderStyle.None;
            busca.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            busca.ForeColor = Color.White;
            busca.Location = new Point(26, 360);
            busca.Name = "busca";
            busca.Size = new Size(130, 19);
            busca.TabIndex = 23;
            busca.TextChanged += busca_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 161, 43);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 616);
            panel1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(253, 105, 1);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 161, 43);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(253, 105, 1);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 25;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(253, 105, 1);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DimGray;
            dataGridView1.Location = new Point(177, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(707, 318);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(21, 380);
            panel6.Name = "panel6";
            panel6.Size = new Size(135, 2);
            panel6.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(150, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(158, 2);
            panel5.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(645, 165);
            panel4.Name = "panel4";
            panel4.Size = new Size(158, 2);
            panel4.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(376, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 2);
            panel3.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(110, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 2);
            panel2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(686, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // buscanombre
            // 
            buscanombre.AutoSize = true;
            buscanombre.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            buscanombre.Location = new Point(40, 420);
            buscanombre.Name = "buscanombre";
            buscanombre.Size = new Size(111, 26);
            buscanombre.TabIndex = 1;
            buscanombre.Text = "Nombre";
            buscanombre.UseVisualStyleBackColor = true;
            // 
            // buscausuario
            // 
            buscausuario.AutoSize = true;
            buscausuario.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            buscausuario.Location = new Point(40, 388);
            buscausuario.Name = "buscausuario";
            buscausuario.Size = new Size(109, 26);
            buscausuario.TabIndex = 0;
            buscausuario.Text = "Usuario";
            buscausuario.UseVisualStyleBackColor = true;
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(896, 616);
            Controls.Add(panel1);
            Name = "Empleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Label label1;
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
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton guardar;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dataGridView1;
    }
}