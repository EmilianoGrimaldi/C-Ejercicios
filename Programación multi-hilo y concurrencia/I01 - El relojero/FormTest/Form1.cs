using Entidades;
using static System.Net.Mime.MediaTypeNames;

namespace FormTest
{
    public partial class Form1 : Form
    {
        Temporizador temporizador;
        public Form1()
        {
            InitializeComponent();
        }
        //private void AsignarHora()
        //{
        //    lbl_Hora.Text = DateTime.Now.ToString();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            temporizador = new(1000);
            temporizador.TiempoCumplido += ()=> AsignarHora(lbl_Hora);
            //ActualizarHoraConHilos();
        }

        //private void AsignarHora(object sender, EventArgs e)
        //{
        //    lbl_Hora.Text = DateTime.Now.ToString();

        //}
        private void ActualizarHoraConHilos()
        {
            Task task = Task.Run(ActualizarHora);
        }
        private void ActualizarHora()
        {
            do
            {
                AsignarHora(lbl_Hora);
            } while (true);
        }
        private void AsignarHora(Label label)
        {
            if (InvokeRequired)
            {
                Action<Label> delegadoAsignarHora = AsignarHora;
                lbl_Hora.Invoke(delegadoAsignarHora, label);
            }
            else
            {
                label.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }

        private void btn_Detener_Click(object sender, EventArgs e)
        {
            temporizador.DetenerTemporizador();          
        }

        //private void ActualizarHoraTimer()
        //{
        //    reloj.Interval = 1000;
        //    reloj.Tick += new EventHandler(AsignarHora);
        //    reloj.Start();
        //}
    }
}
