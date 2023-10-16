namespace PowerOfNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = 1;
            for(int i = 0;i<power;i++)
            {
                result *= num;
                
            }
            Console.WriteLine(result);
        }
        
        
    }
}