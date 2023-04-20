using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers of rows or columns for matrix A & B is:");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[m, m];
            int[,] b = new int[m, m];
            int[,] c = new int[m, m];
            Console.WriteLine("Enter array elements of matrix A:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix A is:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter array elements of matrix B:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix B is:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < m; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            Console.WriteLine("Matrix multiplication is:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
