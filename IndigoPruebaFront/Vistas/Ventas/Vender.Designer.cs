namespace FrontPrueba.Vistas
{
    partial class Vender
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ImagenProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            PrecioProducto = new DataGridViewTextBoxColumn();
            StockProducto = new DataGridViewTextBoxColumn();
            VenderBoton = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ImagenProducto, NombreProducto, PrecioProducto, StockProducto, VenderBoton });
            dataGridView1.Location = new Point(12, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 51);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(-1, -2);
            label1.Name = "label1";
            label1.Size = new Size(801, 38);
            label1.TabIndex = 6;
            label1.Text = "VENTAS ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ImagenProducto
            // 
            ImagenProducto.HeaderText = "Imagen";
            ImagenProducto.Name = "ImagenProducto";
            ImagenProducto.Width = 80;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Width = 200;
            // 
            // PrecioProducto
            // 
            PrecioProducto.HeaderText = "Precio";
            PrecioProducto.Name = "PrecioProducto";
            PrecioProducto.Width = 200;
            // 
            // StockProducto
            // 
            StockProducto.HeaderText = "Stock";
            StockProducto.Name = "StockProducto";
            StockProducto.Width = 200;
            // 
            // VenderBoton
            // 
            VenderBoton.HeaderText = "Vender";
            VenderBoton.Name = "VenderBoton";
            VenderBoton.Width = 50;
            // 
            // Vender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Vender";
            Text = "Vender";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn ImagenProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn PrecioProducto;
        private DataGridViewTextBoxColumn StockProducto;
        private DataGridViewButtonColumn VenderBoton;
    }
}