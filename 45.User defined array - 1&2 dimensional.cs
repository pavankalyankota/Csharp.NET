using System;

namespace ConsoleApp145
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the type of array, like 1 for one dimensional and 2 for two dimwnsional");
            int x = int.Parse(Console.ReadLine());
            if(x==1)
            {
                Console.WriteLine("Enter the number of elements:");
                int a = int.Parse(Console.ReadLine());
                int[] array1 = new int[a];
                Console.WriteLine("Enter the array elements:");
                for(int i=0;i<a;i++)
                {
                    array1[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Array elements are:");
                for(int i=0;i<a;i++)
                {
                    Console.Write(array1[i] + " ");
                }
            }
            else if(x==2)
            {
                Console.WriteLine("Enter numbers of rows:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of columns:");
                int b = int.Parse(Console.ReadLine());
                int[,] array2 = new int[a, b];
                Console.WriteLine("Enter the elements:");
                for(int i=0;i<a;i++)
                {
                    for(int j=0;j<b;j++)
                    {
                        array2[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Array is:");
                for(int i=0;i<a;i++)
                {
                    for(int j=0;j<b;j++)
                    {
                        Console.Write(array2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
