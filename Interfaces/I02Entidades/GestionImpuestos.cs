using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02Entidades
{
    public class GestionImpuestos
    {
        List<IAduana> impuestosAduana;
        List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new();
            this.impuestosAfip = new();
        }
        public decimal CalcularTotalImpuestosAfip()
        {
            return 0;
        }
        public decimal CalcularTotalImpuestosAduana()
        {
            return 0;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete paquete in paquetes)
            {
                RegistrarImpuestos(paquete);
            }
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            if (paquete.GetType() == typeof(PaquetePesado))
            {
                impuestosAduana.Add(paquete);
                impuestosAfip.Add((IAfip)paquete);
            }
            else
            {
                impuestosAduana.Add(paquete);
            }
        }
    }
}
