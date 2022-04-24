using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._22__1_
{
    internal class Point
    {
        public int x;
        public int y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
        }
        public void Move(int a, int b)
        {
            x += a;
            y += b;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public void Multiply(int a)
        {
            x *= a;
            y *= a;
        }
        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return x;
                if (index == 1)
                    return y;
                else
                    Console.WriteLine("Error");
                return 0;
            }
            set
            {
                if (index == 0)
                    x = value;
                if (index == 1)
                    y = value;
                else
                    Console.WriteLine("Error");
            }
        }
        public static Point operator ++(Point p)
        {
            p.x++;
            p.y++;
            return p;
        }
        public static Point operator --(Point p)
        {
            p.x--;
            p.y--;
            return p;
        }
        public static bool operator ==(Point p1, Point p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
                return true;
            return false;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            if (p1.x != p2.x || p1.y != p2.y)
                return true;
            return false;
        }
        public static Point operator +(Point p, int a)
        {
            p.x += a;
            p.y += a;
            return p;
        }
        public static Point operator +(int a, Point p)
        {
            p.x += a;
            p.y += a;
            return p;
        }        
    }
}
