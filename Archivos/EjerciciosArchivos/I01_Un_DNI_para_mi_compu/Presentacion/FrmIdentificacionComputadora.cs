using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text = $"Compu de {Environment.UserName}";
            ConfigurarLogoSistemaOperativo();
            lblSistemaOperativo.Text = $"Sistema operativo: {Environment.OSVersion} {Environment.Version}";
            lblNombreMaquina.Text = $"Nombre de la máquina: {Environment.MachineName}";
            ConfigurarArquitectura();
            lblCantProcesadores.Text = $"Cant. procesadores: {Environment.ProcessorCount} procesadores lógicos";
            lblDirectorioActual.Text = $"Identificación ejecutada en: {Environment.NewLine} {Environment.CurrentDirectory}";
            ConfigurarEspacioTotalYDisponible();
        }
        private void ConfigurarLogoSistemaOperativo()
        {
            if(OperatingSystem.IsWindows())
            {
                picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
            else
            {
                if (OperatingSystem.IsLinux())
                {
                    picboxSistemaOperativo.Image = Properties.Resources.linux;
                }
                else
                {
                    if (OperatingSystem.IsMacOS())
                    {
                        picboxSistemaOperativo.Image = Properties.Resources.mac;
                    }
                }
            }
        }
        private void ConfigurarArquitectura()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                lblArquitectura.Text = "Arquitectura: 32 bits";
            }
        }
        private void ConfigurarEspacioTotalYDisponible()
        {
            decimal bytesTotales = 0;
            decimal bytesDisponibles = 0;
            foreach (var item in DriveInfo.GetDrives())
            {
                bytesTotales += item.TotalSize;
                bytesDisponibles += item.AvailableFreeSpace;
            }
            //decimal resultado = (bytesTotales * 1 * 1 * 1) / (1024 * 1024 * 1024);
            decimal espacioTotal = bytesTotales * ((decimal)9.31f * (decimal)Math.Pow(10, -10));
            decimal espacioDisponible = bytesDisponibles * ((decimal)9.31f * (decimal)Math.Pow(10, -10));
            lblEspacioTotal.Text = $"Espacio total: {Math.Round(espacioTotal)} Gigabytes";
            lblEspacioDisponible.Text = $"Espacio disponible: {Math.Round(espacioDisponible)} Gigabytes";
        }
    }
}
