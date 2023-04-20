using System;

namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight:");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Your name is:" + name);
            Console.WriteLine("Your age is:" + age);
            Console.WriteLine("Your weight is:" + weight);
            Console.ReadLine();
        }
    }
}
