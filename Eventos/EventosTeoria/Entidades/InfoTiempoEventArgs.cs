using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InfoTiempoEventArgs : EventArgs
    {
        int hora;
        int minuto;
        int segundo;
        public InfoTiempoEventArgs(int h, int m, int s)
        {
            this.hora = h;
            this.minuto = m;
            this.segundo = s;
        }

        public int Hora { get => hora;}
        public int Minuto { get => minuto;}
        public int Segundo { get => segundo;}
    }
}
