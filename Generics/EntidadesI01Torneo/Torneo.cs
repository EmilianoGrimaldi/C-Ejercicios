using System.Text;

namespace EntidadesI01Torneo
{
    public class Torneo<T> where T : Equipo
    {
        string nombre;
        List<T> equipos = new();
        public Torneo(string nombre)
        {
            this.nombre = nombre;
        }
        //Sobrecargar el operador == para que controle si un equipo ya está inscripto al torneo.
        public static bool operator ==(Torneo<T> t, T e)
        {
            foreach (T item in t.equipos)
            {
                if (item == e)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        //Sobrecargar el operador + para agregar un equipo a la lista, siempre y cuando este no se encuentre ya en el torneo.
        public static bool operator +(Torneo<T> t, T e)
        {
            if (t != e)
            {
                t.equipos.Add(e);
                return true;
            }
            return false;
        }

        // El método Mostrar retornará los datos del torneo y de los equipos participantes.

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine("Lista de equipos");
            foreach (T item in equipos)
            {
                sb.AppendLine(item.Ficha());
            }

            return sb.ToString();
        }

        //El método privado CalcularPartido recibirá dos elementos del tipo T, que deberán ser del tipo Equipo o sus herencias, y calculará utilizando la clase Random un resultado del partido. Retornará el resultado como un string con el siguiente formato donde EQUIPOX es el nombre del equipo y RESULTADOX la cantidad de goles/puntos:
        //[EQUIPO1][RESULTADO1] – [RESULTADO2][EQUIPO2]
        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random resultado = new Random();
            return $"{equipo1.nombre} {resultado.Next(0,10)} – {resultado.Next(0,10)} {equipo2.nombre}";
        }
        //La propiedad pública JugarPartido tomará dos equipos de la lista al azar y calculará el resultado del partido a través del método CalcularPartido.

        public string JugarPartido
        {
            get
            {
                Random equipoAzar = new();
                T equipo1;
                T equipo2;
                while (true)
                {
                    equipo1 = equipos.ElementAt(equipoAzar.Next(0,equipos.Count));
                    equipo2 = equipos.ElementAt(equipoAzar.Next(0,equipos.Count));
                    if (equipo1 != equipo2)
                    {
                        break;
                    }
                }      
                return CalcularPartido(equipo1, equipo2);
            }
        }

    }
}
