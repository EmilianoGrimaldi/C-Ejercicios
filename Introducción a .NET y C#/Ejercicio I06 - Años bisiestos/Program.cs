/*
 Escribir un programa que determine si un año es bisiesto.

Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.

IMPORTANTE
Utilizar sentencias de iteración, selectivas y el operador módulo (%).
 */
namespace Ejercicio_I06___Años_bisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingresar un año de inicio");
                if (int.TryParse(Console.ReadLine(), out int anioInicio))
                {
                    do
                    {
                        Console.WriteLine("Ingresar un año de fin");
                        if (int.TryParse(Console.ReadLine(), out int anioFin))
                        {
                            for (int i = anioInicio; i <= anioFin; i++)
                            {
                                bool esBisiesto =  false;
                                if (i % 4 == 0)
                                {
                                    esBisiesto = true;
                                }
                                
                                if (i % 100 == 0)
                                {
                                    esBisiesto = false;
                                }

                                if (i % 100 == 0 & i % 400 == 0)
                                {
                                    esBisiesto = true;
                                }

                                if (esBisiesto)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                            break;
                        }
                    } while (true);
                    break;
                }
            } while (true);
        }
    }
}
