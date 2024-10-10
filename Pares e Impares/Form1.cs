using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParesImparesApp
{
    public partial class Form1 : Form
    {
        private List<int> numerosAleatorios = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Limpia las listas anteriores
            lstPares.Items.Clear();
            lstImpares.Items.Clear();
            numerosAleatorios.Clear();

            // Generar números aleatorios
            Random random = new Random();
            int cantidad;

            if (int.TryParse(txtCantidad.Text, out cantidad) && cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    numerosAleatorios.Add(random.Next(1, 101)); // Genera números entre 1 y 100
                }

                // Mostrar números en las listas correspondientes
                foreach (var numero in numerosAleatorios)
                {
                    if (numero % 2 == 0)
                    {
                        lstPares.Items.Add(numero);
                    }
                    else
                    {
                        lstImpares.Items.Add(numero);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida de números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
