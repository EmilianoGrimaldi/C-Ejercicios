using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades.Alumno
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        static Estudiante()
        {
            random = new();
        }

        public void SetNotaPrimerParcial(int nota)
        {
            if (nota >= 1 && nota <= 10)
            {
                notaPrimerParcial = nota;
            }
        }
        public void SetNotaSegundoParcial(int nota)
        {
            if (nota >= 1 && nota <= 10)
            {
                notaSegundoParcial = nota;
            }
        }
        private float CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial)/ 2;
        }
        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }
            return -1;
        }
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"legajo: {legajo}");
            sb.AppendLine($"nombre: {nombre}");
            sb.AppendLine($"nota primer parcial: {notaPrimerParcial}");
            sb.AppendLine($"nota segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"promedio: {CalcularPromedio()}");
            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"nota final: {CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine($"Alumno desaprobado");
            }

            return sb.ToString();
        }
    }
}
