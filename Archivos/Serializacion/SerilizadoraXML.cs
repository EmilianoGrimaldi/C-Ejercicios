using System.Xml.Serialization;

namespace Serializacion
{
    public static class SerilizadoraXML
    {
        static string ruta;
        static SerilizadoraXML()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos-Serializacion1";
        }

        public static void Escribir(List<Personaje> pjs)
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
                    XmlSerializer xmlSerializer = new(typeof(List<Personaje>));
                    xmlSerializer.Serialize(sw, pjs);
                }

            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static void Escribir(Personaje pj)
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
                    XmlSerializer xmlSerializer = new(typeof(Personaje));
                    xmlSerializer.Serialize(sw, pj);
                }
                
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
        public static List<Personaje> LeerLista()
        {
            string completa = ruta + @"\SerializadoraLista.xml";
            List<Personaje> pjs = null;
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamReader sr = new(completa))
                {
                    XmlSerializer xmlSerializer = new(typeof(List<Personaje>));
                    pjs = xmlSerializer.Deserialize(sr) as List<Personaje>;
                }               
                return pjs;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static Personaje Leer()
        {
            string completa = ruta + @"\Serializadora.xml";
            Personaje pj = null;
            try
            {
                if (Directory.Exists(ruta))
                {
                    using (StreamReader sr = new(completa))
                    {
                        XmlSerializer xmlSerializer = new(typeof(Personaje));
                        pj = (Personaje)xmlSerializer.Deserialize(sr);
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
