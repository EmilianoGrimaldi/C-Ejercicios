using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(0,1)]
        [DataRow(1,2)]
        [DataRow(2,4)]
        [DataRow(3,8)]
        [DataRow(4,16)]
        [DataRow(5,32)]
        public void CalcularPotencia_CuandoExponenteEsMayorOIgualACero_DeberiaRetornarUnResultado(int exponente, int expected)
        {
            //Arramge - Preparamos los valores que vamos a probar
            int numero = 2;
            //int exponente = 0;
            int actual; // retorno de la funcion
            //int expected = 1; // valor que deberia obtener como resultado

            // Act - Ejecutamos el metodo a testear
            actual = Aritmetica.CalcularPotencia(numero, exponente);
            Assert.AreEqual(expected, actual);
        }
    }
}