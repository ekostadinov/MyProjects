using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            

            Array.Sort(arr);
            foreach (int value in arr)
            {
                int[] values = new int[value];
                Console.Write(value);
                int maxLen = 0;

                for (int len = 0; len <= values.Length - 1; len++ )
                {
                    if (values[value] == values[value + 1])
                    {
                        len++;
                        Console.WriteLine(len);
                    }
                    else
                    {
                        len = 0;
                    }
                    if (len > maxLen)
                    {
                        maxLen = len;
                    }
                    Console.WriteLine(maxLen);
                }


                
            }






        }
    }
}
