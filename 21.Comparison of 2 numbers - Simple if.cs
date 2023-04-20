using System;

namespace ConsoleApp121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            if(a==0)
            {
                Console.WriteLine("Enter the number other than zero:");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            if(b==0)
            {
                Console.WriteLine("Enter the value other than zero:");
                 b = int.Parse(Console.ReadLine());
            }
            int div = a / b;
            Console.WriteLine("Result after division is:" + div);
            Console.ReadLine();
        }
    }
}
