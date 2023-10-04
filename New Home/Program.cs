using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Type of flowers - text with options -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //•	Flowers count -an integer in the range[10... 1000]
            //•	Budget - an integer in the range[50... 2500]
            //•	If Nelly buys more than 80 Roses - 10 % discount from the final price
            //•	If Nelly buys more than 90 Dahlias - 15 % discount from the final price
            //•	If Nelly buys more than 80 Tulips - 15 % discount from the final price
            //•	If Nelly buys less than 120 Narcissus - the price is increased by 15 %
            //•	If Nelly buys less than 80 Gladiolus - the price in increased by 20 %
            string flowersType = Console.ReadLine();    
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double cost = 0;
            switch (flowersType)
            {
                case "Roses":
                        cost = flowersCount * 5.00;
                    if (flowersCount > 80)
                        cost = cost * 0.9;
                    break;

                case "Dahlias":
                        cost = flowersCount * 3.80;
                    if(flowersCount > 90)
                        cost = cost * 0.85;
                    break;

                case "Tulips":
                         cost = flowersCount * 2.80;
                    if (flowersCount > 80)
                        cost = cost * 0.85;
                            break;

                case "Narcissus":
                    cost = flowersCount * 3;
                    if (flowersCount < 120)
                        cost = cost * 1.15;
                    break;

                case "Gladiolus":
                    cost = flowersCount * 2.50;
                    if (flowersCount < 80)
                        cost = cost * 1.20;
                    break;

            }
            if (budget < cost)
                Console.WriteLine($"Not enough money, you need {cost - budget:F2} leva more.");
            
            else Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - cost:F2} leva left.");
        }
    }
}