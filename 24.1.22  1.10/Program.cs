﻿using System;

namespace _24._1._22__1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int summ = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {

                    summ += Convert.ToInt32(s[i].ToString());
                }
            }
            Console.WriteLine(summ);
        }
    }
}
