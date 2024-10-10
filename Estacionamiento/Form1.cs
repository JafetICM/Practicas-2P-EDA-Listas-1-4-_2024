using System;
using System.Windows.Forms;

namespace EstacionamientoApp
{
    public partial class Form1 : Form
    {
        private ColaCircularDoble estacionamiento;

        public Form1()
        {
            InitializeComponent();
            estacionamiento = new ColaCircularDoble();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlacas.Text) || string.IsNullOrWhiteSpace(txtPropietario.Text))
            {
                MessageBox.Show("Por favor, ingrese las placas y el nombre del propietario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Auto nuevoAuto = new Auto(txtPlacas.Text, txtPropietario.Text);
            estacionamiento.Insertar(nuevoAuto);
            MessageBox.Show($"Auto con placas {nuevoAuto.Placas} ingresó al estacionamiento.");
            ActualizarCola();
            LimpiarEntradas();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (estacionamiento.ColaVacia())
            {
                MessageBox.Show("No hay autos en el estacionamiento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Nodo autoSalida = estacionamiento.Eliminar();
            if (autoSalida != null)
            {
                Auto auto = autoSalida.Auto;
                DateTime horaSalida = DateTime.Now;
                TimeSpan tiempoEstacionado = horaSalida - auto.HoraEntrada;
                double costoTotal = tiempoEstacionado.TotalSeconds * 2;  // $2.00 pesos por segundo

                MessageBox.Show($"Auto con placas {auto.Placas} salió del estacionamiento.\n" +
                                $"Propietario: {auto.Propietario}\n" +
                                $"Hora de Entrada: {auto.HoraEntrada}\n" +
                                $"Hora de Salida: {horaSalida}\n" +
                                $"Tiempo Estacionado: {tiempoEstacionado.TotalSeconds:F2} segundos\n" +
                                $"Costo Total: ${costoTotal:F2}");
                ActualizarCola();
            }
        }

        private void ActualizarCola()
        {
            lstCola.Items.Clear();
            Nodo nodoActual = estacionamiento.MostrarFrente();
            if (nodoActual != null)
            {
                do
                {
                    lstCola.Items.Add(nodoActual.Auto.ToString());
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual != estacionamiento.MostrarFrente());
            }
        }

        private void LimpiarEntradas()
        {
            txtPlacas.Clear();
            txtPropietario.Clear();
        }
    }
}
