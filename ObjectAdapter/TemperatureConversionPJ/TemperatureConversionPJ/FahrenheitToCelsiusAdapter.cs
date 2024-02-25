using System;
namespace TemperatureConversionPJ
{
    /*
         這個腳本扮演的角色 ==> 適配器 Adapter：實現轉換功能的對象
     
     
         類(Class)適配器 與 物件(Object) 適配器 , 的差異在於這裡

         實現轉換功能的類 有無直接擁有需要被轉換的類

         
         相較於 類適配器 這裡 多了個成員變量 FahrenheitTemperature , 並透過建構子 來取得 FahrenheitTemperature（被轉換的對象）

         在 GetTemperator 被調用時 , 直接調用成員變量的 GetTemperator 來實現公式
    
     */


    public class FahrenheitToCelsiusAdapter:ICelsiusTemperature
    {
        private FahrenheitTemperature temperature;

        public FahrenheitToCelsiusAdapter(FahrenheitTemperature temperature)
        {
            this.temperature = temperature;
        }

        public double GetTemperator()
        {
            return (temperature.GetTemperature()-32)*5/9;
        }
    }
}
