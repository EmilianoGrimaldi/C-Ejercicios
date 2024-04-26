using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo):base(origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo):this(costo)
        {
            this.costo = costo;
        }
        public float GetCostoLlamada()
        {
            return costo;
        }

    }
}
