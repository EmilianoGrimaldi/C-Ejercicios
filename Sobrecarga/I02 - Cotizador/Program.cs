/*
 Crear un proyecto de tipo biblioteca de clases. Construir tres clases dentro de un namespace llamado Billetes: Pesos, Euro y Dolar.

Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,17 Dólares y 1 Dólar equivale a 102,65 Pesos.

TIP
Para operar dos tipos de monedas distintos, primero se deberá convertir todo a una misma moneda y luego realizar la operación. Por ejemplo, si quiero sumar Dolar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.

El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.

Los constructores estáticos le darán a las clases una cotización por defecto respecto del dólar.

Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.

Los operadores de comparación == compararán cantidades.

Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso.

Crear un proyecto de consola y colocar dentro del método Main el código necesario para probar todas las funcionalidades.
 */

using System.Drawing;
using Billetes;

namespace I02___Cotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Euro e = new Euro(10, 0.809f);
            Dolar d = new Dolar(10);
            Peso p = new Peso(10, 20.1655f);

            Peso p2 = 10;
            Peso p3 = new Peso(10);

            Euro aux_e = e + d;
            Console.WriteLine(@"Euro + Dólar (€18,09xx): {0}", aux_e.GetCantidad());
            aux_e = e + p;
            Console.WriteLine("Euro + Pesos (€10,40xx): {0}", aux_e.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Dolar aux_d = d + e;
            Console.WriteLine("Dólar + Euro (U$S22,36xx): {0}", aux_d.GetCantidad());
            aux_d = d + p;
            Console.WriteLine("Dólar + Pesos (U$S10,49xx): {0}", aux_d.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Peso aux_p = p + e;
            Console.WriteLine("Pesos + Euro ($259,26xx): {0}", aux_p.GetCantidad());
            aux_p = p + d;
            Console.WriteLine("Pesos + Dólar ($211,65xx): {0}", aux_p.GetCantidad());
        }
    }
}
