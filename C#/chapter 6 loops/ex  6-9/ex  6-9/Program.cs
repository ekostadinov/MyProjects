using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ex__6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value for 'n' and 'x': ");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            decimal factN = 1;
            decimal powX = 1;
            decimal sum = 1;

            for (int i = 1; i <= n; n++)
            {
                factN *= i;                
                powX *= (decimal)Math.Pow(x, i); // same as powX *=x;
                sum += factN / powX;
            }

            Console.WriteLine("Sum =" + sum);




        }
    }
}
