namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCategoria));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            DGVCategoria = new DataGridView();
            inactivo = new RadioButton();
            activo = new RadioButton();
            label4 = new Label();
            buscanom = new TextBox();
            estado = new Label();
            label = new Label();
            nomcategoria = new TextBox();
            limpiar = new FontAwesome.Sharp.IconButton();
            guardar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panelCategoria = new Panel();
            btnMaximizarCategoria = new FontAwesome.Sharp.IconButton();
            btnCerrarCategoria = new FontAwesome.Sharp.IconButton();
            btnMinimizarCategoria = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVCategoria).BeginInit();
            panelCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(DGVCategoria);
            panel1.Controls.Add(inactivo);
            panel1.Controls.Add(activo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buscanom);
            panel1.Controls.Add(estado);
            panel1.Controls.Add(label);
            panel1.Controls.Add(nomcategoria);
            panel1.Controls.Add(limpiar);
            panel1.Controls.Add(guardar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 434);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(546, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(438, 221);
            panel3.Name = "panel3";
            panel3.Size = new Size(143, 2);
            panel3.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(130, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 2);
            panel2.TabIndex = 28;
            // 
            // DGVCategoria
            // 
            DGVCategoria.AllowUserToAddRows = false;
            DGVCategoria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCategoria.BackgroundColor = Color.FromArgb(255, 161, 43);
            DGVCategoria.BorderStyle = BorderStyle.None;
            DGVCategoria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVCategoria.ColumnHeadersHeight = 29;
            DGVCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            DGVCategoria.EnableHeadersVisualStyles = false;
            DGVCategoria.Location = new Point(358, 247);
            DGVCategoria.Name = "DGVCategoria";
            DGVCategoria.ReadOnly = true;
            DGVCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVCategoria.RowHeadersVisible = false;
            DGVCategoria.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVCategoria.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DGVCategoria.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(255, 161, 43);
            DGVCategoria.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            DGVCategoria.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            DGVCategoria.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVCategoria.Size = new Size(314, 166);
            DGVCategoria.TabIndex = 10;
            DGVCategoria.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // inactivo
            // 
            inactivo.AutoSize = true;
            inactivo.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            inactivo.ForeColor = Color.White;
            inactivo.Location = new Point(130, 239);
            inactivo.Name = "inactivo";
            inactivo.Size = new Size(109, 24);
            inactivo.TabIndex = 9;
            inactivo.Text = "Inactivo";
            inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Checked = true;
            activo.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            activo.ForeColor = Color.White;
            activo.Location = new Point(133, 205);
            activo.Name = "activo";
            activo.Size = new Size(90, 24);
            activo.TabIndex = 8;
            activo.TabStop = true;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(398, 171);
            label4.Name = "label4";
            label4.Size = new Size(229, 25);
            label4.TabIndex = 7;
            label4.Text = "Buscar por Nombre";
            // 
            // buscanom
            // 
            buscanom.BackColor = Color.FromArgb(255, 161, 43);
            buscanom.BorderStyle = BorderStyle.None;
            buscanom.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscanom.ForeColor = Color.White;
            buscanom.Location = new Point(438, 205);
            buscanom.Name = "buscanom";
            buscanom.Size = new Size(140, 19);
            buscanom.TabIndex = 6;
            buscanom.TextChanged += buscanom_TextChanged;
            // 
            // estado
            // 
            estado.AutoSize = true;
            estado.Font = new Font("Verdana", 12F, FontStyle.Bold);
            estado.ForeColor = Color.White;
            estado.Location = new Point(38, 221);
            estado.Name = "estado";
            estado.Size = new Size(88, 25);
            estado.TabIndex = 5;
            estado.Text = "Estado";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.Location = new Point(26, 137);
            label.Name = "label";
            label.Size = new Size(101, 25);
            label.TabIndex = 4;
            label.Text = "Nombre";
            // 
            // nomcategoria
            // 
            nomcategoria.BackColor = Color.FromArgb(255, 161, 43);
            nomcategoria.BorderStyle = BorderStyle.None;
            nomcategoria.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nomcategoria.ForeColor = Color.WhiteSmoke;
            nomcategoria.Location = new Point(133, 143);
            nomcategoria.Name = "nomcategoria";
            nomcategoria.Size = new Size(147, 19);
            nomcategoria.TabIndex = 3;
            nomcategoria.KeyPress += nomcategoria_KeyPress;
            // 
            // limpiar
            // 
            limpiar.FlatAppearance.BorderSize = 0;
            limpiar.FlatStyle = FlatStyle.Flat;
            limpiar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            limpiar.ForeColor = Color.White;
            limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            limpiar.IconColor = Color.White;
            limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            limpiar.IconSize = 35;
            limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            limpiar.Location = new Point(169, 309);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(140, 56);
            limpiar.TabIndex = 2;
            limpiar.Text = "     Limpiar";
            limpiar.UseVisualStyleBackColor = true;
            limpiar.Click += limpiar_Click;
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
            guardar.Location = new Point(18, 309);
            guardar.Name = "guardar";
            guardar.Size = new Size(145, 56);
            guardar.TabIndex = 1;
            guardar.Text = "     Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(213, 36);
            label1.TabIndex = 0;
            label1.Text = "CATEGORIA";
            // 
            // panelCategoria
            // 
            panelCategoria.BackColor = Color.FromArgb(233, 233, 233);
            panelCategoria.Controls.Add(btnMaximizarCategoria);
            panelCategoria.Controls.Add(btnCerrarCategoria);
            panelCategoria.Controls.Add(btnMinimizarCategoria);
            panelCategoria.Controls.Add(label1);
            panelCategoria.Dock = DockStyle.Top;
            panelCategoria.Location = new Point(0, 0);
            panelCategoria.Margin = new Padding(2);
            panelCategoria.Name = "panelCategoria";
            panelCategoria.Size = new Size(690, 54);
            panelCategoria.TabIndex = 1;
            panelCategoria.MouseDown += panelCategoria_MouseDown;
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
            btnMaximizarCategoria.Location = new Point(622, 0);
            btnMaximizarCategoria.Margin = new Padding(2);
            btnMaximizarCategoria.Name = "btnMaximizarCategoria";
            btnMaximizarCategoria.Size = new Size(36, 20);
            btnMaximizarCategoria.TabIndex = 6;
            btnMaximizarCategoria.UseVisualStyleBackColor = false;
            btnMaximizarCategoria.Click += btnMaximizarCategoria_Click;
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
            btnCerrarCategoria.Location = new Point(654, 0);
            btnCerrarCategoria.Margin = new Padding(2);
            btnCerrarCategoria.Name = "btnCerrarCategoria";
            btnCerrarCategoria.Size = new Size(36, 20);
            btnCerrarCategoria.TabIndex = 7;
            btnCerrarCategoria.UseVisualStyleBackColor = false;
            btnCerrarCategoria.Click += btnCerrarCategoria_Click;
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
            btnMinimizarCategoria.Location = new Point(587, 0);
            btnMinimizarCategoria.Margin = new Padding(2);
            btnMinimizarCategoria.Name = "btnMinimizarCategoria";
            btnMinimizarCategoria.Size = new Size(36, 20);
            btnMinimizarCategoria.TabIndex = 5;
            btnMinimizarCategoria.UseVisualStyleBackColor = false;
            btnMinimizarCategoria.Click += btnMinimizarCategoria_Click;
            // 
            // MantenimientoCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(690, 434);
            Controls.Add(panelCategoria);
            Controls.Add(panel1);
            Name = "MantenimientoCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categoria";
            Shown += MantenimientoCategoria_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVCategoria).EndInit();
            panelCategoria.ResumeLayout(false);
            panelCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox buscanom;
        private Label estado;
        private Label label;
        private TextBox nomcategoria;
        private FontAwesome.Sharp.IconButton limpiar;
        private FontAwesome.Sharp.IconButton guardar;
        private Label label1;
        private RadioButton inactivo;
        private RadioButton activo;
        private Label label4;
        private DataGridView DGVCategoria;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
        private Panel panelCategoria;
        private FontAwesome.Sharp.IconButton btnMaximizarCategoria;
        private FontAwesome.Sharp.IconButton btnCerrarCategoria;
        private FontAwesome.Sharp.IconButton btnMinimizarCategoria;
    }
}