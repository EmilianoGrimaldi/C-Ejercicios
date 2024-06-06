using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesC02GoSpeedRacerGo_
{
    public class CompetenciaNoDisponibleException :Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo):base(mensaje)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje,innerException)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Excepción en el método {0} de la clase {1}:");
            sb.AppendLine($"{Message}");
            sb.AppendLine($"{InnerException}\t");

            return sb.ToString();
        }
    }
}
