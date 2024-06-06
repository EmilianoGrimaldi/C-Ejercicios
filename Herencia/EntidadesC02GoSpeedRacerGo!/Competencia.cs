using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEnciendanSusMotores
{ 
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
        short cantidadCompetidores;
        short cantidadVueltas;
        List<VehiculoDeCarrera> competidores;
        TipoCompetencia tipo;

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipoCompetencia):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            tipo = tipoCompetencia;
        }
        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        public List<VehiculoDeCarrera> this[int i] { get => competidores; }
        public TipoCompetencia Tipo { get => tipo; set => tipo = value; }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("COMPETENCIA");
            sb.AppendLine($"Tipo de competencia -> {tipo}");
            sb.AppendLine($"Cantidad de vueltas -> {cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores -> {cantidadCompetidores}");
            foreach (VehiculoDeCarrera vehiculo in competidores)
            {
                if (vehiculo.GetType() == typeof(AutoF1))
                {
                    sb.Append(((AutoF1)vehiculo).MostrarDatos());
                }
                else
                {
                    sb.Append(((MotoCross)vehiculo).MostrarDatos());
                }
            }
            return sb.ToString();
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
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

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            
            if ((c.tipo == TipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross)) || (c.tipo == TipoCompetencia.F1) && a.GetType() == typeof(AutoF1))
            {
                
                foreach (VehiculoDeCarrera vehiculo in c.competidores)
                {
                    if (vehiculo == a)
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
         
            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
    }
}
