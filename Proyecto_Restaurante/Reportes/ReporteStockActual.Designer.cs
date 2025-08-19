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
            dgvReporteProducto = new DataGridView();
            pdf = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvReporteProducto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReporteProducto
            // 
            dgvReporteProducto.AllowUserToAddRows = false;
            dgvReporteProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporteProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteProducto.EnableHeadersVisualStyles = false;
            dgvReporteProducto.Location = new Point(63, 99);
            dgvReporteProducto.Name = "dgvReporteProducto";
            dgvReporteProducto.ReadOnly = true;
            dgvReporteProducto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReporteProducto.RowHeadersVisible = false;
            dgvReporteProducto.RowHeadersWidth = 51;
            dgvReporteProducto.Size = new Size(702, 307);
            dgvReporteProducto.TabIndex = 0;
            // 
            // pdf
            // 
            pdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pdf.FlatAppearance.BorderSize = 0;
            pdf.FlatStyle = FlatStyle.Flat;
            pdf.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pdf.ForeColor = Color.White;
            pdf.IconChar = FontAwesome.Sharp.IconChar.None;
            pdf.IconColor = Color.Black;
            pdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pdf.Location = new Point(667, 448);
            pdf.Name = "pdf";
            pdf.Size = new Size(98, 52);
            pdf.TabIndex = 1;
            pdf.Text = "PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvReporteProducto);
            panel1.Controls.Add(pdf);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 539);
            panel1.TabIndex = 2;
            // 
            // ReporteStockActual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(832, 543);
            Controls.Add(panel1);
            Name = "ReporteStockActual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteStockActual";
            ((System.ComponentModel.ISupportInitialize)dgvReporteProducto).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReporteProducto;
        private FontAwesome.Sharp.IconButton pdf;
        private Panel panel1;
    }
}