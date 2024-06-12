namespace Entidades
{
    public static class Aritmetica
    {
        public static int CalcularPotencia(int numero, int exponente)
        {
            int resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= numero;
            }

            return resultado;
        }
    }
}
