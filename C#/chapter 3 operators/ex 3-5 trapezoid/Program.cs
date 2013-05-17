using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("За лице на трапец Въведи страна a");
            string line = Console.ReadLine();
            int a;
            int.TryParse(line, out a);

            Console.WriteLine("Въведи страна b");
            string line1 = Console.ReadLine();
            int b;
            int.TryParse(line1, out b);

            Console.WriteLine("Въведи височина");
            string line2 = Console.ReadLine();
            int h;
            int.TryParse(line1, out h);

            Console.WriteLine("Лицето на посоченият трапец е:");
            Console.WriteLine(((a+b)/2)*h);
        }
    }
}
