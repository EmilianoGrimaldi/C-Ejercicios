using HerenciaDeportivaEntidades;
namespace C01___Herencia_deportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new(4312321,"Prueba");
            Persona persona2 = new(3215612,"Victor");
            DirectorTecnico director1 = new("Falcioni", new(1956,07,20));
            DirectorTecnico director2 = new("Bianchi", new(1949, 04, 26));
            DirectorTecnico director3 = new("Miguel Russo", new(1956, 04, 9));
            Jugador jugador1 = new(12345678,"Martinez");
            Jugador jugador2 = new(12314567,"Roberto");
            Jugador jugador3 = new(41256123,"Lautaro");
            Jugador jugador4 = new(98764231,"Sarasa", 28, 25);
            Jugador jugador5 = new(81237813,"Bob", 200, 85);
            Jugador jugador6 = new(78123134,"Julian", 150, 100);

            Console.WriteLine(persona1.MostrarDatos());
            Console.WriteLine(persona2.MostrarDatos());
            Console.WriteLine(director1.MostrarDatos());
            Console.WriteLine(director2.MostrarDatos());
            Console.WriteLine(director3.MostrarDatos());
            Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(jugador2.MostrarDatos());
            Console.WriteLine(jugador3.MostrarDatos());
            Console.WriteLine(jugador4.MostrarDatos());
            Console.WriteLine(jugador5.MostrarDatos());
            Console.WriteLine(jugador6.MostrarDatos());

            Console.WriteLine(director1 == director2);
            Console.WriteLine(director1 != director2);
            Console.WriteLine(jugador1 == jugador2);
            Console.WriteLine(jugador1 != jugador2);


        }
    }
}
