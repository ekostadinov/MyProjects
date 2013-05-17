using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace ex__6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value for 'n' and 'x': ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger x = BigInteger.Parse(Console.ReadLine());
            BigInteger factN = 1;
            BigInteger powX = 1;
            BigInteger sum = 1;

            do
            {
                factN *= n;
                n--;
            } while (n > 0);
            Console.WriteLine(factN);                    

            for (int i = 0; i < x; i++)
            {
                powX *= n;
                sum += factN / powX; 
            }
            Console.WriteLine(powX);                  

            Console.WriteLine("The resuly is : " + sum);
            
        }
    }
}
