using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListaDelSuperForm
{
    public partial class frmListaDelSuper : Form
    {
        List<string> listaSupermercado;
        static string rutaArchivo;
        public frmListaDelSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
        }
        static frmListaDelSuper()
        {
            string rutaApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            const string nombreArchivo = "listaSupermercado.xml";
            rutaArchivo = Path.Combine(rutaApplicationData, nombreArchivo);
        }
        private void frmListaDelSuper_Load(object sender, EventArgs e)
        {
            AgregarToolTip();
            CargarLista();
            Refrescar();
        }

        private void CargarLista()
        {
            if (Directory.Exists(rutaArchivo))
            {
                using (StreamReader streamReader = new StreamReader(rutaArchivo))
                {
                    try
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                        listaSupermercado = xmlSerializer.Deserialize(streamReader) as List<string>;
                    }
                    catch (Exception ex)
                    {
                        MostrarMensajeDeError(ex);
                    }
                }
            }
        }

        private void AgregarToolTip()
        {
            toolTipBtnAgregar.SetToolTip(btnAgregar, "Agregar objeto");
            toolTipBtnQuitar.SetToolTip(btnQuitar, "Eliminar objeto");
            toolTipBtnModificar.SetToolTip(btnModificar, "Modificar objeto");
        }

        public void Refrescar()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarElemento();
        }

        private void AgregarElemento()
        {
            FrmAltaModificacion frmAM = new FrmAltaModificacion("Agregar objeto", "", "Agregar");
            frmAM.ShowDialog();
            if (frmAM.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frmAM.Objeto);
                AlmacenarCambios();
                Refrescar();
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Quitar();
        }

        private void Quitar()
        {
            if (lstObjetos.SelectedIndex != -1)
            {
                listaSupermercado.RemoveAt(lstObjetos.SelectedIndex);
                Refrescar();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un elemento de la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstObjetos.SelectedIndex != -1)
            {          
                string elementoSeleccionado = lstObjetos.SelectedItem as string;
                FrmAltaModificacion frmAM = new FrmAltaModificacion("Modificar objeto", elementoSeleccionado, "Modificar");
                frmAM.ShowDialog();
                if (frmAM.DialogResult == DialogResult.OK)
                {
                    int indice = listaSupermercado.IndexOf(elementoSeleccionado);
                    listaSupermercado[indice] = frmAM.Objeto;
                    AlmacenarCambios();
                    Refrescar();
                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un elemento de la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AlmacenarCambios()
        {
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                    xmlSerializer.Serialize(streamWriter, listaSupermercado);
                }
                catch (Exception ex)
                {
                    MostrarMensajeDeError(ex);
                }
            }
        }
        private void MostrarMensajeDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(ex.Message);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
