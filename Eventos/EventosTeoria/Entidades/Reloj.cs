namespace Entidades
{
    public class Reloj
    {
        public delegate void NotificadorCambioTiempo(Reloj reloj, InfoTiempoEventArgs infoTiempo);

        public event NotificadorCambioTiempo SegundoCambiado;

        int hora;
        int minuto;
        int segundo;
        public void Ejecutar()
        {
            for (; ; )
            {
                // duerme la ejecucion 100 milisengundos
                Thread.Sleep(100);

                // obtiene hora actual
                DateTime dt = DateTime.Now;
                // si los segundos cambian
                // notifica a los suscriptores
                if (dt.Second != segundo)
                {
                    // crea una instancia de InfoTiempoEventArgs
                    // para pasar al suscriptor
                    InfoTiempoEventArgs infoTiempo = new InfoTiempoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    // verifico que haya suscriptores al evento
                    if (SegundoCambiado is not null)
                    {
                        SegundoCambiado.Invoke(this, infoTiempo);
                    }
                }

                // actualizo el estado del objeto Reloj
                this.hora = dt.Hour;
                this.minuto = dt.Minute;
                this.segundo = dt.Second;
            }
        }
    }
}
