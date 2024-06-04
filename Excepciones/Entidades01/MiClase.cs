using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades01
{
    public class MiClase
    {
        public MiClase()
        {      
            try
            {
                MiClase miClase = new MiClase();
            }
            catch (Exception ex)
            {
                throw new UnaException("Excepcion capturada en MiClase()", ex);
            }
        }
        public MiClase(string msj):this()
        {
            try
            {
                MetodoEstatico();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }
    }
}
