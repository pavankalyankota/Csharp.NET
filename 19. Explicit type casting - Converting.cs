using System;

namespace ConsoleApp119
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student id:");
            ulong sid = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Enter student name:");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter m1 marks:");
            float m1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter m2 marks:");
            float m2 = Convert.ToSingle(Console.ReadLine());
            float total = m1 + m2;
            float average = total / 2;
            Console.WriteLine(sname + " " + "total marks" + " " + total);
            Console.WriteLine(sname + " " + "average marks" + " " + average);
            Console.ReadLine();
        }
    }
}
