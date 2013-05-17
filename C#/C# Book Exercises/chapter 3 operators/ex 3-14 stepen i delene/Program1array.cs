using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_14_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете просто число от 1 до 100: ");
            string line = Console.ReadLine();
            int n;
            int.TryParse(line, out n);


            int[] SimpleNumbers = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61,
 67, 71, 73, 79, 83, 89, 97};

            foreach (int simple in SimpleNumbers)
            {
                if (n != simple)
                {
                    Console.WriteLine("Въведеното число е съставно!Опитайте отново!");
                }
                    else
                    {
                        Console.WriteLine("Успех!");
                }
                }
        }
    }
    }

