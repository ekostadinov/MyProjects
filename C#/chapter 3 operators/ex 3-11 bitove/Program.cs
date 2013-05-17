using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_11_bitove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете цяло число:");
            string line = Console.ReadLine();
            int n;
            int.TryParse(line, out n);

            Console.WriteLine(  n);
        }
    }
}
