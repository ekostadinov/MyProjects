using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_4
{
    class Program
    {
        static void CountTimes(int [] arr)
        {               
            Array.Sort(arr);

            int len = 1;
            int bestLen = len;
            int start = 0;
            int bestStart = arr[0];

            for (int indexInner = 1; indexInner < arr.Length - 1; indexInner++)
            {  
                if (arr[indexInner] == arr[indexInner - 1])
                {
                    start++;
                    len++;
                }
                else
                {
                    start = 1;
                    len = 1;
                }
                if (len > bestLen)
                {
                    if (bestLen < len)
                    {
                        bestLen = len;
                        start = indexInner - len;
                    }
                    bestLen++;
                    bestStart = arr[indexInner];
                }                
            }
            Console.WriteLine("Max Sequence is: {0} and number is: {1} ", bestLen, bestStart);  
        }

        static void Main(string[] args)
        {
            int [] arr = new int[] { 2, 3, 1, 4, 2, 3, 4, 5, 2 };

            Console.WriteLine("The array of numbers is: ");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                Console.Write(arr[index] + " ");                
            }
            Console.WriteLine();
            
            CountTimes(arr);            
        }


    }
}
