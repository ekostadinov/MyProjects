using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number which is smaller then the first number!");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int bestSum = 0;
            int bestLen = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter array value for [{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
                

                for (int len = 0, sum = arr[0]; len <= k-1 && sum >= len - 1; len ++, sum += arr[len])
                {

                    for (int len1 = 1, sum1 = arr[1]; len1 <= k && sum1 >= len1 - 1; len1 ++, sum1 += arr[len1])
                    {
                        Console.WriteLine(sum + " " + sum1);
                    }
                }
                   
            }


        }
    }
}
