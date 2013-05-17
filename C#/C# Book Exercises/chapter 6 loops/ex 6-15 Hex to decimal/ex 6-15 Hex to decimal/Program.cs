using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ex_6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Hex number!");
            string n = Console.ReadLine();

            int num = Int32.Parse(n, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("The decimal result of your number is {0} !", num);
            
        }
    }
}
