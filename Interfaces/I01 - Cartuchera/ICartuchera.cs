using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01___Cartuchera
{
    public interface ICartuchera<T>
    {
        bool RecorrerElementos();
        bool Agregar(T elemento);
        
    }
}
