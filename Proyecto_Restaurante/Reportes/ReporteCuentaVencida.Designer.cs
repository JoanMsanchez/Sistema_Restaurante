namespace Proyecto_Restaurante.Reportes
{
    partial class ReporteCuentaVencida
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
            dgvCuentaVencida = new DataGridView();
            pdf = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuentaVencida).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCuentaVencida);
            panel1.Controls.Add(pdf);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 469);
            panel1.TabIndex = 0;
            // 
            // dgvCuentaVencida
            // 
            dgvCuentaVencida.AllowUserToAddRows = false;
            dgvCuentaVencida.AllowUserToDeleteRows = false;
            dgvCuentaVencida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCuentaVencida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuentaVencida.BackgroundColor = Color.White;
            dgvCuentaVencida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentaVencida.Location = new Point(44, 94);
            dgvCuentaVencida.Name = "dgvCuentaVencida";
            dgvCuentaVencida.RowHeadersVisible = false;
            dgvCuentaVencida.RowHeadersWidth = 51;
            dgvCuentaVencida.Size = new Size(676, 279);
            dgvCuentaVencida.TabIndex = 7;
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
            pdf.Location = new Point(610, 394);
            pdf.Name = "pdf";
            pdf.Size = new Size(110, 52);
            pdf.TabIndex = 6;
            pdf.Text = "    PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnMaximizar);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnMinimizar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 54);
            panel2.TabIndex = 0;
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
            btnMaximizar.Location = new Point(695, 2);
            btnMaximizar.Margin = new Padding(2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(36, 20);
            btnMaximizar.TabIndex = 21;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
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
            btnCerrar.Location = new Point(727, 2);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(36, 20);
            btnCerrar.TabIndex = 22;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(537, 36);
            label1.TabIndex = 8;
            label1.Text = "REPORTE DE CUENTA VENCIDA";
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
            btnMinimizar.Location = new Point(660, 2);
            btnMinimizar.Margin = new Padding(2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(36, 20);
            btnMinimizar.TabIndex = 20;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // ReporteCuentaVencida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(765, 469);
            Controls.Add(panel1);
            Name = "ReporteCuentaVencida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteCuentaVencida";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCuentaVencida).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvCuentaVencida;
        private FontAwesome.Sharp.IconButton pdf;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
    }
}