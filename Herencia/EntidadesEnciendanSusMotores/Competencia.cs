using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEnciendanSusMotores
{
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("COMPETENCIA");
            sb.AppendLine($"Cantidad de vueltas -> {cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores -> {cantidadCompetidores}");
            foreach (AutoF1 autoF1 in competidores)
            {
                sb.AppendLine("---------------");
                sb.Append(autoF1.MostrarDatos());
                sb.Append("---------------");
            }
            return sb.ToString();
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            /*
             La sobrecarga del operador + agregará un competidor si es que aún hay espacio (validar con cantidadCompetidores) y el competidor no forma parte de la lista (== entre Competencia y AutoF1).
             */
            Random combustible = new Random();
            if (c.competidores.Count < c.cantidadCompetidores)
            {
                if (c == a)
                {
                    return false;
                }
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)combustible.Next(15,101);
                c.competidores.Add(a);
                return true;
            }
            else
            {
                return false;
            }  
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
