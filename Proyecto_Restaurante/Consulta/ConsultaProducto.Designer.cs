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
            label3 = new Label();
            panel6 = new Panel();
            buscar = new TextBox();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            comboCategoria = new DataGridViewTextBoxColumn();
            comboUnidad = new DataGridViewTextBoxColumn();
            stockActual = new DataGridViewTextBoxColumn();
            stockMinimo = new DataGridViewTextBoxColumn();
            costo = new DataGridViewTextBoxColumn();
            venta = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
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
            panelConsultaProducto.Name = "panelConsultaProducto";
            panelConsultaProducto.Size = new Size(1924, 72);
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
            btnMaximizarConsultaProducto.Location = new Point(1839, 0);
            btnMaximizarConsultaProducto.Margin = new Padding(2);
            btnMaximizarConsultaProducto.Name = "btnMaximizarConsultaProducto";
            btnMaximizarConsultaProducto.Size = new Size(45, 25);
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
            btnCerrarConsultaProducto.Location = new Point(1879, 0);
            btnCerrarConsultaProducto.Margin = new Padding(2);
            btnCerrarConsultaProducto.Name = "btnCerrarConsultaProducto";
            btnCerrarConsultaProducto.Size = new Size(45, 25);
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
            btnMinimizarConsultaProducto.Location = new Point(1796, 0);
            btnMinimizarConsultaProducto.Margin = new Padding(2);
            btnMinimizarConsultaProducto.Name = "btnMinimizarConsultaProducto";
            btnMinimizarConsultaProducto.Size = new Size(45, 25);
            btnMinimizarConsultaProducto.TabIndex = 14;
            btnMinimizarConsultaProducto.UseVisualStyleBackColor = false;
            btnMinimizarConsultaProducto.Click += btnMinimizarConsultaProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 161, 43);
            label1.Location = new Point(23, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 44);
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
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 507);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 74);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(233, 29);
            label3.TabIndex = 6;
            label3.Text = "Buscar Producto";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(49, 141);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(169, 2);
            panel6.TabIndex = 24;
            // 
            // buscar
            // 
            buscar.BackColor = Color.FromArgb(255, 161, 43);
            buscar.BorderStyle = BorderStyle.None;
            buscar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            buscar.ForeColor = Color.White;
            buscar.Location = new Point(55, 116);
            buscar.Margin = new Padding(4);
            buscar.Name = "buscar";
            buscar.Size = new Size(162, 22);
            buscar.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, descripcion, comboCategoria, comboUnidad, stockActual, stockMinimo, costo, venta, estado });
            dataGridView1.Location = new Point(249, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1412, 351);
            dataGridView1.TabIndex = 26;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.Width = 150;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.MinimumWidth = 8;
            descripcion.Name = "descripcion";
            descripcion.Width = 150;
            // 
            // comboCategoria
            // 
            comboCategoria.HeaderText = "Categoria";
            comboCategoria.MinimumWidth = 8;
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Width = 150;
            // 
            // comboUnidad
            // 
            comboUnidad.HeaderText = "Unidad";
            comboUnidad.MinimumWidth = 8;
            comboUnidad.Name = "comboUnidad";
            comboUnidad.Width = 150;
            // 
            // stockActual
            // 
            stockActual.HeaderText = "Stock Actual";
            stockActual.MinimumWidth = 8;
            stockActual.Name = "stockActual";
            stockActual.Width = 150;
            // 
            // stockMinimo
            // 
            stockMinimo.HeaderText = "Stock Minimo";
            stockMinimo.MinimumWidth = 8;
            stockMinimo.Name = "stockMinimo";
            stockMinimo.Width = 150;
            // 
            // costo
            // 
            costo.HeaderText = "Costo Compra";
            costo.MinimumWidth = 8;
            costo.Name = "costo";
            costo.Width = 150;
            // 
            // venta
            // 
            venta.HeaderText = "Costo venta";
            venta.MinimumWidth = 8;
            venta.Name = "venta";
            venta.Width = 150;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 8;
            estado.Name = "estado";
            estado.Width = 150;
            // 
            // ConsultaProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 161, 43);
            ClientSize = new Size(1924, 579);
            Controls.Add(panel2);
            Controls.Add(panelConsultaProducto);
            Name = "ConsultaProductos";
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
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn comboCategoria;
        private DataGridViewTextBoxColumn comboUnidad;
        private DataGridViewTextBoxColumn stockActual;
        private DataGridViewTextBoxColumn stockMinimo;
        private DataGridViewTextBoxColumn costo;
        private DataGridViewTextBoxColumn venta;
        private DataGridViewTextBoxColumn estado;
        private Panel panel6;
        private TextBox buscar;
    }
}