using System.Text;

namespace Centralita
{
    enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public float GetDuracion()
        {
            return duracion;
        }

        public string GetNroDestino()
        {
            return nroDestino;
        }

        public string GetNroOrigen()
        {
            return nroOrigen;
        }
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Duracion: {duracion}");
            sb.AppendLine($"Numero de destino: {nroDestino}");
            sb.Append($"Numero de origen: {nroOrigen}");

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return 1;
        }
    }
}
