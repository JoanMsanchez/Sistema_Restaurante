namespace Proyecto_Restaurante.Consulta
{
    partial class ConsultaProductos
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
            panelConsultaProducto = new Panel();
            btnMaximizarConsultaProducto = new FontAwesome.Sharp.IconButton();
            btnCerrarConsultaProducto = new FontAwesome.Sharp.IconButton();
            btnMinimizarConsultaProducto = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            buscar = new TextBox();
            label3 = new Label();
            panelConsultaProducto.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelConsultaProducto
            // 
            panelConsultaProducto.BackColor = Color.White;
            panelConsultaProducto.Controls.Add(btnMaximizarConsultaProducto);
            panelConsultaProducto.Controls.Add(btnCerrarConsultaProducto);
            panelConsultaProducto.Controls.Add(btnMinimizarConsultaProducto);
            panelConsultaProducto.Controls.Add(label1);
            panelConsultaProducto.Dock = DockStyle.Top;
            panelConsultaProducto.Location = new Point(0, 0);
            panelConsultaProducto.Margin = new Padding(2);
            panelConsultaProducto.Name = "panelConsultaProducto";
            panelConsultaProducto.Size = new Size(1286, 58);
            panelConsultaProducto.TabIndex = 0;
            panelConsultaProducto.MouseDown += panelConsultaProducto_MouseDown;
            // 
            // btnMaximizarConsultaProducto
            // 
            btnMaximizarConsultaProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarConsultaProducto.BackColor = Color.CornflowerBlue;
            btnMaximizarConsultaProducto.FlatAppearance.BorderSize = 0;
            btnMaximizarConsultaProducto.FlatStyle = FlatStyle.Flat;
            btnMaximizarConsultaProducto.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarConsultaProducto.IconColor = Color.OldLace;
            btnMaximizarConsultaProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarConsultaProducto.IconSize = 20;
            btnMaximizarConsultaProducto.Location = new Point(1218, 0);
            btnMaximizarConsultaProducto.Margin = new Padding(2);
            btnMaximizarConsultaProducto.Name = "btnMaximizarConsultaProducto";
            btnMaximizarConsultaProducto.Size = new Size(36, 20);
            btnMaximizarConsultaProducto.TabIndex = 15;
            btnMaximizarConsultaProducto.UseVisualStyleBackColor = false;
            btnMaximizarConsultaProducto.Click += btnMaximizarConsultaProducto_Click;
            // 
            // btnCerrarConsultaProducto
            // 
            btnCerrarConsultaProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarConsultaProducto.BackColor = Color.Tomato;
            btnCerrarConsultaProducto.FlatAppearance.BorderSize = 0;
            btnCerrarConsultaProducto.FlatStyle = FlatStyle.Flat;
            btnCerrarConsultaProducto.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarConsultaProducto.IconColor = Color.OldLace;
            btnCerrarConsultaProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarConsultaProducto.IconSize = 20;
            btnCerrarConsultaProducto.Location = new Point(1250, 0);
            btnCerrarConsultaProducto.Margin = new Padding(2);
            btnCerrarConsultaProducto.Name = "btnCerrarConsultaProducto";
            btnCerrarConsultaProducto.Size = new Size(36, 20);
            btnCerrarConsultaProducto.TabIndex = 16;
            btnCerrarConsultaProducto.UseVisualStyleBackColor = false;
            btnCerrarConsultaProducto.Click += btnCerrarConsultaProducto_Click;
            // 
            // btnMinimizarConsultaProducto
            // 
            btnMinimizarConsultaProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarConsultaProducto.BackColor = Color.Turquoise;
            btnMinimizarConsultaProducto.FlatAppearance.BorderSize = 0;
            btnMinimizarConsultaProducto.FlatStyle = FlatStyle.Flat;
            btnMinimizarConsultaProducto.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizarConsultaProducto.IconColor = Color.OldLace;
            btnMinimizarConsultaProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarConsultaProducto.IconSize = 20;
            btnMinimizarConsultaProducto.Location = new Point(1184, 0);
            btnMinimizarConsultaProducto.Margin = new Padding(2);
            btnMinimizarConsultaProducto.Name = "btnMinimizarConsultaProducto";
            btnMinimizarConsultaProducto.Size = new Size(36, 20);
            btnMinimizarConsultaProducto.TabIndex = 14;
            btnMinimizarConsultaProducto.UseVisualStyleBackColor = false;
            btnMinimizarConsultaProducto.Click += btnMinimizarConsultaProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(18, 7);
            label1.Name = "label1";
            label1.Size = new Size(203, 36);
            label1.TabIndex = 2;
            label1.Text = "PRODUCTO";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(buscar);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 58);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 454);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 124);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1264, 281);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(568, 74);
            panel6.Name = "panel6";
            panel6.Size = new Size(135, 2);
            panel6.TabIndex = 24;
            // 
            // buscar
            // 
            buscar.BackColor = Color.FromArgb(255, 161, 43);
            buscar.BorderStyle = BorderStyle.None;
            buscar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            buscar.ForeColor = Color.White;
            buscar.Location = new Point(568, 49);
            buscar.Name = "buscar";
            buscar.Size = new Size(130, 19);
            buscar.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(365, 43);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 6;
            label3.Text = "Buscar Producto";
            // 
            // ConsultaProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(1286, 512);
            Controls.Add(panel2);
            Controls.Add(panelConsultaProducto);
            Margin = new Padding(2);
            Name = "ConsultaProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            panelConsultaProducto.ResumeLayout(false);
            panelConsultaProducto.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConsultaProducto;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMaximizarConsultaProducto;
        private FontAwesome.Sharp.IconButton btnCerrarConsultaProducto;
        private FontAwesome.Sharp.IconButton btnMinimizarConsultaProducto;
        protected Label label3;
        private DataGridView dataGridView1;
        private Panel panel6;
        private TextBox buscar;
    }
}