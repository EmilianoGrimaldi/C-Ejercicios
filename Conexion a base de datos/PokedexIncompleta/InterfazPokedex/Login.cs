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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new(SeleccionarEntrenador());
            frmPrincipal.ShowDialog();
        }

        private string SeleccionarEntrenador()
        {
            string entrenador = string.Empty;
            if (rdbAsh.Checked)
            {
                entrenador = rdbAsh.Text;
            }
            else if (rdbBrock.Checked)
            {
                entrenador = rdbBrock.Text;
            }
            else
            {
                entrenador = rdbMisty.Text;
            }

            return entrenador;
        }
    }
}
