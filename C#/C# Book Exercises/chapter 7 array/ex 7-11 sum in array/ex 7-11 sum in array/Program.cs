using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sum value for search in the array");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[] { 4, 3, 1, 4, 2, 5, 8};
            int start= 0;
            int end = 0;
            
            
            for (int i = 0; i <= arr.Length-1; i ++)
            {
                int sum = 0;

                for (int y = i; y <= arr.Length-1; y ++)
                {   
                    sum += arr[y];

                    if (sum == n)
                    {
                        start = i;
                        end = y;
                    }

                }                 
            }

            for (int index = start; index <= end; index++  )
            {
                Console.WriteLine("The numbers of your sum are: {0}", arr[index]);
            }

            Console.WriteLine();
        }
    }
}
