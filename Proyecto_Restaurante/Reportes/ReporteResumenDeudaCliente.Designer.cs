namespace Proyecto_Restaurante.Reportes
{
    partial class ReporteResumenDeudaCliente
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
            panel3 = new Panel();
            txtNombre = new TextBox();
            label1 = new Label();
            pdf = new FontAwesome.Sharp.IconButton();
            dvgResumenDeudaCliente = new DataGridView();
            Titulo = new Panel();
            btnMaximizarUnidadMedida = new FontAwesome.Sharp.IconButton();
            btnCerrarUnidadMedida = new FontAwesome.Sharp.IconButton();
            btnMinimizarUnidadMedida = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgResumenDeudaCliente).BeginInit();
            Titulo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pdf);
            panel1.Controls.Add(dvgResumenDeudaCliente);
            panel1.Controls.Add(Titulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 591);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(266, 135);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 2);
            panel3.TabIndex = 30;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 161, 43);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(266, 105);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 25);
            txtNombre.TabIndex = 9;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 29);
            label1.TabIndex = 8;
            label1.Text = "Buscar Cliente ";
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
            pdf.Location = new Point(1030, 496);
            pdf.Margin = new Padding(4, 4, 4, 4);
            pdf.Name = "pdf";
            pdf.Size = new Size(155, 65);
            pdf.TabIndex = 6;
            pdf.Text = "    PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click;
            // 
            // dvgResumenDeudaCliente
            // 
            dvgResumenDeudaCliente.AllowUserToAddRows = false;
            dvgResumenDeudaCliente.AllowUserToDeleteRows = false;
            dvgResumenDeudaCliente.AllowUserToResizeRows = false;
            dvgResumenDeudaCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgResumenDeudaCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgResumenDeudaCliente.BackgroundColor = Color.White;
            dvgResumenDeudaCliente.BorderStyle = BorderStyle.None;
            dvgResumenDeudaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgResumenDeudaCliente.Location = new Point(46, 154);
            dvgResumenDeudaCliente.Margin = new Padding(4, 4, 4, 4);
            dvgResumenDeudaCliente.Name = "dvgResumenDeudaCliente";
            dvgResumenDeudaCliente.ReadOnly = true;
            dvgResumenDeudaCliente.RowHeadersVisible = false;
            dvgResumenDeudaCliente.RowHeadersWidth = 51;
            dvgResumenDeudaCliente.Size = new Size(1139, 335);
            dvgResumenDeudaCliente.TabIndex = 1;
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.White;
            Titulo.Controls.Add(btnMaximizarUnidadMedida);
            Titulo.Controls.Add(btnCerrarUnidadMedida);
            Titulo.Controls.Add(btnMinimizarUnidadMedida);
            Titulo.Controls.Add(label3);
            Titulo.Dock = DockStyle.Top;
            Titulo.ForeColor = SystemColors.ControlText;
            Titulo.Location = new Point(0, 0);
            Titulo.Margin = new Padding(4, 4, 4, 4);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1225, 68);
            Titulo.TabIndex = 0;
            Titulo.MouseDown += Titulo_MouseDown_1;
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
            btnMaximizarUnidadMedida.Location = new Point(1140, 2);
            btnMaximizarUnidadMedida.Margin = new Padding(2);
            btnMaximizarUnidadMedida.Name = "btnMaximizarUnidadMedida";
            btnMaximizarUnidadMedida.Size = new Size(45, 25);
            btnMaximizarUnidadMedida.TabIndex = 18;
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
            btnCerrarUnidadMedida.Location = new Point(1180, 2);
            btnCerrarUnidadMedida.Margin = new Padding(2);
            btnCerrarUnidadMedida.Name = "btnCerrarUnidadMedida";
            btnCerrarUnidadMedida.Size = new Size(45, 25);
            btnCerrarUnidadMedida.TabIndex = 19;
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
            btnMinimizarUnidadMedida.Location = new Point(1096, 2);
            btnMinimizarUnidadMedida.Margin = new Padding(2);
            btnMinimizarUnidadMedida.Name = "btnMinimizarUnidadMedida";
            btnMinimizarUnidadMedida.Size = new Size(45, 25);
            btnMinimizarUnidadMedida.TabIndex = 17;
            btnMinimizarUnidadMedida.UseVisualStyleBackColor = false;
            btnMinimizarUnidadMedida.Click += btnMinimizarUnidadMedida_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 161, 43);
            label3.Location = new Point(15, 11);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(920, 44);
            label3.TabIndex = 5;
            label3.Text = "REPORTE RESUMEN DE DEUDA POR CLIENTE";
            // 
            // ReporteResumenDeudaCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(1225, 591);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ReporteResumenDeudaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteResumenDeudaCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgResumenDeudaCliente).EndInit();
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Titulo;
        private DataGridView dvgResumenDeudaCliente;
        private FontAwesome.Sharp.IconButton pdf;
        private TextBox txtNombre;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnMaximizarUnidadMedida;
        private FontAwesome.Sharp.IconButton btnCerrarUnidadMedida;
        private FontAwesome.Sharp.IconButton btnMinimizarUnidadMedida;
    }
}