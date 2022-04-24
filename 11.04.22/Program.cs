using System;

namespace _11._04._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user to enter value of x
            Console.WriteLine("Enter value of x");
            //read value of x
            double x = double.Parse(Console.ReadLine());
        }
        abstract class Function
        {
            // Создать абстрактный класс Function с методом вычисления значения функции y=f(x) в заданной точке.
            public abstract double Calculate(double x);
            // Line (y=ax+b)
            public class Line : Function
            {
                public double a;
                public double b;
                public Line(double a, double b)
                {
                    this.a = a;
                    this.b = b;
                }
                public override double Calculate(double x)
                {
                    return a * x + b;
                }
            }
            //Kub (y=ax2+bx+c)
            public class Kub : Function
            {
                public double a;
                public double b;
                public double c;
                public Kub(double a, double b, double c)
                {
                    this.a = a;
                    this.b = b;
                    this.c = c;
                }
                public override double Calculate(double x)
                {
                    return a * x * x + b * x + c;
                }
            }
            // Hyperbola (y=(a/x)+b)
            public class Hyperbola : Function
            {
                public double a;
                public double b;
                public Hyperbola(double a, double b)
                {
                    this.a = a;
                    this.b = b;
                }
                public override double Calculate(double x)
                {
                    return (a / x) + b;
                }
            }
            //method show for "Line : Function"
            public static void Show(Line line)
            {
                Console.WriteLine("y = {0}x + {1}", line.a, line.b);
            }

            //method show for "Kub : Function"
            public static void Show(Kub kub)
            {
                Console.WriteLine("y = {0}x2 + {1}x + {2}", kub.a, kub.b, kub.c);
            }
            //method show for "Hyperbola : Function"
            public static void Show(Hyperbola hyperbola)
            {
                Console.WriteLine("y = ({0}/x) + {1}", hyperbola.a, hyperbola.b);
            }
            
        }
    }
}