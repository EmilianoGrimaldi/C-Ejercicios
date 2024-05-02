using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class PuestoAtencion
    {
        public enum Puesto
        { 
            Caja1,
            Caja2
        }
        static int numeroActual;
        Puesto puesto;
        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public static int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }    
        public bool Atender(Cliente cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(1000);
                return true;
            }
            return false; 
        }
    }
}
