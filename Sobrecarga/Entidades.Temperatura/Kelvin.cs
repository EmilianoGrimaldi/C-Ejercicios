using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Temperatura
{
    public class Kelvin
    {
        private double temperatura;
        private Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public double GetTemperatura()
        {
            return temperatura;
        }
        private double KelvinCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
        private double KelvinFahrenheit(double kelvin)
        {
            return (kelvin - 273.15) * 9/5 + 32;
        }

        public static explicit operator Kelvin(double kelvin)
        {
            return new Kelvin(kelvin);
        }

        public static explicit operator Celsius(Kelvin kelvin)
        {
            return (Celsius)kelvin.KelvinCelsius(kelvin.GetTemperatura());
        }

        public static explicit operator Fahrenheit(Kelvin kelvin)
        {
            return (Fahrenheit)kelvin.KelvinFahrenheit(kelvin.GetTemperatura());
        }

    }
}
