using System;
using System.Collections.Generic;


namespace Program
{
    class progamm
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("WriteLines.txt");
            for (int i = 0; i < 10; i++)
            {
                file.WriteLine("This is line number {0}", i);
            }
            file.Close();
        }
    }
}