namespace FrontPrueba.Vistas.Ventas
{
    partial class ModalVentas
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
            label1 = new Label();
            btnAgregarProducto = new Button();
            textBoxNombre = new TextBox();
            label2 = new Label();
            textBoxPrecio = new TextBox();
            label3 = new Label();
            textBoxStock = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 38);
            label1.TabIndex = 7;
            label1.Text = "AGREGAR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(195, 325);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(75, 23);
            btnAgregarProducto.TabIndex = 11;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(146, 123);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(179, 23);
            textBoxNombre.TabIndex = 13;
            // 
            // label2
            // 
            label2.Location = new Point(146, 89);
            label2.Name = "label2";
            label2.Size = new Size(179, 21);
            label2.TabIndex = 12;
            label2.Text = "Nombre Producto";
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(146, 198);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(179, 23);
            textBoxPrecio.TabIndex = 15;
            // 
            // label3
            // 
            label3.Location = new Point(146, 164);
            label3.Name = "label3";
            label3.Size = new Size(179, 21);
            label3.TabIndex = 14;
            label3.Text = "Precio";
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(146, 280);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(179, 23);
            textBoxStock.TabIndex = 17;
            // 
            // label4
            // 
            label4.Location = new Point(146, 246);
            label4.Name = "label4";
            label4.Size = new Size(179, 21);
            label4.TabIndex = 16;
            label4.Text = "Stock";
            // 
            // ModalVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 390);
            Controls.Add(textBoxStock);
            Controls.Add(label4);
            Controls.Add(textBoxPrecio);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(btnAgregarProducto);
            Controls.Add(label1);
            Name = "ModalVentas";
            Text = "ModalVentas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregarProducto;
        private TextBox textBoxNombre;
        private Label label2;
        private TextBox textBoxPrecio;
        private Label label3;
        private TextBox textBoxStock;
        private Label label4;
    }
}