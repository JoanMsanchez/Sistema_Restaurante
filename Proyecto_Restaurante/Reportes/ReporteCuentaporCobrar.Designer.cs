namespace Proyecto_Restaurante.Reportes
{
    partial class ReporteCuentaporCobrar
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
            panel1 = new Panel();
            pdf = new FontAwesome.Sharp.IconButton();
            dtgCxC = new DataGridView();
            panel2 = new Panel();
            label3 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCxC).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pdf);
            panel1.Controls.Add(dtgCxC);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 611);
            panel1.TabIndex = 0;
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
            pdf.Location = new Point(633, 547);
            pdf.Name = "pdf";
            pdf.Size = new Size(98, 52);
            pdf.TabIndex = 4;
            pdf.Text = "PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click;
            // 
            // dtgCxC
            // 
            dtgCxC.AllowUserToResizeColumns = false;
            dtgCxC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCxC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCxC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCxC.Location = new Point(50, 138);
            dtgCxC.Name = "dtgCxC";
            dtgCxC.RowHeadersWidth = 51;
            dtgCxC.Size = new Size(681, 368);
            dtgCxC.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(791, 54);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 161, 43);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(603, 36);
            label3.TabIndex = 3;
            label3.Text = "REPORTE DE CUENTA POR COBRAR";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(225, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 9;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 103);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 8;
            label1.Text = "Buscar Cliente ";
            // 
            // ReporteCuentaporCobrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(791, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReporteCuentaporCobrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteCuentaporCobrar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCxC).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgCxC;
        private FontAwesome.Sharp.IconButton pdf;
        private Panel panel2;
        private Label label3;
        private TextBox txtNombre;
        private Label label1;
    }
}