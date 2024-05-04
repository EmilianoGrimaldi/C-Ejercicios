using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadisticaDeportivaEntidades
{
    public class Jugador
    {
        int dni;
        string nombre;
        int partidosJugados;
        int totalGoles;

        /*
        Todos los datos estadísticos del jugador se inicializarán en 0 dentro del constructor privado.
        El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
        MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
        Dos jugadores serán iguales si tienen el mismo DNI.
         */
        private Jugador()
        {
            partidosJugados = 0;
            totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles):this(dni,nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
        public float PromedioGoles
        { 
            get 
            {
                if (partidosJugados > 0)
                { 
                   return (float)totalGoles / partidosJugados;
                }
                return 0; 
            }
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

        public int Dni 
        { 
            get 
            {
                return dni; 
            } 
            set 
            {
                dni = value;  
            }
        }
        public string Nombre 
        {
            get
            {
                return nombre;
            }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }         
            } 
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Dni: {dni}");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Total de goles: {totalGoles}");
            sb.AppendLine($"Promedio de goles: {PromedioGoles:N2}");

            return sb.ToString();
        }
        /*
         Dos jugadores serán iguales si tienen el mismo DNI.
         */
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
