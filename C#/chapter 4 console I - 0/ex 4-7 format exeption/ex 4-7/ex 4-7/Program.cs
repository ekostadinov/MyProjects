using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете първото от общо пет числа!");
            string line = Console.ReadLine();
            int a = int.Parse(line);
            

            while (true)
            {
                if (a is int)
                {
                    Console.WriteLine(line);
                    break;
                }
                else
                {
                    throw new Exception ("Въведете число!");
                }
            }
            


            Console.WriteLine("Въведете второто от общо пет числа!");
            string line1 = Console.ReadLine();
            int number1 = int.Parse(line1);


            while (true)
            {
                if (number1 is int)
                {
                    break;
                }
            }


            Console.WriteLine("Въведете третото от общо пет числа!");
            string line2 = Console.ReadLine();
            int number2 = int.Parse(line2);


            while (true)
            {
                if (number2 is int)
                {
                    break;
                }
            }

            Console.WriteLine("Въведете четвъртото от общо пет числа!");
            string line3 = Console.ReadLine();
            int number3 = int.Parse(line3);


            while (true)
            {
                if (number3 is int)
                {
                    break;
                }
            }


            Console.WriteLine("Въведете последното число!");
            string line4 = Console.ReadLine();
            int number4 = int.Parse(line4);


            while (true)
            {
                if (number4 is int)
                {
                    break;
                }
            }

            Console.WriteLine("Сумата от въведените числа е:" + (a + number1 + number2 + number3 + number4));

        }
    }
}
