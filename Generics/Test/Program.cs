using EntidadesI01Torneo;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new("Torneo de Futbol");
            Torneo<EquipoBasquet> torneoBasquet = new("Torneo de Basquet");
            EquipoFutbol futbol1 = new("Independiente",new(1904,8,1));
            EquipoFutbol futbol2 = new("Boca",new(1905,4,3));
            EquipoFutbol futbol3 = new("River", new(1901,5,25));
            EquipoBasquet basquet1 = new("Los Dallas Mavericks",new(1980,1,1));
            EquipoBasquet basquet2 = new("Timberwolves", new(1989, 1, 1));
            EquipoBasquet basquet3 = new("Angels", new(1990, 1, 1));

            if (torneoFutbol + futbol1)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else 
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (torneoFutbol + futbol2)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (torneoFutbol + futbol3)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (torneoBasquet + basquet1)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (torneoBasquet + basquet2)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (torneoBasquet + basquet3)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else
            {
                Console.WriteLine("No se pudo agregar");
            }
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
        }
    }
}
