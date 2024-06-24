namespace Entidades
{
    public static class Extension
    {
        public static string FizzBuzz(this int numero)
        {
            bool divisibleCinco = numero % 5 == 0;
            bool divisibleTres = numero % 3 == 0;
            if (divisibleCinco && divisibleTres)
            {
                return "FizzBuzz".ToLower();
            }
            else if (divisibleCinco)
            {
                return "Buzz".ToLower();
            }
            else if (divisibleTres)
            {
                return "Fizz".ToLower();
            }
            else
            {
                return numero.ToString();
            }
        }
    }
}
