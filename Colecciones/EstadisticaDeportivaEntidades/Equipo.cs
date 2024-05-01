using System.Data.Common;

namespace EstadisticaDeportivaEntidades
{
    public class Equipo
    {
        List<Jugador> jugadores;
        short cantidadDeJugadores;
        string nombre;
        /*
        Clase Equipo
        La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
        */
        private Equipo()
        {
            jugadores = new();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        /*
         La sobrecarga del operador + agregará jugadores a la lista siempre y cuando no exista aún en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo cantidadDeJugadores
         */
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if (jugador == j)
                    {        
                        return false;
                    }      
                }
                e.jugadores.Add(j);
                return true;
            }
            else 
            {
                return false;
            }       
        }

    }
}
