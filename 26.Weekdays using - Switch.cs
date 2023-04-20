using System;

namespace ConsoleApp126
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weekday number:");
            int weekday = int.Parse(Console.ReadLine());
            switch(weekday)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Enter valid weekday number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
