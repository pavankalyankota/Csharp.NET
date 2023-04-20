using System;

namespace ConsoleApp123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b value:");
            int b = int.Parse(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if(b>a)
            {
                Console.WriteLine("b i greater than a");
            }
            else
            {
                Console.WriteLine("a and b are equal");
            }
            Console.ReadLine();
        }
    }
}
