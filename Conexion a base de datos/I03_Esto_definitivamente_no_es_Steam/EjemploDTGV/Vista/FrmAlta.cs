using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAlta : Form
    {
        int codigoJuego;
        Juego juego;
        public FrmAlta(int codigoJuego) : this()
        { 
            btnGuardar.Text = "Modificar";           
            this.codigoJuego = codigoJuego;
            PintarForm();
            cmbUsuarios.Hide();
            lblUsuarios.Text = string.Empty;
        }
        private void PintarForm()
        {   
            juego = JuegoDao.LeerPorId(codigoJuego);
            txtNombre.Text = juego.Nombre;
            txtGenero.Text = juego.Genero;
            nupPrecio.Value = (decimal)juego.Precio;
            nupPrecio.Maximum = 10000;
        }
        public FrmAlta()
        {
            InitializeComponent();
            nupPrecio.Maximum = 10000;
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {    
            cmbUsuarios.DataSource = UsuarioDao.Leer();
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text != "Modificar")
                {
                    Juego nuevoJuego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text,
                    ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);

                    JuegoDao.Guardar(nuevoJuego);
                }
                else
                {
                    Juego nuevoJuego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text, ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario,
                   codigoJuego);

                    JuegoDao.Modificar(nuevoJuego);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
            }
        }
    } 
}
