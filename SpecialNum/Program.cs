namespace SpecialNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isSpecial = true;
            int originalNum = number;
            while (number > 0)
            {
                int digit = number % 10;
                if (originalNum % digit != 0)
                {
                    isSpecial = false;
                    break;
                }
                number = number / 10;
            }
            
            if (isSpecial==true) 
            { 
            Console.WriteLine($"{originalNum} is special");
            }else
            {
                Console.WriteLine($"{originalNum} is not special");
            }
        }
    }
}