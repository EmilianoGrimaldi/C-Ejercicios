/*
 Consigna
Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */
using Entidades;

namespace Ejercicio_I02___Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumador = 0;
            string continuar;

            do 
            {
                Console.WriteLine("Ingresar un numero");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    sumador += numero;
                }

                Console.WriteLine("¿Desea continuar? (S/N)");
                continuar = Console.ReadLine();
                
            } while(Validador.ValidarRespuesta(continuar));

            Console.WriteLine(sumador);
        }
    }
}
