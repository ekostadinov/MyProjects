using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = 0;
            int binaryNumber;
            int power = 1;

            Console.WriteLine("Enter your binary number !");
            binaryNumber = Convert.ToInt32(Console.ReadLine());

            while (binaryNumber > 0)
            {
                decimalNumber += binaryNumber % 10 * power;
                binaryNumber = binaryNumber / 10;
                power = power * 2;
            }
            Console.WriteLine("The decimal equilavent is {0}!", decimalNumber);
            

        }
    }
}
