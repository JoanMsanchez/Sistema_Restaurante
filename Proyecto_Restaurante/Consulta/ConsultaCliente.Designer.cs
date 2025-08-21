namespace Proyecto_Restaurante.Consulta
{
    partial class ConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCliente));
            panel1 = new Panel();
            buscaCondicion = new RadioButton();
            buscaNombre = new RadioButton();
            panel6 = new Panel();
            buscar = new TextBox();
            label3 = new Label();
            DGVConsultaCliente = new DataGridView();
            pictureBox1 = new PictureBox();
            panelConsultaCliente = new Panel();
            btnMaximizarCategoria = new FontAwesome.Sharp.IconButton();
            btnCerrarCategoria = new FontAwesome.Sharp.IconButton();
            btnMinimizarCategoria = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVConsultaCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelConsultaCliente.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buscaCondicion);
            panel1.Controls.Add(buscaNombre);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(buscar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DGVConsultaCliente);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 507);
            panel1.TabIndex = 0;
            // 
            // buscaCondicion
            // 
            buscaCondicion.AutoSize = true;
            buscaCondicion.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            buscaCondicion.ForeColor = Color.White;
            buscaCondicion.Location = new Point(457, 122);
            buscaCondicion.Name = "buscaCondicion";
            buscaCondicion.Size = new Size(206, 24);
            buscaCondicion.TabIndex = 33;
            buscaCondicion.TabStop = true;
            buscaCondicion.Text = "Condición de Pago";
            buscaCondicion.UseVisualStyleBackColor = true;
            buscaCondicion.CheckedChanged += buscaCondicion_CheckedChanged;
            // 
            // buscaNombre
            // 
            buscaNombre.AutoSize = true;
            buscaNombre.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            buscaNombre.ForeColor = Color.White;
            buscaNombre.Location = new Point(346, 122);
            buscaNombre.Name = "buscaNombre";
            buscaNombre.Size = new Size(105, 24);
            buscaNombre.TabIndex = 32;
            buscaNombre.TabStop = true;
            buscaNombre.Text = "Nombre";
            buscaNombre.UseVisualStyleBackColor = true;
            buscaNombre.CheckedChanged += buscaNombre_CheckedChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(197, 147);
            panel6.Name = "panel6";
            panel6.Size = new Size(135, 2);
            panel6.TabIndex = 30;
            // 
            // buscar
            // 
            buscar.BackColor = Color.FromArgb(255, 161, 43);
            buscar.BorderStyle = BorderStyle.None;
            buscar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            buscar.ForeColor = Color.White;
            buscar.Location = new Point(202, 127);
            buscar.Name = "buscar";
            buscar.Size = new Size(130, 19);
            buscar.TabIndex = 31;
            buscar.TextChanged += buscar_TextChanged;
            buscar.KeyPress += buscar_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 120);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 29;
            label3.Text = "Buscar Cliente";
            // 
            // DGVConsultaCliente
            // 
            DGVConsultaCliente.AllowUserToAddRows = false;
            DGVConsultaCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVConsultaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVConsultaCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVConsultaCliente.BackgroundColor = Color.FromArgb(255, 161, 43);
            DGVConsultaCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVConsultaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVConsultaCliente.ColumnHeadersHeight = 29;
            DGVConsultaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVConsultaCliente.DefaultCellStyle = dataGridViewCellStyle3;
            DGVConsultaCliente.EnableHeadersVisualStyles = false;
            DGVConsultaCliente.Location = new Point(19, 164);
            DGVConsultaCliente.Name = "DGVConsultaCliente";
            DGVConsultaCliente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVConsultaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVConsultaCliente.RowHeadersVisible = false;
            DGVConsultaCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVConsultaCliente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DGVConsultaCliente.Size = new Size(765, 287);
            DGVConsultaCliente.TabIndex = 0;
            DGVConsultaCliente.CellMouseDoubleClick += DGVConsultaCliente_CellMouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(708, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // panelConsultaCliente
            // 
            panelConsultaCliente.BackColor = Color.White;
            panelConsultaCliente.Controls.Add(btnMaximizarCategoria);
            panelConsultaCliente.Controls.Add(btnCerrarCategoria);
            panelConsultaCliente.Controls.Add(btnMinimizarCategoria);
            panelConsultaCliente.Controls.Add(label6);
            panelConsultaCliente.Dock = DockStyle.Top;
            panelConsultaCliente.Location = new Point(0, 0);
            panelConsultaCliente.Margin = new Padding(2);
            panelConsultaCliente.Name = "panelConsultaCliente";
            panelConsultaCliente.Size = new Size(844, 54);
            panelConsultaCliente.TabIndex = 1;
            panelConsultaCliente.MouseDown += panelConsultaCliente_MouseDown;
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
            btnMaximizarCategoria.Location = new Point(776, 0);
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
            btnCerrarCategoria.Location = new Point(808, 0);
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
            btnMinimizarCategoria.Location = new Point(742, 0);
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
            label6.Size = new Size(159, 36);
            label6.TabIndex = 2;
            label6.Text = "CLIENTE";
            // 
            // ConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(844, 507);
            Controls.Add(panelConsultaCliente);
            Controls.Add(panel1);
            Name = "ConsultaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConcultaCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVConsultaCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelConsultaCliente.ResumeLayout(false);
            panelConsultaCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DGVConsultaCliente;
        private RadioButton buscaCondicion;
        private RadioButton buscaNombre;
        private Panel panel6;
        private TextBox buscar;
        protected Label label3;
        private Panel panelConsultaCliente;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnMaximizarCategoria;
        private FontAwesome.Sharp.IconButton btnCerrarCategoria;
        private FontAwesome.Sharp.IconButton btnMinimizarCategoria;
        private PictureBox pictureBox1;
    }
}