using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[] { "Istanbul", "Ankara", "Izmir", "Bursa", "Antalya", "Bolu", "Konya", "Kayseri", "Kahramanmaras", "Trabzon" };
            int lastCity = 0;
            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i].Contains("t") || cities[i].Contains("T"))
                {
                    lastCity = i;
                }
            }
            Console.WriteLine(lastCity);
        }
    }
}
