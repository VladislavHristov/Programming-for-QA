namespace Animal_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case"dog": 
                    Console.WriteLine("mammal"); 
                    break;
                case"crododile": 
                    Console.WriteLine("reptile");
                    break;
                case"tortoise":
                    Console.WriteLine("reptile");
                    break;
                case"snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;



            }
            
        }
    }
}