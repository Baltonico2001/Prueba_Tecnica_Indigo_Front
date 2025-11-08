namespace FrontPrueba.Vistas
{
    partial class Login
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
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnInicioSesion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(128, 24);
            label1.Name = "label1";
            label1.Size = new Size(179, 44);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESION ";
            // 
            // label2
            // 
            label2.Location = new Point(128, 83);
            label2.Name = "label2";
            label2.Size = new Size(179, 21);
            label2.TabIndex = 1;
            label2.Text = "USUARIO";
            // 
            // label3
            // 
            label3.Location = new Point(128, 174);
            label3.Name = "label3";
            label3.Size = new Size(179, 18);
            label3.TabIndex = 2;
            label3.Text = "CLAVE";
            // 
            // label5
            // 
            label5.Location = new Point(128, 318);
            label5.Name = "label5";
            label5.Size = new Size(179, 18);
            label5.TabIndex = 4;
            label5.Text = "Errores";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 6;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.Location = new Point(177, 275);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(75, 23);
            btnInicioSesion.TabIndex = 7;
            btnInicioSesion.Text = "INICIAR";
            btnInicioSesion.UseVisualStyleBackColor = true;
            btnInicioSesion.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 446);
            Controls.Add(btnInicioSesion);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnInicioSesion;
    }
}