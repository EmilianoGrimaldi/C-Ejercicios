using System.Data.SqlClient;

namespace Entidades
{
    public class PersonaDTO //objeto de transferencia de datos
    {
        string nombre;
        int id;

        public PersonaDTO(string nombre)
        {
            this.nombre = nombre;
        }

        public PersonaDTO(string nombre, int id) : this(nombre)
        {
            this.id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"Nombre: {nombre}";
        }
    }
}
