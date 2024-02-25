using System;
namespace TemperatureConversionPJ
{
    public class Celsius:ICesiusTemperature
    {
        private readonly double temperature;
        public Celsius(double temperature)
        {
            this.temperature = temperature;
        }

        public double GetCesiusTemperature()
        {
            return temperature;
        }
    }
}
