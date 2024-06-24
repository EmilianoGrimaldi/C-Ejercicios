using EntidadesCentralita;
using EntidadesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EntidadesCentralita.Provincial;

namespace C01___La_centralita_Episodio_II
{
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        int focusTxt;
        Franja franjas;
        TipoLlamada tipoLlamada;
        public FrmLlamador(Centralita centralita, FrmMenu frmMenu)
        {
            InitializeComponent();
            this.centralita = centralita;
            StartPosition = frmMenu.StartPosition;
        }

        public Centralita Centralita
        {
            get
            {
                return centralita;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Franja));
            // Lectura    
            Enum.TryParse<Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }

        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir del llamador?", "Cierre de programa", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            Escribir(btnUno.Text);
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            Escribir(btnDos.Text);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            Escribir(btnTres.Text);
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            Escribir(btnCuatro.Text);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            Escribir(btnCinco.Text);
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            Escribir(btnSeis.Text);
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            Escribir(btnSiete.Text);
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            Escribir(btnOcho.Text);
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            Escribir(btnNueve.Text);
        }

        private void btnAterisco_Click(object sender, EventArgs e)
        {
            Escribir(btnAterisco.Text);
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            Escribir(btnCero.Text);
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            Escribir(btnNumeral.Text);
        }

        private void Escribir(string tecla)
        {
            if (focusTxt == 1)
            {
                txtNroDestino.Text += tecla;
                if (txtNroDestino.Text[0] == '#')
                {
                    cmbFranja.Enabled = true;
                    tipoLlamada = TipoLlamada.Provincial;
                }
                else
                {
                    cmbFranja.Enabled = false;
                    tipoLlamada = TipoLlamada.Local;
                }
            }

            if (focusTxt == 2)
            {
                txtNroOrigen.Text += tecla;
            }

        }
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random randomDuracion = new Random();
            float duracionLlamada = randomDuracion.Next(1, 51);

            if (!string.IsNullOrEmpty(txtNroDestino.Text) && !string.IsNullOrEmpty(txtNroOrigen.Text))
            {
                if (tipoLlamada == TipoLlamada.Provincial)
                {
                    Provincial llamada = new Provincial(txtNroOrigen.Text, franjas, duracionLlamada, txtNroDestino.Text);
                    try
                    {
                        if (centralita + llamada)
                        {
                            ProvincialDAO.Guardar(llamada);
                            MessageBox.Show("Llamada provincial realizada con exito");
                        }
                    }
                    catch (CentralitaExcepcion)
                    {
                        MessageBox.Show("Una de las llamadas ya esta registrada en la centralita", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    Random randomCosto = new Random();
                    double costoLlamada = randomCosto.NextDouble() * (5.6 - 0.5) + 0.5;
                    Local llamada = new Local(txtNroOrigen.Text, duracionLlamada, txtNroDestino.Text, (float)costoLlamada);
                    try
                    {
                        if (centralita + llamada)
                        {
                            LocalDAO.Guardar(llamada);
                            MessageBox.Show("Llamada local realizada con exito");
                        }
                    }
                    catch (CentralitaExcepcion)
                    {
                        MessageBox.Show("Una de las llamadas ya esta registrada en la centralita", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                 
                }
            }
            else
            {
                MessageBox.Show("Numero de destino y de origen no deben estar vacios","Campos vacios", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Clear();
            txtNroOrigen.Clear();
            cmbFranja.Enabled = true;
            tipoLlamada = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNroDestino_Click(object sender, EventArgs e)
        {
            focusTxt = 1;
        }

        private void txtNroOrigen_Click(object sender, EventArgs e)
        {
            focusTxt = 2;
        }
    
    }
}
