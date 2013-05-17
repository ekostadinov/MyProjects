using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ex_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value for K!, if 1<K<N:");
            BigInteger k = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine("Insert value for N!, if N>K:");
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger result = n - k;

            BigInteger factorial = 1;
            do 
            {
            factorial *=k;
            k--;
            }while (k>1);
            Console.WriteLine("K! =: " + factorial);

            BigInteger factorial1 = 1;
            do
            {
                factorial1 *= n;
                n--;
            } while (n > k);
            Console.WriteLine("N! =: " + factorial1);

           BigInteger factorial2 = 1;
            do
            {
                factorial2 *= result;
                result--;
            } while (n > k);
            Console.WriteLine("(N-K)! =: " + factorial2);

            Console.WriteLine("The result of N!*K!/(N-K)! is: " + ((factorial*factorial1)/(factorial2)));

      }
    }
}
