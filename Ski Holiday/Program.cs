namespace Ski_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());  
            string typeOfRoom = Console.ReadLine(); 
            string assessment = Console.ReadLine();
            double price = 0;
            int nightsToStay = days - 1;

            switch (typeOfRoom)
            {
                case "room for one person":
                    price = nightsToStay * 118;
                    if(assessment == "positive")
                    {
                        price = price +(price* 0.25);
                    }else
                    {
                        price = price +(price* 0.1);
                    }
                    Console.WriteLine($"{price:f2}");
                    break;
                case "apartment":
                    price = nightsToStay * 155;
                    if(nightsToStay < 10)
                    {
                        price = price * 0.7;
                        if (assessment == "positive")
                        {
                            price = price + (price * 0.25);
                        }
                        else
                        {
                            price = price + (price * 0.1);
                        }Console.WriteLine($"{price:f2}");
                    }else if(nightsToStay>= 10 && nightsToStay <= 15)
                    {
                        if (assessment == "positive")
                        {
                            price = price + (price * 0.25);
                        }
                        else
                        {
                            price = price + (price * 0.1);
                        }
                        Console.WriteLine($"{price:f2}");
                        
                        
                    }
                    

            }

            //Console.WriteLine("Hello, World!");
        }
    }
}