using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_6_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("За лице на триъгълник Въведи дължина на едната страна:");
            string line = Console.ReadLine();
            int a;
            int.TryParse(line, out a);

            Console.WriteLine("Въведи дължина на височината спусната към нея:");
            string line1 = Console.ReadLine();
            int h;
            int.TryParse(line1, out h);
            
            Console.WriteLine("Лицето на посоченият триъгълник е:");
            Console.WriteLine((a * h) / 2);

            Console.WriteLine("За периметър на триъгълник Въведи дължина на едната страна:");
            string line3 = Console.ReadLine();
            int z;
            int.TryParse(line3, out z);

            Console.WriteLine("Въведи дължина на втората страна:");
            string line4 = Console.ReadLine();
            int x;
            int.TryParse(line4, out x);

            Console.WriteLine("Въведи дължина на третатата страна:");
            string line5 = Console.ReadLine();
            int f;
            int.TryParse(line5, out f);

            Console.WriteLine("Периметърът на посоченият триъгълник е:");
            Console.WriteLine((z + x) + f);
        }
    }
}
