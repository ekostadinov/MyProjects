using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_6_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number !");
            int n = int.Parse(Console.ReadLine());
            int result = n % 2;
            int result2 = n / 2;

            Console.WriteLine("Your number in binary system is: ");
            Console.WriteLine(result);

            for (int i = result2, z = result; i <= n && i > 0 && z <= n && z >= 0; i = i / 2, z = i % 2)
            {
               Console.WriteLine(z);           
            }

            
            

        }
    }
}
