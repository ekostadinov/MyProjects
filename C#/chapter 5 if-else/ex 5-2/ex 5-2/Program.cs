using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете първо число!");
            int a = int.Parse(Console.ReadLine());
                
            Console.WriteLine("Въведете второ число!");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете трето число!");
            int c = int.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Произведението на числата ще е нула!");
            }

            if ((a<0 && b<0 && c<0) || (a<0 && b>0 && c>0) || (b<0 && a>0 && c>0) || (c<0 && b>0 && c>0))
            {
                Console.WriteLine("Резултата от произведението на числата ще е отрицателен!");
            }

            else  
            {
                Console.WriteLine("Резултата от произведението на числата ще е положителен!");
            }

            


        }
    }
}
