using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02Entidades
{
    public class PaquetePesado : Paquete, IAfip
    {
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg) : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }
        public new decimal Impuestos
        {
            get
            {
                return (25 * costoEnvio) / 100;
            }
        }
        public override bool TienePrioridad
        {
            get
            {
                return false;
            }
        }
        public override decimal AplicarImpuestos() 
        {
            return Impuestos + base.Impuestos + costoEnvio;
        }
    }
}
