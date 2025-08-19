namespace Proyecto_Restaurante.Reportes
{
    partial class ReporteEntradaySalida
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
            rbTodo = new RadioButton();
            label2 = new Label();
            dtpHasta = new DateTimePicker();
            label1 = new Label();
            dtpDesde = new DateTimePicker();
            rbSalida = new RadioButton();
            rbEntrada = new RadioButton();
            dgvReporteEntradaySalida = new DataGridView();
            pdf = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteEntradaySalida).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(rbTodo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpHasta);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpDesde);
            panel1.Controls.Add(rbSalida);
            panel1.Controls.Add(rbEntrada);
            panel1.Controls.Add(dgvReporteEntradaySalida);
            panel1.Controls.Add(pdf);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 657);
            panel1.TabIndex = 0;
            // 
            // rbTodo
            // 
            rbTodo.AutoSize = true;
            rbTodo.Checked = true;
            rbTodo.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rbTodo.ForeColor = Color.White;
            rbTodo.Location = new Point(546, 82);
            rbTodo.Name = "rbTodo";
            rbTodo.Size = new Size(89, 29);
            rbTodo.TabIndex = 10;
            rbTodo.TabStop = true;
            rbTodo.Text = "Todo";
            rbTodo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(306, 126);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 9;
            label2.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.CalendarFont = new Font("Verdana", 10.2F);
            dtpHasta.Location = new Point(199, 154);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(290, 27);
            dtpHasta.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(306, 54);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 7;
            label1.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarFont = new Font("Verdana", 10.2F);
            dtpDesde.Location = new Point(199, 82);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(290, 27);
            dtpDesde.TabIndex = 6;
            // 
            // rbSalida
            // 
            rbSalida.AutoSize = true;
            rbSalida.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rbSalida.ForeColor = Color.White;
            rbSalida.Location = new Point(546, 152);
            rbSalida.Name = "rbSalida";
            rbSalida.Size = new Size(101, 29);
            rbSalida.TabIndex = 5;
            rbSalida.TabStop = true;
            rbSalida.Text = "Salida";
            rbSalida.UseVisualStyleBackColor = true;
            // 
            // rbEntrada
            // 
            rbEntrada.AutoSize = true;
            rbEntrada.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rbEntrada.ForeColor = Color.White;
            rbEntrada.Location = new Point(546, 117);
            rbEntrada.Name = "rbEntrada";
            rbEntrada.Size = new Size(120, 29);
            rbEntrada.TabIndex = 4;
            rbEntrada.TabStop = true;
            rbEntrada.Text = "Entrada";
            rbEntrada.UseVisualStyleBackColor = true;
            // 
            // dgvReporteEntradaySalida
            // 
            dgvReporteEntradaySalida.AllowUserToAddRows = false;
            dgvReporteEntradaySalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporteEntradaySalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteEntradaySalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteEntradaySalida.EnableHeadersVisualStyles = false;
            dgvReporteEntradaySalida.Location = new Point(39, 199);
            dgvReporteEntradaySalida.Name = "dgvReporteEntradaySalida";
            dgvReporteEntradaySalida.ReadOnly = true;
            dgvReporteEntradaySalida.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReporteEntradaySalida.RowHeadersVisible = false;
            dgvReporteEntradaySalida.RowHeadersWidth = 51;
            dgvReporteEntradaySalida.Size = new Size(812, 352);
            dgvReporteEntradaySalida.TabIndex = 2;
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
            pdf.Location = new Point(753, 576);
            pdf.Name = "pdf";
            pdf.Size = new Size(98, 52);
            pdf.TabIndex = 3;
            pdf.Text = "PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click_1;
            // 
            // ReporteEntradaySalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(893, 655);
            Controls.Add(panel1);
            Name = "ReporteEntradaySalida";
            Text = "ReporteEntradaySalida";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteEntradaySalida).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvReporteEntradaySalida;
        private FontAwesome.Sharp.IconButton pdf;
        private Label label2;
        private DateTimePicker dtpHasta;
        private Label label1;
        private DateTimePicker dtpDesde;
        private RadioButton rbSalida;
        private RadioButton rbEntrada;
        private RadioButton rbTodo;
    }
}