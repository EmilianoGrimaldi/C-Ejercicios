﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo):base(duracion,destino, origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo):this(llamada.NroOrigen, llamada.Duracion,llamada.NroDestino,costo)
        {

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
            //CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma.
            return duracion * costo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Llamada Local");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {costo}");

            return sb.ToString();
        }
    }
}
