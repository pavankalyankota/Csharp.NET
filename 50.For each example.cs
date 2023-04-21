using System;

namespace ConsoleApp89
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
