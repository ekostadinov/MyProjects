using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_5
{
    class Program
    {
        static int GetPositions(int arrSize)
        {
            for (int posIndex = 0; posIndex < arrSize; posIndex++)
            {
                Console.Write(posIndex + " ");
            }

            return arrSize;
        }

        static int GetNumbers(int [] arr, int num)
        {
            for (int index = 0; index < arr.Length; index++ )
            {
                Console.Write("Enter value for [{0}]:", index);
                arr[index] = int.Parse(Console.ReadLine());
            }
            return num;
            
        }

        static int PrintNumbers (int [] arr, int num)
        {
            for (int innerIndex = 0; innerIndex < arr.Length; innerIndex++)
                {
                    Console.Write(arr[innerIndex] + " ");
                }
            return num;
        }

        static int SelectedPosition(int [] arr, int numPos, int arrSize)
        {
            if (numPos <= arrSize)
            {
                for (int innerIndex = numPos; innerIndex < arr.Length; innerIndex++)
                {
                    Console.Write("The number for position {0} is {1}!", numPos, arr[innerIndex]);
                    break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }

            
            return numPos;
        }

        static int ComparePositions(int [] arr, int numPos)
        {
            if (arr[0] < arr[1])
            {
                Console.WriteLine("The number in position 0 is smaller then number in position 1!");
            }
            else
            {
                Console.WriteLine("The number in position 0 is bigger then number in position 1!");
            }

            // missing "compare last number in array" solution 

            for (int innerIndex = numPos; innerIndex < arr.Length; innerIndex ++)
            {
                if (arr[innerIndex - 1] > arr[innerIndex] && arr[innerIndex] < arr[innerIndex + 1])
                {
                    Console.WriteLine("The number in selected position is smaller then previous and next number");
                }
                else if (arr[innerIndex -1] < arr[innerIndex] && arr[innerIndex] > arr[innerIndex + 1])
                {
                    Console.WriteLine("The number in selected position is bigger then previous and next number!");
                }                
                else if (arr[innerIndex - 1] > arr[innerIndex] && arr[innerIndex] > arr[innerIndex + 1])
                {
                    Console.WriteLine("The number in selected position is smaller then the previous number, but bigger then the next one");
                }
                else if ( arr[innerIndex - 1] < arr[innerIndex] && arr[innerIndex] < arr[innerIndex + 1])
                {
                    Console.WriteLine("The number in selected position is bigger then previous, but smaller then next number!");
                }
            }
            return numPos;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array!");
            int arrSize = int.Parse(Console.ReadLine());

            int num = 0;

            int [] arr = new int [arrSize];

            GetNumbers(arr, num);
            Console.WriteLine();

            Console.WriteLine("Number positions in the array:");
            GetPositions(arrSize);
            Console.WriteLine();

            Console.WriteLine("Array numbers are: ");
            PrintNumbers(arr, num);
            Console.WriteLine();

            Console.WriteLine("Choose number position!");
            int numPos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            SelectedPosition(arr, numPos, arrSize);
            Console.WriteLine();

            ComparePositions(arr, numPos);
            Console.WriteLine();
        }

    }
}
