using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02ContabilidadEntidades
{
    public class Contabilidad<T, U> where T : Documento where U : Documento, new()
    {
        List<T> egresos;
        List<U> ingresos;

        public Contabilidad()
        {
            egresos = new();
            ingresos = new();
        }

        public List<T> Egresos { get => egresos;}
        public List<U> Ingresos { get => ingresos;}

        public static Contabilidad<T, U> operator +(Contabilidad <T, U> c, T egreso)
        {
            
            if (c.egresos is not null)
            {
                c.egresos.Add(egreso);
                return c;
            }

            return null;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (c.ingresos is not null)
            {
                c.ingresos.Add(ingreso);
                return c;
            }

            return null;
        }
    }
}
