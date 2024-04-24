using Entidades.Sumador;

namespace I01___Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador(3);
            Sumador sumador2 = new Sumador();    
            Sumador sumador3 = new Sumador(4);
            Console.WriteLine(sumador1.Sumar(1, 1));
            Console.WriteLine(sumador2.Sumar("1", "1"));
            Console.WriteLine($"cantidad sumas: {(int)sumador1}");
            Console.WriteLine($"cantidad sumas: {(int)sumador2}");
            Console.WriteLine(sumador1 + sumador2);
            Console.WriteLine(sumador1 | sumador2);
            Console.WriteLine(sumador1 | sumador3);
        }
    }
}
