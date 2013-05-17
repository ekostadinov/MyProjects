using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_19
{
    class Program
    {
        static void Main(string[] args)
        {
            var cur = 1;
            const int Total = 10000000;
            var pc = Enumerable.Range(2, Total).ToList();

            while (cur <= Math.Sqrt(Total))
            {
                var cur1 = cur;
                var cur2 = pc.First(i => i > cur1);

                pc.RemoveAll(i => i != cur2 && i % cur2 == 0);
                cur = cur2;
            }

            Console.WriteLine(pc.Max());
        }
    }
}
