using System;

namespace ConsoleApp135
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1;i<=10;i++)
            {
                if (i == 10)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
