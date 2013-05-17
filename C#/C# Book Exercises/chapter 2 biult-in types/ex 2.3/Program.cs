using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d =0.000001M;
            // Test decimal.
            if (d == 0.000001M)
            {
                Console.WriteLine(d);
            }
            decimal y = 0.000002M;
            // Add decimal.
            y += d;
            Console.WriteLine(y);
            // Subtract and multiply decimal.
            y -= (d + 2);
            Console.WriteLine(y);
        }
    }
}
