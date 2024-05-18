using EntidadesRegistrate;
using System.Text;

namespace I02___Registrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Paises.Items.Add("Argentina");
            Paises.Items.Add("Chile");
            Paises.Items.Add("Uruguay");
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string nombre;
            string direccion;
            int edad;
            string genero = string.Empty;
            string[] cursos = new string[3];
            string? pais;

            if (!string.IsNullOrEmpty(txt_Nombre.Text) && !string.IsNullOrEmpty(txt_Direccion.Text))
            {
                nombre = txt_Nombre.Text;
                direccion = txt_Direccion.Text;
                edad = (int)nud_Edad.Value;
                foreach (Control item in gb_Genero.Controls)
                {
                    if (item is RadioButton && ((RadioButton)item).Checked)
                    {
                        genero = item.Text;
                    }
                }
                foreach (Control item in gb_Cursos.Controls)
                {
                    if (item is CheckBox && ((CheckBox)item).Checked)
                    {
                        int indexLibre = BuscarLibre(cursos);
                        if (indexLibre != -1)
                        {
                            cursos[indexLibre] = item.Text;
                        }
                    }
                }

                if (Paises.SelectedIndex != -1)
                {
                    pais = Paises.SelectedItem.ToString();
                    Ingresante ingresante = new(nombre, direccion, genero, pais, cursos, edad);
                    MessageBox.Show(ingresante.Mostrar());
                }          
            }
            else
            {
                MessageBox.Show("Campos vacios");
            }
        }
        private int BuscarLibre(string[] cursos)
        {
            for (int i = 0; i < cursos.Length; i++)
            {
                if (cursos[i] is null)
                {
                    return i;
                }
            }

            return -1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar el programa?","Informacion",MessageBoxButtons.YesNo);
            if (result == DialogResult.No) 
            {
                e.Cancel = true;
            }
        }
    }
}
