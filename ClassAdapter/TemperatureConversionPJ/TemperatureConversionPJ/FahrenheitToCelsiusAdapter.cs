using System;
namespace TemperatureConversionPJ
{
    /*
     適配器 Adapter
     這個腳本扮演了 適配器的角色 
     也就是 實現 轉換功能的對象


        FahrenheitToCelsiusAdapter 繼承了 FahrenheitTemperature（華氏）
        並且實做了 ICelsiusTemperature 的 方法

        實作的內容為 呼叫 基底的方法 來做計算從新回傳一個值

     */
    public class FahrenheitToCelsiusAdapter:FahrenheitTemperature,ICelsiusTemperature
    {
        public FahrenheitToCelsiusAdapter(double temperature) : base(temperature)
        {
            
        }


        public double GetCTemperature()
        {
            return (base.GetTemperature() - 32) * 5 / 9;
        }
    }
}
