using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VentanillaBancoApp
{
    public partial class Form1 : Form
    {
        private Queue<Cliente> colaClientes;
        private int numeroTurno;

        public Form1()
        {
            InitializeComponent();
            colaClientes = new Queue<Cliente>();
            numeroTurno = 1;
            cmbMovimiento.Items.AddRange(new string[] { "Depósito", "Retiro", "Consulta", "Pago de servicios" });
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) || cmbMovimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese el nombre del cliente y seleccione un movimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear nuevo cliente y agregar a la cola
            Cliente nuevoCliente = new Cliente(numeroTurno, txtNombreCliente.Text, cmbMovimiento.SelectedItem.ToString());
            colaClientes.Enqueue(nuevoCliente);
            numeroTurno++;

            // Mostrar mensaje de confirmación
            MessageBox.Show($"Se agregó el cliente con Turno: {nuevoCliente.NumeroTurno}, Nombre: {nuevoCliente.Nombre} a la cola.");

            // Actualizar la vista
            ActualizarVista();
            txtNombreCliente.Clear();
            cmbMovimiento.SelectedIndex = -1;
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (colaClientes.Count == 0)
            {
                MessageBox.Show("No hay clientes en la cola para atender.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Atender al primer cliente en la cola
            Cliente clienteAtendido = colaClientes.Dequeue();
            TimeSpan tiempoEspera = DateTime.Now - clienteAtendido.HoraLlegada;

            // Mostrar mensaje de atención
            MessageBox.Show($"Cliente atendido: {clienteAtendido.Nombre}\nTiempo de espera: {tiempoEspera.TotalSeconds} segundos.");

            // Actualizar la vista
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            // Limpiar el DataGridView y llenar con los datos de la cola actual
            dgvClientes.Rows.Clear();
            foreach (var cliente in colaClientes)
            {
                dgvClientes.Rows.Add(cliente.NumeroTurno, cliente.Nombre, cliente.Movimiento, cliente.HoraLlegada);
            }

            // Mostrar el valor de frente y final de la cola
            if (colaClientes.Count > 0)
            {
                lblFrente.Text = $"Frente: Turno {colaClientes.Peek().NumeroTurno} - {colaClientes.Peek().Nombre}";
                lblFinal.Text = $"Final: Turno {colaClientes.ToArray()[colaClientes.Count - 1].NumeroTurno} - {colaClientes.ToArray()[colaClientes.Count - 1].Nombre}";
            }
            else
            {
                lblFrente.Text = "Frente: ---";
                lblFinal.Text = "Final: ---";
            }
        }
    }
}
