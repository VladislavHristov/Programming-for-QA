using System;

namespace DivisonBy2_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countBy2 = 0;
            int countBy3 = 0;
            int countBy4 = 0;
            for (int i = 1; i <= n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                if (newNum % 2 == 0)
                {
                    countBy2++;
                } 
                if (newNum % 3 == 0)
                {
                    countBy3++;
                } 
                if (newNum % 4 == 0)
                {
                    countBy4++;
                }
                
                //o On the first line print percent of the numbers that are divisible by 2
                //o On the first line print percent of the numbers that are divisible by 3
                //o On the first line print percent of the numbers that are divisible by 4
                

            }
            double percentBy2 = countBy2 * 1.0 / n * 100;
            double percentBy3 = countBy3 * 1.0 / n * 100;
            double percentBy4 = countBy4 * 1.0 / n * 100;
            Console.WriteLine($"{percentBy2:F2}%");
            Console.WriteLine($"{percentBy3:F2}%");
            Console.WriteLine($"{percentBy4:F2}%");
        }
    }
}