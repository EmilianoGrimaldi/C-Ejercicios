using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        protected override string Extension
        {
            get
            {
                return ".txt";
            }
        }

        public void Guardar(string ruta, string contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                File.WriteAllText(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            if (ValidarExtension(ruta))
            {
                File.WriteAllText(ruta, contenido);
            }
        }

        public string Leer(string ruta)
        {
            string datos = string.Empty;
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {   
                /*using (StreamReader sr = new(ruta))
                {
                    datos = sr.ReadToEnd();
                }*/
                datos = File.ReadAllText(ruta);
                return datos;
            }
            return datos;
        }
    }
}
