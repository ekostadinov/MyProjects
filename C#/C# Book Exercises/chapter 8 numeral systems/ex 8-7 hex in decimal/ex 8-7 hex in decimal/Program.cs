using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive hex number: ");
            string inHex = Console.ReadLine();

            string inDec = Convert.ToString(Convert.ToInt32(inHex, 16), 10);
            Console.WriteLine("Your number in decimal is:" + inDec);
        }
    }
}
