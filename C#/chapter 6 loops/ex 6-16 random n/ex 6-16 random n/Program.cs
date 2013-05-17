using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ex_6_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value!");
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();

        for ( int i = 1; i <= n; i++)
            {               
                Console.WriteLine("Your random number: {0} ", rand.Next (1, i));
            }


        }
    }
 }

