/*
 Consigna
Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) {}

IMPORTANTE
NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
 */
using Entidades;

namespace Ejercicio_I03___Conversor_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Entidades.Conversor.ConvertirDecimalABinario(2));
            Console.WriteLine(Entidades.Conversor.ConvertirBinarioADecimal(11));
        }
    }
}
