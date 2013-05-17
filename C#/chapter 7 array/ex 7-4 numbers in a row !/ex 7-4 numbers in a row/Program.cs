using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
            int len = 1;
            int bestLen = len;
            int start = 0;
            int bestStart = arr[0];
            int length = arr.Length;                        

            for (int index = 1; index < length - 1; index++)
            {
                        
                if (arr[index] == arr[index - 1])
                {
                        start++;
                        len++;             
                }
                else
                {
                        start = 1;
                        len=1;                    
                }
                if (len > bestLen)
                {
                    if (bestLen < len)
                    {
                        bestLen = len;
                        start = index - len;
                    }
                    bestLen ++;
                    bestStart = arr[index];
                    
                }                
            }
            Console.WriteLine("Max Sequence is: {0} and number is: {1} ", bestLen, bestStart);

        }
    }
}
