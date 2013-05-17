using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число!");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете число!");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете число!");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Най-голямото число е:" + a);
            }

            if (b > a && b > c)
            {
                Console.WriteLine("Най-голямото число е:" + b);
            }

            if (c>a && c>b)
            {
                Console.WriteLine("Най-голямото число е:" + c);
            }

        }
    }
}
