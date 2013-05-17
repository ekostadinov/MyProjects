using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_1
{
    class Numbers
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Моля, въведете цяло число:");
                string line = Console.ReadLine(); // Read string from console
                int value;
                int.TryParse(line, out value);
                if (value % 2 == 0)
                {

                    Console.Write("Въведеното число е четно!");
                }
                else
                {
                    Console.WriteLine("Въведеното число е нечетно!");
                }
            }
        }
    }
}