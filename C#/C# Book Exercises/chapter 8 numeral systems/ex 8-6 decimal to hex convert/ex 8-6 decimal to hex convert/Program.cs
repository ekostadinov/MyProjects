using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive decimal number: ");
            string number = Console.ReadLine();

            string inHex = Convert.ToString(Convert.ToInt32(number, 10), 16);

            Console.WriteLine("Your number in hex is: " + inHex);

        }
    }
}
