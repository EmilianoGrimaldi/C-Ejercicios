namespace I02ContabilidadEntidades
{
    public class Documento
    {
        int numero;

        public Documento(int numero)
        {
            this.numero = numero;
        }

        public int Numero { get => numero; }
    }
}
