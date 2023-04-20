using System;

namespace ConsoleApp137
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, div;
            stage1:
                Console.WriteLine("Enter a value:");
            a = float.Parse(Console.ReadLine());
            if (a == 0)
                goto stage1;
            stage2:
            Console.WriteLine("Enter b value:");
            b = float.Parse(Console.ReadLine());
            if (b == 0)
                goto stage2;
            div = a / b;
            Console.WriteLine("Vakue after division:" + div);
            Console.ReadLine();
        }
    }
}
