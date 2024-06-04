using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia : Publicacion
    {
        /*
         La propiedad HayStock controlará solo que haya stock, sin importar el valor de venta.
        La propiedad EsColor siempre será que NO.
        La conversión explicita generará un objeto Biografia.
         */
        protected override bool EsColor { get { return false; } }
        public override bool HayStock 
        {  
            get
            {
                if (stock > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public Biografia(string nombre):base(nombre)
        {
        }
        public Biografia(string nombre, int stock) : base(nombre, stock)
        {
        }
        public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {
        }

        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
}
