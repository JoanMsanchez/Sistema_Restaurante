namespace Proyecto_Restaurante.Mantenimiento
{
    partial class MantenimientoCondicionPago
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
            diascredito = new TextBox();
            panel5 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            autopagoNO = new RadioButton();
            autopagoSI = new RadioButton();
            label1 = new Label();
            limpiar = new FontAwesome.Sharp.IconButton();
            guardar = new FontAwesome.Sharp.IconButton();
            buscanom = new TextBox();
            nomCondicion = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            inactivo = new RadioButton();
            activo = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            DGVCondiconPago = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCondiconPago).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(diascredito);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(limpiar);
            panel1.Controls.Add(guardar);
            panel1.Controls.Add(buscanom);
            panel1.Controls.Add(nomCondicion);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(inactivo);
            panel1.Controls.Add(activo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DGVCondiconPago);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 495);
            panel1.TabIndex = 0;
            // 
            // diascredito
            // 
            diascredito.BackColor = Color.FromArgb(255, 161, 43);
            diascredito.BorderStyle = BorderStyle.None;
            diascredito.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diascredito.ForeColor = Color.WhiteSmoke;
            diascredito.Location = new Point(506, 109);
            diascredito.Name = "diascredito";
            diascredito.Size = new Size(70, 19);
            diascredito.TabIndex = 55;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(506, 133);
            panel5.Name = "panel5";
            panel5.Size = new Size(70, 2);
            panel5.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(353, 109);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 53;
            label5.Text = "Días crédito";
            // 
            // panel4
            // 
            panel4.Controls.Add(autopagoNO);
            panel4.Controls.Add(autopagoSI);
            panel4.ForeColor = Color.FromArgb(255, 161, 43);
            panel4.Location = new Point(149, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(131, 85);
            panel4.TabIndex = 52;
            // 
            // autopagoNO
            // 
            autopagoNO.AutoSize = true;
            autopagoNO.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            autopagoNO.ForeColor = Color.White;
            autopagoNO.Location = new Point(11, 48);
            autopagoNO.Name = "autopagoNO";
            autopagoNO.Size = new Size(56, 24);
            autopagoNO.TabIndex = 1;
            autopagoNO.TabStop = true;
            autopagoNO.Text = "No";
            autopagoNO.UseVisualStyleBackColor = true;
            // 
            // autopagoSI
            // 
            autopagoSI.AutoSize = true;
            autopagoSI.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            autopagoSI.ForeColor = Color.White;
            autopagoSI.Location = new Point(11, 18);
            autopagoSI.Name = "autopagoSI";
            autopagoSI.Size = new Size(48, 24);
            autopagoSI.TabIndex = 0;
            autopagoSI.TabStop = true;
            autopagoSI.Text = "Si";
            autopagoSI.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 196);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 51;
            label1.Text = "Autopago ";
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
            limpiar.Location = new Point(175, 395);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(140, 56);
            limpiar.TabIndex = 50;
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
            guardar.Location = new Point(24, 395);
            guardar.Name = "guardar";
            guardar.Size = new Size(145, 56);
            guardar.TabIndex = 49;
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
            buscanom.Location = new Point(480, 251);
            buscanom.Name = "buscanom";
            buscanom.Size = new Size(147, 19);
            buscanom.TabIndex = 48;
            // 
            // nomCondicion
            // 
            nomCondicion.BackColor = Color.FromArgb(255, 161, 43);
            nomCondicion.BorderStyle = BorderStyle.None;
            nomCondicion.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nomCondicion.ForeColor = Color.WhiteSmoke;
            nomCondicion.Location = new Point(183, 109);
            nomCondicion.Name = "nomCondicion";
            nomCondicion.Size = new Size(147, 19);
            nomCondicion.TabIndex = 47;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(480, 273);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 2);
            panel3.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(180, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 2);
            panel2.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(441, 223);
            label4.Name = "label4";
            label4.Size = new Size(250, 25);
            label4.TabIndex = 44;
            label4.Text = "Buscar por Condición";
            // 
            // inactivo
            // 
            inactivo.AutoSize = true;
            inactivo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inactivo.ForeColor = Color.White;
            inactivo.Location = new Point(123, 307);
            inactivo.Name = "inactivo";
            inactivo.Size = new Size(109, 24);
            inactivo.TabIndex = 43;
            inactivo.TabStop = true;
            inactivo.Text = "Inactivo";
            inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activo.ForeColor = Color.White;
            activo.Location = new Point(123, 273);
            activo.Name = "activo";
            activo.Size = new Size(90, 24);
            activo.TabIndex = 42;
            activo.TabStop = true;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 281);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 41;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 106);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 39;
            label2.Text = "Descripción";
            // 
            // DGVCondiconPago
            // 
            DGVCondiconPago.AllowUserToAddRows = false;
            DGVCondiconPago.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVCondiconPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVCondiconPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCondiconPago.BackgroundColor = Color.FromArgb(255, 161, 43);
            DGVCondiconPago.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVCondiconPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVCondiconPago.ColumnHeadersHeight = 25;
            DGVCondiconPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVCondiconPago.DefaultCellStyle = dataGridViewCellStyle3;
            DGVCondiconPago.EnableHeadersVisualStyles = false;
            DGVCondiconPago.Location = new Point(353, 281);
            DGVCondiconPago.Name = "DGVCondiconPago";
            DGVCondiconPago.ReadOnly = true;
            DGVCondiconPago.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVCondiconPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVCondiconPago.RowHeadersVisible = false;
            DGVCondiconPago.RowHeadersWidth = 51;
            DGVCondiconPago.Size = new Size(406, 205);
            DGVCondiconPago.TabIndex = 40;
            // 
            // MantenimientoCondicionPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(771, 499);
            Controls.Add(panel1);
            Name = "MantenimientoCondicionPago";
            Text = "MantenimientoCondicionPago";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCondiconPago).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton limpiar;
        private FontAwesome.Sharp.IconButton guardar;
        private TextBox buscanom;
        private TextBox nomCondicion;
        private Panel panel3;
        private Panel panel2;
        private Label label4;
        private RadioButton inactivo;
        private RadioButton activo;
        private Label label3;
        private Label label2;
        private DataGridView DGVCondiconPago;
        private Panel panel4;
        private RadioButton autopagoNO;
        private RadioButton autopagoSI;
        private Label label1;
        private TextBox diascredito;
        private Panel panel5;
        private Label label5;
    }
}