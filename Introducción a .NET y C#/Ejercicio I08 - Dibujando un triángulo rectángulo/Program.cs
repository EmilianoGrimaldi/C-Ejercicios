/*
 Escribir un programa que imprima por consola un triángulo como el siguiente:

*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.

IMPORTANTE
Utilizar sentencias de iteración y selectivas.
 */
namespace Ejercicio_I08___Dibujando_un_triángulo_rectángulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string dibujo = "*";
            Console.WriteLine("Ingresar la altura del triangulo");
            altura = int.Parse(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                Console.WriteLine(dibujo);
                dibujo += "**";
            }
        }
    }
}
