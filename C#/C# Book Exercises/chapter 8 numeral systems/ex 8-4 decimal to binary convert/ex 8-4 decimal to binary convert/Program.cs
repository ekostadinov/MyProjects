using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter positive decimal number: ");
            string num = Console.ReadLine();

            string result = Convert.ToString(Convert.ToInt32(num, 10), 2);
            Console.WriteLine("Your number in binary is: ");
            Console.WriteLine(result);
        }
    }
}
