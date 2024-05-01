/*
 Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

Mostrar la colección tal como fue cargada.
Luego mostrar los positivos ordenados en forma decreciente.
Por último, mostrar los negativos ordenados en forma creciente.
 */
namespace I02___Números_locos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            List<int> lista = new();
            Queue<int> positivosQueue = new();
            Queue<int> negativosQueue = new();
            Stack<int> positivosStack = new();
            Stack<int> negativosStack = new();
          
            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(-100, 101));                   
            }

            Console.WriteLine("Numeros random lista:");
            foreach (var numero in lista)
            {
                Console.WriteLine(numero);
            }

            lista.Sort(OrdenarDecreciente);

            foreach (int numero in lista)
            {
                if (numero > 0)
                {                   
                    positivosQueue.Enqueue(numero);
                }             
                else
                {
                    if (numero < 0)
                    {
                        negativosStack.Push(numero);
                    }
                }
            }

            Console.WriteLine("Positivos ordenados decreciente");
            foreach (var numero in positivosQueue)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("Negativos ordenados creciente");
            foreach (var numero in negativosStack)
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
