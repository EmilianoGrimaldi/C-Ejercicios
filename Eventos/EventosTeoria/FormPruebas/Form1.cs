using Entidades;

namespace FormPruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reloj reloj = new Reloj();
            reloj.SegundoCambiado += ActualizarLabel;
            Task.Run(() => 
            {
                reloj.Ejecutar();
            });        
        }

        private void ActualizarLabel(Reloj reloj, InfoTiempoEventArgs info)
        {
            if (InvokeRequired)
            {
                Action<Reloj, InfoTiempoEventArgs> delegadoReloj = ActualizarLabel;
                object[] parametros = new object[] { reloj, info };
                Invoke(delegadoReloj, parametros);
            }
            else
            {
                MostrarCambioTiempo(reloj, info);
            }
        }

        public void MostrarCambioTiempo(object reloj, InfoTiempoEventArgs info)
        {
            lblTiempo.Text = $"{info.Hora}:{info.Minuto}:{info.Segundo}";
        }
    }
}
