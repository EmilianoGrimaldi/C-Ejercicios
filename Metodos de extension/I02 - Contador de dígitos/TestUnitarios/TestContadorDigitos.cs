using Biblioteca;

namespace TestUnitarios
{
    [TestClass]
    public class TestContadorDigitos
    {
        [TestMethod]
        [DataRow(0,1)]
        [DataRow(1,1)]
        [DataRow(2,1)]
        [DataRow(3,1)]
        [DataRow(4,1)]
        [DataRow(5,1)]
        [DataRow(6,1)]
        [DataRow(7,1)]
        [DataRow(8,1)]
        [DataRow(9,1)]
        public void ContarCantidadDeDigitos_CuandoSeIngresaUnNumeroDeUnaCifra_DeberiaRetornarUno(long numero, int expected)
        {
            long actual = numero.ContadorDigitos();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoSeIngresaUnNumeroDeDosCifras_DeberiaRetornarDos()
        {
            long actual;
            for (long i = 10; i < 100; i++)
            {
                actual = i.ContadorDigitos();        
                Assert.AreEqual(2, actual);
            }
        }

        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoSeIngresaUnNumeroDeTresCifras_DeberiaRetornarTres()
        {
            long actual;
            for (long i = 100; i < 1000; i++)
            {
                actual = i.ContadorDigitos();
                Assert.AreEqual(3, actual);
            }
        }
    }
}