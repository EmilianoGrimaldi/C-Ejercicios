/*
 El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
 */
using Entidades;

namespace Ejercicio_A01___Calcular_un_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado;   
            Console.WriteLine("Ingrese un numero");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                resultado = Factorial.Calcular(numero);
                Console.WriteLine(resultado);
            }         
        }
    }
}
