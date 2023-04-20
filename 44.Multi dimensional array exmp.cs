using System;

namespace ConsoleApp144
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] a = new int[,] { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            for(i=0;i<a.GetLength(0);i++)
            {
                for(j=0;j<a.GetLength(1);j++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine(a[i, j] + " ");
                    }
                    else
                        Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
