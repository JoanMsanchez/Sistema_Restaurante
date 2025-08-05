namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoSala
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            fecha = new TextBox();
            label2 = new Label();
            limpiar = new FontAwesome.Sharp.IconButton();
            guardar = new FontAwesome.Sharp.IconButton();
            DGVSala = new DataGridView();
            panel3 = new Panel();
            label4 = new Label();
            buscar = new TextBox();
            desactivo = new RadioButton();
            activo = new RadioButton();
            estado = new Label();
            label = new Label();
            descripcion = new TextBox();
            panelSala = new Panel();
            btnMaximizarSala = new FontAwesome.Sharp.IconButton();
            btnCerrarSala = new FontAwesome.Sharp.IconButton();
            btnMinimizarSala = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVSala).BeginInit();
            panelSala.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(fecha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(limpiar);
            panel1.Controls.Add(guardar);
            panel1.Controls.Add(DGVSala);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buscar);
            panel1.Controls.Add(desactivo);
            panel1.Controls.Add(activo);
            panel1.Controls.Add(estado);
            panel1.Controls.Add(label);
            panel1.Controls.Add(descripcion);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 472);
            panel1.TabIndex = 0;
            // 
            // fecha
            // 
            fecha.BackColor = Color.FromArgb(255, 161, 43);
            fecha.BorderStyle = BorderStyle.None;
            fecha.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fecha.ForeColor = Color.WhiteSmoke;
            fecha.Location = new Point(502, 129);
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Size = new Size(147, 19);
            fecha.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(514, 102);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 52;
            label2.Text = "Fecha";
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
            limpiar.Location = new Point(183, 360);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(140, 56);
            limpiar.TabIndex = 51;
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
            guardar.Location = new Point(31, 360);
            guardar.Name = "guardar";
            guardar.Size = new Size(145, 56);
            guardar.TabIndex = 50;
            guardar.Text = "     Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // DGVSala
            // 
            DGVSala.AllowUserToAddRows = false;
            DGVSala.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVSala.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVSala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVSala.BackgroundColor = Color.FromArgb(255, 161, 43);
            DGVSala.BorderStyle = BorderStyle.None;
            DGVSala.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVSala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVSala.ColumnHeadersHeight = 29;
            DGVSala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVSala.DefaultCellStyle = dataGridViewCellStyle3;
            DGVSala.EnableHeadersVisualStyles = false;
            DGVSala.Location = new Point(382, 289);
            DGVSala.Name = "DGVSala";
            DGVSala.ReadOnly = true;
            DGVSala.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVSala.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVSala.RowHeadersVisible = false;
            DGVSala.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVSala.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DGVSala.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(255, 161, 43);
            DGVSala.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            DGVSala.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            DGVSala.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVSala.Size = new Size(407, 166);
            DGVSala.TabIndex = 49;
            DGVSala.CellMouseDoubleClick += DGVSala_CellMouseDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(514, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(143, 2);
            panel3.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(455, 201);
            label4.Name = "label4";
            label4.Size = new Size(272, 25);
            label4.TabIndex = 47;
            label4.Text = "Buscar por Descripcion";
            // 
            // buscar
            // 
            buscar.BackColor = Color.FromArgb(255, 161, 43);
            buscar.BorderStyle = BorderStyle.None;
            buscar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscar.ForeColor = Color.White;
            buscar.Location = new Point(514, 235);
            buscar.Name = "buscar";
            buscar.Size = new Size(140, 19);
            buscar.TabIndex = 46;
            buscar.TextChanged += buscar_TextChanged;
            // 
            // desactivo
            // 
            desactivo.AutoSize = true;
            desactivo.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            desactivo.ForeColor = Color.White;
            desactivo.Location = new Point(135, 283);
            desactivo.Name = "desactivo";
            desactivo.Size = new Size(109, 24);
            desactivo.TabIndex = 45;
            desactivo.TabStop = true;
            desactivo.Text = "Inactivo";
            desactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            activo.ForeColor = Color.White;
            activo.Location = new Point(135, 254);
            activo.Name = "activo";
            activo.Size = new Size(90, 24);
            activo.TabIndex = 44;
            activo.TabStop = true;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // estado
            // 
            estado.AutoSize = true;
            estado.Font = new Font("Verdana", 12F, FontStyle.Bold);
            estado.ForeColor = Color.White;
            estado.Location = new Point(40, 270);
            estado.Name = "estado";
            estado.Size = new Size(88, 25);
            estado.TabIndex = 43;
            estado.Text = "Estado";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.Location = new Point(81, 79);
            label.Name = "label";
            label.Size = new Size(144, 25);
            label.TabIndex = 42;
            label.Text = "Descripcion";
            // 
            // descripcion
            // 
            descripcion.BackColor = Color.FromArgb(255, 161, 43);
            descripcion.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descripcion.ForeColor = Color.WhiteSmoke;
            descripcion.Location = new Point(31, 114);
            descripcion.Multiline = true;
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(237, 90);
            descripcion.TabIndex = 41;
            // 
            // panelSala
            // 
            panelSala.BackColor = Color.White;
            panelSala.Controls.Add(btnMaximizarSala);
            panelSala.Controls.Add(btnCerrarSala);
            panelSala.Controls.Add(btnMinimizarSala);
            panelSala.Controls.Add(label1);
            panelSala.Dock = DockStyle.Top;
            panelSala.Location = new Point(0, 0);
            panelSala.Margin = new Padding(2);
            panelSala.Name = "panelSala";
            panelSala.Size = new Size(799, 54);
            panelSala.TabIndex = 1;
            panelSala.MouseDown += panelSala_MouseDown;
            // 
            // btnMaximizarSala
            // 
            btnMaximizarSala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarSala.BackColor = Color.CornflowerBlue;
            btnMaximizarSala.FlatAppearance.BorderSize = 0;
            btnMaximizarSala.FlatStyle = FlatStyle.Flat;
            btnMaximizarSala.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarSala.IconColor = Color.OldLace;
            btnMaximizarSala.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarSala.IconSize = 20;
            btnMaximizarSala.Location = new Point(731, 0);
            btnMaximizarSala.Margin = new Padding(2);
            btnMaximizarSala.Name = "btnMaximizarSala";
            btnMaximizarSala.Size = new Size(36, 20);
            btnMaximizarSala.TabIndex = 9;
            btnMaximizarSala.UseVisualStyleBackColor = false;
            btnMaximizarSala.Click += btnMaximizarSala_Click;
            // 
            // btnCerrarSala
            // 
            btnCerrarSala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSala.BackColor = Color.Tomato;
            btnCerrarSala.FlatAppearance.BorderSize = 0;
            btnCerrarSala.FlatStyle = FlatStyle.Flat;
            btnCerrarSala.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarSala.IconColor = Color.OldLace;
            btnCerrarSala.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarSala.IconSize = 20;
            btnCerrarSala.Location = new Point(763, 0);
            btnCerrarSala.Margin = new Padding(2);
            btnCerrarSala.Name = "btnCerrarSala";
            btnCerrarSala.Size = new Size(36, 20);
            btnCerrarSala.TabIndex = 10;
            btnCerrarSala.UseVisualStyleBackColor = false;
            btnCerrarSala.Click += btnCerrarSala_Click;
            // 
            // btnMinimizarSala
            // 
            btnMinimizarSala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarSala.BackColor = Color.Turquoise;
            btnMinimizarSala.FlatAppearance.BorderSize = 0;
            btnMinimizarSala.FlatStyle = FlatStyle.Flat;
            btnMinimizarSala.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarSala.IconColor = Color.OldLace;
            btnMinimizarSala.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarSala.IconSize = 20;
            btnMinimizarSala.Location = new Point(696, 0);
            btnMinimizarSala.Margin = new Padding(2);
            btnMinimizarSala.Name = "btnMinimizarSala";
            btnMinimizarSala.Size = new Size(36, 20);
            btnMinimizarSala.TabIndex = 8;
            btnMinimizarSala.UseVisualStyleBackColor = false;
            btnMinimizarSala.Click += btnMinimizarSala_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(101, 36);
            label1.TabIndex = 1;
            label1.Text = "SALA";
            // 
            // MantenimientoSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(799, 472);
            Controls.Add(panelSala);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "MantenimientoSala";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoSala";
            Shown += MantenimientoSala_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVSala).EndInit();
            panelSala.ResumeLayout(false);
            panelSala.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelSala;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizarSala;
        private FontAwesome.Sharp.IconButton btnCerrarSala;
        private FontAwesome.Sharp.IconButton btnMinimizarSala;
        private Label label;
        private TextBox descripcion;
        private RadioButton desactivo;
        private RadioButton activo;
        private Label estado;
        private Panel panel3;
        private Label label4;
        private TextBox buscar;
        private DataGridView DGVSala;
        private FontAwesome.Sharp.IconButton limpiar;
        private FontAwesome.Sharp.IconButton guardar;
        private Label label2;
        private TextBox fecha;
    }
}