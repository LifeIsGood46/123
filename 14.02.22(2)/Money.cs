using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._22_2_
{
    internal class Money
    {
        public int Nominal { get; set; }
        public int Count { get; set; }
        public Money(int nominal, int count)
        {
            Nominal = nominal;
            Count = count;
        }
        public int Cash()
        {
            return Count * Nominal;
        }
        public void Show()
        {
            Console.WriteLine("Banknote: {0}", Nominal);
            Console.WriteLine("Count: {0}", Count);
            Console.WriteLine("Cash: {0}", Cash());
        }
        public bool CanBuy(int sum)
        {
            return Cash() >= sum;
        }
        public int HowManyCanBuy(int sum)
        {
            return sum / Cash();
        }
        public void Buy(int price)
        {
            Count -= HowManyCanBuy(price);
        }
        public int GetCount()
        {
            return Cash();
        }
        public void SetCount(int count)
        {
            Count = count;
        }
        public int GetSum()
        {
            return Nominal * Count;
        }
        public int this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Nominal;
                }
                else if (index == 1)
                {
                    return Count;
                }
                else
                {
                    Console.WriteLine("Error");
                    return 0;
                }
            }
            set
            {
                if (index == 0)
                {
                    Nominal = value;
                }
                else if (index == 1)
                {
                    Count = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public static Money operator ++(Money money)
        {
            money.Count++;
            return money;
        }
        public static Money operator --(Money money)
        {
            money.Count--;
            return money;
        }
        public static Money operator +(Money money, int value)
        {
            money.Count += value;
            return money;
        }
        public static Money operator +(int value, Money money)
        {
            money.Count += value;
            return money;
        }
    }
}
