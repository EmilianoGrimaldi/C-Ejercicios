using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoJson<T> : Archivo, IArchivo<T> where T : class
    {
        protected override string Extension
        {
            get
            {
                return ".json";
            }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (base.ValidarSiExisteElArchivo(ruta))
            {
                string json = JsonSerializer.Serialize<T>(contenido);
                File.WriteAllText(ruta, json);
            }
            /*if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }*/
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (base.ValidarExtension(ruta))
            {
                string json = JsonSerializer.Serialize<T>(contenido);
                File.WriteAllText(ruta, json);
            }
            /*if (base.ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }*/
        }
        /*private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                string json = JsonSerializer.Serialize(contenido);
                streamWriter.Write(json);
            }
        }*/
        public T Leer(string ruta)
        {
            if (base.ValidarSiExisteElArchivo(ruta))
            {
                string json = File.ReadAllText(ruta);
                return JsonSerializer.Deserialize<T>(json);
                /*using (StreamReader streamReader = new StreamReader(ruta))
                {
                    string json = streamReader.ReadToEnd();
                    return JsonSerializer.Deserialize<T>(json);
                }*/
            }
            return null;  
        }
    }
}
