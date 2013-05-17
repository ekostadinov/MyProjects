using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_4
{
    class Program
    {
        static int CountTimes(int num, int arrSize)
        {
            int [] arr = new int[arrSize];

            for (int index = 0; index < arrSize; index++)
            {
                Console.Write("Enter value for [{0}]: ", index);
                arr[index] = int.Parse(Console.ReadLine());
            }

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
                Console.WriteLine("Max Sequence is: {0} and number is: {1} ", bestLen, bestStart);
            }
                           
            
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the size of the array!");
            int arrSize = int.Parse(Console.ReadLine());

            CountTimes(num, arrSize);
            
        }
        
    }
}
