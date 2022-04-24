using System;

namespace _14._02._22_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Nominal:");
            int nominal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Count:");
            int count = int.Parse(Console.ReadLine());
            Money money = new Money(nominal, count);
            money.Show();
            Console.WriteLine("Enter name of product:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter price of product:");
            int price = int.Parse(Console.ReadLine());
            if (money.CanBuy(price))
            {
                Console.WriteLine("You can buy this product");
            }
            else
            {
                Console.WriteLine("You can't buy this product");
            }
            Console.WriteLine("You can buy {0} {1}", money.CanBuy(price), name);
            Console.WriteLine("Do you want to buy this product? yes/no");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                money.Buy(price);
            }
            Console.WriteLine("Sum of money is {0}", money.GetSum());
        }
    }
}