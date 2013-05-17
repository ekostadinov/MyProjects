using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_10_2
{
    class Program
    {
        static int elNum;
        static int combNum;
        static int [] array;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements!");
            elNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of combinations!");
            combNum = int.Parse(Console.ReadLine());

            array = new int [elNum];

            ElementsCombination(0);

        }

        static void ElementsCombination(int currentCombination) 
    {
        if (currentCombination >= combNum)
            {
                PrintCombinations();
                return;
            }

        for (int counter = 1; counter <= elNum; counter++ )
        {
            array[currentCombination] = counter;
            ElementsCombination(currentCombination + 1);
        }
    }

        static void PrintCombinations()
        {
            for (int index = 0; index < combNum; index++)
            {
                Console.Write("{0} ", array[index]);
            }
            Console.WriteLine();
        }
        // missing logic to avoid same combinations as [1,2] and [2,1] (they are considered as equal)
    }
}
