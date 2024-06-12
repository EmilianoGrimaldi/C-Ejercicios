namespace ListaDelSuperForm
{
    public partial class FrmAltaModificacion : Form
    {

        public FrmAltaModificacion(string titulo, string texto, string botonConfirmar)
        {
            InitializeComponent();
            Text = titulo;
            txtObjeto.Text = texto;
            btnConfirmar.Text = botonConfirmar;
        }

        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13:
                    Confirmar();
                    break;
                case (char)27:
                    Cancelar();
                    break;    
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        public void MostrarAdvertencia(string advertencia)
        {
            MessageBox.Show(advertencia, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();  
        }

        private void Confirmar()
        {
            if (!string.IsNullOrEmpty(txtObjeto.Text))
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MostrarAdvertencia("No puede estar el campo vacio");
            }
        }
        private void Cancelar()
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
