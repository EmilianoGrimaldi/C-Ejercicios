using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public class CentralitaExcepcion : Exception
    {
        public CentralitaExcepcion()
        {
        }
        public CentralitaExcepcion(string? message) : base(message)
        {
        }
        public CentralitaExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
