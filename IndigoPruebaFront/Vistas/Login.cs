using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontPrueba.Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear instancia del formulario Inicio
            Inicio inicioForm = new Inicio();

            // Mostrar el formulario Inicio
            inicioForm.Show();

            // Cerrar el formulario Login (el actual)
            this.Hide(); // lo ocultas para no cerrarlo del todo
                         // this.Close(); // si prefieres cerrarlo completamente
        }
    }
}
