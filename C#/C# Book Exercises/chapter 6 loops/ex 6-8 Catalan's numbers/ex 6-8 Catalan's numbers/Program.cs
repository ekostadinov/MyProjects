using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ex_6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value for 'n': ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger result1 = n * 2;
            BigInteger result2 = n + 1;

            BigInteger f = 1;
            do
            {
                f *= n;
                n--;
            }while (n>0);
            Console.WriteLine("n! = " + f);
            
            BigInteger f1 = 1;
            do
            {
                f1 *= result1;
                result1--;
            }while (result1 > 0);
            Console.WriteLine("(2*n)! = " + f1);
            
            BigInteger f2 = 1;
            do
            {
                f2 *= result2;
                result2--;
            }while (result2 > 0);
            Console.WriteLine("(n+1)! = " + f2);
           
            Console.WriteLine("The Catalan's number in this case is: " + f1 / (f2*f));
                       

        }
    }
}
