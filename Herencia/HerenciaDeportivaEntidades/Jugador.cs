using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDeportivaEntidades
{
    public class Jugador : Persona
    {
        int partidosJugados;
        int totalGoles;

        public Jugador(int dni, string nombre):base(dni, nombre)
        { 
            
        }
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles):this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public int PartidosJugados
        {
            get
            {
                return partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return totalGoles;
            }
        }

        public float PromedioDeGoles
        {
            get
            {
                return totalGoles / partidosJugados;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre -> {Nombre}");
            sb.AppendLine($"Dni -> {Dni}");
            sb.AppendLine($"Partidos jugados -> {partidosJugados}");
            sb.AppendLine($"Total de goles -> {totalGoles}");
            sb.AppendLine($"Promedio de goles -> {PromedioDeGoles}");
            
            

            return sb.ToString();
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return (jugador1.Nombre == jugador2.Nombre) && (jugador1.Dni == jugador2.Dni);
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
