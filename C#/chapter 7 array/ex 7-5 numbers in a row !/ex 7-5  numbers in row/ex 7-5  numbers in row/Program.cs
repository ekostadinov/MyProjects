using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int bestCount = 0;
            int start = 0;
            int i = 0;            

            int[] arr = { 3, 2, 3, 4, 5, 2, 2, 4 };
            int length = arr.Length;

            for (i = 0; i < (length - 1); i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    count++;
                }
                if (arr[i] >= arr[i + 1])
                {

                    if (bestCount < count)
                    {
                        bestCount = count;
                        start = i - count + 1;
                    }
                    count = 1;
                }
            }
            for (int j = start; j <= bestCount; j++)
            {
                Console.Write(arr[j] + " ");                
            }

       }
    }
}
