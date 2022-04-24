using System;
using System.Collections.Generic;


namespace Program
{
    class progamm
    {
        static void Main(string[] args)
        {
            //make file with random numbers
            Random rnd = new Random();
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            // convert to string and write to file
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i] + " ";
            }
            System.IO.File.WriteAllText(@"C:\Users\Александр\Desktop\test.txt", str);
            
        }
    }
}