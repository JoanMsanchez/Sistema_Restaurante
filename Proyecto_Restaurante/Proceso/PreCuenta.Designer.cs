namespace Proyecto_Restaurante.Proceso
{
    partial class PreCuenta
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
            textBox1 = new TextBox();
            txtFecha = new TextBox();
            label7 = new Label();
            txtTotal = new TextBox();
            label4 = new Label();
            txtItbis = new TextBox();
            label5 = new Label();
            txtSubTotal = new TextBox();
            label6 = new Label();
            txtAtendido = new TextBox();
            label3 = new Label();
            txtCondicion = new TextBox();
            label2 = new Label();
            txtCliente = new TextBox();
            label1 = new Label();
            dgvPreCuenta = new DataGridView();
            panel2 = new Panel();
            txtSalaMesa = new TextBox();
            txtOrden = new TextBox();
            label14 = new Label();
            label13 = new Label();
            pdf = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreCuenta).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pdf);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtFecha);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtItbis);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSubTotal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtAtendido);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCondicion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCliente);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvPreCuenta);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 676);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 161, 43);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(38, 550);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 69);
            textBox1.TabIndex = 16;
            textBox1.Text = "Revise su pedido antes de procesar el pago.";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.FromArgb(255, 161, 43);
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Verdana", 10.2F);
            txtFecha.ForeColor = Color.White;
            txtFecha.Location = new Point(535, 148);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(212, 21);
            txtFecha.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(444, 144);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 14;
            label7.Text = "Fecha";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(255, 161, 43);
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Verdana", 10.2F);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(766, 616);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 21);
            txtTotal.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(596, 616);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 12;
            label4.Text = "Total";
            // 
            // txtItbis
            // 
            txtItbis.BackColor = Color.FromArgb(255, 161, 43);
            txtItbis.BorderStyle = BorderStyle.None;
            txtItbis.Font = new Font("Verdana", 10.2F);
            txtItbis.ForeColor = Color.White;
            txtItbis.Location = new Point(766, 583);
            txtItbis.Name = "txtItbis";
            txtItbis.ReadOnly = true;
            txtItbis.Size = new Size(125, 21);
            txtItbis.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(596, 583);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 10;
            label5.Text = "ITEBIS 18%";
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.FromArgb(255, 161, 43);
            txtSubTotal.BorderStyle = BorderStyle.None;
            txtSubTotal.Font = new Font("Verdana", 10.2F);
            txtSubTotal.ForeColor = Color.White;
            txtSubTotal.Location = new Point(766, 550);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(125, 21);
            txtSubTotal.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(596, 550);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 8;
            label6.Text = "Sub-Total";
            // 
            // txtAtendido
            // 
            txtAtendido.BackColor = Color.FromArgb(255, 161, 43);
            txtAtendido.BorderStyle = BorderStyle.None;
            txtAtendido.Font = new Font("Verdana", 10.2F);
            txtAtendido.ForeColor = Color.White;
            txtAtendido.Location = new Point(219, 187);
            txtAtendido.Name = "txtAtendido";
            txtAtendido.ReadOnly = true;
            txtAtendido.Size = new Size(182, 21);
            txtAtendido.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 183);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 6;
            label3.Text = "Atendido por ";
            // 
            // txtCondicion
            // 
            txtCondicion.BackColor = Color.FromArgb(255, 161, 43);
            txtCondicion.BorderStyle = BorderStyle.None;
            txtCondicion.Font = new Font("Verdana", 10.2F);
            txtCondicion.ForeColor = Color.White;
            txtCondicion.Location = new Point(219, 152);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.ReadOnly = true;
            txtCondicion.Size = new Size(182, 21);
            txtCondicion.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(53, 148);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 4;
            label2.Text = "Condicion";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.FromArgb(255, 161, 43);
            txtCliente.BorderStyle = BorderStyle.None;
            txtCliente.Font = new Font("Verdana", 10.2F);
            txtCliente.ForeColor = Color.White;
            txtCliente.Location = new Point(219, 119);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(182, 21);
            txtCliente.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 115);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 2;
            label1.Text = "Cliente";
            // 
            // dgvPreCuenta
            // 
            dgvPreCuenta.BackgroundColor = Color.White;
            dgvPreCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreCuenta.Location = new Point(38, 240);
            dgvPreCuenta.Name = "dgvPreCuenta";
            dgvPreCuenta.RowHeadersWidth = 51;
            dgvPreCuenta.Size = new Size(834, 291);
            dgvPreCuenta.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtSalaMesa);
            panel2.Controls.Add(txtOrden);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 54);
            panel2.TabIndex = 0;
            // 
            // txtSalaMesa
            // 
            txtSalaMesa.BackColor = Color.White;
            txtSalaMesa.BorderStyle = BorderStyle.None;
            txtSalaMesa.Font = new Font("Verdana", 10.2F);
            txtSalaMesa.ForeColor = Color.FromArgb(255, 161, 43);
            txtSalaMesa.Location = new Point(446, 18);
            txtSalaMesa.Name = "txtSalaMesa";
            txtSalaMesa.ReadOnly = true;
            txtSalaMesa.Size = new Size(159, 21);
            txtSalaMesa.TabIndex = 21;
            // 
            // txtOrden
            // 
            txtOrden.BackColor = Color.White;
            txtOrden.BorderStyle = BorderStyle.None;
            txtOrden.Font = new Font("Verdana", 10.2F);
            txtOrden.ForeColor = Color.FromArgb(255, 161, 43);
            txtOrden.Location = new Point(267, 18);
            txtOrden.Name = "txtOrden";
            txtOrden.ReadOnly = true;
            txtOrden.Size = new Size(161, 21);
            txtOrden.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.DarkOrange;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Enabled = false;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(243, 6);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(2, 43);
            label14.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(255, 161, 43);
            label13.Location = new Point(12, 9);
            label13.Name = "label13";
            label13.Size = new Size(226, 36);
            label13.TabIndex = 18;
            label13.Text = "PRECUENTA ";
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
            pdf.Location = new Point(38, 612);
            pdf.Name = "pdf";
            pdf.Size = new Size(110, 52);
            pdf.TabIndex = 7;
            pdf.Text = "    PDF";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += pdf_Click;
            // 
            // PreCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(907, 676);
            Controls.Add(panel1);
            Name = "PreCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PreCuenta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreCuenta).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvPreCuenta;
        private TextBox txtAtendido;
        private Label label3;
        private TextBox txtCondicion;
        private Label label2;
        private TextBox txtCliente;
        private Label label1;
        private TextBox txtTotal;
        private Label label4;
        private TextBox txtItbis;
        private Label label5;
        private TextBox txtSubTotal;
        private Label label6;
        private TextBox txtFecha;
        private Label label7;
        private TextBox txtSalaMesa;
        private TextBox txtOrden;
        private Label label14;
        private Label label13;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton pdf;
    }
}