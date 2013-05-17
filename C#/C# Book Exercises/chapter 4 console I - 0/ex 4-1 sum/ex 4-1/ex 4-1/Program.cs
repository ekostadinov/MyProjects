using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете първо число: ");
            string line = Console.ReadLine();
            int a;
            int.TryParse(line, out a);

            Console.WriteLine("Въведете второ число: ");
            string line2 = Console.ReadLine();
            int b;
            int.TryParse(line, out b);

            Console.WriteLine("Въведете трето число: ");
            string line3 = Console.ReadLine();
            int c;
            int.TryParse(line, out c);



            Console.WriteLine("Сумата от въведените числа е:" + (a+b+c));
        }
    }
}
