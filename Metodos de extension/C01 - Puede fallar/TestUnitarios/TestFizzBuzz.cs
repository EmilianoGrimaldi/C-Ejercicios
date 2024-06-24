using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestFizzBuzz
    {
        [TestMethod]
        [DataRow(3,"fizz")]
        [DataRow(6,"fizz")]
        [DataRow(9,"fizz")]
        [DataRow(12,"fizz")]
        public void FizzBuzz_CuandoEsDivisiblePorTres_DebeRetornarFizz(int numero, string expected)
        {
            string actual = numero.FizzBuzz();
            Assert.AreEqual(expected.ToLower(), actual);
        }

        [TestMethod]
        [DataRow(5,"buzz")]
        [DataRow(10,"buzz")]
        [DataRow(20,"buzz")]
        [DataRow(25,"buzz")]
        [DataRow(35,"buzz")]
        public void FizzBuzz_CuandoEsDivisiblePorCinco_DebeRetornarBuzz(int numero, string expected)
        {
            string actual = numero.FizzBuzz();
            Assert.AreEqual(expected.ToLower(), actual);
        }

        [TestMethod]
        [DataRow(15, "fizzbuzz")]
        [DataRow(30, "fizzbuzz")]
        [DataRow(45, "fizzbuzz")]
        [DataRow(60, "fizzbuzz")]
        [DataRow(75, "fizzbuzz")]
        public void FizzBuzz_CuandoEsDivisiblePorCincoYTres_DebeRetornarFizzBuzz(int numero, string expected)
        {
            string actual = numero.FizzBuzz();
            Assert.AreEqual(expected.ToLower(), actual);
        }
        [TestMethod]
        [DataRow(1,"1")]
        [DataRow(2,"2")]
        [DataRow(4,"4")]
        [DataRow(7,"7")]
        [DataRow(8,"8")]
        public void FizzBuzz_CuandoNoEsDivisiblePorCincoOTres_DebeRetornarElMismoNumero(int numero, string expected)
        {
            string actual = numero.FizzBuzz();
            Assert.AreEqual(expected.ToLower(), actual);
        }
    }
}