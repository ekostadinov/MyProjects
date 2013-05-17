using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array lenght and then elements!");
            int num = int.Parse(Console.ReadLine());

            int [] arr = new int [num];

            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write("Enter value for [{0}]:", index);
                arr[index] = int.Parse(Console.ReadLine());

                Console.Write("Array is:" + arr[index]);
            }

            Array.Sort(arr);
            foreach (int values in arr)
            {
                Console.Write(values);
                Console.WriteLine(" ");
            }
            Console.WriteLine();




        }
    }
}
