using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Temperatura
{
    public class Fahrenheit
    {
        private double temperatura;
        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public double GetTemperatura()
        {
            return temperatura;
        }
        private double FahrenheitCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5/9;
        }
        private double FahrenheitKelvin(double fahrenheit)
        {
            return (fahrenheit - 32) * 5/9 + 273.15;
        }
        
        public static explicit operator Fahrenheit(double fahrenheit)
        {
            return new Fahrenheit(fahrenheit);
        }

        public static explicit operator Celsius(Fahrenheit fahrenheitTemp)
        {
            return (Celsius)fahrenheitTemp.FahrenheitCelsius(fahrenheitTemp.GetTemperatura());
        }

        public static explicit operator Kelvin(Fahrenheit fahrenheitTemp)
        {
            return (Kelvin)fahrenheitTemp.FahrenheitKelvin(fahrenheitTemp.GetTemperatura());
        }
        
    }


    
}
