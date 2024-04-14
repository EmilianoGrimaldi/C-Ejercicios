using Entidades.Alumno;

namespace Ejercicio_I03___El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new("Peposo", "113100","Pepe");
            Estudiante estudiante2 = new("Lalala","115410","Lali");
            Estudiante estudiante3 = new("Sarasa","111125","Sara");
            estudiante1.SetNotaPrimerParcial(4);
            estudiante1.SetNotaSegundoParcial(7);
            estudiante2.SetNotaPrimerParcial(2);
            estudiante2.SetNotaSegundoParcial(2);
            estudiante3.SetNotaPrimerParcial(9);
            estudiante3.SetNotaSegundoParcial(6);
            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
