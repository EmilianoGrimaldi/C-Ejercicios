using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EntidadesCentralita
{
    public class Local : Llamada, IGuardar<Local>
    {
        private float costo;

        public Local(string origen, float duracion, string destino, float costo):base(duracion,destino, origen)
        {
            this.costo = costo;
        }
        public Local():this("12345678",0, "87654321",0)
        {
            
        }
        public Local(float costo, Llamada llamada):this(llamada.NroOrigen, llamada.Duracion,llamada.NroDestino,costo)
        {

        }
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        string IGuardar<Local>.RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public new string NroOrigen { get => nroOrigen; set => nroOrigen = value; }
        public new string NroDestino { get => nroDestino; set => nroDestino = value; }
        public new float Duracion { get => duracion; set => duracion = value;  }
        public float Costo { get => costo; set => costo = value; }
        private float CalcularCosto()
        {
            //CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma.
            return duracion * costo;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Llamada Local");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo llamada: {costo}");
            sb.AppendLine($"Costo total: {CostoLlamada}");

            return sb.ToString();
        }
        public override bool Equals(object? obj)
        {
            return obj is Local;
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

                string archivoName = Path.Combine(path,"Local.xml");
                using (StreamWriter sw = new(archivoName))
                {                 
                    XmlSerializer serializer = new XmlSerializer(typeof(Local));
                    serializer.Serialize(sw,this);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo serializar", ex);
            }
        }

        public Local Leer()
        {
            Local deserializado = default;
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "llamadas");
                string archivoName = Path.Combine(path, "Local.xml");

                if (File.Exists(archivoName))
                {
                    using (StreamReader sr = new(archivoName))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Local));
                        deserializado = serializer.Deserialize(sr) as Local;
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
                throw new Exception("No se pudo deserealizar",ex);
            }    
        }
    }
}
