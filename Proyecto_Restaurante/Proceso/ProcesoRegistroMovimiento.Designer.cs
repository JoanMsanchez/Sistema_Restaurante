
namespace Proyecto_Restaurante.Proceso
{
    partial class ProcesoRegistroMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesoRegistroMovimiento));
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            buscar = new TextBox();
            listSugerencia = new ListBox();
            btnConsultaProducto = new FontAwesome.Sharp.IconButton();
            dgvLineas = new DataGridView();
            pictureBox1 = new PictureBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            inactivo = new RadioButton();
            activo = new RadioButton();
            label9 = new Label();
            observaciones = new TextBox();
            fecha = new TextBox();
            comboTipoMovimiento = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelMovimiento = new Panel();
            label6 = new Label();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLineas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMovimiento.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 161, 43);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(buscar);
            panel2.Controls.Add(listSugerencia);
            panel2.Controls.Add(btnConsultaProducto);
            panel2.Controls.Add(dgvLineas);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(inactivo);
            panel2.Controls.Add(activo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(observaciones);
            panel2.Controls.Add(fecha);
            panel2.Controls.Add(comboTipoMovimiento);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(935, 623);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(326, 294);
            label3.Name = "label3";
            label3.Size = new Size(268, 25);
            label3.TabIndex = 81;
            label3.Text = "Producto Seleccionado";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(132, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 2);
            panel3.TabIndex = 80;
            // 
            // buscar
            // 
            buscar.BackColor = Color.FromArgb(255, 161, 43);
            buscar.BorderStyle = BorderStyle.None;
            buscar.Font = new Font("Verdana", 10.2F);
            buscar.ForeColor = Color.White;
            buscar.Location = new Point(132, 91);
            buscar.Name = "buscar";
            buscar.Size = new Size(186, 21);
            buscar.TabIndex = 79;
            buscar.TextChanged += buscar_TextChanged;
            // 
            // listSugerencia
            // 
            listSugerencia.BackColor = Color.FromArgb(255, 161, 43);
            listSugerencia.BorderStyle = BorderStyle.None;
            listSugerencia.Font = new Font("Verdana", 10.2F);
            listSugerencia.ForeColor = Color.White;
            listSugerencia.FormattingEnabled = true;
            listSugerencia.Location = new Point(132, 132);
            listSugerencia.Name = "listSugerencia";
            listSugerencia.Size = new Size(186, 40);
            listSugerencia.TabIndex = 78;
            listSugerencia.MouseDoubleClick += listSugerencia_MouseDoubleClick;
            // 
            // btnConsultaProducto
            // 
            btnConsultaProducto.BackColor = Color.FromArgb(255, 161, 43);
            btnConsultaProducto.FlatAppearance.BorderSize = 0;
            btnConsultaProducto.FlatStyle = FlatStyle.Flat;
            btnConsultaProducto.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultaProducto.ForeColor = Color.White;
            btnConsultaProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnConsultaProducto.IconColor = SystemColors.ControlLightLight;
            btnConsultaProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaProducto.IconSize = 30;
            btnConsultaProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaProducto.Location = new Point(326, 86);
            btnConsultaProducto.Margin = new Padding(2);
            btnConsultaProducto.Name = "btnConsultaProducto";
            btnConsultaProducto.Size = new Size(39, 36);
            btnConsultaProducto.TabIndex = 77;
            btnConsultaProducto.UseVisualStyleBackColor = false;
            btnConsultaProducto.Click += btnConsultaProducto_Click;
            // 
            // dgvLineas
            // 
            dgvLineas.AllowUserToAddRows = false;
            dgvLineas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dgvLineas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLineas.BackgroundColor = Color.FromArgb(255, 161, 43);
            dgvLineas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLineas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLineas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLineas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLineas.Location = new Point(189, 331);
            dgvLineas.Margin = new Padding(2);
            dgvLineas.Name = "dgvLineas";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvLineas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvLineas.RowHeadersVisible = false;
            dgvLineas.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dgvLineas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvLineas.Size = new Size(538, 201);
            dgvLineas.TabIndex = 76;
            dgvLineas.CellContentClick += dgvLineas_CellContentClick;
            dgvLineas.CellValidating += dgvLineas_CellValidating;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(792, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 35;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(163, 546);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 56);
            btnLimpiar.TabIndex = 69;
            btnLimpiar.Text = "     Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 35;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(12, 546);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 56);
            btnGuardar.TabIndex = 68;
            btnGuardar.Text = "     Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // inactivo
            // 
            inactivo.AutoSize = true;
            inactivo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inactivo.ForeColor = Color.White;
            inactivo.Location = new Point(720, 225);
            inactivo.Name = "inactivo";
            inactivo.Size = new Size(109, 24);
            inactivo.TabIndex = 67;
            inactivo.Text = "Inactivo";
            inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Checked = true;
            activo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activo.ForeColor = Color.White;
            activo.Location = new Point(720, 195);
            activo.Name = "activo";
            activo.Size = new Size(90, 24);
            activo.TabIndex = 66;
            activo.TabStop = true;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(626, 208);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 65;
            label9.Text = "Estado";
            // 
            // observaciones
            // 
            observaciones.BackColor = Color.FromArgb(255, 161, 43);
            observaciones.Font = new Font("Verdana", 10.2F);
            observaciones.ForeColor = Color.White;
            observaciones.Location = new Point(562, 76);
            observaciones.Multiline = true;
            observaciones.Name = "observaciones";
            observaciones.Size = new Size(214, 80);
            observaciones.TabIndex = 14;
            // 
            // fecha
            // 
            fecha.BackColor = Color.FromArgb(255, 161, 43);
            fecha.BorderStyle = BorderStyle.None;
            fecha.Font = new Font("Verdana", 10.2F);
            fecha.ForeColor = Color.White;
            fecha.Location = new Point(462, 224);
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Size = new Size(151, 21);
            fecha.TabIndex = 13;
            // 
            // comboTipoMovimiento
            // 
            comboTipoMovimiento.BackColor = Color.FromArgb(255, 161, 43);
            comboTipoMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoMovimiento.FlatStyle = FlatStyle.Flat;
            comboTipoMovimiento.Font = new Font("Verdana", 10.2F);
            comboTipoMovimiento.ForeColor = Color.White;
            comboTipoMovimiento.FormattingEnabled = true;
            comboTipoMovimiento.Location = new Point(251, 220);
            comboTipoMovimiento.Name = "comboTipoMovimiento";
            comboTipoMovimiento.Size = new Size(162, 28);
            comboTipoMovimiento.TabIndex = 8;
            comboTipoMovimiento.SelectedIndexChanged += comboTipoMovimiento_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(380, 92);
            label8.Name = "label8";
            label8.Size = new Size(176, 25);
            label8.TabIndex = 6;
            label8.Text = "Observaciones";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(479, 196);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 5;
            label7.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 223);
            label2.Name = "label2";
            label2.Size = new Size(233, 25);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Movimiento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // panelMovimiento
            // 
            panelMovimiento.BackColor = Color.White;
            panelMovimiento.Controls.Add(label6);
            panelMovimiento.Controls.Add(btnMaximizar);
            panelMovimiento.Controls.Add(btnCerrar);
            panelMovimiento.Controls.Add(btnMinimizar);
            panelMovimiento.Dock = DockStyle.Top;
            panelMovimiento.Location = new Point(0, 0);
            panelMovimiento.Margin = new Padding(2);
            panelMovimiento.Name = "panelMovimiento";
            panelMovimiento.Size = new Size(935, 56);
            panelMovimiento.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 161, 43);
            label6.Location = new Point(12, 10);
            label6.Name = "label6";
            label6.Size = new Size(656, 36);
            label6.TabIndex = 2;
            label6.Text = "REGISTRO MOVIMIENTO INVENTARIO";
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
            btnMaximizar.Location = new Point(868, 0);
            btnMaximizar.Margin = new Padding(2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(36, 20);
            btnMaximizar.TabIndex = 12;
            btnMaximizar.UseVisualStyleBackColor = false;
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
            btnCerrar.Size = new Size(36, 20);
            btnCerrar.TabIndex = 13;
            btnCerrar.UseVisualStyleBackColor = false;
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
            btnMinimizar.Location = new Point(833, 0);
            btnMinimizar.Margin = new Padding(2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(36, 20);
            btnMinimizar.TabIndex = 11;
            btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // ProcesoRegistroMovimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 623);
            Controls.Add(panelMovimiento);
            Controls.Add(panel2);
            Name = "ProcesoRegistroMovimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProcesoRegistroMovimiento";
            Load += ProcesoRegistroMovimiento_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLineas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMovimiento.ResumeLayout(false);
            panelMovimiento.PerformLayout();
            ResumeLayout(false);
        }

        private void btnMinimizarSala_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCerrarSala_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnMaximizarSala_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox observaciones;
        private TextBox fecha;
        private ComboBox comboTipoMovimiento;
        private Label label8;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private RadioButton inactivo;
        private RadioButton activo;
        private Label label9;
        private PictureBox pictureBox1;
        private Panel panelMovimiento;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private DataGridView dgvLineas;
        private FontAwesome.Sharp.IconButton btnConsultaProducto;
        private TextBox buscar;
        private ListBox listSugerencia;
        private Panel panel3;
        private Label label3;
    }
}