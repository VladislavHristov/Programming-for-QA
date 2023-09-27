namespace Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());  
            double rate = double.Parse(Console.ReadLine());
            double interest = amount * (rate / 100);
            double forOneMonth = interest / 12;
            double lastamount = amount + month * forOneMonth;

            //lastamount = deposited amount + term of deposit * (deposited amount * annual interest rate) / 12
            Console.WriteLine(lastamount);



            
        }
    }
}