using System.Text;

namespace EntidadesEnciendanSusMotores
{
    public class AutoF1 : VehiculoDeCarrera
    {
        short caballosDeFuerza;

        public AutoF1(short numero, string escuderia):base(escuderia,numero)
        {              
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
        public short CaballosDeFuerza { get => caballosDeFuerza; set => caballosDeFuerza = value; }

        public string MostrarDatos()
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza -> {caballosDeFuerza}");
            return sb.ToString();
        }
        public static bool operator ==(AutoF1 v1, AutoF1 v2)
        {
            return (v1.escuderia == v2.escuderia) && (v1.numero == v2.numero) && (v1.caballosDeFuerza == v2.caballosDeFuerza);
        }
        public static bool operator !=(AutoF1 v1, AutoF1 v2)
        {
            return !(v1 == v2);
        }
    }
}
