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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string str)
        {
            lbl_Nombre.Text = str;
        }
    }
}
