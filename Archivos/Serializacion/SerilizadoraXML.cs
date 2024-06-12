using System.Xml.Serialization;

namespace Serializacion
{
    public static class SerilizadoraXML<T>
    {
        static string ruta;
        static SerilizadoraXML()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos-Serializacion1";
        }

        public static void Escribir(List<T> pjs)
        {
            string completa = ruta + @"\SerializadoraLista.xml";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new(completa))
                {
                    XmlSerializer xmlSerializer = new(typeof(List<T>));
                    xmlSerializer.Serialize(sw, pjs);
                }

            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static void Escribir(T pj)
        {
            string completa = ruta + @"\Serializadora.xml";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new(completa))
                {
                    XmlSerializer xmlSerializer = new(typeof(T));
                    xmlSerializer.Serialize(sw, pj);
                }
                
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
        public static List<T> LeerLista()
        {
            string completa = ruta + @"\SerializadoraLista.xml";
            List<T> pjs = null;
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamReader sr = new(completa))
                {
                    XmlSerializer xmlSerializer = new(typeof(List<T>));
                    pjs = xmlSerializer.Deserialize(sr) as List<T>;
                }               
                return pjs;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static T Leer()
        {
            string completa = ruta + @"\Serializadora.xml";
            T pj = default;
            try
            {
                if (Directory.Exists(ruta))
                {
                    using (StreamReader sr = new(completa))
                    {
                        XmlSerializer xmlSerializer = new(typeof(T));
                        pj = (T)xmlSerializer.Deserialize(sr);
                    }
                }
                return pj;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
    }
}
