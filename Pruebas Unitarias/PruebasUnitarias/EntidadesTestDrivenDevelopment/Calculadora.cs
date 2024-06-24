using System.Text.RegularExpressions;

namespace EntidadesTestDrivenDevelopment
{
    public static class Calculadora
    {
        public static int Add(string numeros)
        {
            
            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }
            
            string delimitador = ",";
            if (numeros.StartsWith("//"))
            {
                int delimitadorIndex = numeros.IndexOf('\n');
                delimitador = numeros.Substring(2, delimitadorIndex - 2);
                numeros = numeros.Substring(delimitadorIndex + 1);
            }

            string[] numSeparados = Regex.Split(numeros, $"[\n{Regex.Escape(delimitador)}]");
            int suma = 0;
            var numerosNegativos = numSeparados.Where(p => int.Parse(p) < 0).ToList();

            if (numerosNegativos.Any())
            {
                throw new NegativoNoPermitidoException($"Negativos no permitidos: {string.Join(", ", numerosNegativos)}");
            }

            foreach (string parte in numSeparados)
            {
                if (!string.IsNullOrEmpty(parte))
                {
                    suma += int.Parse(parte);
                }
            }

            return suma;
        }
    }
}
