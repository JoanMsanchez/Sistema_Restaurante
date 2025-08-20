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
            Titulo = new Panel();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteEntradaySalida).BeginInit();
            Titulo.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 714);
            panel1.TabIndex = 0;
            // 
            // rbTodo
            // 
            rbTodo.AutoSize = true;
            rbTodo.Checked = true;
            rbTodo.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rbTodo.ForeColor = Color.White;
            rbTodo.Location = new Point(566, 143);
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
            label2.Location = new Point(326, 188);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 9;
            label2.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.CalendarFont = new Font("Verdana", 10.2F);
            dtpHasta.Location = new Point(220, 215);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(290, 27);
            dtpHasta.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(326, 116);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 7;
            label1.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarFont = new Font("Verdana", 10.2F);
            dtpDesde.Location = new Point(220, 143);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(290, 27);
            dtpDesde.TabIndex = 6;
            // 
            // rbSalida
            // 
            rbSalida.AutoSize = true;
            rbSalida.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rbSalida.ForeColor = Color.White;
            rbSalida.Location = new Point(566, 214);
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
            rbEntrada.Location = new Point(566, 178);
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
            dgvReporteEntradaySalida.AllowUserToDeleteRows = false;
            dgvReporteEntradaySalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporteEntradaySalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteEntradaySalida.BackgroundColor = Color.White;
            dgvReporteEntradaySalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteEntradaySalida.EnableHeadersVisualStyles = false;
            dgvReporteEntradaySalida.Location = new Point(39, 271);
            dgvReporteEntradaySalida.Name = "dgvReporteEntradaySalida";
            dgvReporteEntradaySalida.ReadOnly = true;
            dgvReporteEntradaySalida.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReporteEntradaySalida.RowHeadersVisible = false;
            dgvReporteEntradaySalida.RowHeadersWidth = 51;
            dgvReporteEntradaySalida.Size = new Size(810, 354);
            dgvReporteEntradaySalida.TabIndex = 2;
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
            pdf.Location = new Point(738, 640);
            pdf.Name = "pdf";
            pdf.Size = new Size(111, 52);
            pdf.TabIndex = 3;
            pdf.Text = "   PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click_1;
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.White;
            Titulo.Controls.Add(btnMaximizar);
            Titulo.Controls.Add(btnCerrar);
            Titulo.Controls.Add(btnMinimizar);
            Titulo.Controls.Add(label3);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Margin = new Padding(2);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(893, 54);
            Titulo.TabIndex = 1;
            Titulo.MouseDown += Titulo_MouseDown;
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
            btnMaximizar.Location = new Point(823, 2);
            btnMaximizar.Margin = new Padding(2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(36, 20);
            btnMaximizar.TabIndex = 15;
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
            btnCerrar.Location = new Point(855, 2);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(36, 20);
            btnCerrar.TabIndex = 16;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
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
            btnMinimizar.Location = new Point(788, 2);
            btnMinimizar.Margin = new Padding(2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(36, 20);
            btnMinimizar.TabIndex = 14;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 161, 43);
            label3.Location = new Point(10, 7);
            label3.Name = "label3";
            label3.Size = new Size(566, 36);
            label3.TabIndex = 2;
            label3.Text = "REPORTE DE ENTRADA Y SALIDA";
            // 
            // ReporteEntradaySalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(893, 714);
            Controls.Add(Titulo);
            Controls.Add(panel1);
            Name = "ReporteEntradaySalida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteEntradaySalida";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteEntradaySalida).EndInit();
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
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
        private Panel Titulo;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
    }
}