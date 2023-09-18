using System.Runtime.ConstrainedExecution;

namespace Teaching_materials
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Number of packages of pens - integer in the range[0...100]
           //Number of packets of markers - integer in the range[0...100]
           //Liters of board cleaner -an integer in the range[0... 50]
          //Discount percentage -integer in the range[0...100]
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            //Package of pens - 5.80 lv.
            //Package of markers - 7.20 lv.
            //Board cleaner -1.20 BGN(per liter)
            double pricePens = pens * 5.80;
            double priceMarkers = markers * 7.20;
            double priceLiters = liters * 1.20;
            double priceForAll = pricePens + priceMarkers + priceLiters;
            double priceForMaterials = priceForAll - (priceForAll * discount / 100);


            Console.WriteLine(priceForMaterials);
        }
    }
}