namespace FrontPrueba.Vistas
{
    partial class Inicio
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
            btnVentas = new Button();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(32, 101);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(175, 119);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "VENDER";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // button2
            // 
            button2.Location = new Point(309, 101);
            button2.Name = "button2";
            button2.Size = new Size(175, 119);
            button2.TabIndex = 1;
            button2.Text = "PRODUCTOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(583, 101);
            button3.Name = "button3";
            button3.Size = new Size(175, 119);
            button3.TabIndex = 2;
            button3.Text = "PROVEEDORES";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(180, 302);
            button1.Name = "button1";
            button1.Size = new Size(175, 119);
            button1.TabIndex = 3;
            button1.Text = "CLIENTES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(447, 302);
            button4.Name = "button4";
            button4.Size = new Size(175, 119);
            button4.TabIndex = 4;
            button4.Text = "REPORTES";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(726, 38);
            label1.TabIndex = 5;
            label1.Text = "SISTEMA DE VENTAS ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnVentas);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVentas;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private Label label1;
    }
}