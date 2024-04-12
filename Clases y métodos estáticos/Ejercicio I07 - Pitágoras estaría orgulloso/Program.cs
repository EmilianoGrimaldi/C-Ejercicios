/*
 
Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

Mostrar el resultado en la consola.

 */
using Entidades;

namespace Ejercicio_I07___Pitágoras_estaría_orgulloso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pitagoras.Calcular(1,1));
        }
    }
}
