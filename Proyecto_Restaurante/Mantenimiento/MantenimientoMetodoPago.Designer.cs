namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoMetodoPago
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
            panel3 = new Panel();
            panel2 = new Panel();
            DGVMetodoPago = new DataGridView();
            inactivo = new RadioButton();
            activo = new RadioButton();
            label4 = new Label();
            buscanom = new TextBox();
            estado = new Label();
            label = new Label();
            nomMetodoPago = new TextBox();
            limpiar = new FontAwesome.Sharp.IconButton();
            guardar = new FontAwesome.Sharp.IconButton();
            panelMantenimientoMetododePago = new Panel();
            btnMaximizarCategoria = new FontAwesome.Sharp.IconButton();
            btnCerrarCategoria = new FontAwesome.Sharp.IconButton();
            btnMinimizarCategoria = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMetodoPago).BeginInit();
            panelMantenimientoMetododePago.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(DGVMetodoPago);
            panel1.Controls.Add(inactivo);
            panel1.Controls.Add(activo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buscanom);
            panel1.Controls.Add(estado);
            panel1.Controls.Add(label);
            panel1.Controls.Add(nomMetodoPago);
            panel1.Controls.Add(limpiar);
            panel1.Controls.Add(guardar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(446, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(143, 2);
            panel3.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(133, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 2);
            panel2.TabIndex = 40;
            // 
            // DGVMetodoPago
            // 
            DGVMetodoPago.AllowUserToAddRows = false;
            DGVMetodoPago.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVMetodoPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVMetodoPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMetodoPago.BackgroundColor = Color.FromArgb(255, 161, 43);
            DGVMetodoPago.BorderStyle = BorderStyle.None;
            DGVMetodoPago.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVMetodoPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVMetodoPago.ColumnHeadersHeight = 29;
            DGVMetodoPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVMetodoPago.DefaultCellStyle = dataGridViewCellStyle3;
            DGVMetodoPago.EnableHeadersVisualStyles = false;
            DGVMetodoPago.Location = new Point(366, 221);
            DGVMetodoPago.Name = "DGVMetodoPago";
            DGVMetodoPago.ReadOnly = true;
            DGVMetodoPago.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVMetodoPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVMetodoPago.RowHeadersVisible = false;
            DGVMetodoPago.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVMetodoPago.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DGVMetodoPago.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(255, 161, 43);
            DGVMetodoPago.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            DGVMetodoPago.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            DGVMetodoPago.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVMetodoPago.Size = new Size(314, 166);
            DGVMetodoPago.TabIndex = 39;
            DGVMetodoPago.CellMouseDoubleClick += DGVMetodoPago_CellMouseDoubleClick;
            // 
            // inactivo
            // 
            inactivo.AutoSize = true;
            inactivo.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            inactivo.ForeColor = Color.White;
            inactivo.Location = new Point(124, 237);
            inactivo.Name = "inactivo";
            inactivo.Size = new Size(109, 24);
            inactivo.TabIndex = 38;
            inactivo.TabStop = true;
            inactivo.Text = "Inactivo";
            inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            activo.ForeColor = Color.White;
            activo.Location = new Point(124, 207);
            activo.Name = "activo";
            activo.Size = new Size(90, 24);
            activo.TabIndex = 37;
            activo.TabStop = true;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(406, 145);
            label4.Name = "label4";
            label4.Size = new Size(229, 25);
            label4.TabIndex = 36;
            label4.Text = "Buscar por Nombre";
            // 
            // buscanom
            // 
            buscanom.BackColor = Color.FromArgb(255, 161, 43);
            buscanom.BorderStyle = BorderStyle.None;
            buscanom.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscanom.ForeColor = Color.White;
            buscanom.Location = new Point(446, 179);
            buscanom.Name = "buscanom";
            buscanom.Size = new Size(140, 19);
            buscanom.TabIndex = 35;
            buscanom.TextChanged += buscanom_TextChanged;
            // 
            // estado
            // 
            estado.AutoSize = true;
            estado.Font = new Font("Verdana", 12F, FontStyle.Bold);
            estado.ForeColor = Color.White;
            estado.Location = new Point(29, 223);
            estado.Name = "estado";
            estado.Size = new Size(88, 25);
            estado.TabIndex = 34;
            estado.Text = "Estado";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.Location = new Point(29, 139);
            label.Name = "label";
            label.Size = new Size(101, 25);
            label.TabIndex = 33;
            label.Text = "Nombre";
            // 
            // nomMetodoPago
            // 
            nomMetodoPago.BackColor = Color.FromArgb(255, 161, 43);
            nomMetodoPago.BorderStyle = BorderStyle.None;
            nomMetodoPago.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nomMetodoPago.ForeColor = Color.WhiteSmoke;
            nomMetodoPago.Location = new Point(136, 145);
            nomMetodoPago.Name = "nomMetodoPago";
            nomMetodoPago.Size = new Size(147, 19);
            nomMetodoPago.TabIndex = 32;
            nomMetodoPago.KeyPress += nomMetodoPago_KeyPress;
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
            limpiar.Location = new Point(182, 326);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(140, 56);
            limpiar.TabIndex = 31;
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
            guardar.Location = new Point(30, 326);
            guardar.Name = "guardar";
            guardar.Size = new Size(145, 56);
            guardar.TabIndex = 30;
            guardar.Text = "     Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // panelMantenimientoMetododePago
            // 
            panelMantenimientoMetododePago.BackColor = Color.White;
            panelMantenimientoMetododePago.Controls.Add(btnMaximizarCategoria);
            panelMantenimientoMetododePago.Controls.Add(btnCerrarCategoria);
            panelMantenimientoMetododePago.Controls.Add(btnMinimizarCategoria);
            panelMantenimientoMetododePago.Controls.Add(label6);
            panelMantenimientoMetododePago.Dock = DockStyle.Top;
            panelMantenimientoMetododePago.Location = new Point(0, 0);
            panelMantenimientoMetododePago.Margin = new Padding(2);
            panelMantenimientoMetododePago.Name = "panelMantenimientoMetododePago";
            panelMantenimientoMetododePago.Size = new Size(702, 54);
            panelMantenimientoMetododePago.TabIndex = 1;
            panelMantenimientoMetododePago.MouseDown += panelMantenimientoMetododePago_MouseDown;
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
            btnMaximizarCategoria.Location = new Point(634, 0);
            btnMaximizarCategoria.Margin = new Padding(2);
            btnMaximizarCategoria.Name = "btnMaximizarCategoria";
            btnMaximizarCategoria.Size = new Size(36, 20);
            btnMaximizarCategoria.TabIndex = 12;
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
            btnCerrarCategoria.Location = new Point(666, 0);
            btnCerrarCategoria.Margin = new Padding(2);
            btnCerrarCategoria.Name = "btnCerrarCategoria";
            btnCerrarCategoria.Size = new Size(36, 20);
            btnCerrarCategoria.TabIndex = 13;
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
            btnMinimizarCategoria.Location = new Point(600, 0);
            btnMinimizarCategoria.Margin = new Padding(2);
            btnMinimizarCategoria.Name = "btnMinimizarCategoria";
            btnMinimizarCategoria.Size = new Size(36, 20);
            btnMinimizarCategoria.TabIndex = 11;
            btnMinimizarCategoria.UseVisualStyleBackColor = false;
            btnMinimizarCategoria.Click += btnMinimizarCategoria_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 161, 43);
            label6.Location = new Point(10, 7);
            label6.Name = "label6";
            label6.Size = new Size(322, 36);
            label6.TabIndex = 2;
            label6.Text = "METODO DE PAGO";
            // 
            // MantenimientoMetodoPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(702, 450);
            Controls.Add(panelMantenimientoMetododePago);
            Controls.Add(panel1);
            Name = "MantenimientoMetodoPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoMetodoPago";
            Shown += MantenimientoMetodoPago_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMetodoPago).EndInit();
            panelMantenimientoMetododePago.ResumeLayout(false);
            panelMantenimientoMetododePago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView DGVMetodoPago;
        private RadioButton inactivo;
        private RadioButton activo;
        private Label label4;
        private TextBox buscanom;
        private Label estado;
        private Label label;
        private TextBox nomMetodoPago;
        private FontAwesome.Sharp.IconButton limpiar;
        private FontAwesome.Sharp.IconButton guardar;
        private Panel panelMantenimientoMetododePago;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnMaximizarCategoria;
        private FontAwesome.Sharp.IconButton btnCerrarCategoria;
        private FontAwesome.Sharp.IconButton btnMinimizarCategoria;
    }
}