using EntidadesC02GoSpeedRacerGo_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEnciendanSusMotores
{ 
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
        short cantidadCompetidores;
        short cantidadVueltas;
        List<T> competidores;
        TipoCompetencia tipo;

        private Competencia()
        {
            competidores = new List<T>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipoCompetencia):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            tipo = tipoCompetencia;
        }
        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        public List<T> this[int i] { get => competidores; }
        public List<T> Competidores { get => competidores; }
        public TipoCompetencia Tipo { get => tipo; set => tipo = value; }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("COMPETENCIA");
            sb.AppendLine($"Tipo de competencia -> {tipo}");
            sb.AppendLine($"Cantidad de vueltas -> {cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores -> {cantidadCompetidores}");
            foreach (T vehiculo in competidores)
            {
                if (vehiculo.GetType() == typeof(T))
                {
                    sb.Append(((T)vehiculo).MostrarDatos());
                }
                else
                {
                    sb.Append(((T)vehiculo).MostrarDatos());
                }
            }
            return sb.ToString();
        }
        public static bool operator +(Competencia<T> c, VehiculoDeCarrera a)
        {
            /*
             La sobrecarga del operador + agregará un competidor si es que aún hay espacio (validar con cantidadCompetidores) y el competidor no forma parte de la lista (== entre Competencia y AutoF1).
             */
            try
            {
                Random combustible = new Random();
                if (c.competidores.Count < c.cantidadCompetidores)
                {
                    if (c == a)
                    {
                        throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "+");
                    }
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.CantidadCombustible = (short)combustible.Next(15,101);
                    c.competidores.Add((T)a);
                    return true;
                }
                else
                {
                    return false;
                }  
            }
            catch (Exception ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta","Competencia","+",ex);
            }
        }

        public static bool operator -(Competencia<T> c, VehiculoDeCarrera a)
        {
            if (c == a)
            {
                c.competidores.Remove((T)a);
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia<T> c, VehiculoDeCarrera a)
        {
            bool ok = false;
            if ((c.tipo == TipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross)) || (c.tipo == TipoCompetencia.F1) && a.GetType() == typeof(AutoF1))
            {
                
                foreach (T vehiculo in c.competidores)
                {
                    if (vehiculo == a)
                    {
                        ok = true;
                    }
                }
            }
            else
            {
                ok = true;
            }
         
            return ok;
        }
        public static bool operator !=(Competencia<T> c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
    }
}
