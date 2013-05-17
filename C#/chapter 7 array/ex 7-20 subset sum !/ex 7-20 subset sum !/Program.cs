using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the size of the array: ");
        string line = Console.ReadLine();
        int n = int.Parse(line);
        int[] array = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element [{0}]: ", index);
            line = Console.ReadLine();
            array[index] = int.Parse(line);
        }
        Console.Write("Please enter the target sum: ");
        line = Console.ReadLine();
        int targetSum = int.Parse(line);
 
        Console.Write("Please enter the number of elements used to form the sum: ");
        line = Console.ReadLine();
        int elementsToUse = int.Parse(line);
 
        int result = SubsetSumCheck(array, targetSum, elementsToUse);
        if (result > 0)
        {
            resultPrinter(array, result);
        }
        else
        {
            Console.WriteLine("Solution not found.");
        }
    }
 
    static void resultPrinter(int[] array, int result)
    {
        Console.WriteLine("Best found: ");
        for (int i = 0; i < array.Length; i++)
        {
            if ((result & (1 << i)) != 0)
            {
                Console.Write("({0}) ", array[i]);
            }
        }
        Console.WriteLine();
    }
 
    static int SubsetSumCheck(int[] array, int targetSum,int targetElementsUsed)
    {
        for (int combinationNumber = 1; combinationNumber < (1 << array.Length); combinationNumber++)
        {
            int sum = 0;
            int elementsUsed = 0;
            for (int indexOfElement = 0; indexOfElement < array.Length; indexOfElement++)
            {
                if ((combinationNumber & (1 << indexOfElement)) != 0)
                {
                    sum += array[indexOfElement];
                    elementsUsed++;
                    if (elementsUsed==targetElementsUsed)
                    {
                        break;
                    }
                }
            }
            if (sum == targetSum&&elementsUsed==targetElementsUsed)
            {
                return combinationNumber;
            }
        }
        return 0;
    }
}

        }

