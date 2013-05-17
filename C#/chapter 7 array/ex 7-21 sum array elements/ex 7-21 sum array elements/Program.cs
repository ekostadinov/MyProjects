using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how meny numbers you want and then the values!");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter how many elements should sum consist: ");
            int elements = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter sum value: ");
            int sum = int.Parse(Console.ReadLine());

            int [] arr = new int [num];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter value for [{0}]: ", i);                
                arr[i] = int.Parse(Console.ReadLine());                
                
            }

            int result = SubsetSumCheck(arr, sum, elements);

            if (result > 0)
                {
                    Console.Write(arr[i], result);
                }
            else
            {
            Console.WriteLine("Solution not found. ");
            }
    }








        }
    }
}
