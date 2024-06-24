using I02Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AduanaTest
{
    [TestClass]
    public class GestionImpuestosTest
    {
        //Implementar la prueba unitaria CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana de la clase GestionImpuestosTest.
        //Deberá verificar que el método CalcularTotalImpuestosAduana retorne la suma de los impuestos de aduana. Realizar la prueba con al menos un paquete de cada tipo.
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            Paquete pf = new PaqueteFragil("1234",300.0M,"Uruguay","Argentina",100);
            Paquete pp = new PaquetePesado("4321",400.0M,"Argenina","Chile",200);
            decimal actual = ((35 * 300.0M) / 100) + ((35 * 400.0M) / 100);
            decimal expected = ((IAduana)pf).Impuestos + ((IAduana)pp).Impuestos;
            
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            Paquete pf = new PaqueteFragil("1234", 300.0M, "Uruguay", "Argentina", 100);
            Paquete pp = new PaquetePesado("4321", 400.0M, "Argenina", "Chile", 200);
            decimal actual = (35 * 300.0M) / 100 + (25 * 400.0M) / 100;
            decimal expected = pf.Impuestos + ((IAfip)pp).Impuestos;

            Assert.AreEqual(actual, expected);
        }
    }
}
