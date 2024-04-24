namespace Entidades.Temperatura
{
    public class Celsius
    {
        private double temperatura;

        private Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public double GetTemperatura() 
        {
            return temperatura;
        }

        private double CelciusKelvin(double celsius)
        {
            return celsius + 273.15;
        }
        private double CelsiusFahrenheit(double celsius)
        {
            return (celsius * 9/5) + 32;
        }

        public static explicit operator Celsius(double celsius)
        { 
            return new Celsius(celsius);
        }

        public static explicit operator Kelvin(Celsius celsiusTemp)
        {
            return (Kelvin)celsiusTemp.CelciusKelvin(celsiusTemp.GetTemperatura());
        }

        public static explicit operator Fahrenheit(Celsius celsiusTemp)
        {
            return (Fahrenheit)celsiusTemp.CelsiusFahrenheit(celsiusTemp.GetTemperatura());
        }
    }
}
