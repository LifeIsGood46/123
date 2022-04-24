using System;
using System.Collections.Generic;


namespace Program
{
    class progamm
    {
        static void Main(string[] args)
        {
            string[] lines = { "This is the first line", "This is the second line", "This is the third line" };
            System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt");
            int count = 0;
            foreach (string line in lines2)
            {
                if (line.StartsWith("T"))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
    