using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_10_2_iterative
{
    class Program
    {
        static int[] array;        
        static int elNum;
        static int combNum;
        static int index;
        static int index2;
        static string combo;
        static string combo2;
        static string comboAll;
        static string comboAllReverse;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements!");
            elNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of combinations!");
            combNum = int.Parse(Console.ReadLine());

            array = new int[elNum];

            Console.WriteLine("The combinations of your number are: ");
            GetCombinations();
            Console.WriteLine();
        }

        static void GetCombinations()
        {            
                for (index = 1; index <= elNum; index++)
                {
                    for (index2 = 1; index2 <= elNum; index2 ++)
                    {
                        Console.Write("({0} {1}), ",index, index2 );
                        
                        CombinationsCheck();   
                    
                    }
                }
        }

        static void CombinationsCheck()
        {
            Console.WriteLine();
            combo = index.ToString();
            combo2 = index2.ToString();

            ToStringCheck();            
        }

        static void ToStringCheck()
        {
            comboAll = combo + combo2;
            comboAllReverse = combo2 + combo;

            PrintResult();
            
        }

        static void PrintResult()
        {
            
            if (comboAll + 1 == comboAllReverse)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine(comboAll);
            }
        }


    }
}
