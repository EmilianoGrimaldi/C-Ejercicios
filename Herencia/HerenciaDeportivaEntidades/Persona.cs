using System.Text;

namespace HerenciaDeportivaEntidades
{
    public class Persona
    {
        long dni;
        string nombre;

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
        }

        public string Nombre
        { 
            get
            {
                return nombre;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre -> {nombre}");
            sb.Append($"Dni -> {dni}");

            return sb.ToString();
        }
    }
}
