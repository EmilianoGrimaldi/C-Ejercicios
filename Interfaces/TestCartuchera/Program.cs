using I01___Cartuchera;
using System.Runtime.Intrinsics.Arm;
namespace TestCartuchera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parte 1
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = miLapiz.Escribir("Hola"); //implicito
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = ((IAcciones)miBoligrafo).Escribir("Hola"); //explicito
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.ReadKey();
            //Parte 2
            Lapiz miLapiz2 = new Lapiz(10);
            Boligrafo miBoligrafo2 = new Boligrafo(10, ConsoleColor.Green);
            CartucheraMultiuso cartucheraMultiuso = new CartucheraMultiuso();
            CartucheraSimple cartucheraSimple = new CartucheraSimple();
            if(cartucheraSimple.Agregar(miBoligrafo2))
            {
                Console.WriteLine("Se agrego el boligrafo");
            }
            if (cartucheraSimple.Agregar(miLapiz2))
            {
                Console.WriteLine("Se agrego el lapiz");
            }
            cartucheraMultiuso.Agregar(miBoligrafo2);
            cartucheraMultiuso.Agregar(miLapiz2);
            bool resMultiuso;
            bool resSimple;
            
            do
            {
                resMultiuso = cartucheraMultiuso.RecorrerElementos();
                resSimple = cartucheraSimple.RecorrerElementos();
                Console.WriteLine($"Multiuso ->{resMultiuso} --- Simple -> {resSimple}");
                if (!resMultiuso || !resSimple)
                {
                    break;
                }
            } while (true);
            Console.WriteLine(miLapiz2.ToString());
            Console.WriteLine(((IAcciones)miBoligrafo2).ToString());
            Console.WriteLine($"Multiuso ->{resMultiuso} --- Simple -> {resSimple}");
        }
    }
}
