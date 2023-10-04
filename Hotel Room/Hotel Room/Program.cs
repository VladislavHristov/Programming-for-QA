using System;

namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartments = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50 * countNights;
                    priceApartments = 65 * countNights;
                    if (countNights > 14)
                    {
                        priceStudio -= (50 * countNights * 0.30); // 30% discount for more than 14 nights in May and October
                        priceApartments -= (65 * countNights * 0.10); // 10% discount for more than 14 nights in any month
                    }
                    else if (countNights > 7)
                    {
                        priceStudio -= (50 * countNights * 0.05); // 5% discount for more than 7 nights in May and October
                    }
                    break;

                case "June":
                case "September":
                    priceStudio = 75.20 * countNights;
                    priceApartments = 68.70 * countNights;
                    if (countNights > 14)
                    {
                        priceStudio -= (75.20 * countNights * 0.20); // 20% discount for more than 14 nights in June and September
                        priceApartments -= (68.70 * countNights * 0.10); // 10% discount for more than 14 nights in any month
                    }
                    break;

                case "July":
                case "August":
                    priceStudio = 76 * countNights;
                    priceApartments = 77 * countNights;
                    if (countNights > 14)
                    {
                        priceApartments -= (77 * countNights * 0.10); // 10% discount for more than 14 nights in any month
                    }
                    break;

                
            }

            Console.WriteLine($"Apartment: {priceApartments:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        }
    }
}
