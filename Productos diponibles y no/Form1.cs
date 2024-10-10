using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SupermercadoApp
{
    public partial class Form1 : Form
    {
        private List<Producto> productosDisponibles = new List<Producto>();
        private List<Producto> productosRetirados = new List<Producto>();
        private int contadorProductos = 1;  // Contador para el nombre del producto

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = "Producto" + contadorProductos;
            Producto nuevoProducto = new Producto(nombreProducto);
            productosDisponibles.Add(nuevoProducto);
            contadorProductos++;
            MessageBox.Show($"{nuevoProducto.Nombre} agregado con éxito.");
            RefrescarListas();
        }

        private void btnRetirarProducto_Click(object sender, EventArgs e)
        {
            if (lstDisponibles.SelectedItem != null)
            {
                Producto productoSeleccionado = (Producto)lstDisponibles.SelectedItem;
                productosDisponibles.Remove(productoSeleccionado);
                productosRetirados.Add(productoSeleccionado);
                MessageBox.Show($"{productoSeleccionado.Nombre} ha sido retirado.");
                RefrescarListas();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para retirar.");
            }
        }

        private void btnMostrarDisponibles_Click(object sender, EventArgs e)
        {
            lstDisponibles.DataSource = null;
            lstDisponibles.DataSource = productosDisponibles;
        }

        private void btnMostrarRetirados_Click(object sender, EventArgs e)
        {
            lstRetirados.DataSource = null;
            lstRetirados.DataSource = productosRetirados;
        }

        private void RefrescarListas()
        {
            lstDisponibles.DataSource = null;
            lstDisponibles.DataSource = productosDisponibles;

            lstRetirados.DataSource = null;
            lstRetirados.DataSource = productosRetirados;
        }
    }
}
