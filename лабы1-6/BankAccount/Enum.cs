using System;

namespace BankAccount
{
    internal class Program
    {
        
        public static long NextNumber()
        {
            return nextAccNo++;
        }
        
        
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo;
        
        
        public enum AccountType { Checking, Deposit }
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            Console.WriteLine("The Customer Account Type is {0}",goldAccount);
            Console.WriteLine("The Customer Account Type is {0}",platinumAccount);
        }
        class CreateAccount
        {
            public static void TestWithdraw(BankAccount acc)
            {
                Console.Write("Enter amount to withdraw: ");
                decimal amount =
                decimal.Parse(Console.ReadLine());
                if (!acc.Withdraw(amount))
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            static void Main()
            {
                BankAccount berts = NewBankAccount();
                Write(berts);
                TestDeposit(berts);
                Write(berts);
                TestWithdraw(berts);
                Write(berts);
                BankAccount freds = NewBankAccount();
                Write(freds);
                TestDeposit(freds);
                Write(freds);
                TestWithdraw(freds);
                Write(freds);
            }
            public static void TestDeposit(BankAccount acc)
            {
                Console.Write("Enter amount to deposit: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                acc.Deposit(amount);
            }
            static BankAccount NewBankAccount()
            {
                BankAccount created = new BankAccount();
                created.Populate(balance);
                return created;
            }
            private AccountType accType;
            public enum AccountType { Checking, Deposit }
            public CreateAccount(AccountType accType)
            {
                this.accType = accType;
            }
            public void PrintAccountType()
            {
                Console.WriteLine("The Customer Account Type is {0}", accType);
            }
        }
        class BankAccount
        {
            public bool Withdraw(decimal amount)
            {
               bool sufficientFunds = accBal >= amount;
               if (sufficientFunds) {
                    accBal -= amount;
               }
                return sufficientFunds;
            }
            public decimal Deposit(decimal amount)
            {
                accBal += amount;
                return accBal;
            }
            public void Populate(decimal balance)
            {
                accNo = NextNumber();
                accBal = balance;
                accType = AccountType.Checking;
            }
            private long accNo;
            private decimal accBal;
            private AccountType accType;
            private static long NextNunber;
            private static long NextNumber()
            {
                return nextAccNo++;
            }
            public long Number()
            {
                return accNo;
            }
            public decimal Balance()
            {
                return accBal;
            }
            public string Type()
            {
                return accType.ToString();
            }
            static void Write(BankAccount toWrite)
            {
                Console.WriteLine("Account number is {0}",
                toWrite.Number());
                Console.WriteLine("Account balance is {0}",
                toWrite.Balance());
                Console.WriteLine("Account type is {0}",
                toWrite.Type());
            }
        }   
    }
}