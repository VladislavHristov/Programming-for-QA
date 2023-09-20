namespace Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double deg = radian * 180 / Math.PI;
            
            Console.WriteLine(deg);
        }
    }
}