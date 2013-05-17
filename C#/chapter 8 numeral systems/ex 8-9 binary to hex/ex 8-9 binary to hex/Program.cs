using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive binary number: ");
            string inBinary = Console.ReadLine();

            string inHex = Convert.ToString(Convert.ToInt32(inBinary, 2), 16);
            Console.WriteLine("Your number in hex is: {0} ", inHex);
        }
    }
}
