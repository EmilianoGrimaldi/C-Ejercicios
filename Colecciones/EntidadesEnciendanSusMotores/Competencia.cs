using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("COMPETENCIA");
            sb.AppendLine($"Cantidad de vueltas -> {cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores -> {cantidadCompetidores}");
            foreach (AutoF1 vehiculo in competidores)
            {
                sb.AppendLine(vehiculo.MostrarDatos());   
            }
            return sb.ToString();
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
            foreach (AutoF1 vehiculo in c.competidores)
            {
                if (vehiculo == a)
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
        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c.competidores.Count <= c.cantidadCompetidores && c != a)
            {
                Random randomCombustible = new();
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)randomCombustible.Next(15,101);
                c.competidores.Add(a);
                return true;
            }              
            return false;
        }
    }
}
