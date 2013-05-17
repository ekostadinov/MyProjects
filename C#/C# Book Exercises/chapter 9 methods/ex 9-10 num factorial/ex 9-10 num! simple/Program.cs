using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ex_9_10
{
    class Program
    {
        static void Getfactorial(BigInteger factNum, int num)
        {
            if (num > 0 && num <= 100)
            {
                do
                {
                    factNum *= num;
                    num--;
                } while (num > 0);
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
                        
            Console.WriteLine("The factorial of your number is: {0}", factNum);
        }

        static void Main(string[] args)
        {            
            BigInteger factNum = 1;
            Console.WriteLine("Enter a number between 1 and 100!");
            int num = int.Parse(Console.ReadLine());

            Getfactorial(factNum, num);
            Console.WriteLine();
        }
    }
}
