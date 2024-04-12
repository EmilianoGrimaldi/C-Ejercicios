/*
 Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
 */
using Entidades;

namespace Ejercicio_I08___El_tiempo_pasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*DateTime hoy = DateTime.Now;
            int anioActual = hoy.Year;*/

            DateTime fecha = new();

            do
            {
                Console.WriteLine("Ingrese una fecha dd/mm/aaaa");
                if (DateTime.TryParse(Console.ReadLine(), out fecha))
                {
                    Console.WriteLine(CalculadoraDeTiempo.CalcularDias(fecha));
                    break;
                }
            } while(true);


            /*do
            {
                Console.WriteLine("Ingrese año de nacimiento");
                if (int.TryParse(Console.ReadLine(), out int anio))
                {
                    if (anio >= 1000 && anio <= anioActual)
                    {
                        do
                        {
                            Console.WriteLine("Ingrese mes de nacimiento");
                            if (int.TryParse(Console.ReadLine(), out int mes))
                            {
                                if (mes >= 1 && mes <= 12)
                                {
                                    do
                                    {
                                        Console.WriteLine("Ingrese dia de nacimiento");
                                        if (int.TryParse(Console.ReadLine(), out int dia))
                                        {
                                            if ((mes == 2 && dia >= 1 && dia <= 29) || (mes != 2 && dia >= 1 && dia <= 31))
                                            {
                                                Console.WriteLine($"El numero de dias vividos hasta la fecha actual es: {CalculadoraDeTiempo.CalcularDias(dia, mes, anio)}");
                                                break;
                                            }         
                                        }
                                    } while (true);
                                        
                                    break;
                                }
                            }
                        } while (true);
                        break;
                    }
                }
            } while (true);  */
        }
    }
}
