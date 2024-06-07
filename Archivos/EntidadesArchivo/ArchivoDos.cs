using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesArchivo
{
    //metodo 2
    public static class ArchivoDos
    {
        static string ruta;
        static ArchivoDos()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos";
        }
        public static void Escribir()
        {
            string completa = ruta + @"\Laboratorio2ParteDos" + DateTime.Now.ToString("HH_mm_ss") + ".txt";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string datos = "Hola mundo";

                File.WriteAllText(completa, datos);
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static string Leer()
        {
            try
            {
                string datos = string.Empty;

                if (Directory.Exists(ruta))
                {
                    string completa = ruta + @"\Laboratorio2ParteDos08_10_05.txt";

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
