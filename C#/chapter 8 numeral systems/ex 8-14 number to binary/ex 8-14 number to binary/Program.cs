using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            string num = Console.ReadLine();
            num = num.ToUpper();

            Console.WriteLine("Enter with number in what numeral system is your number: ");
            int sys = int.Parse(Console.ReadLine());

            string result = Convert.ToString(Convert.ToInt32(num, sys), 2);

            Console.WriteLine("Your number {0} in binary is {1}!", num, result);
        }
    }
}
