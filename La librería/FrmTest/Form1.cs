using Entidades;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;

namespace FrmTest
{
    public partial class FrmTest : Form
    {
        Vendedor vendedor;
        public FrmTest()
        {
            InitializeComponent();
            vendedor = new("Don Pepito");
        }

        private void TesterApp_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);
            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.ObtenerInformeDeVentas(vendedor);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string resultadoVenta = string.Empty;
            if (lstStock.SelectedIndex != -1)
            {
                if(vendedor + (Publicacion)lstStock.SelectedItem)
                {
                    resultadoVenta = "Venta exitosa";
                }
                else
                {
                    resultadoVenta = "No hay stock";
                }
                MessageBox.Show(resultadoVenta);
            }
        }
        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro que desea salir?", "Cierre de programa", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
