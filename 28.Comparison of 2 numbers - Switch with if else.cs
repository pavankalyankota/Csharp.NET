using System;

namespace ConsoleApp128
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b value:");
            int b = int.Parse(Console.ReadLine());
            switch(a>b)
            {
                case true:
                    Console.WriteLine("a is greater than b");
                    break;
                case false:
                    if(b>a)
                    {
                        Console.WriteLine("b is greater than a");
                    }
                    else
                    {
                        Console.WriteLine(" and b are equal");
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
