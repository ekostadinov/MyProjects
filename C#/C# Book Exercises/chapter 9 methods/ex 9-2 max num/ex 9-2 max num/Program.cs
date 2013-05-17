using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, then second number and finaly a third number!");

            Getmax();
        }

        static void Getmax()
        {
            int num = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thNum = int.Parse(Console.ReadLine());

            Console.Write("The max number is: ");
            Console.Write(Math.Max(Math.Max(num, secNum), thNum));
            Console.WriteLine();
        }

    }
}
