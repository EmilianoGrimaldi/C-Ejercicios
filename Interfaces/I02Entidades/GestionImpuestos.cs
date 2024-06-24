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
            decimal total = default;
            foreach (IAfip item in impuestosAfip)
            {
                total += item.Impuestos;    
            }

            return total; 
        }
        public decimal CalcularTotalImpuestosAduana()
        {
            decimal total = default;
            foreach (IAduana item in impuestosAduana)
            {
                total += item.Impuestos;
            }

            return total;
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
