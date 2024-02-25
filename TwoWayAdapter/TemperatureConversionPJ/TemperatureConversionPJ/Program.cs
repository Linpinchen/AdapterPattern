using System;

namespace TemperatureConversionPJ
{

    /*
      
      
      
     適配器模式說明 ：

        定義 ：
              可以將一個類別的介面轉換成用戶端預期的另一個介面  （轉接器可以讓介面不相融的類別合作無間）

        適配器的內部角色 ：

                請求者 Client : 調用服務的角色

                目標 Target：定義了 Client 要使用的功能

                轉換對象 Adaptee: 需要被適配器轉換的對象

                適配器 Adapter：實現轉換功能的對象

    ==========================================================================================================


     雙向適配器


     雙向適配器可以將兩個不同的接口進行相互的轉換

     一個接口可以 既是 Target  也可以是 Adaptee


                  ＿＿＿＿＿＿＿＿＿＿＿＿ ___________Client__________________ _________________  
                ｜                                                                           |
                ｜                                   |                                       |
                ｜                                   |                                       |
                Ｖ                                   |                                       V
        << interface >>                              |                              <<  interface  >>
     FahrenheitTemperature   <---|                   |                    |--->      CelsiusTemperature
     +GetTemperator():double     |                   |                    |         +GetTemperator():double
                ^                | implements        |         implements |                   ^
                |                |                   |                    |                   |
                |  extends       |                                        |                   | extends
                |                |_____________ TwoWayAdapter ____________|                   |
                |                            +GetCoTemperature()                              |
            Fahrenheit                       +GetCoTemperature()                           Celsius
     +GetFoTemperature():double                                                    +GetCoTemperature():double
     





     
     */

    class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(25);
            TwoWayAdapter twoWayAdapterCoToFo = new TwoWayAdapter(celsius);
            Console.WriteLine($"雙向適配器參數為攝氏,華氏度數:{twoWayAdapterCoToFo.GetFahrenheitTemperature()}:攝氏度數{twoWayAdapterCoToFo.GetCesiusTemperature()}");

            Fahrenheit fahrenheit = new Fahrenheit(100);
            TwoWayAdapter twoWayAdapterFoToCo = new TwoWayAdapter(fahrenheit);
            Console.WriteLine($"雙向適配器參數為華氏,華氏度數:{twoWayAdapterFoToCo.GetFahrenheitTemperature()}:攝氏度數{twoWayAdapterFoToCo.GetCesiusTemperature()}");

            Console.Read();
        }
    }
}
