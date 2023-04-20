using System;

namespace ConsoleApp116
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name:");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter student location:");
            string slocation=Console.ReadLine();
            Console.WriteLine("Enter student address");
            string saddress = Console.ReadLine();
            Console.WriteLine("Student name is:" + sname);
            Console.WriteLine("Student location is:" + slocation);
            Console.WriteLine("Student address is:" + saddress);
            Console.ReadLine();
        }
    }
}
