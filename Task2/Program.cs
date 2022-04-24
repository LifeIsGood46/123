using System;
//Задан список из десяти городов. (массив [.] string) Поменять местами
//названия двух городов, названия которых оканчиваются сочетанием букв «ск» или ‘sk’
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Самара", "Тольятти", "Москва", "Санкт-петербург", "Чебоксары", "Рязань", "Крым", "Сочи", "Курск", "Магнитогорск" };
            int last = words.Length - 1;
            for (int i = last - 1; i >= 0; i--)
            {
                if (words[i].EndsWith("ск"))
                {
                    string temp = words[last];
                    words[last] = words[i];
                    words[i] = temp;
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", words));
        } 
    }
}
