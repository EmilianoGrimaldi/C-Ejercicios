namespace Entidades
{
    public class Caja
    {
        static Random random;
        Queue<string> clientesALaEspera;
        string nombreCaja;
        Action<Caja,string> delegadoClienteAtendido;

        static Caja()
        {
            random = new Random();
        }

        public Caja(string nombreCaja, Action<Caja,string> delegadoClienteAtendido)
        {
            this.nombreCaja = nombreCaja;
            clientesALaEspera = new();
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        public string NombreCaja { get => nombreCaja;}

        public int CantidadDeClientesALaEspera
        {
            get
            {
                return clientesALaEspera.Count;
            }
        }
        internal void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            Task task = Task.Run(() => {
                while (true)
                {
                    if (clientesALaEspera.Any())
                    {
                        if (clientesALaEspera.TryDequeue(out string? cliente))
                        {
                            delegadoClienteAtendido?.Invoke(this, cliente);
                            Thread.Sleep(random.Next(1000, 5000));
                        }
                    }
                }
            });
            return task;
        }
    }
}
