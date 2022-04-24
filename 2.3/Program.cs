using System;
using System.Collections.Generic;


namespace Program
{
    class progamm
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[100];
            int[] array2 = new int[100];
            string str = "";
            string str2 = "";
            for (int i = 0; i < 100; i++)
            {
                array[i] = rnd.Next(0, 100);
                array2[i] = rnd.Next(0, 100);
                str += array[i] + " ";
                str2 += array2[i] + " ";
            }
            System.IO.File.WriteAllText(@"C:\Users\User\Desktop\array.txt", str);
            System.IO.File.WriteAllText(@"C:\Users\User\Desktop\array2.txt", str2);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\array2.txt");
            System.IO.File.WriteAllLines(@"C:\Users\User\Desktop\array2.txt", lines);
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\array.txt");
            string[] lines3 = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\array2.txt");
            Console.WriteLine("Array 1:");
            foreach (string line in lines2)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Array 2:");
            foreach (string line in lines3)
            {
                Console.WriteLine(line);
            }
        }
    }
}