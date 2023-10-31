using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;

            

            while (true)
            {
                
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                    break;

                if (double.TryParse(input, out double transaction))
                {
                    balance += transaction;
                    if (transaction >= 0)
                        Console.WriteLine($"Increase: {transaction:F2}");
                    else
                        Console.WriteLine($"Decrease: {Math.Abs(transaction):F2}");
                }
                
            }

            Console.WriteLine($"Balance: {balance:F2}");
        }
    }
}
