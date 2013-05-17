using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte example = - 115; 
            byte example1 = 224;
            short example2 = - 10000; 
            ushort example3 = 20000;
            int example4 = 4825932; 
            uint example5 = 970700000;
            ulong example6 = 123456789123456789;
            Console.WriteLine(example + "пример2" + example1 + "пример3" + example2 + "пример4" + example3 + "пример5" + example4 + "пример6" + example5 + "пример7" + example6 + "пример8");
            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine(maxIntValue);
        }
    }
}




