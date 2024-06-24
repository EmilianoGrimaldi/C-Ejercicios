using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public class InvalidCastException : Exception
    {
        public InvalidCastException()
        {
        }

        public InvalidCastException(string? message) : base(message)
        {
        }

        public InvalidCastException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
