using System;

namespace BiggestNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;


            for (int i =1;i <=n; i++)
            {
              int newNum=int.Parse(Console.ReadLine());
               // biggest = newNum;
                
                if (newNum>biggest )
                {
                    biggest = newNum;
                }
                
            }
            Console.WriteLine(biggest);

        }
    }
}