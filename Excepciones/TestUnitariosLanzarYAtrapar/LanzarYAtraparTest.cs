using Entidades01;

namespace TestUnitariosLanzarYAtrapar
{
    [TestClass]
    public class LanzarYAtraparTest
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MetodoEstatico_CuandoDevuelveUnaExcepcion_DeberaDevolverDivideByZeroException()
        {
            MiClase.MetodoEstatico();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ConstructorMiClaseSinParametros_CuandoLlamaAMetodoEstatico_DeberaDevolverDivideByZeroException()
        {
            MiClase miClase = new();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaException))]
        public void ConstructorMiClaseConParametros_CuandoInstanciaMiClaseSinParametros_DeberaDevolverUnaExcepcionConMensaje()
        {
            MiClase miClase = new("Hola");
        }
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void MetodoInstanciaOtraClase_CuandoInstanciaMiClaseConParametros_DeberaDevolverMiExcepcionConMensaje()
        {
            OtraClase otraClase = new();
            otraClase.MetodoInstancia();
        }
    }
}