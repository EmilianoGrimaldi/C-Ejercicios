/*
 Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
 */
namespace Ejercicio_I05___Tirame_un_centro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            do
            {
                bool esNumero = int.TryParse(Console.ReadLine(), out int numero);
                if (esNumero)
                {
                    for (int i = 1; i <= numero; i++)
                    {
                        int sumaAnterior = 0;
                        int sumaPosterior = 0;
                        for (int j = 1; j < i; j++)
                        {
                            sumaAnterior += j;
                        }

                        for (int j = i + 1; ; j++)
                        {
                            sumaPosterior += j;

                            if (sumaPosterior == sumaAnterior)
                            {
                                Console.WriteLine(i);
                                break;
                            }
                            else if (sumaPosterior > sumaAnterior)
                            {
                                break;
                            }
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Error! Ingresar un numero");
                }
            }while(true);
        }
    }
}
