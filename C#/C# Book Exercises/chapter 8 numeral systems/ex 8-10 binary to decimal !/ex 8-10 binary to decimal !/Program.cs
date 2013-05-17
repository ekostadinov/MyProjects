using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number:");
            string inBin = Console.ReadLine();
            int inDec = 0;
            int binaryLength = inBin.Length;
            
            for (int i = 0; i < binaryLength; i++)
            {
                if (((inBin[i] - '0') & 1) == 1)
                {
                    inDec |= (1 << (binaryLength - i - 1));
                }
            }
            Console.WriteLine("Your number in decimal is: {0}", inDec);

        }
    }
}
