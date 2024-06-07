using System.Numerics;

namespace EntidadesArchivo
{
    //primer forma
    public static class Archivo
    {
        static string ruta;

        static Archivo() 
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos";
        }

        public static void Escribir()
        {
            string completa = ruta + @"\Laboratorio.txt";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new(completa, true)) //true me agrega texto, el false pisa lo que ya tengo
                {
                    sw.WriteLine("FECHA");
                    sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                }
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
                    string completa = ruta + @"\Laboratorio.txt";

                    using (StreamReader sr = new(completa))
                    {
                        string lines;
                        datos = sr.ReadToEnd(); //lectura completa

                        /*while ((lines = sr.ReadLine()) != null)
                        {
                            datos += "\n" + lines;
                        }*/
                    }
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
