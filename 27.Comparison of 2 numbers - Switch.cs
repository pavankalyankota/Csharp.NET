using System;

namespace ConsoleApp127
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
                    switch(b>a)
                    {
                        case true:
                            Console.WriteLine("b is grater than a");
                            break;
                        case false:
                            Console.WriteLine("a and b are equal");
                            break;
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
