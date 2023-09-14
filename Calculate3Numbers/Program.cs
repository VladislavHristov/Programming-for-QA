using System.Threading.Channels;

namespace Calculate3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z. 
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine()); 
            int sum1 = (x + y) * z;
            int sum2 = (x * y) + (y * z);


            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}