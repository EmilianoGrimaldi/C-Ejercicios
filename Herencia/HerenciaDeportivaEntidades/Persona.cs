using System.Text;

namespace HerenciaDeportivaEntidades
{
    public class Persona
    {
        protected long dni;
        protected string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(long dni, string nombre):this(nombre)
        {
            this.dni = dni;
        }
        public long Dni
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
            sb.AppendLine($"Nombre -> {nombre}");
            sb.AppendLine($"Dni -> {dni}");

            return sb.ToString();
        }
    }
}
