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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            // Crear instancia del formulario Inicio
            Vender inicioForm = new Vender();

            // Mostrar el formulario Inicio
            inicioForm.Show();
            // Cerrar el formulario Inicio 
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos inicioForm = new Productos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proveedores inicioForm = new Proveedores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes inicioForm = new Clientes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reportes reportesForm = new Reportes();
        }
    }
}
