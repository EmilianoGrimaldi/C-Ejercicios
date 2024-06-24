using I02Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AduanaTest
{
    [TestClass]
    public class PaqueteFragilTest
    {
        //Implementar la prueba unitaria AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana de la clase PaqueteFragilTest. Deberá verificar que el método AplicarImpuestos, cuando se invoca de forma implícita desde una instancia de PaqueteFragil, retorne el costo del envío con el impuesto de aduana aplicado.
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            Paquete paquete = new PaqueteFragil("123", 250.0M, "Sarasa", "Saroso", 24);

            decimal expected = ((35 * 250.0M) / 100) + 250.0M;

            decimal actual = paquete.AplicarImpuestos();

            Assert.AreEqual(expected, actual);

        }
        //Implementar la prueba unitaria Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio de la clase PaqueteFragilTest. Deberá verificar que la propiedad Impuestos, cuando se invoca de forma implícita desde una instancia de PaqueteFragil, retorne el 35% del costo de envío.
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            
            Paquete paquete = new PaqueteFragil("123", 250.0M , "Sarasa", "Saroso", 24);

            decimal expected = (35 * 250.0M) / 100;

            decimal actual = paquete.Impuestos;

            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            Paquete pf = new PaqueteFragil("123", 234, "Sarasa", "Saroso", 24);
            Assert.IsInstanceOfType(pf, typeof(PaqueteFragil));
            Assert.AreEqual(true, pf.TienePrioridad);
        }
    }
}
