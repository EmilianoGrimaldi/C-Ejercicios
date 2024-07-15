using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializadora : IGuardar<List<Serie>>
    {
        public void Guardar(List<Serie> items, string ruta)
        {
            try
            {
                using (StreamWriter sw = new(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Serie>));
                    xmlSerializer.Serialize(sw, items);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                throw new BacklogException("Error en guardar en el xml");
            }
        }
        void IGuardar<List<Serie>>.Guardar(List<Serie> item, string ruta)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    File.CreateText(ruta);
                }
                string json = JsonSerializer.Serialize(item);
                File.WriteAllText(ruta, json);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                throw new BacklogException("Error en guardar en el json");
            }
        }

        public List<Serie> LeerXML(string ruta)
        {
            List<Serie> series = null;
            try
            {           
                using (StreamReader sr = new(ruta))
                {
                    XmlSerializer xmlSerializer = new(typeof(List<Serie>));
                    series = xmlSerializer.Deserialize(sr) as List<Serie>;
                }
                return series;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }
        }

        public List<Serie> LeerJson(string ruta)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    File.Create(ruta);
                }
                string objetoJson = File.ReadAllText(ruta);
                return JsonSerializer.Deserialize<List<Serie>>(objetoJson);

            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }
        }
    }
}
