using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTestDrivenDevelopment
{
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException()
        {
        }

        public NegativoNoPermitidoException(string? message) : base(message)
        {
        }

        public NegativoNoPermitidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
