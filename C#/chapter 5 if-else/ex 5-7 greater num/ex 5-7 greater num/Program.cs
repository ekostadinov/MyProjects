using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_5_7
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

            Console.WriteLine("Въведете число!");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете число!");
            int e = int.Parse(Console.ReadLine());

            if (a != 0 && b != 0 && c != 0 && d != 0 && e != 0)
            {
                if (a > b && a > c && a > d && a > e)
                {
                    Console.WriteLine("Най-голямото число е:" + a);
                }

                if (b > a && b > c && b > d && b > e)
                {
                    Console.WriteLine("Най-голямото число е:" + b);
                }

                if (c > a && c > b && c > d && c > e)
                {
                    Console.WriteLine("Най-голямото число е:" + c);
                }
                if (d > a && d > b && d > c && d > e)
                {
                    Console.WriteLine("Най-голямото число е:" + d);
                }
                if (e > a && e > b && e > c && e > d)
                {
                    Console.WriteLine("Най-голямото число е:" + e);
                }
            }
            else
            {
                Console.WriteLine("Въведените числа са равни!");
            }
        }
    }
}
