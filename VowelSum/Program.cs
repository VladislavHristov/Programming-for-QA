namespace VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //string ch = Console.ReadLine();
            int sum = 0;
            for(int i =1;i<=n;i++)
            {
                //ch = Console.ReadLine();
                char symbol = char.Parse(Console.ReadLine());
                switch (symbol)
                {
                    case 'a': sum++; break;
                    case 'e': sum += 2;break;
                    case 'i': sum += 3;break;
                    case 'o': sum += 4;break;
                    case 'u': sum += 5;break;
                }
                
            }Console.WriteLine(sum);
        }
    }
}