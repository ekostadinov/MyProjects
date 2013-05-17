using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex__6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число!");
            int a = int.Parse(Console.ReadLine());
            

            for (int i = 1; i<=a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
