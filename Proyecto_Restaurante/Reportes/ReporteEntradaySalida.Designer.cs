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
            panel2 = new Panel();
            label3 = new Label();
            btnMaximizarUnidadMedida = new FontAwesome.Sharp.IconButton();
            btnCerrarUnidadMedida = new FontAwesome.Sharp.IconButton();
            btnMinimizarUnidadMedida = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteEntradaySalida).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rbTodo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpHasta);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpDesde);
            panel1.Controls.Add(rbSalida);
            panel1.Controls.Add(rbEntrada);
            panel1.Controls.Add(dgvReporteEntradaySalida);
            panel1.Controls.Add(pdf);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 893);
            panel1.TabIndex = 0;
            // 
            // rbTodo
            // 
            rbTodo.AutoSize = true;
            rbTodo.Checked = true;
            rbTodo.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rbTodo.ForeColor = Color.White;
            rbTodo.Location = new Point(708, 179);
            rbTodo.Margin = new Padding(4, 4, 4, 4);
            rbTodo.Name = "rbTodo";
            rbTodo.Size = new Size(103, 33);
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
            label2.Location = new Point(408, 235);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 29);
            label2.TabIndex = 9;
            label2.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.CalendarFont = new Font("Verdana", 10.2F);
            dtpHasta.Location = new Point(275, 269);
            dtpHasta.Margin = new Padding(4, 4, 4, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(362, 31);
            dtpHasta.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(408, 145);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 29);
            label1.TabIndex = 7;
            label1.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarFont = new Font("Verdana", 10.2F);
            dtpDesde.Location = new Point(275, 179);
            dtpDesde.Margin = new Padding(4, 4, 4, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(362, 31);
            dtpDesde.TabIndex = 6;
            // 
            // rbSalida
            // 
            rbSalida.AutoSize = true;
            rbSalida.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rbSalida.ForeColor = Color.White;
            rbSalida.Location = new Point(708, 267);
            rbSalida.Margin = new Padding(4, 4, 4, 4);
            rbSalida.Name = "rbSalida";
            rbSalida.Size = new Size(120, 33);
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
            rbEntrada.Location = new Point(708, 223);
            rbEntrada.Margin = new Padding(4, 4, 4, 4);
            rbEntrada.Name = "rbEntrada";
            rbEntrada.Size = new Size(143, 33);
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
            dgvReporteEntradaySalida.Location = new Point(49, 339);
            dgvReporteEntradaySalida.Margin = new Padding(4, 4, 4, 4);
            dgvReporteEntradaySalida.Name = "dgvReporteEntradaySalida";
            dgvReporteEntradaySalida.ReadOnly = true;
            dgvReporteEntradaySalida.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReporteEntradaySalida.RowHeadersVisible = false;
            dgvReporteEntradaySalida.RowHeadersWidth = 51;
            dgvReporteEntradaySalida.Size = new Size(1012, 443);
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
            pdf.Location = new Point(939, 815);
            pdf.Margin = new Padding(4, 4, 4, 4);
            pdf.Name = "pdf";
            pdf.Size = new Size(122, 65);
            pdf.TabIndex = 3;
            pdf.Text = "PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnMaximizarUnidadMedida);
            panel2.Controls.Add(btnCerrarUnidadMedida);
            panel2.Controls.Add(btnMinimizarUnidadMedida);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 68);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 161, 43);
            label3.Location = new Point(13, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(686, 44);
            label3.TabIndex = 2;
            label3.Text = "REPORTE DE ENTRADA Y SALIDA";
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
            btnMaximizarUnidadMedida.Location = new Point(1029, 2);
            btnMaximizarUnidadMedida.Margin = new Padding(2);
            btnMaximizarUnidadMedida.Name = "btnMaximizarUnidadMedida";
            btnMaximizarUnidadMedida.Size = new Size(45, 25);
            btnMaximizarUnidadMedida.TabIndex = 15;
            btnMaximizarUnidadMedida.UseVisualStyleBackColor = false;
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
            btnCerrarUnidadMedida.Location = new Point(1069, 2);
            btnCerrarUnidadMedida.Margin = new Padding(2);
            btnCerrarUnidadMedida.Name = "btnCerrarUnidadMedida";
            btnCerrarUnidadMedida.Size = new Size(45, 25);
            btnCerrarUnidadMedida.TabIndex = 16;
            btnCerrarUnidadMedida.UseVisualStyleBackColor = false;
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
            btnMinimizarUnidadMedida.Location = new Point(985, 2);
            btnMinimizarUnidadMedida.Margin = new Padding(2);
            btnMinimizarUnidadMedida.Name = "btnMinimizarUnidadMedida";
            btnMinimizarUnidadMedida.Size = new Size(45, 25);
            btnMinimizarUnidadMedida.TabIndex = 14;
            btnMinimizarUnidadMedida.UseVisualStyleBackColor = false;
            // 
            // ReporteEntradaySalida
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(1116, 893);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ReporteEntradaySalida";
            Text = "ReporteEntradaySalida";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteEntradaySalida).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnMaximizarUnidadMedida;
        private FontAwesome.Sharp.IconButton btnCerrarUnidadMedida;
        private FontAwesome.Sharp.IconButton btnMinimizarUnidadMedida;
    }
}