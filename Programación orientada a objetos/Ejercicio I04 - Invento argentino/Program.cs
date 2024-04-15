using Geometria.Ejercicio_I04;
using System.Drawing;

namespace Ejercicio_I04___Invento_argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);

            Console.WriteLine("Bolígrafo Azul:");
            Console.WriteLine("Color: " + boligrafoAzul.GetColor());
            Console.WriteLine("Tinta: " + boligrafoAzul.GetTinta());
            Console.WriteLine("Pintando...");
            string dibujoAzul;
            boligrafoAzul.Pintar(100, out dibujoAzul);
            Console.WriteLine(dibujoAzul);
            Console.ResetColor();
            Console.WriteLine("Tinta restante: " + boligrafoAzul.GetTinta());
            Console.WriteLine("Recargando...");
            boligrafoAzul.Recargar();
            Console.WriteLine("Tinta recargada: " + boligrafoAzul.GetTinta());

            Console.WriteLine();

            Console.WriteLine("Bolígrafo Rojo:");
            Console.WriteLine("Color: " + boligrafoRojo.GetColor());
            Console.WriteLine("Tinta: " + boligrafoRojo.GetTinta());
            Console.WriteLine("Pintando...");
            string dibujoRojo;
            boligrafoRojo.Pintar(60, out dibujoRojo);
            
            Console.WriteLine(dibujoRojo);
            Console.ResetColor();
            Console.WriteLine("Tinta restante: " + boligrafoRojo.GetTinta());
            Console.WriteLine("Recargando...");
            boligrafoRojo.Recargar();
            Console.WriteLine("Tinta recargada: " + boligrafoRojo.GetTinta());

            Console.WriteLine();

            Console.WriteLine("Bolígrafo Azul:");
            Console.WriteLine("Color: " + boligrafoAzul.GetColor());
            Console.WriteLine("Tinta: " + boligrafoAzul.GetTinta());
            Console.WriteLine("Pintando...");
            boligrafoAzul.Pintar(50, out dibujoAzul);
            Console.WriteLine(dibujoAzul);
            Console.ResetColor(); // Restaurar el color original de la consola
            Console.WriteLine("Tinta restante: " + boligrafoAzul.GetTinta());
            Console.WriteLine("Recargando...");
            boligrafoAzul.Recargar();
            Console.WriteLine("Tinta recargada: " + boligrafoAzul.GetTinta());

            Console.WriteLine();

            Console.WriteLine("Bolígrafo Rojo:");
            Console.WriteLine("Color: " + boligrafoRojo.GetColor());
            Console.WriteLine("Tinta: " + boligrafoRojo.GetTinta());
            Console.WriteLine("Pintando...");
            boligrafoRojo.Pintar(60, out dibujoRojo);

            Console.WriteLine(dibujoRojo);
            Console.ResetColor(); // Restaurar el color original de la consola
            Console.WriteLine("Tinta restante: " + boligrafoRojo.GetTinta());
            Console.WriteLine("Recargando...");
            boligrafoRojo.Recargar();
            Console.WriteLine("Tinta recargada: " + boligrafoRojo.GetTinta());
        }
    }
}
