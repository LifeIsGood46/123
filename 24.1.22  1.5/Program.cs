using System;

namespace _24._1._22__1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(IsThere(s));

            Console.ReadKey();
        }

        static bool IsThere(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
                if (s[i] == s[i + 1])
                    return true;

            return false;
        }
    }
}