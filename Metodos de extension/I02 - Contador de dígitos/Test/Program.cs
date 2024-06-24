using Biblioteca;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            long numero;
            do
            {
                Console.Write($"Ingrese un numero: ");

                if (long.TryParse(Console.ReadLine(),out numero))
                {
                    Console.WriteLine($"Numero de   \t   {numero.ContadorDigitos()} digitos");
                }
                else
                {
                    break;
                }

            } while (true);
            
        }
    }
}
