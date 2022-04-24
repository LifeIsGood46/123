using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] secondNames = { "Ivanov", "Petrov", "Sidorov", "Vasilev", "Semenov", "Pavlov", "Kuznetsov", "Kozlov", "Kravchenko", "Golubev", "Golub" };
            string[] names = Array.FindAll(secondNames, x => x.EndsWith("v"));
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}


