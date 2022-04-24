using System;

namespace _31._01._22
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] cities = { "Самара", "Тольятти", "Москва", "Санкт-петербург", "Чебоксары", "Рязань", "Крым", "Сочи", "Курск", "Магнитогорск" };
            foreach (var item in cities)
            {
                if (item.Contains("бург")) Console.WriteLine(item);
            }
            
        }
    }
}
