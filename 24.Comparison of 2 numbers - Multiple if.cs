using System;

namespace ConsoleApp124
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
            if(b>a)
            {
                Console.WriteLine("b is greater than a");
            }
            if(a==b)
            {
                Console.WriteLine("a and b are equal");
            }
            Console.ReadLine();
        }
    }
}
