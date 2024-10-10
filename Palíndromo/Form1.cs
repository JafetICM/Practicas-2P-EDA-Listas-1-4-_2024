using System;
using System.Windows.Forms;

namespace PalindromosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            if (!string.IsNullOrWhiteSpace(palabra))
            {
                if (EsPalindromo(palabra))
                {
                    lblResultado.Text = $"La palabra '{palabra}' es un palíndromo.";
                }
                else
                {
                    lblResultado.Text = $"La palabra '{palabra}' no es un palíndromo.";
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una palabra válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsPalindromo(string palabra)
        {
            string palabraMinusculas = palabra.ToLower();
            char[] caracteres = palabraMinusculas.ToCharArray();
            Array.Reverse(caracteres);
            string palabraInvertida = new string(caracteres);

            return palabraMinusculas == palabraInvertida;
        }
    }
}
