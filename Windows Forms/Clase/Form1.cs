namespace Clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Saludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA", "Informacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form = new Form2();
            DialogResult resultado = form.ShowDialog();
            if (resultado == DialogResult.Cancel)
            {
                ShowDialog();
            }
        }
    }
}
