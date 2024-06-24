using EntidadesCentralita;

namespace C01___La_centralita_Episodio_II
{
    public partial class FrmMenu : Form
    {
        Centralita c;
        FrmMostrar frmMostrar;
        FrmLlamador frmLlamador;
        TipoLlamada tipoLlamada;
        public FrmMenu()
        {
            InitializeComponent();
            c = new Centralita();
        }

        public TipoLlamada TipoLlamada
        {
            set
            {
                tipoLlamada = value;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la centralita?", "Cierre de programa", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            Hide();
            frmLlamador = new FrmLlamador(c, this);
            DialogResult result = frmLlamador.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            if (frmLlamador is not null)
            {
                Hide();
                tipoLlamada = TipoLlamada.Todas;
                frmMostrar = new(frmLlamador.Centralita, this, tipoLlamada.ToString());
                DialogResult result = frmMostrar.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Show();
                }
            }
            else
            {
                MessageBox.Show("No hay llamadas para mostrar", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            if (frmLlamador is not null)
            {
            Hide();
            tipoLlamada = TipoLlamada.Local;
            frmMostrar = new(frmLlamador.Centralita, this, tipoLlamada.ToString());
            DialogResult result = frmMostrar.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Show();
                }
            }
            else
            {
                MessageBox.Show("No hay llamadas para mostrar", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            if (frmLlamador is not null)
            {
                Hide();
                tipoLlamada = TipoLlamada.Provincial;
                frmMostrar = new(frmLlamador.Centralita, this, tipoLlamada.ToString());
                DialogResult result = frmMostrar.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Show();
                }
            }
            else
            {
                MessageBox.Show("No hay llamadas para mostrar","Informacion",MessageBoxButtons.OK);
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
