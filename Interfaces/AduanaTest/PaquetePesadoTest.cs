using I02Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AduanaTest
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado pp = new("123", 234, "Sarasa", "Saroso", 14);
            Assert.AreEqual(false, pp.TienePrioridad);
        }
        //Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita de la clase PaquetePesadoTest. Deberá verificar que la propiedad Impuestos, cuando se invoca de forma implícita desde una instancia de PaquetePesado, retorne el 35% del costo de envío.
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            Paquete paquete = new PaquetePesado("123", 300.0M, "Sarasa", "Saroso", 24);

            decimal expected = (35 * 300.0M) / 100;

            decimal actual = paquete.Impuestos;

            Assert.AreEqual(expected, actual);
        }
        //Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaIAfip de la clase PaquetePesadoTest. Deberá verificar que la propiedad Impuestos, cuando se invoca de forma explícita desde una referencia de tipo IAfip, retorne el 25% del costo de envío.
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaIAfip()
        {
            Paquete paquete = new PaquetePesado("123", 300.0M, "Sarasa", "Saroso", 24);

            decimal expected = (25 * 300.0M) / 100;

            decimal actual = ((IAfip)paquete).Impuestos;

            Assert.AreEqual(expected, actual);
        }
        //Implementar la prueba unitaria AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana de la clase PaquetePesadoTest. Deberá verificar que el método AplicarImpuestos, cuando se invoca de forma implícita desde una instancia de PaquetePesado, retorne el costo de envío con ambos impuestos de AFIP y aduana aplicados.
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            PaquetePesado paquete = new PaquetePesado("123", 300.0M, "Sarasa", "Saroso", 24);
            decimal costoEnvio = 300.0M;
            decimal impuestoAfip = (25 * costoEnvio) / 100;
            decimal impuestoAduana = (35 * costoEnvio) / 100;
            decimal expected = impuestoAduana + impuestoAfip + costoEnvio;

            decimal actual = paquete.AplicarImpuestos();

            Assert.AreEqual(expected, actual);
        }
    }
}
