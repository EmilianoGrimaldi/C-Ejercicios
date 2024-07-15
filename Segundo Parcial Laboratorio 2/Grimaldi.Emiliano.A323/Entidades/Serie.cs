using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serie
    {
        string genero;
        string nombre;

        public Serie()
        {
            
        }

        public Serie(string genero, string nombre)
        {
            this.genero = genero;
            this.nombre = nombre;
        }

        public string Genero { get => genero; set => genero = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return $"{nombre} {genero}";
        }
    }
}
