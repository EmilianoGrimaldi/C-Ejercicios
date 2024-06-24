using EntidadesC02GoSpeedRacerGo_;
using EntidadesEnciendanSusMotores;

namespace C03_Parada_en_boxesTestUnitarios
{
    [TestClass]
    public class TestUnitariosGoSpeedRacerGo
    {
        [TestMethod]
        public void ListaVehiculosCompetencia_CuandoInstancioObjetoLaListaEsteInstanciada_NoDebeDevolverNull()
        {
            Competencia<AutoF1> competencia = new(10,5,Competencia<AutoF1>.TipoCompetencia.MotoCross);
            Assert.AreNotEqual(null,competencia.Competidores);
        }

        [TestMethod]
        public void SobrecargaOperadorMas_NoSeLanceExcepcionAlQuererAgregarMotoCompetenciaMotocross_NoDeberiaOcurrirNingunaExcepcion()
        {
            Competencia<MotoCross> competencia = new(10, 5, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross moto = new(10, "Rojo10");
            Assert.IsTrue(competencia + moto);
        }
        [TestMethod]
        public void SobrecargaOperadorMasYIgual_AlAgregarUnVehiculoFigureEnLista_DeberiaRetornarTrue()
        {
            Competencia<MotoCross> competencia = new(10, 5, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross m1 = new(10, "Rojo10");
            Assert.AreEqual(true, competencia + m1);
            Assert.AreEqual(true, competencia == m1);
        }
        [TestMethod]
        public void SobrecargaOperadorMasYIgual_AlQuitarUnVehiculoNoFigureEnLista_DeberiaRetornarTrue()
        {
            Competencia<MotoCross> competencia = new(10, 5, Competencia<MotoCross>.TipoCompetencia.F1);
            MotoCross m1 = new(10, "Rojo10");
            bool agregar = competencia + m1;
            Assert.AreEqual(true, competencia - m1);
            Assert.AreEqual(true, competencia != m1);
        }
    }
}