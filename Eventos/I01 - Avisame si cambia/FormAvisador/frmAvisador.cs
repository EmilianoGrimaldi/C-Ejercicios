using Biblioteca;

namespace FormAvisador
{
    public partial class frmAvisador : Form
    {
        Persona persona;
        public frmAvisador()
        {
            InitializeComponent();
        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (persona is null)
            {
                if (!string.IsNullOrEmpty(txt_Apellido.Text) && !string.IsNullOrEmpty(txt_Nombre.Text))
                {
                    persona = new(txt_Apellido.Text, txt_Nombre.Text);
                    btn_Crear.Text = "Actualizar";
                    persona.EventoString += NotificarCambio;
                    persona.EventoStringMsg($"Se modifico el nombre: {persona.Nombre} y el apellido: {persona.Apellido}");
                    lbl_NombreApellido.Text = persona.Mostrar();
                }
            }
            else
            {
                persona.Nombre = txt_Nombre.Text;
                persona.Apellido = txt_Apellido.Text;
                lbl_NombreApellido.Text = persona.Mostrar();
            }       
        }
    }
}
