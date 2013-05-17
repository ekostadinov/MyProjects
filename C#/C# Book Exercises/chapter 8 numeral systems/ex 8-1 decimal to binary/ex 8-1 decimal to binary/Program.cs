using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Endet a positive decimal number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Your number in binary is: ");            
            
            string inBinary = "";
            do
            {
                inBinary += (num & 1);
                num >>= 1;
            }
            while (num > 0);
            inBinary = new string(inBinary.Reverse().ToArray());
            Console.WriteLine(inBinary);
            
        }
    }
}
