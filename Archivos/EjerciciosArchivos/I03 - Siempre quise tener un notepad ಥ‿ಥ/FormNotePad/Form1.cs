using Entidades;
using System.Numerics;
namespace FormNotePad
{
    public partial class frmNotePad : Form
    {
        public frmNotePad()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    Stream archivoAbierto = openFileDialog.OpenFile();
                    using (StreamReader sr = new(archivoAbierto))
                    {
                        string lines;
                        richTextBox1.Text = sr.ReadToEnd();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show(new Exception($"Error en el archivo").ToString());
                }
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{richTextBox1.Text.Length} caracteres";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();         
            saveFileDialog.Filter = "Archivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(new Exception($"Error en el archivo").ToString());
                }
            }
        }
    }
}
