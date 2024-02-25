using System;
namespace TemperatureConversionPJ
{
    // 轉接介面
    // 相當於 Target 得角色 , 定義了客端需要的 “ 華氏轉攝氏的功能 ”
    public interface ICelsiusTemperature
    {
        public double GetCTemperature();
    }
}
