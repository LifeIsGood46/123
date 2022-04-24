using System;

namespace _24._1._22_1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string lol = "Сегодня в меню: баранина,свинина,курица.";
            Console.WriteLine(lol.Substring(lol.LastIndexOf(':') + 1));
            Console.ReadKey();
        }
    }
}
