using System.Text;

namespace EntidadesEnciendanSusMotores
{
    public class AutoF1
    {
        short cantidadCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {          
            this.numero = numero;
            this.escuderia = escuderia;
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public string MostrarDatos()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"Numero: {numero}");
            sb.AppendLine($"En competencia: {enCompetencia}");
            sb.AppendLine($"Cantidad de combustible: {cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");
            return sb.ToString();
        }
        public static bool operator ==(AutoF1 v1, AutoF1 v2)
        {
            return (v1.escuderia == v2.escuderia) && (v1.numero == v2.numero);
        }
        public static bool operator !=(AutoF1 v1, AutoF1 v2)
        {
            return !(v1 == v2);
        }
    }
}
