using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_10_sum_in_subset
{
    class SumInSubset
    {
         static int[] array;
        static int index;

        static void Main(string[] args)
        {
            Console.WriteLine("Your array is: ");
            array = new int[] { 2, 3, 1, -1 };

            PrintArray();
            Console.WriteLine();

            Console.WriteLine("All combinations are: ");
            GetCombinations(0);
        }

        static void PrintArray()
        {
            for (index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
        }

        static void GetCombinations(int currentCombo)
        {
            if (currentCombo >= array.Length)
            {
                PrintCombinations();
                return;
            }

            for (int counter = array[0]; counter <= array.Length; counter++)
            {
                array[currentCombo] = counter;
                GetCombinations(currentCombo + 1);
            }

        }

        static void PrintCombinations()
        {
            for (int index2 = 0; index2 <= array.Length; index2++)
            {
                // array[index2] = index; // prints combinations using size of array, we need the elements
                Console.Write("{0} ", array[index2]);
            }
            Console.WriteLine();

        }
    
    
    }
}
