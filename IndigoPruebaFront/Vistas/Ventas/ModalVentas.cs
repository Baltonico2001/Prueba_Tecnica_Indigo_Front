using IndigoPruebaFront.Modelo;
using IndigoPruebaFront.ServiciosApi;
using System.Globalization;

using IndigoPruebaFront.ServiciosApi;
using IndigoPruebaFront.Modelo;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontPrueba.Vistas.Ventas
{
    public partial class ModalVentas : Form
    {
        private readonly ProductoServicio _service;

        public ModalVentas()
        {
            InitializeComponent();
            _service = new ProductoServicio();
        }

        private async void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Validación básica
            var nombre = textBoxNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombre.Focus();
                return;
            }

            if (!decimal.TryParse(textBoxPrecio.Text.Trim(), NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out var precio))
            {
                MessageBox.Show("Precio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPrecio.Focus();
                return;
            }

            if (!int.TryParse(textBoxStock.Text.Trim(), out var stock))
            {
                MessageBox.Show("Stock inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxStock.Focus();
                return;
            }

            var producto = new Producto
            {
                Nombre = nombre,
                Precio = precio,
                Stock = stock
            };

            try
            {
                btnAgregarProducto.Enabled = false;
                await _service.CrearAsync(producto);
                MessageBox.Show("Producto Creado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAgregarProducto.Enabled = true;
            }
        }
    }
}