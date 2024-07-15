using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensoraRandom
    {
        public static int GenerarRandom(this List<Serie> lista)
        {
            Random random = new Random();
            return random.Next(0, lista.Count + 1);
        }
    }
}
