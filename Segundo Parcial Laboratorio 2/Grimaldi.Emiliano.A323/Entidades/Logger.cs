using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Logger
    {
        static string ruta;
        static Logger()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        public static void Log(string mensaje)
        {
            string completa = Path.Combine(ruta,"Errores.txt");
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string datos = $"{mensaje} - {DateTime.Now}";

                File.WriteAllText(completa, datos);
            }
            catch (Exception)
            {
                throw new BacklogException($"Error en el archivo {completa}");
            }
        }
    }
}
