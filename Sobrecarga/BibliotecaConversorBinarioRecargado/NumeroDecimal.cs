using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConversorBinarioRecargado
{
    public class NumeroDecimal
    {
        private double numero;
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        public double Numero
        { 
            get 
            { 
                return this.numero; 
            }
        }
        public string ConvertirDecimalABinario(double numero)
        {
            string valorBinario = string.Empty;
            int resulDiv = (int)numero;
            int restoDiv;

            if (resulDiv >= 0)
            {
                do
                {
                    restoDiv = resulDiv % 2;
                    resulDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario;
                } while (resulDiv > 0);
            }

            return valorBinario;
        }

        public static explicit operator NumeroDecimal(double num)
        {
            return new NumeroDecimal(num);
        }

        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)numeroDecimal.ConvertirDecimalABinario(numeroDecimal.numero);
        }
        public static bool operator ==(NumeroDecimal dec, NumeroBinario bin)
        {
            return dec.numero == ((NumeroDecimal)bin).numero;
        }
        public static bool operator !=(NumeroDecimal dec, NumeroBinario bin)
        {
            return !(dec == bin);
        }
        public static double operator +(NumeroDecimal dec, NumeroBinario bin)
        {
            return dec.Numero + ((NumeroDecimal)bin).Numero;
        }
        public static double operator -(NumeroDecimal dec, NumeroBinario bin)
        {
            return dec.Numero - ((NumeroDecimal)bin).Numero;
        }
    }
}
