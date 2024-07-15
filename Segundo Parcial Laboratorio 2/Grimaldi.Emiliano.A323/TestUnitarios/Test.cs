using Entidades;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TestUnitarios
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void SerializarXML_SerializaUnaListaAXML_DebeCoincidirLaInformacionSinPerdidas()
        {
            List<Serie> series = new List<Serie>(){new("Prueba","Test")};
            Serializadora serializadora = new Serializadora();
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.xml");
            serializadora.Guardar(series, ruta);
            List<Serie> seriesDeserealizada= serializadora.LeerXML(ruta);
            foreach (Serie item in seriesDeserealizada)
            {
                Assert.AreEqual(item.Nombre, series[0].Nombre);
            }          
        }

        [TestMethod]
        public void SerializarJSON_SerializaUnaListaAJSON_DebeCoincidirLaInformacionSinPerdidas()
        {

        }
        [TestMethod]
        [ExpectedException(typeof(BacklogException))]
        public void BackLockException_DevuelveUnaException_DebeTirarBackLockException()
        {
            throw new BacklogException("Probando");
        }
    }
}