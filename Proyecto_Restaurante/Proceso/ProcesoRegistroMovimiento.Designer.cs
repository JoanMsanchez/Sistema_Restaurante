
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesoRegistroMovimiento));
            panel2 = new Panel();
            dgvLineas = new DataGridView();
            comboProducto = new ComboBox();
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
            panel2.Controls.Add(dgvLineas);
            panel2.Controls.Add(comboProducto);
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
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1169, 712);
            panel2.TabIndex = 3;
            // 
            // dgvLineas
            // 
            dgvLineas.AllowUserToAddRows = false;
            dgvLineas.AllowUserToDeleteRows = false;
            dgvLineas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLineas.Location = new Point(56, 210);
            dgvLineas.Name = "dgvLineas";
            dgvLineas.RowHeadersVisible = false;
            dgvLineas.RowHeadersWidth = 62;
            dgvLineas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLineas.Size = new Size(497, 233);
            dgvLineas.TabIndex = 76;
            dgvLineas.CellContentClick += dgvLineas_CellContentClick;
            dgvLineas.CellValidating += dgvLineas_CellValidating;
            // 
            // comboProducto
            // 
            comboProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboProducto.BackColor = Color.FromArgb(255, 161, 43);
            comboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProducto.FlatStyle = FlatStyle.Flat;
            comboProducto.Font = new Font("Verdana", 10.2F);
            comboProducto.ForeColor = Color.White;
            comboProducto.FormattingEnabled = true;
            comboProducto.Location = new Point(177, 111);
            comboProducto.Margin = new Padding(4);
            comboProducto.Name = "comboProducto";
            comboProducto.Size = new Size(272, 33);
            comboProducto.TabIndex = 74;
            comboProducto.SelectionChangeCommitted += comboProducto_SelectionChangeCommitted;
            comboProducto.KeyDown += comboProducto_KeyDown;
            comboProducto.MouseDoubleClick += comboProducto_MouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(977, 76);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 120);
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
            btnLimpiar.Location = new Point(787, 577);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(175, 70);
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
            btnGuardar.Location = new Point(587, 578);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(181, 70);
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
            inactivo.Location = new Point(734, 330);
            inactivo.Margin = new Padding(4);
            inactivo.Name = "inactivo";
            inactivo.Size = new Size(130, 29);
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
            activo.Location = new Point(734, 292);
            activo.Margin = new Padding(4);
            activo.Name = "activo";
            activo.Size = new Size(108, 29);
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
            label9.Location = new Point(621, 312);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(103, 29);
            label9.TabIndex = 65;
            label9.Text = "Estado";
            // 
            // observaciones
            // 
            observaciones.BackColor = Color.FromArgb(255, 161, 43);
            observaciones.Font = new Font("Verdana", 10.2F);
            observaciones.ForeColor = Color.White;
            observaciones.Location = new Point(32, 509);
            observaciones.Margin = new Padding(4);
            observaciones.Multiline = true;
            observaciones.Name = "observaciones";
            observaciones.Size = new Size(266, 99);
            observaciones.TabIndex = 14;
            // 
            // fecha
            // 
            fecha.BackColor = Color.FromArgb(255, 161, 43);
            fecha.BorderStyle = BorderStyle.None;
            fecha.Font = new Font("Verdana", 10.2F);
            fecha.ForeColor = Color.White;
            fecha.Location = new Point(961, 244);
            fecha.Margin = new Padding(4);
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Size = new Size(189, 25);
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
            comboTipoMovimiento.Location = new Point(793, 111);
            comboTipoMovimiento.Margin = new Padding(4);
            comboTipoMovimiento.Name = "comboTipoMovimiento";
            comboTipoMovimiento.Size = new Size(188, 33);
            comboTipoMovimiento.TabIndex = 8;
            comboTipoMovimiento.SelectedIndexChanged += comboTipoMovimiento_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(56, 474);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(209, 29);
            label8.TabIndex = 6;
            label8.Text = "Observaciones";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1022, 200);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 29);
            label7.TabIndex = 5;
            label7.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(498, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(275, 29);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Movimiento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
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
            panelMovimiento.Size = new Size(1169, 70);
            panelMovimiento.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 161, 43);
            label6.Location = new Point(15, 12);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(798, 44);
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
            btnMaximizar.Location = new Point(1085, 0);
            btnMaximizar.Margin = new Padding(2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(45, 25);
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
            btnCerrar.Location = new Point(1123, 0);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 25);
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
            btnMinimizar.Location = new Point(1041, 0);
            btnMinimizar.Margin = new Padding(2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 25);
            btnMinimizar.TabIndex = 11;
            btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // ProcesoRegistroMovimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 712);
            Controls.Add(panelMovimiento);
            Controls.Add(panel2);
            Margin = new Padding(4);
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
        private ComboBox comboProducto;
        private DataGridView dgvLineas;
    }
}