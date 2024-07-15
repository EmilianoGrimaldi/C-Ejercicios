using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CentroDeAtencion c = new CentroDeAtencion("Konecta", 3);
            Rac emp1 = new Rac("u000001", "Jose", new TimeSpan(15, 0, 0));
            Rac emp2 = new Rac("u000002", "Alberto", new TimeSpan(15, 0, 0));
            Rac emp3 = new Rac("u000003", "Leandro", new TimeSpan(10, 0, 0),
            Rac.EGrupo.RRSS);
            Rac emp4 = new Rac("u000003", "Martin", new TimeSpan(10, 0, 0),
            Rac.EGrupo.CALL_OUT);
            Supervisor sup1 = "u000004";
            Supervisor sup2 = new Supervisor("u000005", "Alejandro", new(11, 30,
            0));

            if (c + emp1)
            {
                Console.WriteLine($"{emp1.ToString()} agregado con exito");
            }
            else
            {
                Console.WriteLine("NO OK, No se agrego el empleado 1");
            }
            Console.ReadKey();
            Console.Clear();
            if (c + emp1)
            {
                Console.WriteLine($"{emp1.ToString()} agregado con exito");
            }
            else
            {
                Console.WriteLine("OK No se agrego el empleado 1");
            }

            Console.ReadKey();
            Console.Clear();
            if (c + emp2)
            {
                Console.WriteLine($"{emp2.ToString()} agregado con exito");
            }
            else
            {
                Console.WriteLine("NO OK No se agrego el empleado 2");
            }
            Console.ReadKey();
            Console.Clear();
            if (c + emp3)
            {
                Console.WriteLine($"{emp3.ToString()} agregado con exito");
            }
            else
            {
                Console.WriteLine("NO OK No se agrego el empleado 3");
            }

            Console.ReadKey();
            Console.Clear();
            if (c + emp3)
            {
                Console.WriteLine($"{emp3.ToString()} agregado con exito");
            }
            else
            {
                Console.WriteLine("OK No se agrego el empleado 3");
            }

            Console.ReadKey();
            Console.Clear();

            if (c + emp4)
            {
                Console.WriteLine($"{emp4.ToString()} agregado con exito");
            }
            else
            {
                Console.WriteLine("OK No se agrego el empleado 4");
            }
            Console.ReadKey();
            Console.Clear();

            if (c + sup1)
            {
                Console.WriteLine($"{sup1.ToString()} agregado con exito");
            }
            else
            {
                Console.WriteLine("NO OK No se agrego el Sup 1");
            }

            Console.ReadKey();
            Console.Clear();

            if (c + sup2)
            {
                Console.WriteLine($"{sup2.ToString()} agregado con exito");
            }
            else
            {
                Console.WriteLine("OK No se agrego el Sup 2");
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(c.ImprimirNomina());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(c - sup1);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(c.ImprimirNomina());

            Console.ReadKey();
        }
    }
}
