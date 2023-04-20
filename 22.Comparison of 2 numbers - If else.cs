using System;

namespace ConsoleApp122
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int j = int.Parse(Console.ReadLine());
            if(i>j)
            {
                Console.WriteLine("First number is greater than Second number");
                Console.WriteLine("Greater value is:" + i);
            }
            else
            {
                Console.WriteLine("Second number is greater than First number");
                Console.WriteLine("Greater value is:" + j);
            }
            Console.ReadLine();
        }
    }
}
