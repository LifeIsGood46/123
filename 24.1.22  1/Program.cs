using System;

namespace _24._1._22__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            char x = 'к';
            char y = 'с';
            int countX = 0;
            int countY = 0;
            foreach (var item in s)
                if (item == x)
                    countX++;
                else if (item == y)
                    countY++;
            Console.WriteLine($"Количество символов x = {x}: {countX}, символов y = {y}: {countY}");
            Console.ReadKey();
        }
    }
}
