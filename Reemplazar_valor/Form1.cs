using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReemplazarValorEnPilaApp
{
    public partial class Form1 : Form
    {
        private Stack<int> pila;

        public Form1()
        {
            InitializeComponent();
            pila = new Stack<int>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                pila.Push(valor);
                MostrarPila();
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValorViejo.Text, out int valorViejo) && int.TryParse(txtValorNuevo.Text, out int valorNuevo))
            {
                pila = Reemplazar(pila, valorViejo, valorNuevo);
                MostrarPila();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para el reemplazo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Stack<int> Reemplazar(Stack<int> pilaOriginal, int viejo, int nuevo)
        {
            Stack<int> pilaTemporal = new Stack<int>();

            // Mover los elementos a una pila temporal y reemplazar los valores
            while (pilaOriginal.Count > 0)
            {
                int valor = pilaOriginal.Pop();
                if (valor == viejo)
                {
                    pilaTemporal.Push(nuevo);
                }
                else
                {
                    pilaTemporal.Push(valor);
                }
            }

            // Devolver los elementos a la pila original
            while (pilaTemporal.Count > 0)
            {
                pilaOriginal.Push(pilaTemporal.Pop());
            }

            return pilaOriginal;
        }

        private void MostrarPila()
        {
            lstPila.Items.Clear();

            foreach (int valor in pila)
            {
                lstPila.Items.Add(valor);
            }
        }
    }
}
