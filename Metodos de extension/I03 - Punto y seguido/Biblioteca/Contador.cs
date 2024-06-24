namespace Biblioteca
{
    public static class Contador
    {
        public static string ContarSignosPuntuacion(this string texto)
        {
            int contadorPuntos = 0;
            int contadorComas = 0;
            int contadorPuntoComa = 0;

            foreach (char caracter in texto)
            {
                if (caracter == '.')
                {
                    contadorPuntos++;
                }
                else if (caracter == ',')
                {
                    contadorComas++;
                }
                else if (caracter == ';')
                {
                    contadorPuntoComa++;
                }
            }
            return $"El texto ingresado contiene\nPuntos: {contadorPuntos}\nComas: {contadorComas}\nPuntoYComa: {contadorPuntoComa}"; 
        }
    }
}
