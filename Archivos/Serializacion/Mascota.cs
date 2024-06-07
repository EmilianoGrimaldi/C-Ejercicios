using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public class Mascota
    {
        string nombre;
        string raza;
        int edad;
        bool peloCorto;
        bool esPerro;
        List<string> comidas;

        public Mascota(string nombre, string raza, int edad, bool peloCorto, bool esPerro, List<string> comidas)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
            this.peloCorto = peloCorto;
            this.esPerro = esPerro;
            this.comidas = comidas;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public int Edad { get => edad; set => edad = value; }
        public bool PeloCorto { get => peloCorto; set => peloCorto = value; }
        public bool EsPerro { get => esPerro; set => esPerro = value; }
        public List<string> Comidas { get => comidas; set => comidas = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Raza: {raza}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"Pelo corto: {peloCorto}");
            sb.AppendLine($"Es perro: {esPerro}");
            foreach (var item in comidas)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
