using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmTestDelegados : Form
    {
       
        public delegate void MiDelegado(string nombre);
        MiDelegado miDelegado;
        public FrmTestDelegados(MiDelegado metodo)
        {
            InitializeComponent();
            miDelegado = metodo;
            // Guardar la referencia al formulario principal
        }
        public FrmTestDelegados()
        {
            InitializeComponent();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {   
            miDelegado.Invoke(txt_Nombre.Text);
        }
    }
}
