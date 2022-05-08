
    using System;
    /// <summary>
    /// This the test harness
    /// </summary>
    public class Test
    {
        public static void Main()
        {
            int x; // Input value 1
            int y; // Input value 2
            int greater; // Result from Greater()
                         // Get input numbers
            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());
            // Test the Greater( ) method
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);
        // Test the Swap method
        Console.WriteLine("Before swap: " + x + "," + y);
        Utils.Swap(ref x, ref y);
        Console.WriteLine("After swap: " + x + "," + y);
    }
    
        class Utils
        {
        public static bool Factorial(int n, out int answer)
        {
            int k; // Loop counter
            int f; // Working value
            bool ok = true; // True if okay, false if not
                            // Check the input value
            if (n < 0)
                ok = false;
            // Calculate the factorial value as the
            // product of all of the numbers from 2 to n
            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                // If something goes wrong in the calculation,
                // catch it here. All exceptions
                // are handled the same way: set the result
                // to zero and return false.
                f = 0;
                ok = false;
            }
            // Assign result value
            answer = f;
            // Return to caller
            return ok;
        }
    }
    public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }

