using System;
namespace TemperatureConversionPJ
{
    /*
        這個腳本扮演了 要被適配器轉換的對象

        也就是 Adaptee
     
     */
    public class FahrenheitTemperature
    {
        private readonly double temperature;

        public FahrenheitTemperature( double temperature)
        {
            this.temperature = temperature;
        }

        public double GetTemperature()
        {
            return temperature;
        }
    }
}
