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
            List<int> numeros = new();
            Queue<int> positivosQueue = new();
            Queue<int> negativosQueue = new();
            Stack<int> positivosStack = new();
            Stack<int> negativosStack = new();

            for (int i = 0; i < 20; i++)
            {
                int numero = random.Next(-100, 101);
                if (numero != 0)
                {
                    numeros.Add(numero);
                }   
            }
            Console.WriteLine("Numeros random:");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > 0)
                {
                    positivosQueue.Enqueue(numeros[i]);
                    positivosStack.Push(numeros[i]);
                }
                else if (numeros[i] < 0)
                {
                    negativosQueue.Enqueue(numeros[i]);
                    negativosStack.Push(numeros[i]);
                }       
            }

            Console.WriteLine("POSITIVOS QUEUE");
            foreach (var item in positivosQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("POSITIVOS STACK");
            foreach (var item in positivosStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("NEGATIVOS QUEUE");
            foreach (var item in negativosQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("NEGATIVOS STACK");
            foreach (var item in negativosStack)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
