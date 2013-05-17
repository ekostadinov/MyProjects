using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число:");
            string line = Console.ReadLine();
            int n;
            int.TryParse(line, out n);

            Console.WriteLine("Въведете позиция:");
            string line1 = Console.ReadLine();
            int p;
            int.TryParse(line1, out p);

            Console.WriteLine("Въведете стойност на бит-а, 1 или 0:");
            string line2 = Console.ReadLine();
            int v;
            int.TryParse(line2, out v);

            int mask = n & (~(1 << p));
            Console.WriteLine("Новата стойност на въведеното число е:");
            
            if (v == 1)
            {
                Console.WriteLine((n & mask) == 0 ? (n & (~(1 << p))) : (n | (1 << p)));
            }
            else
            {
                Console.WriteLine((n & mask) != 0 ? (n & (~(1 << p))) : (n | (1 << p)));
            }
        }
    }
}
