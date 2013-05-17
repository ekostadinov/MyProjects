using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_24
{
    class Program
    {
            static int numberOfLoops;
            static int numberOfIterations;
            static int [] loops;

        static void Main()
        {
            Console.WriteLine("Enter number for permutation!");
            numberOfIterations = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of combinations!");
            numberOfLoops = int.Parse(Console.ReadLine());

            loops = new int [numberOfLoops];

            NestedLoops (0);
        }

        static void NestedLoops(int curentLoop)
        {
            if (curentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }
            
            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[curentLoop] = counter;
                NestedLoops(curentLoop + 1);
            }
            }
    
            static void PrintLoops()
            {
                for ( int i = 0; i < numberOfLoops; i++)
                {
                    Console.Write("{0} ", loops[i]);
                }
                Console.WriteLine();
            }
    }
    
    
    
    
    
    
    }
    
