/*
 Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

Mostrar el vector tal como fue ingresado.
Luego mostrar los positivos ordenados en forma decreciente.
Por último, mostrar los negativos ordenados en forma creciente.
 */
using System.Collections;
 
namespace I01___Números_locos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int[] numeros = new int[20];
            List<int> positivos = new();
            List<int> negativos = new(); 
            
            for (int i = 0; i < numeros.Length; i++)
            {
                int numero = random.Next(-100, 101);
                if (numero != 0)
                {
                    numeros[i] = numero;
                }   
            }
            Console.WriteLine("Numeros random:");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    positivos.Add(numeros[i]);
                }
                else if (numeros[i] < 0)
                {
                    negativos.Add(numeros[i]);
                }
            }
            positivos.Sort(OrdenarDecreciente);
            negativos.Sort(OrdenarCreciente);
            Console.WriteLine("Positivos ordenados decreciente");
            foreach (var numero in positivos)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("Negativos ordenados creciente");
            foreach (var numero in negativos)
            {
                Console.WriteLine(numero);
            }

        }
        public static int OrdenarDecreciente(int n1, int n2)
        {
            return n2 - n1;
        }
        public static int OrdenarCreciente(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
