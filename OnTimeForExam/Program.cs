namespace OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int studentHour = int.Parse(Console.ReadLine());
            int studentMinutes = int.Parse(Console.ReadLine());

            int examInMinutes = examHours * 60 + examMinutes;
            int studentInMinutes = studentHour * 60 + studentMinutes;
            int timeDiff =   examInMinutes - studentInMinutes;


            if(studentInMinutes == examInMinutes)
            {
                Console.WriteLine("On time");
                

            }else if(examInMinutes - studentInMinutes <= 30)
            {
                int lateHours = timeDiff / 60;
                int lateMinutes = timeDiff % 60;
                Console.WriteLine("On time");
                Console.WriteLine($"{lateMinutes} minutes before the start");
            }
            if(examInMinutes - studentInMinutes > 59)
            {
                int lateHours = timeDiff / 60;
                int lateMinutes = timeDiff % 60;
                Console.WriteLine("Early");
                Console.WriteLine($"{lateMinutes:00} minutes before the start");
            }else 
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{late}");
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}