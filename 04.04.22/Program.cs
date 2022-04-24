using System;

namespace _04._04._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date in format dd.mm.yyyy");
            string date = Console.ReadLine();
            DateTime dateTime = DateTime.Parse(date);
            Console.WriteLine(dateTime.ToString("dddd"));
            Console.WriteLine("Day before: " + dateTime.AddDays(-1).ToString("dddd"));
            Console.WriteLine("Next day: " + dateTime.AddDays(1).ToString("dddd"));
            Console.WriteLine("Days left: " + (dateTime.AddDays(1) - DateTime.Now).Days);
        }
    }
}