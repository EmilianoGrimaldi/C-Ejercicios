using System.Drawing;
using Geometria;

namespace I05___Prueba_de_geometría
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar puntos
            Punto punto1 = new Punto(2, -1);
            Punto punto3 = new Punto(7, 3);

            // Instanciar rectángulo
            Rectangulo rectangulo = new Rectangulo(punto1, punto3);

            // Mostrar datos del rectángulo
            MostrarDatosRectangulo(rectangulo);

            Console.ReadKey();
        }

        // Método estático para mostrar los datos de un rectángulo
        static void MostrarDatosRectangulo(Rectangulo rectangulo)
        {
            Console.WriteLine("Vértice 1: ({0}, {1})", rectangulo.GetVertice1().GetX(), rectangulo.GetVertice1().GetY());
            Console.WriteLine("Vértice 2: ({0}, {1})", rectangulo.GetVertice2().GetX(), rectangulo.GetVertice2().GetY());
            Console.WriteLine("Vértice 3: ({0}, {1})", rectangulo.GetVertice3().GetX(), rectangulo.GetVertice3().GetY());
            Console.WriteLine("Vértice 4: ({0}, {1})", rectangulo.GetVertice4().GetX(), rectangulo.GetVertice4().GetY());
            Console.WriteLine("Área: {0}", rectangulo.Area());
            Console.WriteLine("Perímetro: {0}", rectangulo.Perimetro());
        }
    }
}
