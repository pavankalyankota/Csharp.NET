using System;

namespace ConsoleApp143
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] name = new string[4];
            int[] age = new int[4];
            for(i=0;i<4;i++)
            {
                Console.Write("Enter name:\t");
                name[i] = Console.ReadLine();
                Console.Write("Enter age:\t");
                age[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
            }
            Console.Write("Enter name for searching:\t");
            string find = Console.ReadLine();
        

                if (name[0] == find)
                {
                    Console.WriteLine("Searching person age is:\t" + age[0]);
                }

                else if (name[1] == find)
                {
                    Console.WriteLine("Searching person age is:\t" + age[1]);
                }

                else if (name[2] == find)
                {
                    Console.WriteLine("Searching person age is:\t" + age[2]);
                }

                else if (name[3] == find)
                {
                    Console.WriteLine("Searching person age is:\t" + age[3]);
                }

                else
                {
                    Console.Write("You have entered wrong name:\t");
                    
                }
            
                
            
            Console.ReadLine();
        }
    }
}
