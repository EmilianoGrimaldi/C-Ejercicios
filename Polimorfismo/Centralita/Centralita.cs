using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public class Centralita
    {
        List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita(string nombreEmpresa)
        {
            listaDeLlamadas = new();
            razonSocial = nombreEmpresa;
        }
        public Centralita()
        {

        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas); ;
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        /*
        CalcularGanancia será privado. Este método recibe un enumerado TipoLlamada y retornará el valor de lo recaudado, según el criterio elegido (ganancias por las llamadas del tipo Local, Provincial o de Todas según corresponda).
        */
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0f;
            float gananciaProvincial = 0f;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local l)
                {
                    gananciaLocal += l.CostoLlamada;
                }
                else if (llamada is Provincial p)
                {
                    gananciaProvincial += p.CostoLlamada;
                }
            }

            switch (tipo)
            {
                case TipoLlamada.Local:
                    return gananciaLocal;
                case TipoLlamada.Provincial:
                    return gananciaProvincial;
                case TipoLlamada.Todas:
                    return gananciaProvincial + gananciaLocal;
                default:
                    break;
            }

            return -1;
        }
        private string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine(razonSocial);

            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local l)
                {
                    sb.AppendLine(l.ToString());
                }
                else if (llamada is Provincial p)
                {
                    sb.AppendLine(p.ToString());
                }
            }
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public override string ToString()
        {
            return Mostrar();
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }
        /*El operador == retornará true si la centralita contiene la llamada en su lista genérica. Utilizar la sobrecarga del operador == de la clase Llamada.*/
        public static bool operator ==(Centralita c, Llamada l)
        {
            foreach (Llamada llamada in c.listaDeLlamadas)
            {
                if (llamada == l)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        /*
         El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la Centralita. Utilizar la sobrecarga del operador == de Centralita.
         */

        public static bool operator +(Centralita c, Llamada l)
        {
            if (c != l)
            {
                c.AgregarLlamada(l);
                return true;
            }
            return false;
        }
    }
}
