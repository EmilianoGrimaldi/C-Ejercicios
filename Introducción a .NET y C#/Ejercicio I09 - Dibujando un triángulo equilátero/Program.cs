/*
 Consigna
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
namespace Ejercicio_I09___Dibujando_un_triángulo_equilátero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string dibujo = "*";
            string espacio = " ";
            Console.WriteLine("Ingresar la altura del triangulo");
            altura = int.Parse(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < 3 + altura - i; j++)
                {
                    Console.Write(espacio);
                }
                Console.WriteLine(dibujo);
                dibujo += "**";
            }

        }
    }
}
