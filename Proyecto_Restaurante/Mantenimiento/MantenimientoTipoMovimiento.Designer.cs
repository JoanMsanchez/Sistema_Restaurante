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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            stockmenos = new RadioButton();
            stockmas = new RadioButton();
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
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTipoMovimiento).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
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
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 483);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(stockmenos);
            panel4.Controls.Add(stockmas);
            panel4.ForeColor = Color.FromArgb(255, 161, 43);
            panel4.Location = new Point(249, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(131, 85);
            panel4.TabIndex = 66;
            // 
            // stockmenos
            // 
            stockmenos.AutoSize = true;
            stockmenos.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            stockmenos.ForeColor = Color.White;
            stockmenos.Location = new Point(11, 48);
            stockmenos.Name = "stockmenos";
            stockmenos.Size = new Size(109, 24);
            stockmenos.TabIndex = 1;
            stockmenos.TabStop = true;
            stockmenos.Text = "Stock -1";
            stockmenos.UseVisualStyleBackColor = true;
            // 
            // stockmas
            // 
            stockmas.AutoSize = true;
            stockmas.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            stockmas.ForeColor = Color.White;
            stockmas.Location = new Point(11, 18);
            stockmas.Name = "stockmas";
            stockmas.Size = new Size(116, 24);
            stockmas.TabIndex = 0;
            stockmas.TabStop = true;
            stockmas.Text = "Stock +1";
            stockmas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 142);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 65;
            label1.Text = "Operación de Stock";
            // 
            // nomMovimiento
            // 
            nomMovimiento.BackColor = Color.FromArgb(255, 161, 43);
            nomMovimiento.BorderStyle = BorderStyle.None;
            nomMovimiento.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nomMovimiento.ForeColor = Color.WhiteSmoke;
            nomMovimiento.Location = new Point(312, 56);
            nomMovimiento.Name = "nomMovimiento";
            nomMovimiento.Size = new Size(147, 19);
            nomMovimiento.TabIndex = 61;
            nomMovimiento.KeyPress += nomMovimiento_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(309, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 2);
            panel2.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 51);
            label2.Name = "label2";
            label2.Size = new Size(282, 25);
            label2.TabIndex = 53;
            label2.Text = "Nombre del movimiento";
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
            limpiar.Location = new Point(176, 340);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(140, 56);
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
            guardar.Location = new Point(25, 340);
            guardar.Name = "guardar";
            guardar.Size = new Size(145, 56);
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
            buscanom.Location = new Point(504, 196);
            buscanom.Name = "buscanom";
            buscanom.Size = new Size(147, 19);
            buscanom.TabIndex = 62;
            buscanom.TextChanged += buscanom_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(504, 218);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 2);
            panel3.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(460, 168);
            label4.Name = "label4";
            label4.Size = new Size(250, 25);
            label4.TabIndex = 58;
            label4.Text = "Buscar por Condición";
            // 
            // inactivo
            // 
            inactivo.AutoSize = true;
            inactivo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inactivo.ForeColor = Color.White;
            inactivo.Location = new Point(114, 248);
            inactivo.Name = "inactivo";
            inactivo.Size = new Size(109, 24);
            inactivo.TabIndex = 57;
            inactivo.TabStop = true;
            inactivo.Text = "Inactivo";
            inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activo.ForeColor = Color.White;
            activo.Location = new Point(114, 218);
            activo.Name = "activo";
            activo.Size = new Size(90, 24);
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
            label3.Location = new Point(24, 226);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
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
            DGVTipoMovimiento.Location = new Point(334, 226);
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
            DGVTipoMovimiento.Size = new Size(484, 251);
            DGVTipoMovimiento.TabIndex = 54;
            DGVTipoMovimiento.CellMouseDoubleClick += DGVTipoMovimiento_CellMouseDoubleClick;
            // 
            // MantenimientoTipoMovimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(829, 490);
            Controls.Add(panel1);
            Name = "MantenimientoTipoMovimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoTipoMovimiento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTipoMovimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private RadioButton stockmenos;
        private RadioButton stockmas;
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
    }
}