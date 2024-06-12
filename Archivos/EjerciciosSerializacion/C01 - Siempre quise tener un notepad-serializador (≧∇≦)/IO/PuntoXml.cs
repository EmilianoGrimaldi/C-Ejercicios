using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IO
{
    public class PuntoXml<T> : Archivo,IArchivo<T> where T : class
    {
        protected override string Extension
        {
            get
            {
                return ".xml";
            }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (base.ValidarSiExisteElArchivo(ruta))
            {
                using (StreamWriter sb = new(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sb, contenido);
                }
            }          
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (base.ValidarExtension(ruta))
            {
                using (StreamWriter sb = new(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sb, contenido);
                }
            }
            
        }

        public T Leer(string ruta)
        {
            if (base.ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader sr = new(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    return xmlSerializer.Deserialize(sr) as T;
                }
            }
            return default;
        }
    }
}
