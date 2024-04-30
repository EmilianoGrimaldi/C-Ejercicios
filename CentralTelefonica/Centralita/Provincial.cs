using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base()
        { 
            
        }
        public Provincial(Franja miFranja, Llamada llamada):base()
        {
            this.franjaHoraria = franjaHoraria;
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            return 1;
        }
    }

    
    
}
