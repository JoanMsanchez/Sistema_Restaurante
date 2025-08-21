namespace Proyecto_Restaurante.Reportes
{
    partial class ReporteStockActual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteStockActual));
            dgvReporteProducto = new DataGridView();
            pdf = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            Titulo = new Panel();
            btnMaximizarUnidadMedida = new FontAwesome.Sharp.IconButton();
            btnCerrarUnidadMedida = new FontAwesome.Sharp.IconButton();
            btnMinimizarUnidadMedida = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvReporteProducto).BeginInit();
            panel1.SuspendLayout();
            Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvReporteProducto
            // 
            dgvReporteProducto.AllowUserToAddRows = false;
            dgvReporteProducto.AllowUserToDeleteRows = false;
            dgvReporteProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporteProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteProducto.BackgroundColor = Color.White;
            dgvReporteProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteProducto.EnableHeadersVisualStyles = false;
            dgvReporteProducto.Location = new Point(62, 167);
            dgvReporteProducto.Name = "dgvReporteProducto";
            dgvReporteProducto.ReadOnly = true;
            dgvReporteProducto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReporteProducto.RowHeadersVisible = false;
            dgvReporteProducto.RowHeadersWidth = 51;
            dgvReporteProducto.Size = new Size(709, 366);
            dgvReporteProducto.TabIndex = 0;
            // 
            // pdf
            // 
            pdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pdf.FlatAppearance.BorderSize = 0;
            pdf.FlatStyle = FlatStyle.Flat;
            pdf.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pdf.ForeColor = Color.White;
            pdf.IconChar = FontAwesome.Sharp.IconChar.FileText;
            pdf.IconColor = Color.White;
            pdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pdf.IconSize = 35;
            pdf.ImageAlign = ContentAlignment.MiddleLeft;
            pdf.Location = new Point(665, 552);
            pdf.Name = "pdf";
            pdf.Size = new Size(106, 52);
            pdf.TabIndex = 1;
            pdf.Text = "     PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dgvReporteProducto);
            panel1.Controls.Add(pdf);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 630);
            panel1.TabIndex = 2;
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.White;
            Titulo.Controls.Add(btnMaximizarUnidadMedida);
            Titulo.Controls.Add(btnCerrarUnidadMedida);
            Titulo.Controls.Add(btnMinimizarUnidadMedida);
            Titulo.Controls.Add(label1);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Margin = new Padding(2);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(832, 54);
            Titulo.TabIndex = 3;
            Titulo.MouseDown += Titulo_MouseDown;
            // 
            // btnMaximizarUnidadMedida
            // 
            btnMaximizarUnidadMedida.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarUnidadMedida.BackColor = Color.CornflowerBlue;
            btnMaximizarUnidadMedida.FlatAppearance.BorderSize = 0;
            btnMaximizarUnidadMedida.FlatStyle = FlatStyle.Flat;
            btnMaximizarUnidadMedida.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarUnidadMedida.IconColor = Color.OldLace;
            btnMaximizarUnidadMedida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarUnidadMedida.IconSize = 20;
            btnMaximizarUnidadMedida.Location = new Point(762, 2);
            btnMaximizarUnidadMedida.Margin = new Padding(2);
            btnMaximizarUnidadMedida.Name = "btnMaximizarUnidadMedida";
            btnMaximizarUnidadMedida.Size = new Size(36, 20);
            btnMaximizarUnidadMedida.TabIndex = 15;
            btnMaximizarUnidadMedida.UseVisualStyleBackColor = false;
            btnMaximizarUnidadMedida.Click += btnMaximizarUnidadMedida_Click;
            // 
            // btnCerrarUnidadMedida
            // 
            btnCerrarUnidadMedida.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarUnidadMedida.BackColor = Color.Tomato;
            btnCerrarUnidadMedida.FlatAppearance.BorderSize = 0;
            btnCerrarUnidadMedida.FlatStyle = FlatStyle.Flat;
            btnCerrarUnidadMedida.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarUnidadMedida.IconColor = Color.OldLace;
            btnCerrarUnidadMedida.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarUnidadMedida.IconSize = 20;
            btnCerrarUnidadMedida.Location = new Point(794, 2);
            btnCerrarUnidadMedida.Margin = new Padding(2);
            btnCerrarUnidadMedida.Name = "btnCerrarUnidadMedida";
            btnCerrarUnidadMedida.Size = new Size(36, 20);
            btnCerrarUnidadMedida.TabIndex = 16;
            btnCerrarUnidadMedida.UseVisualStyleBackColor = false;
            btnCerrarUnidadMedida.Click += btnCerrarUnidadMedida_Click;
            // 
            // btnMinimizarUnidadMedida
            // 
            btnMinimizarUnidadMedida.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarUnidadMedida.BackColor = Color.Turquoise;
            btnMinimizarUnidadMedida.FlatAppearance.BorderSize = 0;
            btnMinimizarUnidadMedida.FlatStyle = FlatStyle.Flat;
            btnMinimizarUnidadMedida.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarUnidadMedida.IconColor = Color.OldLace;
            btnMinimizarUnidadMedida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarUnidadMedida.IconSize = 20;
            btnMinimizarUnidadMedida.Location = new Point(727, 2);
            btnMinimizarUnidadMedida.Margin = new Padding(2);
            btnMinimizarUnidadMedida.Name = "btnMinimizarUnidadMedida";
            btnMinimizarUnidadMedida.Size = new Size(36, 20);
            btnMinimizarUnidadMedida.TabIndex = 14;
            btnMinimizarUnidadMedida.UseVisualStyleBackColor = false;
            btnMinimizarUnidadMedida.Click += btnMinimizarUnidadMedida_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(490, 36);
            label1.TabIndex = 2;
            label1.Text = "REPORTE DE STOCK ACTUAL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(689, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // ReporteStockActual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(832, 630);
            Controls.Add(Titulo);
            Controls.Add(panel1);
            Name = "ReporteStockActual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteStockActual";
            ((System.ComponentModel.ISupportInitialize)dgvReporteProducto).EndInit();
            panel1.ResumeLayout(false);
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReporteProducto;
        private FontAwesome.Sharp.IconButton pdf;
        private Panel panel1;
        private Panel Titulo;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizarUnidadMedida;
        private FontAwesome.Sharp.IconButton btnCerrarUnidadMedida;
        private FontAwesome.Sharp.IconButton btnMinimizarUnidadMedida;
        private PictureBox pictureBox1;
    }
}