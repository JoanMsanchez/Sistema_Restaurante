namespace Proyecto_Restaurante.Consulta
{
    partial class ConsultaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProveedor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelConsultaProveedor = new Panel();
            btnMaximizarproveedor = new FontAwesome.Sharp.IconButton();
            btnCerrarProveedor = new FontAwesome.Sharp.IconButton();
            btnMinimizarProveedor = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            busca = new TextBox();
            DGVProveedor = new DataGridView();
            panelConsultaProveedor.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVProveedor).BeginInit();
            SuspendLayout();
            // 
            // panelConsultaProveedor
            // 
            panelConsultaProveedor.BackColor = Color.White;
            panelConsultaProveedor.Controls.Add(btnMaximizarproveedor);
            panelConsultaProveedor.Controls.Add(btnCerrarProveedor);
            panelConsultaProveedor.Controls.Add(btnMinimizarProveedor);
            panelConsultaProveedor.Controls.Add(label8);
            panelConsultaProveedor.Dock = DockStyle.Top;
            panelConsultaProveedor.Location = new Point(0, 0);
            panelConsultaProveedor.Margin = new Padding(2);
            panelConsultaProveedor.Name = "panelConsultaProveedor";
            panelConsultaProveedor.Size = new Size(853, 58);
            panelConsultaProveedor.TabIndex = 0;
            panelConsultaProveedor.MouseDown += panelConsultaProveedor_MouseDown;
            // 
            // btnMaximizarproveedor
            // 
            btnMaximizarproveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarproveedor.BackColor = Color.CornflowerBlue;
            btnMaximizarproveedor.FlatAppearance.BorderSize = 0;
            btnMaximizarproveedor.FlatStyle = FlatStyle.Flat;
            btnMaximizarproveedor.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarproveedor.IconColor = Color.OldLace;
            btnMaximizarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarproveedor.IconSize = 20;
            btnMaximizarproveedor.Location = new Point(785, 0);
            btnMaximizarproveedor.Margin = new Padding(2);
            btnMaximizarproveedor.Name = "btnMaximizarproveedor";
            btnMaximizarproveedor.Size = new Size(36, 20);
            btnMaximizarproveedor.TabIndex = 12;
            btnMaximizarproveedor.UseVisualStyleBackColor = false;
            btnMaximizarproveedor.Click += btnMaximizarproveedor_Click;
            // 
            // btnCerrarProveedor
            // 
            btnCerrarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarProveedor.BackColor = Color.Tomato;
            btnCerrarProveedor.FlatAppearance.BorderSize = 0;
            btnCerrarProveedor.FlatStyle = FlatStyle.Flat;
            btnCerrarProveedor.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarProveedor.IconColor = Color.OldLace;
            btnCerrarProveedor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarProveedor.IconSize = 20;
            btnCerrarProveedor.Location = new Point(817, 0);
            btnCerrarProveedor.Margin = new Padding(2);
            btnCerrarProveedor.Name = "btnCerrarProveedor";
            btnCerrarProveedor.Size = new Size(36, 20);
            btnCerrarProveedor.TabIndex = 13;
            btnCerrarProveedor.UseVisualStyleBackColor = false;
            btnCerrarProveedor.Click += btnCerrarProveedor_Click;
            // 
            // btnMinimizarProveedor
            // 
            btnMinimizarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarProveedor.BackColor = Color.Turquoise;
            btnMinimizarProveedor.FlatAppearance.BorderSize = 0;
            btnMinimizarProveedor.FlatStyle = FlatStyle.Flat;
            btnMinimizarProveedor.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarProveedor.IconColor = Color.OldLace;
            btnMinimizarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarProveedor.IconSize = 20;
            btnMinimizarProveedor.Location = new Point(750, 0);
            btnMinimizarProveedor.Margin = new Padding(2);
            btnMinimizarProveedor.Name = "btnMinimizarProveedor";
            btnMinimizarProveedor.Size = new Size(36, 20);
            btnMinimizarProveedor.TabIndex = 11;
            btnMinimizarProveedor.UseVisualStyleBackColor = false;
            btnMinimizarProveedor.Click += btnMinimizarProveedor_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 161, 43);
            label8.Location = new Point(10, 7);
            label8.Name = "label8";
            label8.Size = new Size(225, 36);
            label8.TabIndex = 1;
            label8.Text = "PROVEEDOR";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(busca);
            panel2.Controls.Add(DGVProveedor);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 58);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(853, 429);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(710, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(472, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 2);
            panel1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(245, 71);
            label2.Name = "label2";
            label2.Size = new Size(226, 25);
            label2.TabIndex = 29;
            label2.Text = "Buscar por nombre";
            label2.Click += label2_Click;
            // 
            // busca
            // 
            busca.BackColor = Color.FromArgb(255, 161, 43);
            busca.BorderStyle = BorderStyle.None;
            busca.Font = new Font("Verdana", 9F, FontStyle.Bold);
            busca.ForeColor = Color.White;
            busca.Location = new Point(477, 76);
            busca.Name = "busca";
            busca.Size = new Size(153, 19);
            busca.TabIndex = 30;
            busca.TextChanged += busca_TextChanged;
            busca.KeyPress += busca_KeyPress;
            // 
            // DGVProveedor
            // 
            DGVProveedor.AllowUserToAddRows = false;
            DGVProveedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 161, 43);
            DGVProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProveedor.BackgroundColor = Color.FromArgb(255, 161, 43);
            DGVProveedor.BorderStyle = BorderStyle.None;
            DGVProveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVProveedor.ColumnHeadersHeight = 25;
            DGVProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            DGVProveedor.EnableHeadersVisualStyles = false;
            DGVProveedor.Location = new Point(66, 119);
            DGVProveedor.Name = "DGVProveedor";
            DGVProveedor.ReadOnly = true;
            DGVProveedor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 161, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVProveedor.RowHeadersVisible = false;
            DGVProveedor.RowHeadersWidth = 51;
            DGVProveedor.Size = new Size(720, 281);
            DGVProveedor.TabIndex = 28;
            DGVProveedor.CellDoubleClick += DGVProveedor_CellDoubleClick;
            // 
            // ConsultaProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(853, 487);
            Controls.Add(panel2);
            Controls.Add(panelConsultaProveedor);
            Margin = new Padding(2);
            Name = "ConsultaProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CosultaProveedor";
            Shown += ConsultaProveedor_Shown;
            panelConsultaProveedor.ResumeLayout(false);
            panelConsultaProveedor.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVProveedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConsultaProveedor;
        private Panel panel2;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnMaximizarproveedor;
        private FontAwesome.Sharp.IconButton btnCerrarProveedor;
        private FontAwesome.Sharp.IconButton btnMinimizarProveedor;
        private DataGridView DGVProveedor;
        private Panel panel1;
        protected Label label2;
        protected TextBox busca;
        private PictureBox pictureBox1;
    }
}