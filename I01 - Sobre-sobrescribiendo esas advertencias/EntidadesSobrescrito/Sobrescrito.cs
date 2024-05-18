using System.Text;

namespace EntidadesSobrescrito
{
    public class Sobrescrito
    {
        /* 
         Sobrescribir el método ToString para que retorne "¡Este es mi método ToString sobrescrito!".
        Sobrescribir el método Equals para que retorne true si son del mismo tipo (objetos de la misma clase), false caso contrario.
        Sobrescribir el método GetHashCode para que retorne el número 1142510181.
        Agregar en el método Main el siguiente código:
        */
        string id;

        public Sobrescrito() 
        {
        
        }

        public Sobrescrito(string id):this()
        {
            this.id = id;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("¡Este es mi método ToString sobrescrito!");
            return sb.ToString(); 
        }

        public override bool Equals(object? obj)
        {
            return obj is Sobrescrito;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
