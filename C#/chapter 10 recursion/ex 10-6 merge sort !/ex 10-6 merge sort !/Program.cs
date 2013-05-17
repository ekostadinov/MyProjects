using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_10_6_merge_sort__
{
    class Program
    {
        static int[] arrayA;
        static int[] arrayB;
        static int[] arrayC;
        static int arrSize;
        static int arrSize2;        
        static int index;
        static int index2;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the first array of numbers!");
            arrSize = int.Parse(Console.ReadLine());

            arrayA = new int [arrSize];
            
            GetFirstArray();

            Console.WriteLine("Enter the size of the second array of numbers!");
            arrSize2 = int.Parse(Console.ReadLine());

            arrayB = new int [arrSize2];

            GetSecondArray();
                        
            arrayC = new int [arrayA.Length + arrayB.Length];
            Array.Copy(arrayA, arrayC, arrayA.Length);
            Array.Copy(arrayB, 0, arrayC, arrayA.Length, arrayB.Length);

            Console.WriteLine("Your final array is: ");
            PrintFinalArray();
                      

        }

        static void GetFirstArray()
        {
            for (index = 0; index <= arrayA.Length - 1; index++ )
            {
                Console.Write("Enter value for [{0}]: ", index);
                arrayA[index] = int.Parse(Console.ReadLine());            
            }
            
           SortFirstArray();
        }

        static void SortFirstArray()
        {
                Array.Sort(arrayA);
                Console.WriteLine("Your first array is: ");

                foreach (var numbers in arrayA)
                {
                    Console.Write(numbers);
                    Console.Write(" ");
                }
                Console.WriteLine();
        }

        static void GetSecondArray()
        {
            for (index2 = 0; index2 <= arrayB.Length - 1; index2++)
            {
                Console.Write("Enter value for [{0}]: ", index2);
                arrayB[index2] = int.Parse(Console.ReadLine());
            }

            SortSecondArray();
        }

        static void SortSecondArray()
        {
            Array.Sort(arrayB);
            Console.WriteLine("Your second array is: ");

            foreach (var numbers in arrayB)
            {
                Console.Write(numbers);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
         
        static void PrintFinalArray()
        {
            Array.Sort(arrayC);

            foreach (int numbers in arrayC)
            {
                Console.Write(numbers + " ");
            }
        }

        // this is not exactly merge sort method!!! in merge sort logis the array is divided by 2 (in half)
    
    }
}
