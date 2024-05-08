namespace I01____Hola__Windows_Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Saludar_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            string titulo = "¡Hola, Windows Forms!";
            string msj = $"Soy {nombre} {apellido}";
            if (Validar(nombre, apellido))
            {
                Hide();
                Form2 formSaludo = new Form2(titulo, msj);
                DialogResult result = formSaludo.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    ShowDialog();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool Validar(string nombre, string apellido)
        {
            if (!(string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(apellido)))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Campos vacios");
            }
            return false;
        }
    }
}
