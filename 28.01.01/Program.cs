using System;
using System;
using System.Collections.Generic;
namespace ConsoleApplication64 { }

namespace _28._01._01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> dates = new List<DateTime>();

            //Список дат 
            dates.Add(new DateTime(2014, 6, 30, 9, 31, 0));
            dates.Add(new DateTime(2014, 6, 30, 10, 31, 0));
            dates.Add(new DateTime(2014, 6, 30, 10, 31, 0));

            //Массив температур
            double[] temps = new double[3] { 26.3, 27.1, 30.0 };

            Console.WriteLine("{0:MMM dd(ddd) h:mm > }" + temps[0] + "°C", dates[0]);
            Console.WriteLine("{0:MMM dd(ddd) h:mm > }" + temps[1] + "°C", dates[1]);
            Console.WriteLine("{0:MMM dd(ddd) h:mm > }" + "{1:f1}" + "°C", dates[2], temps[2]);
            Console.ReadLine();
        }
    }
}