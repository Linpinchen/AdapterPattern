using System;
namespace TemperatureConversionPJ
{
    //扮演適配器模式中的 Targer  ==> 定義了 Client端要實現的功能

    public interface ICelsiusTemperature
    {
        public double GetTemperator();
    }
}
