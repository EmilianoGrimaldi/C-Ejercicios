using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazPokedex
{
    public partial class FrmPrincipal : Form
    {
        string entrenador;
        public FrmPrincipal(string entrenador)
        {
            InitializeComponent();
            this.entrenador = entrenador;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            SetearEntrenador();
        }
        private void SetearEntrenador()
        {
            if (imageList1.Images.Count > 0 && entrenador == "Ash")
            {
                picEntrenador.Image = imageList1.Images[0];
            }
            else if (imageList1.Images.Count > 0 && entrenador == "Brock")
            {
                picEntrenador.Image = imageList1.Images[1];
            }
            else
            {
                picEntrenador.Image = imageList1.Images[2];
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new(entrenador);
            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                Show();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnPorEntrenador_Click(object sender, EventArgs e)
        {

        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
 
        }

        private void btnPorTipo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPorRango_Click(object sender, EventArgs e)
        {
  
        }

        private void btnPersonalizada_Click(object sender, EventArgs e)
        {
  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
  
        }

        private void btnSerializacion_Click(object sender, EventArgs e)
        {

        }
    }
}
