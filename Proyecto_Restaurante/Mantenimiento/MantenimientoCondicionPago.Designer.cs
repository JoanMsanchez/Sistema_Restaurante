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
            panel6 = new Panel();
            busDias = new RadioButton();
            busDescripcion = new RadioButton();
            diascredito = new TextBox();
            panel5 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            autopagoNO = new RadioButton();
            autopagoSI = new RadioButton();
            label1 = new Label();
            limpiar = new FontAwesome.Sharp.IconButton();
            guardar = new FontAwesome.Sharp.IconButton();
            busca = new TextBox();
            nomCondicion = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            inactivo = new RadioButton();
            activo = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            DGVCondiconPago = new DataGridView();
            panelMantenimientoCondicion = new Panel();
            btnMaximizarCondicion = new FontAwesome.Sharp.IconButton();
            btnCerrarCondicion = new FontAwesome.Sharp.IconButton();
            btnMinimizarCondicion = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCondiconPago).BeginInit();
            panelMantenimientoCondicion.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(diascredito);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(limpiar);
            panel1.Controls.Add(guardar);
            panel1.Controls.Add(busca);
            panel1.Controls.Add(nomCondicion);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(inactivo);
            panel1.Controls.Add(activo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DGVCondiconPago);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 510);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(busDias);
            panel6.Controls.Add(busDescripcion);
            panel6.Location = new Point(598, 239);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 36);
            panel6.TabIndex = 56;
            // 
            // busDias
            // 
            busDias.AutoSize = true;
            busDias.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            busDias.ForeColor = Color.White;
            busDias.Location = new Point(150, 3);
            busDias.Name = "busDias";
            busDias.Size = new Size(71, 24);
            busDias.TabIndex = 1;
            busDias.TabStop = true;
            busDias.Text = "Días";
            busDias.UseVisualStyleBackColor = true;
            // 
            // busDescripcion
            // 
            busDescripcion.AutoSize = true;
            busDescripcion.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            busDescripcion.ForeColor = Color.White;
            busDescripcion.Location = new Point(3, 3);
            busDescripcion.Name = "busDescripcion";
            busDescripcion.Size = new Size(141, 24);
            busDescripcion.TabIndex = 0;
            busDescripcion.TabStop = true;
            busDescripcion.Text = "Descripción";
            busDescripcion.UseVisualStyleBackColor = true;
            // 
            // diascredito
            // 
            diascredito.BackColor = Color.FromArgb(255, 161, 43);
            diascredito.BorderStyle = BorderStyle.None;
            diascredito.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diascredito.ForeColor = Color.WhiteSmoke;
            diascredito.Location = new Point(613, 111);
            diascredito.Name = "diascredito";
            diascredito.Size = new Size(70, 19);
            diascredito.TabIndex = 55;
            diascredito.KeyPress += diascredito_KeyPress;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(613, 132);
            panel5.Name = "panel5";
            panel5.Size = new Size(70, 2);
            panel5.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(460, 108);
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
            panel4.Location = new Point(149, 168);
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
            autopagoNO.Text = "No";
            autopagoNO.UseVisualStyleBackColor = true;
            autopagoNO.CheckedChanged += autopagoNO_CheckedChanged;
            // 
            // autopagoSI
            // 
            autopagoSI.AutoSize = true;
            autopagoSI.Checked = true;
            autopagoSI.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            autopagoSI.ForeColor = Color.White;
            autopagoSI.Location = new Point(11, 18);
            autopagoSI.Name = "autopagoSI";
            autopagoSI.Size = new Size(48, 24);
            autopagoSI.TabIndex = 0;
            autopagoSI.TabStop = true;
            autopagoSI.Text = "Si";
            autopagoSI.UseVisualStyleBackColor = true;
            autopagoSI.CheckedChanged += autopagoSI_CheckedChanged;
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
            // busca
            // 
            busca.BackColor = Color.FromArgb(255, 161, 43);
            busca.BorderStyle = BorderStyle.None;
            busca.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            busca.ForeColor = Color.WhiteSmoke;
            busca.Location = new Point(392, 256);
            busca.Name = "busca";
            busca.Size = new Size(200, 19);
            busca.TabIndex = 48;
            busca.TextChanged += buscanom_TextChanged;
            // 
            // nomCondicion
            // 
            nomCondicion.BackColor = Color.FromArgb(255, 161, 43);
            nomCondicion.BorderStyle = BorderStyle.None;
            nomCondicion.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nomCondicion.ForeColor = Color.WhiteSmoke;
            nomCondicion.Location = new Point(180, 112);
            nomCondicion.Name = "nomCondicion";
            nomCondicion.Size = new Size(270, 19);
            nomCondicion.TabIndex = 47;
            nomCondicion.KeyPress += nomCondicion_KeyPress;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(392, 278);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(180, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(450, 228);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 44;
            label4.Text = "Buscar";
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
            inactivo.Text = "Inactivo";
            inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Checked = true;
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
            DGVCondiconPago.BorderStyle = BorderStyle.None;
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
            DGVCondiconPago.Location = new Point(339, 286);
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
            DGVCondiconPago.Size = new Size(553, 218);
            DGVCondiconPago.TabIndex = 40;
            DGVCondiconPago.CellMouseDoubleClick += DGVCondiconPago_CellMouseDoubleClick;
            // 
            // panelMantenimientoCondicion
            // 
            panelMantenimientoCondicion.BackColor = Color.White;
            panelMantenimientoCondicion.Controls.Add(btnMaximizarCondicion);
            panelMantenimientoCondicion.Controls.Add(btnCerrarCondicion);
            panelMantenimientoCondicion.Controls.Add(btnMinimizarCondicion);
            panelMantenimientoCondicion.Controls.Add(label6);
            panelMantenimientoCondicion.Dock = DockStyle.Top;
            panelMantenimientoCondicion.Location = new Point(0, 0);
            panelMantenimientoCondicion.Margin = new Padding(2);
            panelMantenimientoCondicion.Name = "panelMantenimientoCondicion";
            panelMantenimientoCondicion.Size = new Size(904, 54);
            panelMantenimientoCondicion.TabIndex = 1;
            panelMantenimientoCondicion.MouseDown += panelMantenimientoCondicion_MouseDown;
            // 
            // btnMaximizarCondicion
            // 
            btnMaximizarCondicion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarCondicion.BackColor = Color.CornflowerBlue;
            btnMaximizarCondicion.FlatAppearance.BorderSize = 0;
            btnMaximizarCondicion.FlatStyle = FlatStyle.Flat;
            btnMaximizarCondicion.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarCondicion.IconColor = Color.OldLace;
            btnMaximizarCondicion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarCondicion.IconSize = 20;
            btnMaximizarCondicion.Location = new Point(836, 0);
            btnMaximizarCondicion.Margin = new Padding(2);
            btnMaximizarCondicion.Name = "btnMaximizarCondicion";
            btnMaximizarCondicion.Size = new Size(36, 20);
            btnMaximizarCondicion.TabIndex = 12;
            btnMaximizarCondicion.UseVisualStyleBackColor = false;
            btnMaximizarCondicion.Click += btnMaximizarCondicion_Click;
            // 
            // btnCerrarCondicion
            // 
            btnCerrarCondicion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarCondicion.BackColor = Color.Tomato;
            btnCerrarCondicion.FlatAppearance.BorderSize = 0;
            btnCerrarCondicion.FlatStyle = FlatStyle.Flat;
            btnCerrarCondicion.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarCondicion.IconColor = Color.OldLace;
            btnCerrarCondicion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarCondicion.IconSize = 20;
            btnCerrarCondicion.Location = new Point(868, 0);
            btnCerrarCondicion.Margin = new Padding(2);
            btnCerrarCondicion.Name = "btnCerrarCondicion";
            btnCerrarCondicion.Size = new Size(36, 20);
            btnCerrarCondicion.TabIndex = 13;
            btnCerrarCondicion.UseVisualStyleBackColor = false;
            btnCerrarCondicion.Click += btnCerrarCondicion_Click;
            // 
            // btnMinimizarCondicion
            // 
            btnMinimizarCondicion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarCondicion.BackColor = Color.Turquoise;
            btnMinimizarCondicion.FlatAppearance.BorderSize = 0;
            btnMinimizarCondicion.FlatStyle = FlatStyle.Flat;
            btnMinimizarCondicion.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarCondicion.IconColor = Color.OldLace;
            btnMinimizarCondicion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarCondicion.IconSize = 20;
            btnMinimizarCondicion.Location = new Point(802, 0);
            btnMinimizarCondicion.Margin = new Padding(2);
            btnMinimizarCondicion.Name = "btnMinimizarCondicion";
            btnMinimizarCondicion.Size = new Size(36, 20);
            btnMinimizarCondicion.TabIndex = 11;
            btnMinimizarCondicion.UseVisualStyleBackColor = false;
            btnMinimizarCondicion.Click += btnMinimizarCondicion_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 161, 43);
            label6.Location = new Point(10, 7);
            label6.Name = "label6";
            label6.Size = new Size(379, 36);
            label6.TabIndex = 2;
            label6.Text = "CONDICION DE PAGO";
            // 
            // MantenimientoCondicionPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(904, 510);
            Controls.Add(panelMantenimientoCondicion);
            Controls.Add(panel1);
            Name = "MantenimientoCondicionPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoCondicionPago";
            Shown += MantenimientoCondicionPago_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCondiconPago).EndInit();
            panelMantenimientoCondicion.ResumeLayout(false);
            panelMantenimientoCondicion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton limpiar;
        private FontAwesome.Sharp.IconButton guardar;
        private TextBox busca;
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
        private Panel panel6;
        private RadioButton busDias;
        private RadioButton busDescripcion;
        private Panel panelMantenimientoCondicion;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnMaximizarCondicion;
        private FontAwesome.Sharp.IconButton btnCerrarCondicion;
        private FontAwesome.Sharp.IconButton btnMinimizarCondicion;
    }
}