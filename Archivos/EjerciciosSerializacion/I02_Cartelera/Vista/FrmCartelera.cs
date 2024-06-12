using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;
        static string nombreArchivo;
        static string rutaCompleta;
        string rutaActual;
        Cartel cartel;
        public FrmCartelera()
        {
            InitializeComponent();
            colorDialog.Color = pnlCartel.BackColor;
        }

        static FrmCartelera()
        {
            rutaConfiguracion = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            nombreArchivo = "configuracion.json";
            rutaCompleta = Path.Combine(rutaConfiguracion, nombreArchivo);
        }
        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            ElegirColorPanel(pnlCartel);
        }
        private void ElegirColorPanel(Panel panel)
        {
            if (colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                panel.BackColor = colorDialog.Color;
            }
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            ElegirColorLabel(lblTitulo);
        }
        private void ElegirColorLabel(Label label)
        {
            if (colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                label.ForeColor = colorDialog.Color;
            }
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            ElegirColorLabel(lblMensaje);
        }
        private Cartel LeerJson(string ruta)
        {
            if (Directory.Exists(rutaConfiguracion))
            {
                try
                {
                    if (File.Exists(ruta))
                    {
                        string objetoJson = File.ReadAllText(ruta);
                        return JsonSerializer.Deserialize<Cartel>(objetoJson);
                    }
                }
                catch (Exception ex)
                {
                    MostrarErrores(ex);
                }

            }
            return null;
        }

        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            cartel = LeerJson(rutaCompleta);
            RefrescarCartel();
        }

        private void RefrescarCartel()
        {
            if (cartel != null)
            {
                pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                txtTitulo.Text = cartel.Titulo.Contenido;
                lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                rtxtMensaje.Text = cartel.Mensaje.Contenido;
                lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
            }
        }
        private Cartel CrearCartel()
        {
            Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
            Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
            return new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje); ;
        }

        private void CrearJson(Cartel cartel)
        {
            if (Directory.Exists(rutaConfiguracion))
            {
                try
                {
                    string objetoJson = JsonSerializer.Serialize(cartel);
                    File.WriteAllText(rutaCompleta, objetoJson);
                    rutaActual = rutaCompleta;
                }
                catch (Exception ex)
                {
                    MostrarErrores(ex);
                }

            }
        }
        private void MostrarErrores(Exception ex)
        {  
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(ex.Message);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(ex.StackTrace);
            MessageBox.Show(stringBuilder.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);  
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            Cartel cartel = CrearCartel();
            CrearJson(cartel);
        }

        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            ImportarArchivo();
        }
        private void ImportarArchivo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Json files(.json)|*.json";
            ofd.ShowDialog();
            rutaActual = ofd.FileName;
            cartel = LeerJson(rutaActual);
            RefrescarCartel();
        }

        private void EstablecerDefault()
        {
            txtTitulo.Text = "Título";
            lblTitulo.ForeColor = Control.DefaultForeColor;

            rtxtMensaje.Text = "Mensaje";
            lblMensaje.ForeColor = Control.DefaultForeColor;

            pnlCartel.BackColor = Control.DefaultBackColor;
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Esta seguro que desea eliminar la configuracion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EstablecerDefault();
                EliminarArchivo(rutaActual);
            }
        }

        private void EliminarArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }
        }
    }
}
