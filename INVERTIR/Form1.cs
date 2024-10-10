using System;
using System.Windows.Forms;

namespace InvertirPalabrasApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            if (!string.IsNullOrWhiteSpace(palabra))
            {
                char[] caracteres = palabra.ToCharArray();
                Array.Reverse(caracteres);
                string palabraInvertida = new string(caracteres);
                lblResultado.Text = $"Palabra invertida: {palabraInvertida}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una palabra válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
