using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive binary number: ");
            string num = Console.ReadLine();

            string result = Convert.ToString(Convert.ToInt32(num, 2), 10);
            Console.WriteLine("Your number in decimal is: ");
            Console.WriteLine(result);
        }
    }
}
