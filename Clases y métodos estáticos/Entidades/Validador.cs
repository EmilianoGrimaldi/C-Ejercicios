using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min & valor <= max;
        }
        public static bool ValidarRespuesta(string respuesta)
        {
            return respuesta.ToUpper() == "S";
        }
    }

    public class Calculadora
    {
        public static double Calcular(float primerOperando, float segundoOperando, char operador)
        {
            double resultado = 0.0;
            switch (operador)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;
                case '/':
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    break;
            }
            return resultado;
        }
        private static bool Validar(float segundoOperando)
        {
            return segundoOperando != 0;
        }
    }
    public class Tabla
    {
        public static string GenerarTabla(int numero)
        {
            int resultado;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tabla de multiplicar del numero {numero}:");
            for (int i = 1; i <= 9; i++)
            {
                resultado = numero * i;
                sb.AppendLine($"{numero} x {i} = {resultado}");
            }
            return sb.ToString();
        }
    }
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string binario = "";
            while (numeroEntero > 0)
            {
                int resto = numeroEntero % 2;
                binario = resto.ToString() + binario;
                numeroEntero /= 2;
            }

            return binario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int decimalResult = 0;
            int baseValue = 1;

            while (numeroEntero > 0)
            {
                int lastDigit = numeroEntero % 10;
                decimalResult += lastDigit * baseValue;
                numeroEntero = numeroEntero / 10;
                baseValue = baseValue * 2;
            }

            return decimalResult;
        }
    }
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double basee, double altura)
        {
            return (basee * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
    public class Pitagoras
    {
        public static double Calcular(double catetoA, double catetoB)
        {
            return Math.Sqrt(Math.Pow(catetoA,2) + Math.Pow(catetoB,2));
        }
    }
    public class CalculadoraDeTiempo
    {
        public static int CalcularDias(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Today;
            return fechaActual.Subtract(fecha).Days;
        }
    }
    public class Factorial

    {
        public static int Calcular(int numero)
        {
            for (int i = numero; i > 1; i--)
            {
                numero *= (i - 1);
            }
            return numero;
        }
    }
}
