using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_5_1_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число!");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете друго число!");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Въведените стойности са равни!");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("Първото число е по-голямо!");
                }
                else
                {
                    Console.WriteLine("Второто число е по-голямо!");
                }
            }

        }
    }
}
