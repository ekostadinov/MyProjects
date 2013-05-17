using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число!");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете число!");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете число!");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете число!");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете число!");
            int e = int.Parse(Console.ReadLine());

            if ((a + b + c + d + e == 0) || (a + b == 0 || a + c == 0 || a + d == 0 || a + e == 0) || (a + b + c == 0 || a + b + d == 0 || a + b + e == 0) || (b + c == 0 || b + d == 0 || b + e == 0) || (b + c + d == 0 || b + d + e == 0) || (c + d == 0 || c + e == 0) || (d + e == 0))
            {
                if (a + b + c + d + e == 0)
                {
                    Console.WriteLine("Сумата на въведените числа е 0 !");
                }
                if (a + b == 0)
                {
                    Console.WriteLine("Сумата на " + a + " и " + b + " е нула !");
                }
                if (a + c == 0)
                {
                    Console.WriteLine("Сумата на " + a + " и " + c + " е нула !");
                }
                if (a + d == 0)
                {
                    Console.WriteLine("Сумата на " + a + " и " + d + " е нула !");
                }
                if (a + e == 0)
                {
                    Console.WriteLine("Сумата на " + a + " и " + e + " е нула !");
                }
                if (a + b + c == 0)
                {
                    Console.WriteLine("Сумата на " + a + " и " + b + " и " + c + " е нула !");
                }
                if (a + b + d == 0)
                {
                    Console.WriteLine("Сумата на " + a + " и " + b + " и " + d + " е нула !");
                }
                if (a + b + e == 0)
                {
                    Console.WriteLine("Сумата на " + a + " и " + b + " и " + e + " е нула !");
                }

                if (b + c == 0)
                {
                    Console.WriteLine("Сумата на " + b + " и " + c + " и " + " е нула !");
                }
                if (b + d == 0)
                {
                    Console.WriteLine("Сумата на " + b + " и " + d + " е нула !");
                }
                if (b + e == 0)
                {
                    Console.WriteLine("Сумата на " + b + " и " + e + " е нула !");
                }

                if (b + c + d == 0)
                {
                    Console.WriteLine("Сумата на " + b + " и " + c + " и " + d + " е нула !");
                }
                if (b + d + e == 0)
                {
                    Console.WriteLine("Сумата на " + b + " и " + d + " и " + e + " е нула !");
                }


                if (c + d == 0)
                {
                    Console.WriteLine("Сумата на " + c + " и " + d + " е нула !");
                }
                if (c + e == 0)
                {
                    Console.WriteLine("Сумата на " + c + " и " + e + " е нула !");
                }
                if (d + e == 0)
                {
                    Console.WriteLine("Сумата на " + d + " и " + e + " е нула !");
                }
            }
            else
            {
                Console.WriteLine("Никое от въведените числа няма сбор равен на нула!");
            }
            
            
       }
    }
}
