using System;

namespace TemperatureConversionPJ
{
    /*

    適配器模式說明 ：


    !! 這裡示範的是 類(Class)適配器模式

    定義 ：
          可以將一個類別的介面轉換成用戶端預期的另一個介面  （轉接器可以讓介面不相融的類別合作無間）




    適配器的內部角色 ：

            請求者 Client : 調用服務的角色

            目標 Target：定義了 Client 要使用的功能 ＝＝> <interface> ICelsiusTemperature (用於顯示攝氏度的溫度)

            轉換對象 Adaptee: 需要被適配器轉換的對象 == > FahrenheitTemperature(華氏) 

            適配器 Adapter：實現轉換功能的對象 ==> FahrenheitToCelsiusAdapter(用於 華氏轉攝氏)






    補充說明 ： Adapter 會實作 Target ,並繼承 Adaptee





    實現方式 ：

            類(Class) 適配器模式 用繼承

            對象(Object)適配器模式 用 介面





 */
    class Program
    {
        static void Main(string[] args)
        {
            FahrenheitTemperature Fo = new FahrenheitTemperature(100);
            ICelsiusTemperature Co = new FahrenheitToCelsiusAdapter(Fo.GetTemperature());

            Console.WriteLine($"華氏度數為:{Fo.GetTemperature()},攝氏度數為:{Co.GetCTemperature()}");
            Console.Read();
        }
    }
}
