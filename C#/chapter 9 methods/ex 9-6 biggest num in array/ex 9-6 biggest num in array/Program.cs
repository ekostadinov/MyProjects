using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_6
{
    class Program
    {
        static int FindPosition(int [] arr, int bestPos, int arrSize, int num)
        {
            int [] positions = new int [arrSize];
            int bestNum = 0;

            if (bestPos <= arrSize - 1)
            {
                for (int pos = bestPos; pos < positions.Length; pos++)
                {
                    for (int index = 0; index < arr.Length - 1; index++)
                    {

                        if (arr[0] != arr[index] && arr[index - 1] < arr[index] && arr[index] > arr[index + 1])
                        {
                            num++;
                            num = bestNum;
                            //  Console.WriteLine(arr[index]);                          
                            break;
                        }
                        arr[index] = bestNum;
                        // Console.Write(bestNum + " "); 
    
                        if (arr[index] == 0 )
                        {
                            pos++;                            
                            Console.WriteLine(index);
                            // make difference between arr[index] and index, compare pos with index
                        }
                 
                        
                    }
                }
            }

            return bestPos;
        }

        static int NumberSearch(int [] arr, int num, int bestNum)
        {
            for (int index = 0; index < arr.Length - 1 ; index ++ )
            {

                if (arr[0] != arr[index] && arr[index - 1] < arr[index] && arr[index] > arr[index + 1])
                {
                    num++;
                    num = bestNum;
                    Console.WriteLine("The number {0} is bigger then previous '{1}' and next '{2}'!", arr[index], arr[index - 1], arr[index + 1]);
                    break;
                }
                else  
                {
                    Console.WriteLine(" - 1");
                }
            }
            return num;
        }


        static int PrintNumbers(int[] arr, int num)
        {
            for (int innerIndex = 0; innerIndex < arr.Length; innerIndex++)
            {
                Console.Write(arr[innerIndex] + " ");
            }
            return num;
        }



        static int PrintPositions(int arrSize)
        {
            for (int posIndex = 0; posIndex < arrSize; posIndex++)
            {
                Console.Write(posIndex + " ");
            }

            return arrSize;
        }



        static int GetNumbers(int [] arr, int arrSize)
    {
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("Enter value for [{0}]: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }
        return arrSize;
    }



        static void Main(string[] args)
        {
            Console.Write("Enter size of the array:");
            int arrSize = int.Parse(Console.ReadLine());
            int num = 0;
            int bestNum = 0;            
            int bestPos = 0;

            int [] arr = new int [arrSize];

            GetNumbers(arr, arrSize);
            Console.WriteLine();

            Console.WriteLine("positions:");
            PrintPositions(arrSize);
            Console.WriteLine();
            
            Console.WriteLine("numbers:");                     
            PrintNumbers(arr, num);
            Console.WriteLine();


            NumberSearch(arr, num, bestNum);
            Console.WriteLine();

            FindPosition(arr, bestPos, arrSize, num);
            Console.WriteLine();
        }


    }
}
