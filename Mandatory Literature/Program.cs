namespace Mandatory_Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());  
            int pagesPerHour = int.Parse(Console.ReadLine());     
            int days = int.Parse(Console.ReadLine());

            int totalHours = pages / pagesPerHour;
            int requiredHours = totalHours / days;

            Console.WriteLine(requiredHours);
        }
    }
}