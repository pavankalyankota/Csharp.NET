using System;

namespace ConsoleApp151
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            Console.WriteLine("Enter 1st row elements:");
            arr[0] = new int[3];
            Console.Write("Enter 1st element:");
            int a = int.Parse(Console.ReadLine());
            arr[0][0] = a;
            Console.Write("Enter 2st element:");
            int b = int.Parse(Console.ReadLine());
            arr[0][1] = b;
            Console.Write("Enter 3st element:");
            int c = int.Parse(Console.ReadLine());
            arr[0][2] = c;
            arr[1] = new int[2];
            Console.WriteLine("Enter 2nd row elements:");
            Console.Write("Enter 1st element:");
            int d = int.Parse(Console.ReadLine());
            arr[1][0] = d;
            Console.Write("Enter 2st element:");
            int e = int.Parse(Console.ReadLine());
            arr[1][1] = e;
            arr[2] = new int[1];
            Console.WriteLine("Enter 3rd row elements:");
            Console.Write("Enter 1st element:");
            int f = int.Parse(Console.ReadLine());
            arr[2][0] = f;
            for(int r=0;r<arr.Length;r++)
            {
                for(int s=0;s<arr[r].Length;s++)
                {
                    Console.Write(arr[r][s] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();   
        }
    }
}
