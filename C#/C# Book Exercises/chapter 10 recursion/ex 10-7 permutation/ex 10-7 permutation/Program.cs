using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_10_7
{
    class Program
    {
        static int[] arr;
        static int num;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            num = int.Parse(Console.ReadLine());

            arr = new int[num];

            for (int index = 0; index < num; index++)
            {
                arr[index] = index + 1;
            }

            GetPermutation();
        }

        static void GetPermutation()
        {
            int len = arr.Length;
            bool [] used = new bool[len];
            StringBuilder outStr = new StringBuilder();
            PrintPermute(outStr, used, len, 0);
        }

        public static void PrintPermute( StringBuilder outStr, bool[] used, int length, int level)
        {
            if (level == length)
            {
                Console.WriteLine("{0} ", outStr);
                return;
            }
            for (int index = 0; index < length; index++)
            {
                if (used[index])
                {
                    continue;
                }
                outStr.Append(arr[index] + " ");
                used[index] = true;
                PrintPermute(outStr, used, length, level + 1);
                used[index] = false;
                outStr.Length = outStr.Length - 2;
            }
        }
               

    }
}
