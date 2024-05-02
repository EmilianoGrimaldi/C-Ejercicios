using System.Text;

namespace EntidadesEnciendanSusMotores
{
    public class AutoF1
    {
        short cantidadCombustible;
        bool enCompetencia;
        short vueltasRestantes;
        string escuderia;
        short numero;

        private AutoF1(short cantidadCombustible, bool enCompetencia, short vueltasRestantes)
        {
            this.cantidadCombustible = cantidadCombustible;
            this.enCompetencia = enCompetencia;
            this.vueltasRestantes = vueltasRestantes;
        }
        public AutoF1(short numero, string escuderia):this(0,false,0)
        {   
            this.numero = numero;
            this.escuderia = escuderia;          
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public string MostrarDatos()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero -> {numero}");
            sb.AppendLine($"Escuderia -> {escuderia}");
            sb.AppendLine($"Vueltas restantes -> {vueltasRestantes}");
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2) 
        {
            return (a1.escuderia == a2.escuderia) && (a1.numero == a2.numero);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
