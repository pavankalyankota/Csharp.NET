using System;

namespace ConsoleApp138
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, res;
            char ch;
            start:
            Console.WriteLine("Enter a value:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter b vlaue:");
            b = float.Parse(Console.ReadLine());
            res = a + b;
            Console.WriteLine("Result after addition is:" + res);
            Console.WriteLine("Please select 'y' to continue or 'n' to stop");
            ch = char.Parse(Console.ReadLine());
            if(ch=='y')
            {
                goto start;
            }
            Console.ReadLine();
        }
    }
}
