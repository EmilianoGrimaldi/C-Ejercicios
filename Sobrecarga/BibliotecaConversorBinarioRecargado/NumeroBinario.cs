using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConversorBinarioRecargado
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        public string Numero
        { 
            get 
            { 
                return numero;
            }
        }
        public double ConvertirBinarioADecimal(string valorRecibido)
        {
            int result = 0;
            int cantidadCaracteres = valorRecibido.Length;
            foreach (char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    result += (int)Math.Pow(2, cantidadCaracteres);
                }
            }

            return result;
        }

        public static explicit operator NumeroBinario(string bin)
        {
            return new NumeroBinario(bin);
        }

        public static explicit operator NumeroDecimal(NumeroBinario numBin)
        {
            return (NumeroDecimal)numBin.ConvertirBinarioADecimal(numBin.numero);
        }
        public static bool operator ==(NumeroBinario bin, NumeroDecimal dec)
        {
            return bin.numero == ((NumeroBinario)dec).numero;
        }
        public static bool operator !=(NumeroBinario bin, NumeroDecimal dec)
        {
            return !(bin == dec);
        }
        public static string operator +(NumeroBinario bin, NumeroDecimal dec)
        {
            return dec.ConvertirDecimalABinario(((NumeroDecimal)bin).Numero + dec.Numero);
        }
        public static string operator -(NumeroBinario bin, NumeroDecimal dec)
        {
            return dec.ConvertirDecimalABinario(((NumeroDecimal)bin).Numero - dec.Numero); ;
        }
    }
}
