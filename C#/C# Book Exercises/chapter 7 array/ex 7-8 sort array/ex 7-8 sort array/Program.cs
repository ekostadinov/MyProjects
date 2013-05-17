using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] values = new int [] {1, 3, 5, 8, 9, 4, 10};

                Array.Sort(values);

                foreach (int value in values)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
        }
    }
}
