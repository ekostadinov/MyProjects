using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace char1
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = 'a';
            Console.WriteLine("The code of ' " + symbol + " ' is: " + (int)symbol);
            symbol = 'b';
            Console.WriteLine("The code of ' " + symbol + " ' is: " + (int)symbol);
            symbol = 'A';
            Console.WriteLine("The code of ' " + symbol + " ' is: " + (int)symbol);
        }
    }
}
