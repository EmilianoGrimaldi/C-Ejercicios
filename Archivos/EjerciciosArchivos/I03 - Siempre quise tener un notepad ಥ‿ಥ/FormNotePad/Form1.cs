using IO;
using System.IO;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
namespace FormNotePad
{
    public partial class frmNotePad : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        string rutaActual;
        PuntoJson<string> json;
        PuntoXml<string> xml;
        PuntoTxt txt;
        public frmNotePad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            json = new();
            xml = new();
            txt = new();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{richTextBox1.Text.Length} caracteres";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void Abrir()
        {   
            DialogResult result = openFileDialog.ShowDialog();
            rutaActual = openFileDialog.FileName;
            if (result == DialogResult.OK)
            {
                try
                {
                    switch (Path.GetExtension(rutaActual))
                    {
                        case ".json":
                            richTextBox1.Text = json.Leer(rutaActual);
                            break;
                        case ".xml":
                            richTextBox1.Text = xml.Leer(rutaActual);
                            break;
                        case ".txt":
                            richTextBox1.Text = txt.Leer(rutaActual);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarErrores(ex);
                }
            }
        }
        private void Guardar()
        {     
            try
            {
                if (rutaActual is null)
                {
                    GuardarComo();
                }
                switch (Path.GetExtension(rutaActual))
                {
                    case ".json":
                        json.Guardar(rutaActual, richTextBox1.Text);
                        break;
                    case ".xml":
                        xml.Guardar(rutaActual, richTextBox1.Text);
                        break;
                    case ".txt":
                        txt.Guardar(rutaActual, richTextBox1.Text);
                        break;
                }              
            }
            catch (Exception ex)
            {
                MostrarErrores(ex);
            }
        }
        private void GuardarComo()
        {
            DialogResult result = saveFileDialog.ShowDialog();
            rutaActual = saveFileDialog.FileName;
            if (result == DialogResult.OK)
            {
                try
                {
                    switch (Path.GetExtension(rutaActual))
                    {
                        case ".json":
                            json.GuardarComo(rutaActual, richTextBox1.Text);
                            break;
                        case ".xml":
                            xml.GuardarComo(rutaActual, richTextBox1.Text);
                            break;
                        case ".txt":
                            txt.GuardarComo(rutaActual, richTextBox1.Text);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarErrores(ex);
                }
            }
        }
        private void MostrarErrores(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error: {ex.Message}");
            sb.AppendLine("Detalle:");
            sb.AppendLine(ex.StackTrace);
            MessageBox.Show(sb.ToString(),"Errores",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

    }
}
