using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EntidadesCentralita
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;
        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion,destino,origen)
        { 
            franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada):this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
           
        }
        public Provincial():this("12345678",Franja.Franja_1,0,"87654321")
        {
            
        }
        string IGuardar<Provincial>.RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Origen { get => nroOrigen; set => nroOrigen = value; }
        public string Destino { get => nroDestino; set => nroDestino = value; }
        public new float Duracion { get => duracion; set => duracion = value; }
        public Franja FranjaHoraria { get => franjaHoraria; set => franjaHoraria = value; }
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            /*CalcularCosto será privado y retornará el valor de la llamada a partir de la duración y el costo de la misma. Los valores serán:
                Franja_1: 0.99
                Franja_2: 1.25
                Franja_3: 0.66
            */

            if (franjaHoraria is Franja.Franja_1)
            {
                return duracion * 0.99f;
            }
            else if (franjaHoraria is Franja.Franja_2)
            {
                return duracion * 1.25f;
            }
            else if (franjaHoraria is Franja.Franja_3)
            {
                return duracion * 0.66f;
            }

            return -1;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine("Llamada provincial");  
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {CostoLlamada}");
            sb.AppendLine($"Franja horaria: {franjaHoraria}");

            return sb.ToString();
        }
        public override bool Equals(object? obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public bool Guardar()
        {
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "llamadas");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string archivoName = Path.Combine(path, "Provincial.xml");
                using (StreamWriter sw = new(archivoName))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                    serializer.Serialize(sw, this);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo serializar", ex);
            }
        }

        public Provincial Leer()
        {
            Provincial deserializado = default;
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "llamadas");
                string archivoName = Path.Combine(path, "Provincial.xml");

                if (File.Exists(archivoName))
                {
                    using (StreamReader sr = new(archivoName))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                        deserializado = serializer.Deserialize(sr) as Provincial;
                        if (deserializado is null)
                        {
                            throw new InvalidCastException();
                        }
                    }                  
                }

                return deserializado;
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidCastException("No es el tipo esperado", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo deserealizar", ex);
            }
        }
    }   
}
