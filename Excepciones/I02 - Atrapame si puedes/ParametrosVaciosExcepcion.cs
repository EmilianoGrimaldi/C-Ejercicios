using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02___Atrapame_si_puedes
{
    public class ParametrosVaciosExcepcion : Exception
    {
        public ParametrosVaciosExcepcion()
        {
        }

        public ParametrosVaciosExcepcion(string? message) : base(message)
        {
        }
        public ParametrosVaciosExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
