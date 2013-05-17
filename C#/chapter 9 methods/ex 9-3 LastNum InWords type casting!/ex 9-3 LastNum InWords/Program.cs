using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_3
{
    class Program
    {   
        static int InWords(int lastNum)
        {            
            switch (lastNum)
            {
                case 0:
                    Console.WriteLine("zero"); break;
                case 1:
                    Console.WriteLine("one"); break;
                case 2:
                    Console.WriteLine("two"); break;
                case 3:
                    Console.WriteLine("three"); break;
                case 4:
                    Console.WriteLine("four"); break;
                case 5:
                    Console.WriteLine("five"); break;
                case 6:
                    Console.WriteLine("six"); break;
                case 7:
                    Console.WriteLine("seven"); break;
                case 8:
                    Console.WriteLine("eight"); break;
                case 9:
                    Console.WriteLine("nine"); break;
                case 10:
                    Console.WriteLine("ten"); break;
                default:
                    Console.WriteLine("Error!"); break;
            }
            return lastNum;
        }

        static int LastNumer(int num)
        {
            double result = (double)num / 10;
            int resultByTen = num / 10;
            double resultSecond = result - resultByTen;
            double resultFinal = resultSecond * 10;
            int lastNum = (int)resultFinal;     // type casting double to int                   
            return InWords(lastNum);
        }

        static void Main()
        {
            Console.WriteLine("Enter a number and see how the last number of it spells!");
            int num = int.Parse(Console.ReadLine());

            LastNumer(num);
        }

    }
}
