using EntidadesTestDrivenDevelopment;

namespace PruebasTestDrivenDevelopment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_CuandoIngresaStringVacio_DeberiaRetornarCero()
        {
            //arrange
            int expected = 0;
            string numero = ""; 
            //act

            int actual = Calculadora.Add(numero);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("1",1)]
        [DataRow("2",2)]
        [DataRow("3",3)]
        [DataRow("4",4)]
        [DataRow("5",5)]
        public void Add_CuandoIngresaUnNumeroString_DeberiaRetornarElMismoNumero(string numero, int expected)
        {
            //arrange
            //int expected = 2;
            //string numero = "2";
            //act

            int actual = Calculadora.Add(numero);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("1,2", 3)]
        [DataRow("2,2", 4)]
        [DataRow("3,3", 6)]
        [DataRow("4,5", 9)]
        [DataRow("5,10", 15)]
        public void Add_CuandoIngresaDosNumerosString_DeberiaRetornarLaSuma(string numero, int expected)
        {
            //arrange
            //int expected = 2;
            //string numero = "2";
            
            //act
            int actual = Calculadora.Add(numero);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("1\n2,3", 6)]
        [DataRow("2\n2,3", 7)]
        [DataRow("5\n2,3", 10)]
        public void Add_CuandoIngresaDosNumerosStringConSaltoDeLinea_DeberiaReemplazarSaltoLineaPorComaDevolverSuma(string numero, int expected)
        {
            //arrange
            //int expected = 2;
            //string numero = "2";

            //act
            int actual = Calculadora.Add(numero);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_NumerosConSaltosDeLinea_RetornaLaSuma()
        {
            string numeros = "1\n2\n3";
            int resultado = Calculadora.Add(numeros);
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void Add_DelimitadorPersonalizado_RetornaLaSuma()
        {
            string numeros = "//;\n1;2";
            int resultado = Calculadora.Add(numeros);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void Add_DelimitadorPersonalizadoYSaltosDeLinea_RetornaLaSuma()
        {
            string numeros = "//;\n1;2\n3";
            int resultado = Calculadora.Add(numeros);
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_NumerosNegativos_LanzaNegativoNoPermitidoException()
        {
            string numeros = "1,-2,3";
            Calculadora.Add(numeros);
        }

        [TestMethod]
        public void Add_NumerosNegativos_LanzaNegativoNoPermitidoExceptionConMensajeCorrecto()
        {
            string numeros = "1,-2,3";
            try
            {
                Calculadora.Add(numeros);
            }
            catch (NegativoNoPermitidoException ex)
            {
                Assert.AreEqual("Negativos no permitidos: -2", ex.Message);
            }
        }
    }
}