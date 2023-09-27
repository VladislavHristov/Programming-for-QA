namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*One liter of water is equal to one cubic decimeter(1 l = 1 dm3).
            //1.Length in cm – an integer number in the range[10... 500]
            //2.Width in cm – an integer number in the range[10... 300]
            //3.Height in cm – an integer number in the range[10... 200]
            //4.Percentage – floating point number in the range[0.000... 100.000]
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());     
            double percentage = double.Parse(Console.ReadLine());   
            int volume = length * width * height;
            double volumeInLiters = volume * 0.001;
            double totalLiters = volumeInLiters * (1 - percentage/100);

            Console.WriteLine(($"{totalLiters:f2}"));
           



        }
    }
}