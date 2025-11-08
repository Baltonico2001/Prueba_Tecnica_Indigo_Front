using FrontPrueba.Vistas.Ventas;
using IndigoPruebaFront.ServiciosApi;

using FrontPrueba.Vistas.Ventas;
using IndigoPruebaFront.ServiciosApi;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontPrueba.Vistas
{
    public partial class Vender : Form
    {
        private readonly ProductoServicio _service;

        public Vender()
        {
            InitializeComponent();
            _service = new ProductoServicio();

            // Asegurar que el Load del formulario esté enlazado
            this.Load += Vender_Load;

            // Configuraciones visuales y de binding para evitar problemas comunes
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Visible = true;
            if (dataGridView1.Height < 200) dataGridView1.Height = 200;
        }

        private async Task CargarProductosAsync()
        {
            var productos = await _service.ObtenerTodosAsync();

            // Forzar refresco del DataSource para evitar enlaces rotos
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;

        }



        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              // Manejo sencillo del click en las celdas para detectar el botón "EliminarBoton"
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var column = dataGridView1.Columns[e.ColumnIndex];
            if (!string.Equals(column.Name, "EliminarBoton", StringComparison.OrdinalIgnoreCase)) return;

            var cellValue = dataGridView1.Rows[e.RowIndex].Cells["IdProducto"]?.Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out var id))
            {
                MessageBox.Show("No se pudo obtener el Id del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                await _service.EliminarAsync(id);
                await CargarProductosAsync();
                MessageBox.Show("Producto eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private async void Vender_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            var inicioForm = new ModalVentas();
            inicioForm.Show();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await CargarProductosAsync();

        }
    }
}