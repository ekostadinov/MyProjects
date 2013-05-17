using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            int num = int.Parse(Console.ReadLine());

            int [] arr = new int [num];

            for (int index = 0; index < num; index++)
            {
                arr[index] = index + 1;
            }
            Permutation(arr);
        }

        public static void Permutation (int [] arr)
        {
            int len = arr.Length;
            bool [] used = new bool [len];
            StringBuilder outStr = new StringBuilder();
            doPermute(arr, outStr, used, len, 0);
        }

        public static void doPermute(int [] arr, StringBuilder outStr, bool[] used, int length, int level)
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
                doPermute(arr, outStr, used, length, level + 1);
                used[index] = false;
                outStr.Length = outStr.Length - 2;

            }
        }


        }
    }


