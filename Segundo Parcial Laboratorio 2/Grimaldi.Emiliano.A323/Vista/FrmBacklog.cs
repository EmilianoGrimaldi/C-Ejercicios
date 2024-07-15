using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Entidades;
using Microsoft.VisualBasic.Logging;

namespace Vista
{
    public partial class FrmBacklog : Form
    {
        private List<Serie> backLog;
        private List<Serie> seriesParaVer;
        private Serializadora serializadora;
        private ManejadorBacklog manejador;

        public FrmBacklog()
        {
            InitializeComponent();
            backLog = AccesoDatos.ObtenerBacklog();
            seriesParaVer = new List<Serie>();
            serializadora = new Serializadora();
            manejador = new ManejadorBacklog();
        }

        /// <summary>
        /// Asigna como manejador del evento NuevaSerieParaVer de manejador al método del formulario CambiarEstadoSerie.
        /// Inicializa la propiedad DataSource de lstbBacklog con el atributo backlog.
        /// Llama al método IniciarManejador de manejador pasándole como argumentos la lista de backlog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBacklog_Load(object sender, EventArgs e)
        {
            manejador.serieParaVer += CambiarEstadoSerie;
            lstbBacklog.DataSource = backLog;
            manejador.IniciarManejador(backLog);
        }

        /// <summary>
        /// Sale del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Serializa a XML la lista de backLog y en JSON la lista de seriesParaVer. La ruta de destino es el escritorio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerializar_Click(object sender, EventArgs e)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaJson = Path.Combine(rutaEscritorio, "SeriesParaVer.json");
            string rutaXml = Path.Combine(rutaEscritorio, "Backlog.xml");

            try
            {
                serializadora.Guardar(backLog, rutaXml);
                ((IGuardar<List<Serie>>)serializadora).Guardar(seriesParaVer, rutaJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Recibe una serie, la agrega a la lista de seriesParaVer y la elimina de la lista de backLog.
        /// Actualiza los listbox desde el hilo principal que es en el que se crearon los controles.
        /// </summary>
        /// <param name="serie"></param>
        private void CambiarEstadoSerie(Serie serie)
        {
            if (InvokeRequired)
            {
                Action<Serie> delegadoSerie = CambiarEstadoSerie;
                Invoke(delegadoSerie, serie);
            }
            else
            {
                seriesParaVer.Add(serie);
                backLog.Remove(serie);

                ActualizarListBox(lstbBacklog, backLog);
                ActualizarListBox(lstbParaVer, seriesParaVer);
            }
        }

        /// <summary>
        /// Actualiza un listbox pasado por parámetro, asignandole al data source el valor de una lista pasada por parámetro.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="lista"></param>
        private void ActualizarListBox(ListBox lb, List<Serie> series)
        {
            lb.DataSource = null;
            lb.DataSource = series;
        }
    }
}
