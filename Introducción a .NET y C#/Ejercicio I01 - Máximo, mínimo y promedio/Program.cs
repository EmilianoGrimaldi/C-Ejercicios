/*
 Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
*/
namespace Ejercicio_I01___Máximo__mínimo_y_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int numero;
            float promedio;
            int minimo = 0;
            int maximo = 0;
            int sumador = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresar un numero");
                numero = int.Parse(Console.ReadLine());

                if (i == 0) 
                {
                    minimo = numero;
                    maximo = numero;
                }
                else
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }

                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                     
                }
                sumador += numero;
            }
            promedio = sumador / i;
            Console.WriteLine("El minimo: " + minimo);
            Console.WriteLine("El maximo: " + maximo);
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}
