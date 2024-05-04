using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEnciendanSusMotores
{
    public class MotoCross : VehiculoDeCarrera
    {
        short cilindrada;

        public MotoCross(string escuderia, short numero) : base(escuderia, numero)
        {
        }
        public MotoCross(string escuderia, short numero, short cilindrada): base(escuderia,numero)
        { 
            this.cilindrada = cilindrada;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Cilindradas -> {cilindrada}");
            return sb.ToString();
        }
        public short Cilindrada { get => cilindrada; set => cilindrada = value; }
        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return (m1.escuderia == m2.escuderia) && (m1.numero == m2.numero) && (m1.cilindrada == m2.cilindrada);
        }
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
