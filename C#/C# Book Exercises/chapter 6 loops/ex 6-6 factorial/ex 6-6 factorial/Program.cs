using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ex_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input К>1:");
            BigInteger k = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine("Input N>K:");
            BigInteger n = BigInteger.Parse(Console.ReadLine());


            BigInteger f = 1;
            do
            {
                f *= k;
                k--;
            } while (k > 0);
            Console.WriteLine("k! is = " + f);

            BigInteger f1 = 1;
            do
            {
                f1 *= n;
                n--;
            }while (n>k);
            Console.WriteLine("n! is = " + f1);

            Console.WriteLine("The result of n!/k! is = " + (f1/f));    
                     
        }
    }
}
