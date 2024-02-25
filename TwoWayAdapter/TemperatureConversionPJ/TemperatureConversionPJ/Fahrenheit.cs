using System;
namespace TemperatureConversionPJ
{
    public class Fahrenheit:IFahrenheitTemperature
    {
        private readonly double temperature;
        public Fahrenheit(double temperature)
        {
            this.temperature = temperature;
        }

        public double GetFahrenheitTemperature()
        {
            return temperature;
        }
    }
}
