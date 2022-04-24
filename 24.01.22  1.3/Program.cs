using System;

namespace _24._01._22__1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "кол около колокола";
            int[] cc = new int[65535];
            int i = 0, count = 0, maxcount = 0;

            for (i = 0; i < 65535; i++)
            {
                cc[i] = 0;
            }
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("{0}", a[i]);
                cc[Convert.ToInt16(a[i])]++;
            }
            for (i = 0; i < 65535; i++)
            {
                count = cc[i];
                if (maxcount < count)
                {
                    maxcount = count;
                }
            }

            Console.WriteLine("\nmaxcount: {0}", maxcount);
            if (maxcount <= 0)
            {
                Console.WriteLine("Символы не найдены");
            }
            else
            {

                Console.WriteLine("Чаще всего встречаются символы:");
                for (i = 0; i < 65535; i++)
                {
                    if (cc[i] == maxcount)
                    {
                        Console.WriteLine("'{0}'", Convert.ToChar(i));
                    }
                }
            }
        }
    }
}
