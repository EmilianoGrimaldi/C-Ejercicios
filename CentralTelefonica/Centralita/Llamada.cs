using System.Text;

namespace EntidadesCentralita
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
        public float Duracion { get => duracion;}
        public string NroDestino { get => nroDestino;}
        public string NroOrigen { get => nroOrigen;}
        
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Duracion: {duracion}");
            sb.AppendLine($"Numero de destino: {nroDestino}");
            sb.AppendLine($"Numero de origen: {nroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            //OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para ordenar una lista de llamadas de forma ascendente          
            return (int)(llamada1.duracion - llamada2.duracion);
        }
    }
}
