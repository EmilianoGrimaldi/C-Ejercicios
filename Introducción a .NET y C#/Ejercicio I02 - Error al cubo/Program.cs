/*
 Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 */
namespace Ejercicio_I02___Error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool resultado;
            Console.WriteLine("Ingrese un numero");
            do 
            {
                resultado = int.TryParse(Console.ReadLine(), out numero);
                if (numero > 0 && resultado)
                {
                    break;
                }
                else 
                { 
                    Console.WriteLine("ERROR. ¡Reingresar número!"); 
                }
            } while(true);

            Console.WriteLine($"Numero al cuadrado: {Math.Pow(numero, 2)}");
            Console.WriteLine($"Numero al cubo: {Math.Pow(numero, 3)}");
        }
    }
}
