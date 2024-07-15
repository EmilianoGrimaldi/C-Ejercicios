namespace Entidades
{
    public delegate void DelegadoBacklog(Serie ciudadano);
    public class ManejadorBacklog
    {
        public event DelegadoBacklog serieParaVer;
        public void IniciarManejador(List<Serie> series)
        {
            Task task = Task.Run(() =>
            {
                MoverSeries(series);
            });
        }

        private void MoverSeries(List<Serie> series)
        {
            if (series is not null)
            {
                while (true)
                {
                    for (int i = 0; i < series.GenerarRandom(); i++)
                    {
                        if (series[i] is not null)
                        {
                            AccesoDatos.ActualizarSerie(series[i]);  
                            Thread.Sleep(1500);
                            serieParaVer.Invoke(series[i]);
                        }
                    }                      
                }             
            }
        }
    }
}
