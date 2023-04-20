using System;

namespace ConsoleApp134
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1;i<= 10;i++)
            {
                if(i==10)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
