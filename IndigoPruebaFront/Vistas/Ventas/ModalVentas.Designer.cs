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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 38);
            label1.TabIndex = 7;
            label1.Text = "ESPECIFIQUE LA VENTA  ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(274, 61);
            label2.Name = "label2";
            label2.Size = new Size(283, 174);
            label2.TabIndex = 8;
            label2.Text = "Imagen   ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.AppWorkspace;
            label3.Location = new Point(274, 260);
            label3.Name = "label3";
            label3.Size = new Size(283, 23);
            label3.TabIndex = 9;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.AppWorkspace;
            label4.Location = new Point(274, 302);
            label4.Name = "label4";
            label4.Size = new Size(283, 23);
            label4.TabIndex = 10;
            label4.Text = "Total Pago";
            // 
            // button1
            // 
            button1.Location = new Point(372, 345);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Vender";
            button1.UseVisualStyleBackColor = true;
            // 
            // ModalVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModalVentas";
            Text = "ModalVentas";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}