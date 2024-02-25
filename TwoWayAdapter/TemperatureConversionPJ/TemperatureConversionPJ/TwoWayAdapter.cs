using System;
namespace TemperatureConversionPJ
{
    /*
        雙向轉接器 實作了 ICesiusTemperature 以及 IFahrenheitTemperature 兩個介面方法

        並擁有 Celsius 以及 Fahrenheit 兩個成員變量

        建構子的部分採用多載

     */
    public class TwoWayAdapter:ICesiusTemperature,IFahrenheitTemperature
    {
        private Celsius celsius;
        private Fahrenheit fahrenheit;

        public TwoWayAdapter(Celsius celsius)
        {
            this.celsius = celsius;
            fahrenheit = new Fahrenheit(celsius.GetCesiusTemperature() * 5/ 9 + 32);
        }

        public TwoWayAdapter(Fahrenheit fahrenheit)
        {
            this.fahrenheit = fahrenheit;
            celsius = new Celsius((fahrenheit.GetFahrenheitTemperature()-32) * 5 / 9);
        }

        public double GetCesiusTemperature()
        {
            return celsius.GetCesiusTemperature();
        }

        public double GetFahrenheitTemperature()
        {
            return fahrenheit.GetFahrenheitTemperature();
        }



    }
}
