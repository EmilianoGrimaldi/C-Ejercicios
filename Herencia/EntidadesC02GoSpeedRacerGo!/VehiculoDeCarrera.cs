using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEnciendanSusMotores
{
    public class VehiculoDeCarrera
    {
        protected short cantidadCombustible;
        protected bool enCompetencia;
        protected short vueltasRestantes;
        protected string escuderia;
        protected short numero;

        public VehiculoDeCarrera(string escuderia, short numero)
        {
            this.escuderia = escuderia;
            this.numero = numero;
        }
        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }
        public string Escuderia { get => escuderia; set => escuderia = value; }
        public short Numero { get => numero; set => numero = value; }
        public string MostrarDatos()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero -> {numero}");
            sb.AppendLine($"Escuderia -> {escuderia}");
            sb.AppendLine($"Vueltas restantes -> {vueltasRestantes}");
            return sb.ToString();
        }
        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return (v1.escuderia == v2.escuderia) && (v1.numero == v2.numero);
        }
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
