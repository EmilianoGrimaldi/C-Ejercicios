using System.Text;

namespace I02Entidades
{
    public abstract class Paquete: IAduana
    {
        string codigoSeguimiento;
        protected decimal costoEnvio;
        string destino;
        string origen;
        double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }
        public abstract bool TienePrioridad { get; }

        public decimal Impuestos
        {
            get
            {
                return (35 * costoEnvio) / 100;
            }
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            string aux = "No tiene prioridad";
            if (TienePrioridad)
            {
                aux = "Tiene prioridad";
            }
            sb.AppendLine($"Codigo de seguimiento: {codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: ${costoEnvio}");
            sb.AppendLine($"Destino: {destino}");
            sb.AppendLine($"Origen: {origen}");
            sb.AppendLine($"Peso: {pesoKg}Kg");
            sb.AppendLine($"{aux}");
            return sb.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            return costoEnvio + Impuestos;
        }
    }
}
