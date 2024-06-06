using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01___Cartuchera
{
    public class CartucheraMultiuso:ICartuchera<IAcciones>
    {
        List<IAcciones> acciones;

        public CartucheraMultiuso()
        {
            this.acciones = new();
        }
        public bool Agregar(IAcciones accion)
        {
            if (acciones is not null)
            {
                acciones.Add(accion);
                return true;
            }
            return false;
        }
        /*
Se deberá recorrer la lista y gastará 1 unidades de cada elemento.
Cuando sea necesario, recargará antes de salir del método (cargar 20 unidades).
Retornará true si se pudo gastar exactamente 1 unidad de todos los elementos.
*/
        public bool RecorrerElementos()
        {
            bool todosGastados = true;
            foreach (IAcciones elemento in acciones)
            {
                try
                {
                    if (elemento.UnidadesDeEscritura > 0)
                    {
                        elemento.UnidadesDeEscritura -= 1;
                    }
                    else
                    {
                        ((IAcciones)elemento).Recargar(20);
                        todosGastados = false;
                    }
                }
                catch (NotImplementedException)
                {
                    todosGastados = false;
                }
            }
            return todosGastados;
        }
    }
}
