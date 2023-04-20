using System;

namespace ConsoleApp120
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double b = double.Parse(Console.ReadLine());
            double div = a / b;
            Console.WriteLine("Division of two numbers is:" + div);
            Console.ReadLine();
        }
    }
}
