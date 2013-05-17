using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число!");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (i % (3*7) == 0)
                {
                    Console.WriteLine("Числата кратни едновременно и на 3 и на 7 в интервала са :" + i);
                }
                
            }
        }
    }
}
