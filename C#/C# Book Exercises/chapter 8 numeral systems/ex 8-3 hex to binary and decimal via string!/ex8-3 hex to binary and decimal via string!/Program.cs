using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "2A3E";
            string num2 = "FA";
            string num3 = "FFFF";
            string num4 = "5A0E9";

            string result1 = Convert.ToString(Convert.ToInt32(num1, 16), 2);
            string result11 = Convert.ToString(Convert.ToInt32(num1, 16), 10);
            Console.WriteLine("Hex number {0} in binary is: ", num1);
            Console.WriteLine(result1);
            Console.WriteLine("and in decimal is: ");
            Console.WriteLine(result11);
            Console.WriteLine();

            string result2 = Convert.ToString(Convert.ToInt32(num2, 16), 2);
            string result22 = Convert.ToString(Convert.ToInt32(num2, 16), 10);
            Console.WriteLine("Hex umber {0} in binary is: ", num2);
            Console.WriteLine(result2);
            Console.WriteLine("and in decimal is: ");
            Console.WriteLine(result22);
            Console.WriteLine();
            
            string result3 = Convert.ToString(Convert.ToInt32(num3, 16), 2);
            string result33 = Convert.ToString(Convert.ToInt32(num3, 16), 10);
            Console.WriteLine("Hex umber {0} in binary is: ", num3);
            Console.WriteLine(result3);
            Console.WriteLine("and in decimal is: ");
            Console.WriteLine(result33);
            Console.WriteLine();

            string result4 = Convert.ToString(Convert.ToInt32(num4, 16), 2);
            string result44 = Convert.ToString(Convert.ToInt32(num4, 16), 10);
            Console.WriteLine("Hex umber {0} in binary is: ", num4);
            Console.WriteLine(result4);
            Console.WriteLine("and in decimal is: ");
            Console.WriteLine(result44);
            Console.WriteLine();



        }
    }
}
