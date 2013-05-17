using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_22a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 1, 4, 3, 0, 3, 6, 4, 5, 1 };
            int N = a.Length;

            int[] lengthOfLNDSEndingAt = new int[N];
            int[] previous = new int[N];
            int lengthOfLNDS = 0;
            int endOfLNDS = -1;
            for (int i = 0; i < N; i++)
            {
                int lengthOfPrecedingLNDS = 0;
                previous[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] <= a[i])
                    {
                        if (lengthOfPrecedingLNDS <
lengthOfLNDSEndingAt[j])
                        {
                            lengthOfPrecedingLNDS =
lengthOfLNDSEndingAt[j];
                            previous[i] = j;
                        }
                    }
                }
                lengthOfLNDSEndingAt[i] = lengthOfPrecedingLNDS + 1;
                if (lengthOfLNDSEndingAt[i] > lengthOfLNDS)
                {
                    lengthOfLNDS = lengthOfLNDSEndingAt[i];
                    endOfLNDS = i;
                }
            }

            Console.WriteLine("Longest subsequence has length " +
lengthOfLNDS);
            int[] longestNDS = new int[lengthOfLNDS];
            int lastElement = endOfLNDS;
            for (int index = lengthOfLNDS - 1; lastElement > -1;
index--)
            {
                longestNDS[index] = a[lastElement];
                lastElement = previous[lastElement];
            }
            for (int i = 0; i < lengthOfLNDS; i++)
            {
                Console.Write(longestNDS[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
