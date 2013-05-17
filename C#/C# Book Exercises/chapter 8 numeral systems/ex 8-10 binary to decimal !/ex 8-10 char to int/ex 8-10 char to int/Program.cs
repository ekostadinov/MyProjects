using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_10
{
    class Program
    {
        public static int BinToDec(int bin)
        {
            string binString = bin.ToString();
            char[] binArray = binString.ToCharArray();
            int magnitude = 0;
            int result = 0;
            for (int i = binArray.Length - 1; i >= 0; i--, magnitude++)
            {
                result += ((int)binArray[i] - 48) * (int)Math.Pow(2, magnitude); //-48 is required to convert char to int
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter binary numer: ");
            int bin = int.Parse(Console.ReadLine());
            Console.WriteLine("Decimal representation: " + BinToDec(bin));
        }
    }
}
