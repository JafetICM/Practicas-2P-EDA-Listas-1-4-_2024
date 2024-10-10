namespace AprobadosReprobadosApp
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public double Calificacion { get; set; }

        public Alumno(string nombre, double calificacion)
        {
            Nombre = nombre;
            Calificacion = calificacion;
        }

        public override string ToString()
        {
            return $"{Nombre} - Calificación: {Calificacion}";
        }
    }
}
