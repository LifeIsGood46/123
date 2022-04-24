using System;

namespace _14._02._22__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);
            Console.WriteLine("Первая точка: ({0}, {1})", p1.X, p1.Y);
            Console.WriteLine("Вторая точка: ({0}, {1})", p2.X, p2.Y);
            Console.WriteLine("Расстояние между точками: {0:F2}",
                p1.Distance(p2));   
            p1.Move(10, 10);
            Console.WriteLine("Первая точка: ({0}, {1})", p1.X, p1.Y);
            Console.WriteLine("Вторая точка: ({0}, {1})", p2.X, p2.Y);
            Console.WriteLine("Расстояние между точками: {0:F2}",
                p1.Distance(p2));
            Console.ReadKey();
        }
    }
}