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
            panel2 = new Panel();
            label3 = new Label();
            btnMaximizarUnidadMedida = new FontAwesome.Sharp.IconButton();
            btnCerrarUnidadMedida = new FontAwesome.Sharp.IconButton();
            btnMinimizarUnidadMedida = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgResumenDeudaCliente).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pdf);
            panel1.Controls.Add(dvgResumenDeudaCliente);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 473);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(213, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 2);
            panel3.TabIndex = 30;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 161, 43);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(213, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 21);
            txtNombre.TabIndex = 9;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 85);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
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
            pdf.Location = new Point(824, 397);
            pdf.Name = "pdf";
            pdf.Size = new Size(124, 52);
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
            dvgResumenDeudaCliente.Location = new Point(37, 123);
            dvgResumenDeudaCliente.Name = "dvgResumenDeudaCliente";
            dvgResumenDeudaCliente.ReadOnly = true;
            dvgResumenDeudaCliente.RowHeadersVisible = false;
            dvgResumenDeudaCliente.RowHeadersWidth = 51;
            dvgResumenDeudaCliente.Size = new Size(911, 268);
            dvgResumenDeudaCliente.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnMaximizarUnidadMedida);
            panel2.Controls.Add(btnCerrarUnidadMedida);
            panel2.Controls.Add(btnMinimizarUnidadMedida);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 54);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 161, 43);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(763, 36);
            label3.TabIndex = 5;
            label3.Text = "REPORTE RESUMEN DE DEUDA POR CLIENTE";
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
            btnMaximizarUnidadMedida.Location = new Point(912, 2);
            btnMaximizarUnidadMedida.Margin = new Padding(2);
            btnMaximizarUnidadMedida.Name = "btnMaximizarUnidadMedida";
            btnMaximizarUnidadMedida.Size = new Size(36, 20);
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
            btnCerrarUnidadMedida.Location = new Point(944, 2);
            btnCerrarUnidadMedida.Margin = new Padding(2);
            btnCerrarUnidadMedida.Name = "btnCerrarUnidadMedida";
            btnCerrarUnidadMedida.Size = new Size(36, 20);
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
            btnMinimizarUnidadMedida.Location = new Point(877, 2);
            btnMinimizarUnidadMedida.Margin = new Padding(2);
            btnMinimizarUnidadMedida.Name = "btnMinimizarUnidadMedida";
            btnMinimizarUnidadMedida.Size = new Size(36, 20);
            btnMinimizarUnidadMedida.TabIndex = 17;
            btnMinimizarUnidadMedida.UseVisualStyleBackColor = false;
            btnMinimizarUnidadMedida.Click += btnMinimizarUnidadMedida_Click;
            // 
            // ReporteResumenDeudaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(980, 473);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ReporteResumenDeudaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteResumenDeudaCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgResumenDeudaCliente).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
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