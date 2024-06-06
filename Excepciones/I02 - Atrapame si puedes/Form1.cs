namespace I02___Atrapame_si_puedes
{
    public partial class formCalculador : Form
    {
        public formCalculador()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtKilometros.Text) && !string.IsNullOrEmpty(txtLitros.Text))
                {
                    int kilometros = int.Parse(txtKilometros.Text);
                    int litros = int.Parse(txtLitros.Text);
                    float resultado = Calculador.Calcular(kilometros, litros);
                    rtbResultado.Text = resultado.ToString();
                }
                else
                {
                    throw new ParametrosVaciosExcepcion();
                }
            }
            catch (ParametrosVaciosExcepcion)
            {
                MessageBox.Show("Hay campos vacios en el formulario", "Parametros Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            { 
                MessageBox.Show("No se pudo convertir el string en entero", "Error de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No es posible dividir por 0", "Error en el divisor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
