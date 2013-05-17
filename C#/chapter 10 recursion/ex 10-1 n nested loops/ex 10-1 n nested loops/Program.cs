using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_10_1_n_nested_loops
{
    class Program
    {
        static int loopNum;
        static int recNum;
        static int[] loopArr;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of nested loops!");
            loopNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number of recursions!");
            recNum = int.Parse(Console.ReadLine());

            loopArr = new int [recNum];

            NestedLoops(0);      

        }

        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == loopNum)
            {
                PrintLoops();
                return;
            }
            else
            {
                for (int counter = 1; counter <= recNum; counter++)
                {
                    loopArr[currentLoop] = counter;
                    NestedLoops(currentLoop + 1);
                }
            }
        }

        static void PrintLoops()
            { 
                for (int index = 0; index <= loopArr.Length; index++)
                    {
                        Console.Write("{0} ", loopArr[index]);
                    }
                    Console.WriteLine();
            }


    }
}
