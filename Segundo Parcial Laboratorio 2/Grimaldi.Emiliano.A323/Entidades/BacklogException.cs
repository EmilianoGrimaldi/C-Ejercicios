using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BacklogException : Exception
    {
        public BacklogException(string? message) : base(message)
        {
        }

        public BacklogException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
