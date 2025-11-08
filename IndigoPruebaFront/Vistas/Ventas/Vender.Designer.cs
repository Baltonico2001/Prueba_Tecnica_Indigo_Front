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
            btnProducto = new Button();
            button1 = new Button();
            IdProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            PrecioProducto = new DataGridViewTextBoxColumn();
            StockProducto = new DataGridViewTextBoxColumn();
            EliminarBoton = new DataGridViewButtonColumn();
            ModificarBoton = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdProducto, NombreProducto, PrecioProducto, StockProducto, EliminarBoton, ModificarBoton });
            dataGridView1.Location = new Point(12, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(725, 52);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // btnProducto
            // 
            btnProducto.Location = new Point(12, 69);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(75, 23);
            btnProducto.TabIndex = 8;
            btnProducto.Text = "AGREGAR";
            btnProducto.UseVisualStyleBackColor = true;
            //btnProducto.Click += btnInicioSesion_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 40);
            button1.Name = "button1";
            button1.Size = new Size(34, 23);
            button1.TabIndex = 9;
            button1.Text = "°°°";
            button1.UseVisualStyleBackColor = true;
            //button1.Click += button1_Click;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "Id";
            IdProducto.HeaderText = "ID";
            IdProducto.Name = "IdProducto";
            IdProducto.Width = 40;
            // 
            // NombreProducto
            // 
            NombreProducto.DataPropertyName = "Nombre";
            NombreProducto.HeaderText = "Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Width = 200;
            // 
            // PrecioProducto
            // 
            PrecioProducto.DataPropertyName = "Precio";
            PrecioProducto.HeaderText = "Precio";
            PrecioProducto.Name = "PrecioProducto";
            PrecioProducto.Width = 190;
            // 
            // StockProducto
            // 
            StockProducto.DataPropertyName = "Stock";
            StockProducto.HeaderText = "Stock";
            StockProducto.Name = "StockProducto";
            StockProducto.Width = 190;
            // 
            // EliminarBoton
            // 
            EliminarBoton.HeaderText = "-";
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Width = 30;
            // 
            // ModificarBoton
            // 
            ModificarBoton.HeaderText = "+";
            ModificarBoton.Name = "ModificarBoton";
            ModificarBoton.Resizable = DataGridViewTriState.True;
            ModificarBoton.SortMode = DataGridViewColumnSortMode.Automatic;
            ModificarBoton.Width = 30;
            // 
            // Vender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnProducto);
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
        private Button btnProducto;
        private Button button1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn PrecioProducto;
        private DataGridViewTextBoxColumn StockProducto;
        private DataGridViewButtonColumn EliminarBoton;
        private DataGridViewButtonColumn ModificarBoton;
    }
}