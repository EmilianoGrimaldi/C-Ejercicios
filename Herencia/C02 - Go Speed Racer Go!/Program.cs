using EntidadesEnciendanSusMotores;
namespace C02___Go_Speed_Racer_Go_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(1, "escu1", 100);
            AutoF1 a2 = new AutoF1(4, "escu2", 200);
            AutoF1 a3 = new AutoF1(5, "escu3", 300);
            AutoF1 a4 = new AutoF1(1, "escu1", 500);
            AutoF1 a5 = new AutoF1(2, "escu4", 400);
            MotoCross m1 = new MotoCross(1, "escu5", 10);
            MotoCross m2 = new MotoCross(4, "escu6", 11);
            MotoCross m3 = new MotoCross(5, "escu7", 5);
            MotoCross m4 = new MotoCross(1, "escu8", 2);
            MotoCross m5 = new MotoCross(2, "escu7", 1);
            Competencia competencia = new Competencia(5, 10, Competencia.TipoCompetencia.F1);

            if (competencia + a1)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a3)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a2)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a4)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a5)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
        }
    }
}
