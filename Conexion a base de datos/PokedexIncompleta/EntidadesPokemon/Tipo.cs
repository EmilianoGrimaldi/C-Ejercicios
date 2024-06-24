using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPokemon
{
    public class Tipo
    {
        int id;
        string nombre;

        public Tipo(string nombre)
        {
            this.nombre = nombre;
        }
        public Tipo(int id, string nombre):this(nombre)
        {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
