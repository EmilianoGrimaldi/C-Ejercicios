using EntidadesMiPrimerCrud;

namespace MiCrudForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Actualizar()
        {
            lstPersonas.DataSource = PersonaDAO.Leer();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona persona = ((Persona)lstPersonas.SelectedValue);
            if (!string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtNombre.Text))
            {
                persona.Apellido = txtApellido.Text;
                persona.Nombre = txtNombre.Text;
                PersonaDAO.Modificar(persona);
                Actualizar();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtNombre.Text))
            {
                PersonaDAO.Guardar(new(txtNombre.Text, txtApellido.Text));
                Actualizar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona persona = ((Persona)lstPersonas.SelectedValue);
            PersonaDAO.Eliminar(persona.Id);
            Actualizar();
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            Persona persona = ((Persona)lstPersonas.SelectedValue);
            txtApellido.Text = persona.Apellido;
            txtNombre.Text = persona.Nombre;
        }
    }
}
