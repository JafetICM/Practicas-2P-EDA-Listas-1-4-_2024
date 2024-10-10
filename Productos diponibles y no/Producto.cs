using System;

namespace SupermercadoApp
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        private static Random random = new Random();

        public Producto(string nombre)
        {
            Nombre = nombre;
            Cantidad = random.Next(1, 100);  // Cantidad aleatoria entre 1 y 100
            Precio = (decimal)(random.NextDouble() * (100 - 1) + 1); // Precio aleatorio entre 1 y 100
        }

        public override string ToString()
        {
            return $"{Nombre} - Cantidad: {Cantidad} - Precio: ${Precio:F2}";
        }
    }
}
