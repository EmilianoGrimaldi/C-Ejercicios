namespace Entidades
{
    public class Temporizador
    {
        CancellationToken cancellationToken;
        CancellationTokenSource cancellationTokenSource;
        Task task;
        int intervalo;

        public delegate void DelegadoTemporizador();
        public event DelegadoTemporizador TiempoCumplido;
        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;         
        }

        public bool EstaActivo
        {
            get
            {
                return task is not null;
                //return hilo is not null &&
                //   (hilo.Status == TaskStatus.Running ||
                //   hilo.Status == TaskStatus.WaitingToRun ||
                //   hilo.Status == TaskStatus.WaitingForActivation);
            }
        }
        public int Intervalo { get => intervalo; set => intervalo = value; }

        public void IniciarTemporizador()
        {
            if (!EstaActivo)
            {
                cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;
                task = Task.Run(CorrerTiempo, cancellationToken);              
            }
            //if (hilo is null || hilo.IsCompleted)
            //{
            //    cancellationTokenSource = new CancellationTokenSource();
            //    cancellationToken = cancellationTokenSource.Token;

            //    hilo = new Task(CorrerTiempo, cancellationToken);
            //}

            //if (!EstaActivo)
            //{
            //    hilo.Start();
            //}
        }

        public void DetenerTemporizador()
        {
            if (EstaActivo)
            {
               cancellationTokenSource.Cancel();
                task = null;
            }
            //if (hilo is not null && !hilo.IsCompleted)
            //{
            //    cancellationTokenSource.Cancel();
            //}
        }
        void CorrerTiempo()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                if (TiempoCumplido is not null)
                {
                    TiempoCumplido.Invoke();
                    Thread.Sleep(intervalo);       
                }
            }
        }
    }
}
