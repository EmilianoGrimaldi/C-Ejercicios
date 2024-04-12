using Entidades;

namespace Ejercicio_I05___Aprendete_las_tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "n";
            do
            {
                do
                {
                    Console.WriteLine("Ingrese un número entero:");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        Console.WriteLine(Tabla.GenerarTabla(numero));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No es entero");
                    }  
                } while (true);

                Console.WriteLine("Desea continuar s/n"); 
                do
                {
                    continuar = Console.ReadLine();
                    if (continuar == "s" | continuar == "n")
                    {
                        break;
                    }
                    Console.WriteLine("Ingrese s/n");
                } while (true);

            } while (continuar != "n");
            
        }
    }
}
