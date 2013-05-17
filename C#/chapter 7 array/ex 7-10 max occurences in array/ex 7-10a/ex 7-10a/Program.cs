using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_10a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            int length = array.Length;
        int index = 0;
        int len = 0;
        int maxLen = 0;
        int sum = 0;

        for (int j = 0; j < length - 1; j++)
        {
            if (j <= length - 2)
            {
                if (array[j] == array[j + 1])
                {
                    len++;
                    sum += array[j];
                }
                else
                {
                    len = 0;
                }
            }
            if (len > maxLen)
            {
                maxLen = len;
                index = j + 1 - len;
            }
        }
        Console.WriteLine("The maximal sequence of equal elements is:");

            for (int k = 0; k <= maxLen; k++)
            {
                Console.Write("{0} ", sum / maxLen);
            }
            Console.WriteLine("\nStarting at arr[{0}]", index);
        }
    }
}
