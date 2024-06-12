using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacion
{
    public class SerializacionJSON<T>
    {
        static string ruta;
        static SerializacionJSON()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos-Serializacion1";
        }

        public static void Escribir(T m)
        {
            string completa = ruta + @"\Serializadora.json";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string objetoJson = JsonSerializer.Serialize(m);
                File.WriteAllText(completa, objetoJson);

            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static T Leer()
        {
            string completa = ruta + @"\Serializadora.json";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string objetoJson = File.ReadAllText(completa);
                return JsonSerializer.Deserialize<T>(objetoJson);

            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

    }
}
