using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
             
            int maxSum = 0;
            int currSum = 0;
            int seqStart = 0;
            int seqEnd = 0;
            int start = 0;

            for (int i = 0; i < myArr.Length; ++i)
            {
                currSum += myArr[i];
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    seqStart = start;
                    seqEnd = i;
                }
                else if (currSum < 0)
                {
                    start = i + 1;
                    currSum = 0;
                }
            }
            Console.WriteLine(maxSum);

            for (int i = seqStart; i <= seqEnd; i++)
            {
                Console.Write(myArr[i] + " ");
            }
        }
            
 

        }
    }

