using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ex_4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Първите сто числа от редицата на Фибоначи са:");

            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger c = 0;

            for (int i = 1; i < 101; i++ )
            {
                Console.WriteLine("{0}: {1}", i, c);
                
                b = c;
                c = a + b;    
            }
        }
    }
}
