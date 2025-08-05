namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoMesa));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelMesa = new Panel();
            btnMaximizarMesa = new FontAwesome.Sharp.IconButton();
            btnCerrarMesa = new FontAwesome.Sharp.IconButton();
            btnMinimizarMesa = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            rbAsientos = new RadioButton();
            rbSala = new RadioButton();
            rbDescripcion = new RadioButton();
            pictureBox1 = new PictureBox();
            boxSala = new ComboBox();
            label7 = new Label();
            fecha = new TextBox();
            label6 = new Label();
            limpiar = new FontAwesome.Sharp.IconButton();
            guardar = new FontAwesome.Sharp.IconButton();
            asientos = new TextBox();
            DGVMesa = new DataGridView();
            panel5 = new Panel();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            busca = new TextBox();
            activo = new RadioButton();
            desMesa = new TextBox();
            inactivo = new RadioButton();
            panel3 = new Panel();
            label4 = new Label();
            panelMesa.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVMesa).BeginInit();
            SuspendLayout();
            // 
            // panelMesa
            // 
            panelMesa.BackColor = Color.White;
            panelMesa.Controls.Add(btnMaximizarMesa);
            panelMesa.Controls.Add(btnCerrarMesa);
            panelMesa.Controls.Add(btnMinimizarMesa);
            panelMesa.Controls.Add(label1);
            panelMesa.Dock = DockStyle.Top;
            panelMesa.Location = new Point(0, 0);
            panelMesa.Margin = new Padding(2);
            panelMesa.Name = "panelMesa";
            panelMesa.Size = new Size(888, 54);
            panelMesa.TabIndex = 0;
            panelMesa.MouseDown += panelMesa_MouseDown;
            // 
            // btnMaximizarMesa
            // 
            btnMaximizarMesa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarMesa.BackColor = Color.CornflowerBlue;
            btnMaximizarMesa.FlatAppearance.BorderSize = 0;
            btnMaximizarMesa.FlatStyle = FlatStyle.Flat;
            btnMaximizarMesa.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarMesa.IconColor = Color.OldLace;
            btnMaximizarMesa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarMesa.IconSize = 20;
            btnMaximizarMesa.Location = new Point(820, 0);
            btnMaximizarMesa.Margin = new Padding(2);
            btnMaximizarMesa.Name = "btnMaximizarMesa";
            btnMaximizarMesa.Size = new Size(36, 20);
            btnMaximizarMesa.TabIndex = 9;
            btnMaximizarMesa.UseVisualStyleBackColor = false;
            btnMaximizarMesa.Click += btnMaximizarMesa_Click;
            // 
            // btnCerrarMesa
            // 
            btnCerrarMesa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarMesa.BackColor = Color.Tomato;
            btnCerrarMesa.FlatAppearance.BorderSize = 0;
            btnCerrarMesa.FlatStyle = FlatStyle.Flat;
            btnCerrarMesa.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarMesa.IconColor = Color.OldLace;
            btnCerrarMesa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarMesa.IconSize = 20;
            btnCerrarMesa.Location = new Point(852, 0);
            btnCerrarMesa.Margin = new Padding(2);
            btnCerrarMesa.Name = "btnCerrarMesa";
            btnCerrarMesa.Size = new Size(36, 20);
            btnCerrarMesa.TabIndex = 10;
            btnCerrarMesa.UseVisualStyleBackColor = false;
            btnCerrarMesa.Click += btnCerrarMesa_Click;
            // 
            // btnMinimizarMesa
            // 
            btnMinimizarMesa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarMesa.BackColor = Color.Turquoise;
            btnMinimizarMesa.FlatAppearance.BorderSize = 0;
            btnMinimizarMesa.FlatStyle = FlatStyle.Flat;
            btnMinimizarMesa.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarMesa.IconColor = Color.OldLace;
            btnMinimizarMesa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarMesa.IconSize = 20;
            btnMinimizarMesa.Location = new Point(785, 0);
            btnMinimizarMesa.Margin = new Padding(2);
            btnMinimizarMesa.Name = "btnMinimizarMesa";
            btnMinimizarMesa.Size = new Size(36, 20);
            btnMinimizarMesa.TabIndex = 8;
            btnMinimizarMesa.UseVisualStyleBackColor = false;
            btnMinimizarMesa.Click += btnMinimizarMesa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(108, 36);
            label1.TabIndex = 1;
            label1.Text = "MESA";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(boxSala);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(fecha);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(limpiar);
            panel2.Controls.Add(guardar);
            panel2.Controls.Add(asientos);
            panel2.Controls.Add(DGVMesa);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(busca);
            panel2.Controls.Add(activo);
            panel2.Controls.Add(desMesa);
            panel2.Controls.Add(inactivo);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 54);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 510);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(rbAsientos);
            panel4.Controls.Add(rbSala);
            panel4.Controls.Add(rbDescripcion);
            panel4.Location = new Point(524, 228);
            panel4.Name = "panel4";
            panel4.Size = new Size(351, 32);
            panel4.TabIndex = 77;
            // 
            // rbAsientos
            // 
            rbAsientos.AutoSize = true;
            rbAsientos.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            rbAsientos.ForeColor = Color.White;
            rbAsientos.Location = new Point(228, 3);
            rbAsientos.Name = "rbAsientos";
            rbAsientos.Size = new Size(112, 24);
            rbAsientos.TabIndex = 2;
            rbAsientos.TabStop = true;
            rbAsientos.Text = "Asientos";
            rbAsientos.UseVisualStyleBackColor = true;
            // 
            // rbSala
            // 
            rbSala.AutoSize = true;
            rbSala.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            rbSala.ForeColor = Color.White;
            rbSala.Location = new Point(152, 3);
            rbSala.Name = "rbSala";
            rbSala.Size = new Size(70, 24);
            rbSala.TabIndex = 1;
            rbSala.TabStop = true;
            rbSala.Text = "Sala";
            rbSala.UseVisualStyleBackColor = true;
            // 
            // rbDescripcion
            // 
            rbDescripcion.AutoSize = true;
            rbDescripcion.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            rbDescripcion.ForeColor = Color.White;
            rbDescripcion.Location = new Point(5, 3);
            rbDescripcion.Name = "rbDescripcion";
            rbDescripcion.Size = new Size(141, 24);
            rbDescripcion.TabIndex = 0;
            rbDescripcion.TabStop = true;
            rbDescripcion.Text = "Descripción";
            rbDescripcion.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(777, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // boxSala
            // 
            boxSala.DropDownStyle = ComboBoxStyle.DropDownList;
            boxSala.FormattingEnabled = true;
            boxSala.Location = new Point(485, 62);
            boxSala.Name = "boxSala";
            boxSala.Size = new Size(151, 28);
            boxSala.TabIndex = 75;
            boxSala.MouseEnter += boxSala_MouseEnter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(532, 24);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 74;
            label7.Text = "Sala";
            // 
            // fecha
            // 
            fecha.BackColor = Color.FromArgb(255, 161, 43);
            fecha.BorderStyle = BorderStyle.None;
            fecha.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fecha.ForeColor = Color.White;
            fecha.Location = new Point(116, 235);
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Size = new Size(110, 19);
            fecha.TabIndex = 73;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(33, 230);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 71;
            label6.Text = "Fecha";
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
            limpiar.Location = new Point(163, 430);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(140, 56);
            limpiar.TabIndex = 70;
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
            guardar.Location = new Point(12, 430);
            guardar.Name = "guardar";
            guardar.Size = new Size(145, 56);
            guardar.TabIndex = 69;
            guardar.Text = "     Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // asientos
            // 
            asientos.BackColor = Color.FromArgb(255, 161, 43);
            asientos.BorderStyle = BorderStyle.None;
            asientos.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            asientos.ForeColor = Color.WhiteSmoke;
            asientos.Location = new Point(220, 159);
            asientos.Name = "asientos";
            asientos.Size = new Size(70, 19);
            asientos.TabIndex = 68;
            asientos.KeyPress += asientos_KeyPress;
            // 
            // DGVMesa
            // 
            DGVMesa.AllowUserToAddRows = false;
            DGVMesa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVMesa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVMesa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMesa.BackgroundColor = Color.FromArgb(255, 161, 43);
            DGVMesa.BorderStyle = BorderStyle.None;
            DGVMesa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVMesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVMesa.ColumnHeadersHeight = 25;
            DGVMesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVMesa.DefaultCellStyle = dataGridViewCellStyle3;
            DGVMesa.EnableHeadersVisualStyles = false;
            DGVMesa.Location = new Point(318, 270);
            DGVMesa.Name = "DGVMesa";
            DGVMesa.ReadOnly = true;
            DGVMesa.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVMesa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVMesa.RowHeadersVisible = false;
            DGVMesa.RowHeadersWidth = 51;
            DGVMesa.Size = new Size(557, 228);
            DGVMesa.TabIndex = 57;
            DGVMesa.CellMouseDoubleClick += DGVMesa_CellMouseDoubleClick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(220, 180);
            panel5.Name = "panel5";
            panel5.Size = new Size(70, 2);
            panel5.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(91, 24);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 56;
            label2.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(33, 153);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 66;
            label5.Text = "No de Asientos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 321);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 58;
            label3.Text = "Estado";
            // 
            // busca
            // 
            busca.BackColor = Color.FromArgb(255, 161, 43);
            busca.BorderStyle = BorderStyle.None;
            busca.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            busca.ForeColor = Color.WhiteSmoke;
            busca.Location = new Point(318, 236);
            busca.Name = "busca";
            busca.Size = new Size(200, 19);
            busca.TabIndex = 65;
            busca.TextChanged += busca_TextChanged;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activo.ForeColor = Color.White;
            activo.Location = new Point(126, 304);
            activo.Name = "activo";
            activo.Size = new Size(90, 24);
            activo.TabIndex = 59;
            activo.TabStop = true;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // desMesa
            // 
            desMesa.BackColor = Color.FromArgb(255, 161, 43);
            desMesa.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desMesa.ForeColor = Color.WhiteSmoke;
            desMesa.Location = new Point(33, 63);
            desMesa.Multiline = true;
            desMesa.Name = "desMesa";
            desMesa.Size = new Size(270, 65);
            desMesa.TabIndex = 64;
            // 
            // inactivo
            // 
            inactivo.AutoSize = true;
            inactivo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inactivo.ForeColor = Color.White;
            inactivo.Location = new Point(126, 338);
            inactivo.Name = "inactivo";
            inactivo.Size = new Size(109, 24);
            inactivo.TabIndex = 60;
            inactivo.TabStop = true;
            inactivo.Text = "Inactivo";
            inactivo.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(318, 258);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(376, 208);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 61;
            label4.Text = "Buscar";
            // 
            // MantenimientoMesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(888, 564);
            Controls.Add(panel2);
            Controls.Add(panelMesa);
            Name = "MantenimientoMesa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoMesa";
            Load += MantenimientoMesa_Load;
            panelMesa.ResumeLayout(false);
            panelMesa.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVMesa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMesa;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizarMesa;
        private FontAwesome.Sharp.IconButton btnCerrarMesa;
        private FontAwesome.Sharp.IconButton btnMinimizarMesa;
        private TextBox asientos;
        private DataGridView DGVMesa;
        private Panel panel5;
        private Label label2;
        private Label label5;
        private Label label3;
        private TextBox busca;
        private RadioButton activo;
        private TextBox desMesa;
        private RadioButton inactivo;
        private Panel panel3;
        private Label label4;
        private FontAwesome.Sharp.IconButton limpiar;
        private FontAwesome.Sharp.IconButton guardar;
        private ComboBox boxSala;
        private Label label7;
        private TextBox fecha;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panel4;
        private RadioButton rbAsientos;
        private RadioButton rbSala;
        private RadioButton rbDescripcion;
    }
}