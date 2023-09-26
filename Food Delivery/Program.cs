using System.Transactions;

namespace Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Chicken menu – 10.35 lv.
            //•	Menu with fish – 12.40 lv.
            //•	Vegetarian menu – 8.15 lv.
            //•	Number of chicken menus – integer in the range[0... 99]
            //•	Number of menus with fish – integer in the range[0... 99]
            //•	Number of vegetarian menus – an integer in the range[0... 99]
            int chicken =int.Parse(Console.ReadLine()); 
            int fish = int.Parse(Console.ReadLine());
            int vegetarian =int.Parse(Console.ReadLine());
            double priceChicken = chicken * 10.35;
            double priceFish = fish * 12.40;
            double priceVegetarian = vegetarian * 8.15;
            double totalPrice = priceChicken + priceFish + priceVegetarian;
            double dessert = totalPrice * 0.20;
            double paymentPrice = totalPrice + dessert + 2.50;
            Console.WriteLine(paymentPrice);


            //Console.WriteLine("Hello, World!");
        }
    }
}