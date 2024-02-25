using System;
namespace TemperatureConversionPJ
{
    /* 扮演了 轉換對象 Adaptee: 需要被適配器轉換的對象
        
    */
    public class FahrenheitTemperature
    {
        private readonly double temperature;
        public FahrenheitTemperature(double temperature)
        {
            this.temperature = temperature;
        }
        public double GetTemperature()
        {
            return temperature;
        }
    }
}
