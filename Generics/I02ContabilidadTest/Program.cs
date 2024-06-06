using I02ContabilidadEntidades;
namespace I02ContabilidadTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recibo recibo1 = new Recibo();
            Factura factura1 = new Factura(123);
            Factura factura2 = new Factura(456);

            Contabilidad<Factura, Recibo> contabilidad = new();

            contabilidad += recibo1;
            contabilidad += factura1;
            contabilidad += factura2;

            foreach (Documento item in contabilidad.Ingresos)
            {
                Console.WriteLine(item.Numero);
            }
            foreach (Documento item in contabilidad.Egresos)
            {
                Console.WriteLine(item.Numero);
            }
        }
    }
}
