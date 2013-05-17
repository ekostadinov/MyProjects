using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2._9_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = "The \"use\" of quotations causes difficulties."; 
            string value =  @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(symbol);
            Console.WriteLine(value);

        }
    }
}
