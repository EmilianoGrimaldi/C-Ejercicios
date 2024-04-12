/*
 Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

Escribir una aplicación que encuentre los 4 primeros números perfectos.
 */
using System.Diagnostics.Metrics;
using System.Drawing;

namespace Ejercicio_I04___Un_número_perfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numero = 1;

            while (contador < 4)
            {
                int sum = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == numero)
                {
                    Console.WriteLine(numero);
                    contador++;
                }

                numero++;
            }

        }
    }
}
