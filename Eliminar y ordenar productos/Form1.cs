using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EliminarOrdenarProductosApp
{
    public partial class Form1 : Form
    {
        private List<Producto> listaProductos = new List<Producto>();
        private int contadorProductos = 1;  // Contador para generar claves únicas

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreProducto.Text) && decimal.TryParse(txtPrecioProducto.Text, out decimal precio))
            {
                string clave = "P" + contadorProductos;  // Generar clave única para el producto
                Producto nuevoProducto = new Producto(txtNombreProducto.Text, precio, clave);
                listaProductos.Add(nuevoProducto);
                lstProductos.Items.Add(nuevoProducto);
                contadorProductos++;
                txtNombreProducto.Clear();
                txtPrecioProducto.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre y un precio válido.");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string claveProducto = txtClaveProducto.Text;

            var productoEliminar = listaProductos.FirstOrDefault(p => p.Clave == claveProducto);

            if (productoEliminar != null)
            {
                listaProductos.Remove(productoEliminar);
                lstProductos.Items.Remove(productoEliminar);
                MessageBox.Show($"Producto con clave {claveProducto} eliminado.");
                txtClaveProducto.Clear();
            }
            else
            {
                MessageBox.Show($"No se encontró un producto con la clave {claveProducto}.");
            }
        }

        private void btnMostrarOrdenados_Click(object sender, EventArgs e)
        {
            lstProductos.Items.Clear();
            var productosOrdenados = listaProductos.OrderBy(p => p.Nombre).ToList();

            foreach (var producto in productosOrdenados)
            {
                lstProductos.Items.Add(producto);
            }
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            decimal costoTotal = listaProductos.Sum(p => p.Precio);
            lblTotalCosto.Text = $"Costo total: {costoTotal:C}";
        }
    }
}
