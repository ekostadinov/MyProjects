using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's enter an array.");
            Console.Write("Enter array's lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter array[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int elementWithMaxOccurences = array[0];
            int currentLenght = 1;
            int maxLenght = currentLenght;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLenght++;
                    if (currentLenght > maxLenght)
                    {
                        maxLenght = currentLenght;
                        elementWithMaxOccurences = array[i];
                    }
                    else
                    {
                        currentLenght = 1;
                    }
                }
            }
            Console.WriteLine("Element with maximum consecutive occurences: " + elementWithMaxOccurences);
            Console.WriteLine("How long is the maximum sequence in which it occurs: {0}", maxLenght);
        }
    }
}
