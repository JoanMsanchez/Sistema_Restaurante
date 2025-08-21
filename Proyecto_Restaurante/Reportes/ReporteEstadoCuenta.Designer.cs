namespace Proyecto_Restaurante.Reportes
{
    partial class ReporteEstadoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEstadoCuenta));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtNombre = new TextBox();
            label1 = new Label();
            pdf = new FontAwesome.Sharp.IconButton();
            dtgEstadoCuenta = new DataGridView();
            Titulo = new Panel();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgEstadoCuenta).BeginInit();
            Titulo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pdf);
            panel1.Controls.Add(dtgEstadoCuenta);
            panel1.Controls.Add(Titulo);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 621);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(772, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(210, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 2);
            panel3.TabIndex = 31;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 161, 43);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(210, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 21);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 123);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 6;
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
            pdf.Location = new Point(771, 545);
            pdf.Name = "pdf";
            pdf.Size = new Size(110, 52);
            pdf.TabIndex = 5;
            pdf.Text = "    PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click;
            // 
            // dtgEstadoCuenta
            // 
            dtgEstadoCuenta.AllowUserToAddRows = false;
            dtgEstadoCuenta.AllowUserToDeleteRows = false;
            dtgEstadoCuenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgEstadoCuenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEstadoCuenta.BackgroundColor = Color.White;
            dtgEstadoCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstadoCuenta.Location = new Point(34, 163);
            dtgEstadoCuenta.Name = "dtgEstadoCuenta";
            dtgEstadoCuenta.RowHeadersVisible = false;
            dtgEstadoCuenta.RowHeadersWidth = 51;
            dtgEstadoCuenta.Size = new Size(847, 365);
            dtgEstadoCuenta.TabIndex = 1;
            // 
            // Titulo
            // 
            Titulo.BackColor = Color.White;
            Titulo.Controls.Add(btnMaximizar);
            Titulo.Controls.Add(btnCerrar);
            Titulo.Controls.Add(label3);
            Titulo.Controls.Add(btnMinimizar);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(917, 54);
            Titulo.TabIndex = 0;
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
            btnMaximizar.Location = new Point(845, 2);
            btnMaximizar.Margin = new Padding(2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(36, 20);
            btnMaximizar.TabIndex = 18;
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
            btnCerrar.Location = new Point(879, 2);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(36, 20);
            btnCerrar.TabIndex = 19;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 161, 43);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(518, 36);
            label3.TabIndex = 4;
            label3.Text = "REPORTE ESTADO DE CUENTA";
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
            btnMinimizar.Location = new Point(810, 2);
            btnMinimizar.Margin = new Padding(2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(36, 20);
            btnMinimizar.TabIndex = 17;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // ReporteEstadoCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(917, 621);
            Controls.Add(panel1);
            Name = "ReporteEstadoCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteEstadoCuenta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgEstadoCuenta).EndInit();
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Titulo;
        private Label label3;
        private DataGridView dtgEstadoCuenta;
        private FontAwesome.Sharp.IconButton pdf;
        private TextBox txtNombre;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}