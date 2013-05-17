using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive hex number: ");
            string inHex = Console.ReadLine();

            string inBinary = Convert.ToString(Convert.ToInt32(inHex, 16), 2);
            Console.WriteLine("Your number in binary is: " + inBinary);
        }
    }
}
