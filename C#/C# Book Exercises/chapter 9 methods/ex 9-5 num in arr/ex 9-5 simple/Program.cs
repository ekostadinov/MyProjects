using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_5
{
    class Program
    {
        static void ShowPositions(int [] arr)
        {
            Console.WriteLine("Position number: ");

            for (int pos = 0; pos < 14; pos++)
            {
                Console.Write(pos + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Numbers: ");

            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write(arr[index] + " ");
            }
            Console.WriteLine();
        }

        static void CompareNumbers(int numPos)
        {
            switch (numPos)
            {
                case 0:
                    Console.WriteLine("Number 2 in position [0] is smaller then number 3 in position [1]");break; 
                    // and so on until case 14
                default :
                    Console.WriteLine("Incorrect position choice!");break;
            }

        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 5, 8, 4, 5, 3, 6, 4, 6, 7, 8, 9, 4, 1};

            Console.WriteLine("The array of numbers!");

            ShowPositions(arr);

            Console.WriteLine("Choose a number position, so we could compare it with it's neighbours!");
            int numPos = int.Parse(Console.ReadLine());

            CompareNumbers(numPos);            
        }


    }
}
