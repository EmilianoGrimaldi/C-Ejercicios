using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reloj reloj = new Reloj();
            //reloj.SegundoCambiado += MostrarCambioTiempo;
            reloj.SegundoCambiado += (reloj, info) => 
            { 
                Console.WriteLine($"{info.Hora}:{info.Minuto}:{info.Segundo}");
            };
            reloj.Ejecutar();
        }
        public static void MostrarCambioTiempo(Reloj reloj, InfoTiempoEventArgs info)
        {
            Console.WriteLine($"{info.Hora}:{info.Minuto}:{info.Segundo}");
        }
    }
}
