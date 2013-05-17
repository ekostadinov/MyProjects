using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете стойност за а!");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете стойност за b!");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете стойност за c!");
            int c = int.Parse(Console.ReadLine());

            int x;

            if (a == 0 && b != 0)
            {
                Console.WriteLine(x = -c / b);


                if (c == 0 && x == 0 && x == -b / a)
                {
                    Console.WriteLine((a * x * x) + (b * x) == 0);
                }

                int d = (b * b) - (4 * a * c);
                int x1;

                if (d == 0)
                {
                    Console.WriteLine(x1 = -b/(2*a));
                }

                if (d > 0)
                {
                    int x2;
                    Console.WriteLine(x1 = (-b - (d*d)) / (2 * a));
                    Console.WriteLine(x2 = (-b + (d * d)) / (2 * a));
                }

                if (d < 0)
                {
                    int i = (d * d) - 1;
                    Console.WriteLine(-b - (i*(d*d) / (2*a)));
                    Console.WriteLine(-b + (i * (d * d) / (2 * a)));
                }

            }

        }
    }
}
