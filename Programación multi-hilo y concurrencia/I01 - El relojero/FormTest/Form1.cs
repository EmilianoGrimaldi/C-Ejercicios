using static System.Net.Mime.MediaTypeNames;

namespace FormTest
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts;
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
            ActualizarHoraConHilos();
        }

        //private void AsignarHora(object sender, EventArgs e)
        //{
        //    lbl_Hora.Text = DateTime.Now.ToString();

        //}
        private void ActualizarHoraConHilos()
        {
            Task task = Task.Run(() => ActualizarHora());
        }
        private void ActualizarHora()
        {
            do
            {
                AsignarHora();
                Thread.Sleep(1000);
            } while (true);
        }
        private void AsignarHora()
        {
            if (lbl_Hora.InvokeRequired)
            {
                Action delegadoAsignarHora = AsignarHora;
                lbl_Hora.Invoke(delegadoAsignarHora);
            }
            else
            {
                lbl_Hora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        //private void ActualizarHoraTimer()
        //{
        //    reloj.Interval = 1000;
        //    reloj.Tick += new EventHandler(AsignarHora);
        //    reloj.Start();
        //}
    }
}
