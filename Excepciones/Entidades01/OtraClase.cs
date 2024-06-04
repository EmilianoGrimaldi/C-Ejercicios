using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades01
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
			try
			{
				new MiClase();
			}
			catch (Exception ex)
			{
				throw new MiExcepcion("Mi excepcion propia en OtraClase()", ex);
			}
        }
    }
}
