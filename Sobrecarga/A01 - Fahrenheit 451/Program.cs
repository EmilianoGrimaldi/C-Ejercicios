/*
 Consigna
Crear un proyecto de consola y un proyecto de biblioteca de clases. Agregar al último tres clases Fahrenheit, Celsius y Kelvin.

Realizar la implementación necesaria para poder convertir una temperatura en sus distintas unidades de medida (Fahrenheit, Celsius y Kelvin).

Utilizar sobrecargas de métodos, operadores y/o conversiones.

TIP
F = C * (9/5) + 32

C = (F-32) * 5/9

F = K * 9/5 – 459.67

K = (F + 459.67) * 5/9

“FAHRENHEIT 451: LA TEMPERATURA A LA QUE EL PAPEL SE INFLAMA Y ARDE”...
La novela de ciencia-ficción 'Fahrenheit 451' fue publicada en 1953 por el escritor estadounidense Ray Bradbury (1920-2012). Presenta una sociedad del futuro en la que los libros están prohibidos y existen «bomberos» que queman cualquier ejemplar que encuentren.
 */
using Entidades.Temperatura;

namespace A01___Fahrenheit_451
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = (Celsius)32;
            Fahrenheit fahrenheit = (Fahrenheit)32;
            Kelvin kelvin = (Kelvin)200;
            Console.WriteLine($"Los {celsius.GetTemperatura()} °C son {((Fahrenheit)celsius).GetTemperatura()} °F");
            Console.WriteLine($"Los {celsius.GetTemperatura()} °C son {((Kelvin)celsius).GetTemperatura()} °K");
            Console.WriteLine($"Los {fahrenheit.GetTemperatura()} °F son {((Celsius)fahrenheit).GetTemperatura()} °C");
            Console.WriteLine($"Los {fahrenheit.GetTemperatura()} °F son {((Kelvin)fahrenheit).GetTemperatura()} °K");
            Console.WriteLine($"Los {kelvin.GetTemperatura()} °K son {((Celsius)kelvin).GetTemperatura()} °C");
            Console.WriteLine($"Los {kelvin.GetTemperatura()} °K son {((Fahrenheit)kelvin).GetTemperatura()} °F");
        }
    }
}
