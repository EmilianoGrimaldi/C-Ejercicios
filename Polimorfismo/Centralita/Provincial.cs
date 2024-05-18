using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion,destino,origen)
        { 
            franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada):this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
           
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            /*CalcularCosto será privado y retornará el valor de la llamada a partir de la duración y el costo de la misma. Los valores serán:
                Franja_1: 0.99
                Franja_2: 1.25
                Franja_3: 0.66
            */

            if (franjaHoraria is Franja.Franja_1)
            {
                return duracion * 0.99f;
            }
            else if (franjaHoraria is Franja.Franja_2)
            {
                return duracion * 1.25f;
            }
            else if (franjaHoraria is Franja.Franja_3)
            {
                return duracion * 0.66f;
            }

            return -1;
        }
        protected string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine("Llamada provincial");  
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {CostoLlamada}");
            sb.AppendLine($"Franja horaria: {franjaHoraria}");

            return sb.ToString();
        }
        public override bool Equals(object? obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }   
}
