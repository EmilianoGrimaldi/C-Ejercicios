using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Archivo
    {
        public static void Escribir(string ruta, string texto)
        {
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string datos = texto;

                File.WriteAllText(ruta, datos);
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }
        }

        public static string Leer(string ruta, string nombreArchivo)
        {
            try
            {
                string datos = string.Empty;

                if (Directory.Exists(ruta))
                {
                    string completa = ruta + nombreArchivo;

                    datos = File.ReadAllText(completa);
                    
                }

                return datos;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {ruta}"); ;
            }
        }
    }
}
