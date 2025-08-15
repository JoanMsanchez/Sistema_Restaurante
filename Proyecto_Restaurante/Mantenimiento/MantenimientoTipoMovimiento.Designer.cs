namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoTipoMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoTipoMovimiento));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            salida = new RadioButton();
            entrada = new RadioButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nomMovimiento = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            limpiar = new FontAwesome.Sharp.IconButton();
            guardar = new FontAwesome.Sharp.IconButton();
            buscanom = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            inactivo = new RadioButton();
            activo = new RadioButton();
            label3 = new Label();
            DGVTipoMovimiento = new DataGridView();
            panelTipodeMovimiento = new Panel();
            btnMaximizarTipodeMovimiento = new FontAwesome.Sharp.IconButton();
            btnCerrarTipodeMovimiento = new FontAwesome.Sharp.IconButton();
            btnMinimizarTipodeMovimiento = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVTipoMovimiento).BeginInit();
            panelTipodeMovimiento.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nomMovimiento);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(limpiar);
            panel1.Controls.Add(guardar);
            panel1.Controls.Add(buscanom);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(inactivo);
            panel1.Controls.Add(activo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DGVTipoMovimiento);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 615);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(salida);
            panel4.Controls.Add(entrada);
            panel4.Location = new Point(324, 210);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 84);
            panel4.TabIndex = 66;
            // 
            // salida
            // 
            salida.AutoSize = true;
            salida.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            salida.ForeColor = Color.White;
            salida.Location = new Point(4, 46);
            salida.Margin = new Padding(4, 4, 4, 4);
            salida.Name = "salida";
            salida.Size = new Size(163, 29);
            salida.TabIndex = 1;
            salida.Text = "Salida (-1)";
            salida.UseVisualStyleBackColor = true;
            // 
            // entrada
            // 
            entrada.AutoSize = true;
            entrada.Checked = true;
            entrada.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            entrada.ForeColor = Color.White;
            entrada.Location = new Point(4, 9);
            entrada.Margin = new Padding(4, 4, 4, 4);
            entrada.Name = "entrada";
            entrada.Size = new Size(191, 29);
            entrada.TabIndex = 0;
            entrada.TabStop = true;
            entrada.Text = "Entrada (+1)";
            entrada.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(858, 61);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 231);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 29);
            label1.TabIndex = 65;
            label1.Text = "Operación de Stock";
            // 
            // nomMovimiento
            // 
            nomMovimiento.BackColor = Color.FromArgb(255, 161, 43);
            nomMovimiento.BorderStyle = BorderStyle.None;
            nomMovimiento.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nomMovimiento.ForeColor = Color.WhiteSmoke;
            nomMovimiento.Location = new Point(218, 125);
            nomMovimiento.Margin = new Padding(4, 4, 4, 4);
            nomMovimiento.Name = "nomMovimiento";
            nomMovimiento.Size = new Size(184, 22);
            nomMovimiento.TabIndex = 61;
            nomMovimiento.KeyPress += nomMovimiento_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(214, 150);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 2);
            panel2.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 29);
            label2.TabIndex = 53;
            label2.Text = "Descripción";
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
            limpiar.Location = new Point(220, 478);
            limpiar.Margin = new Padding(4, 4, 4, 4);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(175, 70);
            limpiar.TabIndex = 64;
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
            guardar.Location = new Point(31, 478);
            guardar.Margin = new Padding(4, 4, 4, 4);
            guardar.Name = "guardar";
            guardar.Size = new Size(181, 70);
            guardar.TabIndex = 63;
            guardar.Text = "     Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // buscanom
            // 
            buscanom.BackColor = Color.FromArgb(255, 161, 43);
            buscanom.BorderStyle = BorderStyle.None;
            buscanom.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscanom.ForeColor = Color.WhiteSmoke;
            buscanom.Location = new Point(630, 298);
            buscanom.Margin = new Padding(4, 4, 4, 4);
            buscanom.Name = "buscanom";
            buscanom.Size = new Size(184, 22);
            buscanom.TabIndex = 62;
            buscanom.TextChanged += buscanom_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(630, 325);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 2);
            panel3.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(575, 262);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(295, 29);
            label4.TabIndex = 58;
            label4.Text = "Buscar por Condición";
            // 
            // inactivo
            // 
            inactivo.AutoSize = true;
            inactivo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inactivo.ForeColor = Color.White;
            inactivo.Location = new Point(142, 362);
            inactivo.Margin = new Padding(4, 4, 4, 4);
            inactivo.Name = "inactivo";
            inactivo.Size = new Size(130, 29);
            inactivo.TabIndex = 57;
            inactivo.Text = "Inactivo";
            inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Checked = true;
            activo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activo.ForeColor = Color.White;
            activo.Location = new Point(142, 325);
            activo.Margin = new Padding(4, 4, 4, 4);
            activo.Name = "activo";
            activo.Size = new Size(108, 29);
            activo.TabIndex = 56;
            activo.TabStop = true;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 335);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 29);
            label3.TabIndex = 55;
            label3.Text = "Estado";
            // 
            // DGVTipoMovimiento
            // 
            DGVTipoMovimiento.AllowUserToAddRows = false;
            DGVTipoMovimiento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVTipoMovimiento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVTipoMovimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVTipoMovimiento.BackgroundColor = Color.FromArgb(255, 161, 43);
            DGVTipoMovimiento.BorderStyle = BorderStyle.None;
            DGVTipoMovimiento.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVTipoMovimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVTipoMovimiento.ColumnHeadersHeight = 25;
            DGVTipoMovimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVTipoMovimiento.DefaultCellStyle = dataGridViewCellStyle3;
            DGVTipoMovimiento.EnableHeadersVisualStyles = false;
            DGVTipoMovimiento.Location = new Point(418, 335);
            DGVTipoMovimiento.Margin = new Padding(4, 4, 4, 4);
            DGVTipoMovimiento.Name = "DGVTipoMovimiento";
            DGVTipoMovimiento.ReadOnly = true;
            DGVTipoMovimiento.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVTipoMovimiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVTipoMovimiento.RowHeadersVisible = false;
            DGVTipoMovimiento.RowHeadersWidth = 51;
            DGVTipoMovimiento.Size = new Size(605, 235);
            DGVTipoMovimiento.TabIndex = 54;
            DGVTipoMovimiento.CellMouseDoubleClick += DGVTipoMovimiento_CellMouseDoubleClick;
            // 
            // panelTipodeMovimiento
            // 
            panelTipodeMovimiento.BackColor = Color.White;
            panelTipodeMovimiento.Controls.Add(btnMaximizarTipodeMovimiento);
            panelTipodeMovimiento.Controls.Add(btnCerrarTipodeMovimiento);
            panelTipodeMovimiento.Controls.Add(btnMinimizarTipodeMovimiento);
            panelTipodeMovimiento.Controls.Add(label6);
            panelTipodeMovimiento.Dock = DockStyle.Top;
            panelTipodeMovimiento.Location = new Point(0, 0);
            panelTipodeMovimiento.Margin = new Padding(2);
            panelTipodeMovimiento.Name = "panelTipodeMovimiento";
            panelTipodeMovimiento.Size = new Size(1039, 68);
            panelTipodeMovimiento.TabIndex = 1;
            // 
            // btnMaximizarTipodeMovimiento
            // 
            btnMaximizarTipodeMovimiento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarTipodeMovimiento.BackColor = Color.CornflowerBlue;
            btnMaximizarTipodeMovimiento.FlatAppearance.BorderSize = 0;
            btnMaximizarTipodeMovimiento.FlatStyle = FlatStyle.Flat;
            btnMaximizarTipodeMovimiento.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarTipodeMovimiento.IconColor = Color.OldLace;
            btnMaximizarTipodeMovimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarTipodeMovimiento.IconSize = 20;
            btnMaximizarTipodeMovimiento.Location = new Point(954, 0);
            btnMaximizarTipodeMovimiento.Margin = new Padding(2);
            btnMaximizarTipodeMovimiento.Name = "btnMaximizarTipodeMovimiento";
            btnMaximizarTipodeMovimiento.Size = new Size(45, 25);
            btnMaximizarTipodeMovimiento.TabIndex = 12;
            btnMaximizarTipodeMovimiento.UseVisualStyleBackColor = false;
            btnMaximizarTipodeMovimiento.Click += btnMaximizarTipodeMovimiento_Click;
            // 
            // btnCerrarTipodeMovimiento
            // 
            btnCerrarTipodeMovimiento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarTipodeMovimiento.BackColor = Color.Tomato;
            btnCerrarTipodeMovimiento.FlatAppearance.BorderSize = 0;
            btnCerrarTipodeMovimiento.FlatStyle = FlatStyle.Flat;
            btnCerrarTipodeMovimiento.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarTipodeMovimiento.IconColor = Color.OldLace;
            btnCerrarTipodeMovimiento.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarTipodeMovimiento.IconSize = 20;
            btnCerrarTipodeMovimiento.Location = new Point(994, 0);
            btnCerrarTipodeMovimiento.Margin = new Padding(2);
            btnCerrarTipodeMovimiento.Name = "btnCerrarTipodeMovimiento";
            btnCerrarTipodeMovimiento.Size = new Size(45, 25);
            btnCerrarTipodeMovimiento.TabIndex = 13;
            btnCerrarTipodeMovimiento.UseVisualStyleBackColor = false;
            btnCerrarTipodeMovimiento.Click += btnCerrarTipodeMovimiento_Click;
            // 
            // btnMinimizarTipodeMovimiento
            // 
            btnMinimizarTipodeMovimiento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarTipodeMovimiento.BackColor = Color.Turquoise;
            btnMinimizarTipodeMovimiento.FlatAppearance.BorderSize = 0;
            btnMinimizarTipodeMovimiento.FlatStyle = FlatStyle.Flat;
            btnMinimizarTipodeMovimiento.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarTipodeMovimiento.IconColor = Color.OldLace;
            btnMinimizarTipodeMovimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarTipodeMovimiento.IconSize = 20;
            btnMinimizarTipodeMovimiento.Location = new Point(911, 0);
            btnMinimizarTipodeMovimiento.Margin = new Padding(2);
            btnMinimizarTipodeMovimiento.Name = "btnMinimizarTipodeMovimiento";
            btnMinimizarTipodeMovimiento.Size = new Size(45, 25);
            btnMinimizarTipodeMovimiento.TabIndex = 11;
            btnMinimizarTipodeMovimiento.UseVisualStyleBackColor = false;
            btnMinimizarTipodeMovimiento.Click += btnMinimizarTipodeMovimiento_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 161, 43);
            label6.Location = new Point(12, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(478, 44);
            label6.TabIndex = 2;
            label6.Text = "TIPO DE MOVIMIENTO";
            // 
            // MantenimientoTipoMovimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(1039, 615);
            Controls.Add(panelTipodeMovimiento);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MantenimientoTipoMovimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoTipoMovimiento";
            Shown += MantenimientoTipoMovimiento_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVTipoMovimiento).EndInit();
            panelTipodeMovimiento.ResumeLayout(false);
            panelTipodeMovimiento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox nomMovimiento;
        private Panel panel2;
        private Label label2;
        private FontAwesome.Sharp.IconButton limpiar;
        private FontAwesome.Sharp.IconButton guardar;
        private TextBox buscanom;
        private Panel panel3;
        private Label label4;
        private RadioButton inactivo;
        private RadioButton activo;
        private Label label3;
        private DataGridView DGVTipoMovimiento;
        private Panel panelTipodeMovimiento;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnMaximizarTipodeMovimiento;
        private FontAwesome.Sharp.IconButton btnCerrarTipodeMovimiento;
        private FontAwesome.Sharp.IconButton btnMinimizarTipodeMovimiento;
        private PictureBox pictureBox1;
        private Panel panel4;
        private RadioButton salida;
        private RadioButton entrada;
    }
}