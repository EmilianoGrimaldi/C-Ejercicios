using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace I01___Cartuchera
{
    public class CartucheraSimple:ICartuchera<Boligrafo>, ICartuchera<Lapiz>
    {
        List<Boligrafo> boligrafos;
        List<Lapiz> lapices;

        public CartucheraSimple()
        {
            this.boligrafos = new();
            this.lapices = new();
        }
        public bool Agregar(Lapiz lapiz)
        {
            if (lapices is not null)
            {
                lapices.Add(lapiz);
                return true;
            }
            return false;
        }

        public bool Agregar(Boligrafo boligrafo)
        {
            if (boligrafos is not null)
            {
                boligrafos.Add(boligrafo);
                return true;
            }
            return false;
        }
        public bool RecorrerElementos()
        {
            bool todosGastados = true;
               
            foreach (Boligrafo boligrafo in boligrafos)
            {
                try
                {
                    if (((IAcciones)boligrafo).UnidadesDeEscritura > 0)
                    {
                        ((IAcciones)boligrafo).UnidadesDeEscritura -= 1;
                    } 
                    else
                    {
                        todosGastados = false;
                        ((IAcciones)boligrafo).Recargar(20);
                    }
                }
                catch (NotImplementedException)
                {
                    todosGastados = false;                
                }
            }
            foreach (Lapiz lapiz in lapices)
            {
                try
                {
                    if (lapiz.UnidadesDeEscritura > 0)
                    {
                        lapiz.UnidadesDeEscritura -= 1;
                    }
                    else
                    {
                        todosGastados = false;
                    }
                }
                catch (NotImplementedException)
                {
                    todosGastados = false;
                    // No se puede recargar el lápiz en este caso
                }
            }   

            return todosGastados;
        }
    }
}
