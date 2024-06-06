using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02Entidades
{
    public interface IAduana
    {
        decimal Impuestos {  get; }
        decimal AplicarImpuestos();
    }
}
