using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_6_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number!");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert second number!");
            int m = int.Parse(Console.ReadLine());

            while (n != 0 && m != 0)
            {
                if (n > m)
                {
                    n = n % m;
                }
                else
                {
                    m = m % n;
                }

            }
            if (n == 0)
            {
                Console.WriteLine("GCD = {0} ", m);
            }
            else
            {
                Console.WriteLine("GCD = {0} ", n);
            }

        }
    }
}
