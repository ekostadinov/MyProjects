using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете колко числа искате да сравните и след това самите числа:");
            int num = int.Parse(Console.ReadLine());

            int min = 0;
            int max = 0;
            int number;

            for (int i = 0; i < num; i++)
            {

                number = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    min = number;
                    max = number;
                }

                if (min > number)
                {
                    min = number;
                }

                if (max < number)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max = {0} , Min = {1}", max, min);


        }
    }
}
