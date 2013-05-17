using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число с десет символа: ");
            string line = Console.ReadLine();
            int a;
            int.TryParse(line, out a);

            Console.WriteLine("Въведете второ число с десет символа: ");
            string line2 = Console.ReadLine();
            int b;
            int.TryParse(line2, out b);

            Console.WriteLine("Въведете трето число с десет символа: ");
            string line3 = Console.ReadLine();
            int c;
            int.TryParse(line3, out c);

            Console.WriteLine();            
            Console.Write("{0:X}", a);
            Console.Write("           ");
            Console.Write("{0:F2}", b);
            Console.Write("             ");
            Console.WriteLine("{0:F2}", - c);
                      
        }
    }
}
