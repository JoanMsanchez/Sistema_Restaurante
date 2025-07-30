namespace Proyecto_Restaurante.Consulta
{
    partial class ConcultaCliente
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
            categoriaproducto = new RadioButton();
            nombreproducto = new RadioButton();
            panel6 = new Panel();
            buscar = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(categoriaproducto);
            panel1.Controls.Add(nombreproducto);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(buscar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 448);
            panel1.TabIndex = 0;
            // 
            // categoriaproducto
            // 
            categoriaproducto.AutoSize = true;
            categoriaproducto.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            categoriaproducto.ForeColor = Color.White;
            categoriaproducto.Location = new Point(555, 84);
            categoriaproducto.Name = "categoriaproducto";
            categoriaproducto.Size = new Size(206, 24);
            categoriaproducto.TabIndex = 33;
            categoriaproducto.TabStop = true;
            categoriaproducto.Text = "Condición de Pago";
            categoriaproducto.UseVisualStyleBackColor = true;
            // 
            // nombreproducto
            // 
            nombreproducto.AutoSize = true;
            nombreproducto.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            nombreproducto.ForeColor = Color.White;
            nombreproducto.Location = new Point(444, 84);
            nombreproducto.Name = "nombreproducto";
            nombreproducto.Size = new Size(105, 24);
            nombreproducto.TabIndex = 32;
            nombreproducto.TabStop = true;
            nombreproducto.Text = "Nombre";
            nombreproducto.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(295, 109);
            panel6.Name = "panel6";
            panel6.Size = new Size(135, 2);
            panel6.TabIndex = 30;
            // 
            // buscar
            // 
            buscar.BackColor = Color.FromArgb(255, 161, 43);
            buscar.BorderStyle = BorderStyle.FixedSingle;
            buscar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            buscar.ForeColor = Color.White;
            buscar.Location = new Point(295, 84);
            buscar.Name = "buscar";
            buscar.Size = new Size(130, 26);
            buscar.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(117, 82);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 29;
            label3.Text = "Buscar Cliente";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 161, 43);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(745, 287);
            dataGridView1.TabIndex = 0;
            // 
            // ConcultaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(800, 451);
            Controls.Add(panel1);
            Name = "ConcultaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConcultaCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private RadioButton categoriaproducto;
        private RadioButton nombreproducto;
        private Panel panel6;
        private TextBox buscar;
        protected Label label3;
    }
}