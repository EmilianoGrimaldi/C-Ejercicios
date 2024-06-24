namespace Biblioteca
{
    public static class Contador
    {
        public static int ContadorDigitos(this long numero)
        {
            return numero.ToString().Length;
        }
    }
}
