using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita
    {
        List<Llamada> listaDeLlamadas;
        string razonSocial;

        public float GananciasPorLocal
        { 
            get
            {
                return 1;
            }
        }
        public float GananciasPorProvincial
        { 
            get
            {
                return 1;
            }
        }
        public float GananciasPorTotal
        { 
            get
            {
                return 1;
            }
        }
        public List<Llamada> Llamadas
        { 
            get
            {
                return listaDeLlamadas;
            }
        }


    }
}
