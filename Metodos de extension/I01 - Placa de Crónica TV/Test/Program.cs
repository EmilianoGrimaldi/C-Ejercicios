using Biblioteca;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Today;
            DateTime fecha = new(2024,7,1);
            //Console.WriteLine(hoy.ObtenerPlacaCronicaTV(Estancion.Estaciones.Invierno));
            Console.WriteLine(fecha.ObtenerPlacaCronicaTV(Estancion.Estaciones.Primavera));
        }
    }
}
