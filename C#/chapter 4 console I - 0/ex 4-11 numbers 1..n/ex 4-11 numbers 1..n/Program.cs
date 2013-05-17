using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число!");
            int n = int.Parse(Console.ReadLine());

            int b = 1;

            for (int a = b; a < n + 1; a++)
            {
                Console.WriteLine("Числата от 1 до {0} са: {1}", n, a);

            }
            
        }
    }
}
