using System.Buffers.Text;
using System.Text.RegularExpressions;

namespace Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Group Budget -integer in the range[1... 8000]
            //•	Season - string: "Spring", "Summer", "Autumn", "Winter"
            //•	Fishermen Count -integer in the range[4... 18]
            //•	The price for renting the boat in the spring is 3000 BGN.
            //•	The price for renting the boat in the summer and autumn is 4200 BGN.
            //•	The price for renting the boat in winter is 2600 BGN.
            //The group receives a discount based on the number of people.
            //•	If the group is up to 6 people including – a discount of 10 %.
            //•	If the group is from 7 to 11 people – a discount of 15 %.
            //•	If the group is from 12 people and more – a discount of 25 %.

            int budget = int.Parse(Console.ReadLine()); 
            string season = Console.ReadLine(); 
            int count = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season) {
                case "Spring": price = 3000;
                    break;
                case "Summer":

                case "Autumn": price = 4200;
                    break;
                case "Winter": price = 2600;
                    break;
                    if (count <= 6)
                        price = price * 0.9;
                    else if (count >= 7 && count <= 11)
                        price = price * 0.85;
                    else if (count >= 12)
                        price = price * 0.75;
                    if (count % 2 == 0 && season != "Autumn")
                    {
                        price = price * 0.95;
                    }
                        
            }

            if(price<=budget)
                Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
            
            else
                Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
        }
    }
}