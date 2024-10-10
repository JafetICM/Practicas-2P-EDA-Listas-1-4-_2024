using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SumaNumerosGrandesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string numero1 = txtNumero1.Text.Trim();
            string numero2 = txtNumero2.Text.Trim();

            if (string.IsNullOrWhiteSpace(numero1) || string.IsNullOrWhiteSpace(numero2))
            {
                MessageBox.Show("Por favor, ingrese ambos números para realizar la suma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que ambos números sean enteros positivos
            if (!EsNumeroValido(numero1) || !EsNumeroValido(numero2))
            {
                MessageBox.Show("Ingrese números válidos (sólo dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear pilas para almacenar los dígitos
            Stack<int> pila1 = ConvertirCadenaAPila(numero1);
            Stack<int> pila2 = ConvertirCadenaAPila(numero2);

            // Realizar la suma de las pilas
            string resultado = SumarPilas(pila1, pila2);

            // Mostrar el resultado
            lblResultado.Text = $"Resultado: {resultado}";
        }

        private Stack<int> ConvertirCadenaAPila(string numero)
        {
            Stack<int> pila = new Stack<int>();

            foreach (char digito in numero)
            {
                pila.Push(int.Parse(digito.ToString()));
            }

            return pila;
        }

        private string SumarPilas(Stack<int> pila1, Stack<int> pila2)
        {
            Stack<int> pilaResultado = new Stack<int>();
            int acarreo = 0;

            while (pila1.Count > 0 || pila2.Count > 0 || acarreo > 0)
            {
                int suma = acarreo;

                if (pila1.Count > 0)
                {
                    suma += pila1.Pop();
                }

                if (pila2.Count > 0)
                {
                    suma += pila2.Pop();
                }

                pilaResultado.Push(suma % 10);  // Guardar el dígito de las unidades
                acarreo = suma / 10;  // Calcular el acarreo
            }

            // Convertir la pila a una cadena para mostrar el resultado
            return string.Join("", pilaResultado);
        }

        private bool EsNumeroValido(string numero)
        {
            foreach (char c in numero)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
