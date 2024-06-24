using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmBiblioteca : Form
    {
        string usuario;
        string genero;
        string juego;
        int codigoJuego;
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = JuegoDao.Leer();
            dtgvBiblioteca.Refresh();
            dtgvBiblioteca.Update();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;
            JuegoDao.Eliminar(biblioteca.CodigoJuego);
            RefrescarBiblioteca();                 
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();
            DialogResult res = frmAlta.ShowDialog();
            if (res == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;
            FrmAlta frmAlta = new FrmAlta(biblioteca.CodigoJuego);
            DialogResult res = frmAlta.ShowDialog();
            if (res == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }          
        }
    }
}
