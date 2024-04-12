/*
 Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 */

using Entidades;

namespace Ejercicio_I06___Calculadora_de_áreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculadoraDeArea.CalcularAreaCuadrado(1.20));
            Console.WriteLine(CalculadoraDeArea.CalcularAreaTriangulo(10,42));
            Console.WriteLine(CalculadoraDeArea.CalcularAreaCirculo(3));
        }
    }
}
