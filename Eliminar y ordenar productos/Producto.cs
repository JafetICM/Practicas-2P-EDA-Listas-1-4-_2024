namespace EliminarOrdenarProductosApp
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Clave { get; set; }

        public Producto(string nombre, decimal precio, string clave)
        {
            Nombre = nombre;
            Precio = precio;
            Clave = clave;
        }

        public override string ToString()
        {
            return $"Clave: {Clave} - {Nombre}, Precio: {Precio:C}";
        }
    }
}
