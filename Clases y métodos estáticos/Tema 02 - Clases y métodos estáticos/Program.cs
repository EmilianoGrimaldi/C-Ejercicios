using Entidades;

/*
 Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
 */
namespace Tema_02___Clases_y_métodos_estáticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int numero;
            int maximo = int.MaxValue;
            int minimo = int.MinValue;
            int sumador = 0;
            float promedio;
            for (i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingresar un numero entre -100 y 100");
                    if (int.TryParse(Console.ReadLine(), out numero))
                    {

                        if (Validador.Validar(numero, -100, 100))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Fuera de rango");
                        }
                    }
                } while (true);

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

            promedio = (float)sumador / i;
            Console.WriteLine("El minimo: " + minimo);
            Console.WriteLine("El maximo: " + maximo);
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}
