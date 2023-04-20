using System;

namespace ConsoleApp141
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[][] a = new int[3][];
            a[0] = new int [] { 10, 20 };
            a[1] = new int[] { 20, 30, 40 };
            a[2] = new int[] { 40, 50, 60, 70 };
            for(i=0;i<a.Length;i++)
            {
              for(j=0;j<a[i].Length;j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
