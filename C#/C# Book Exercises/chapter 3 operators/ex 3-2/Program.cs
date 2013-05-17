using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Моля, въведете цяло число, което да се дели на 5 и 7:");
                string line = Console.ReadLine(); // Read string from console
                int value;
                int.TryParse(line, out value);
                if (value % 35 == 0)
                {

                    Console.WriteLine("Въведеното число се дели на 5 и 7 !");
                }
                else
                {
                    Console.WriteLine("Въведеното число не се дели на 5 и 7 !");
                }
            }
        }
    }
}
