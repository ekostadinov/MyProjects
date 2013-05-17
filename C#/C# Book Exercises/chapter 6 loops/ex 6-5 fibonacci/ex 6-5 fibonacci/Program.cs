using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ex_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Първите до кой член искате да видите числата от редицата на Фибоначи:");
            int n = int.Parse(Console.ReadLine());

            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger c = 0;

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}: {1}", i, c);
                a = b;
                b = c;
                c = a + b;
            }

        }
    }
}
