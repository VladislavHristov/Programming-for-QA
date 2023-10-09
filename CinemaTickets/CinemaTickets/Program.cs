namespace CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();   
            int rows = int.Parse(Console.ReadLine());   
            int columns = int.Parse(Console.ReadLine());

            //•	Premiere – premiere screening, at a price of 12.00 leva.
            //•	Normal – standard screening, at a price of 7.50 leva.
            //•	Discount – screening for children and students at a reduced price of 5.00 leva.
            double income = 0.0;
            if (type == "Premiere")
            {
                income = rows * columns * 12;
            }else if (type == "Normal")
            {
                income = rows * columns * 7.50;
            }else if (type == "Discount")
            {
                income = rows * columns * 5.00;
            }

            Console.WriteLine($"{income:F2} leva");
        }
    }
}