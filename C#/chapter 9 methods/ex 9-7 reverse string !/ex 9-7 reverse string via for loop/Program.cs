using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_7
{
    class Program
    {
        static int ReverseNumber(int num)
        {
            string number = num.ToString();
            string output = "";

            for (int index = number.Length - 1; index >= 0; index--)
            {
                output += number[index];                
            }

            Console.WriteLine(output);
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            int num = int.Parse(Console.ReadLine());

            ReverseNumber(num);
        }
    }
}
