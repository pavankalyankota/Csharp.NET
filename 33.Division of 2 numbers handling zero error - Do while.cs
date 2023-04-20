using System;

namespace ConsoleApp133
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b,div;
            Console.WriteLine("Enter a value:");
            a = float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter value other than zero:");
                a = float.Parse(Console.ReadLine());
            }
            while (a == 0);
            Console.WriteLine("Enter b value:");
            b = float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter value other than zero:");
                b = float.Parse(Console.ReadLine());
            }
            while (b == 0);
            div = a / b;
            Console.WriteLine("value after division:" + div);
            Console.ReadLine();
        }
    }
}
