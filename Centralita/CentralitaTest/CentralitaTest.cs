using EntidadesCentralita;
namespace TestUnitariosCentralita
{
    [TestClass]
    public class CentralitaTest
    {
        [TestMethod]
        public void listaLlamadas_CuandoSeInstanciaListaDeLlamadas_DeberiaRetornarNotNull()
        {
            Centralita centralita = new Centralita();
            List<Llamada> llamadas = centralita.Llamadas;
            Assert.IsNotNull(llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaExcepcion))]
        public void SobrecargaOperadorMas_CuandoSeAgregaUnaLLamadaLocalRepetidaALaLista_DeberiaRetornarCentralitaException()
        {
            Centralita c = new Centralita();
            Local l1 = new("12345678",20,"87654321",200);
            bool seAgrego = c + l1;
            Local l2 = new("12345678",25,"87654321",500);
            seAgrego = c + l2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaExcepcion))]
        public void SobrecargaOperadorMas_CuandoSeAgregaUnaLLamadaProvincialRepetidaALaLista_DeberiaRetornarCentralitaException()
        {
            Centralita c = new Centralita();
            Provincial l1 = new("12345678", Provincial.Franja.Franja_1, 200, "87654321");
            bool seAgrego = c + l1;
            Provincial l2 = new("12345678", Provincial.Franja.Franja_1, 200, "87654321");
            seAgrego = c + l2;
        }

        [TestMethod]
        public void SobrecargaOperadorMas_CuandoSeComparanDosLlamadasLocalDosLlamadasProvinciales_DebenSerIgualesSoloLasInstanciasMismoTipo()
        {
            Local l1 = new("12345678", 20, "87654321", 200);
            Local l2 = new("12345678", 25, "87654321", 500);
            Provincial l3 = new("12345678", Provincial.Franja.Franja_1, 200, "87654321");
            Provincial l4 = new("12345678", Provincial.Franja.Franja_1, 200, "87654321");

            Assert.AreEqual(true, l1 == l2);
            Assert.AreEqual(false, l1 == l3);
            Assert.AreEqual(false, l1 == l4);
            Assert.AreEqual(false, l2 == l3);
            Assert.AreEqual(false, l2 == l4);
            Assert.AreEqual(true, l3 == l4);

        }
    }
}