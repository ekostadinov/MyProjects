using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_9
{
    class Program
    {
        static int PrintResult(int [] arr, int arrSize)
        {
            for (int index = 0; index < arr.Length; index++ )
            {
                Console.Write("{0}", arr[index]);

                if (index < (arr.Length - 1))
                {
                    Console.Write(", ");
                }              
            }

            return arrSize;
        }

        static int SortNumbers (int [] arr, int arrSize)
    {
        for (int index = 0; index < arr.Length - 1; index++)
        {
            for (int innerIndex = index + 1; innerIndex < arr.Length; innerIndex++)
            {
                if (arr[index] < arr[innerIndex])
                {
                    int oldNum = arr[index];
                    arr[index] = arr[innerIndex];
                    arr[innerIndex] = oldNum;
                }
            }
        }
        return arrSize;
    }

        static int GetNumbers(int [] arr, int arrSize)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write(arr[index] + " ");                
            }

            return arrSize;
        }

        static int GetArray(int [] arr, int arrSize)
        {

            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write("Enter value for [{0}] : ", index);
                arr[index] = int.Parse(Console.ReadLine());
            }

            return arrSize;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int arrSize = int.Parse(Console.ReadLine());

            int [] arr = new int [arrSize];

            GetArray(arr, arrSize);
            Console.WriteLine();

            Console.WriteLine("Your array is: ");
            GetNumbers(arr, arrSize);
            Console.WriteLine();

            SortNumbers(arr, arrSize);
            Console.WriteLine();

            Console.WriteLine("In order they are: ");
            PrintResult(arr, arrSize);
            Console.WriteLine();            
        }


    }
}
