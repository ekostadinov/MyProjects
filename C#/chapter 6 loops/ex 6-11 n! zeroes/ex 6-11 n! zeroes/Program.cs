using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ex_6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value for vactoral!");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger facN = 1;
            BigInteger zeroes = 0;
            int divisors = 5;

            do 
            {
                facN *= n;
                n--;
            }while (n>0);
            Console.WriteLine(facN);

            
            while ((n / divisors) != 0)
            {
                zeroes += n / divisors;
                divisors *= divisors;

            }

                Console.WriteLine(zeroes);

        }
    }
}
