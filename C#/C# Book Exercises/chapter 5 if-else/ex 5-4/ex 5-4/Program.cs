using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете реално число!");
            ulong a = ulong.Parse(Console.ReadLine());

            Console.WriteLine("Въведете реално число!");
            ulong b = ulong.Parse(Console.ReadLine());

            Console.WriteLine("Въведете реално число!");
            ulong c = ulong.Parse(Console.ReadLine());


            if (a>b && a>c)
            {
                if (b>c)
                {
                    Console.WriteLine("В намаляващ ред въведените числа са:");
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine("В намаляващ ред въведените числа са:");
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }


            if (b>a && b>c)
            {
                if (a>c)
                {
                    Console.WriteLine("В намаляващ ред въведените числа са:");
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine("В намаляващ ред въведените числа са:");
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }


            if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine("В намаляващ ред въведените числа са:");
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine("В намаляващ ред въведените числа са:");
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
            }


        }
    }
}
