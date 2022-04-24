using System;
using System.Collections.Generic;


namespace Program
{
    class progamm
    {
        static void Main(string[] args)
        {
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            Random rnd = new Random();
            int n = rnd.Next(1, 100);
            for (int i = 0; i < n; i++)
            {
                int rndSymbol = rnd.Next(0, 256);
                System.IO.File.AppendAllText(file1, Convert.ToChar(rndSymbol).ToString());
            }
            n = rnd.Next(1, 100);
            for (int i = 0; i < n; i++)
            {
                int rndSymbol = rnd.Next(0, 256);
                System.IO.File.AppendAllText(file2, Convert.ToChar(rndSymbol).ToString());
            }
            int[] file1Symbols = new int[256];
            int[] file2Symbols = new int[256];
            for (int i = 0; i < 256; i++)
            {
                file1Symbols[i] = 0;
                file2Symbols[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                int symbol1 = System.IO.File.ReadAllText(file1)[i];
                int symbol2 = System.IO.File.ReadAllText(file2)[i];
                file1Symbols[symbol1]++;
                file2Symbols[symbol2]++;
            }
            for (int i = 0; i < 256; i++)
            {
                if (file1Symbols[i] != file2Symbols[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}