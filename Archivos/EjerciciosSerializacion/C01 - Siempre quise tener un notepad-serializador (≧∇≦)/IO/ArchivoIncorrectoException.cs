using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException()
        {
        }
        public ArchivoIncorrectoException(string? message) : base(message)
        {
        }
        public ArchivoIncorrectoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
