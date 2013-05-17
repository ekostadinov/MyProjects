using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_10_5
{
    class Program
    {
        static int[] array;
        static string[] wordsArray;
        static int combNum;
        static int elNum;
        static int index;
        static int index2;
        static int index3;

         

        static void Main(string[] args)
        {
            Console.WriteLine("If your words host is: ");

            ShowWords();
            Console.WriteLine();

            Console.WriteLine("All sub-hosts are: ");

            combNum = 2;
            elNum = 3;
            array = new int [elNum];

            GetFirstCombination();
            
            GetSecondCombination(0);
            Console.WriteLine();

            GetThirdCombination(0);
            Console.WriteLine();

            Console.Write("(");
            GetFourthCombination(0);
            Console.Write(")");
            Console.WriteLine();
            

        }

        static void ShowWords()
        {
            wordsArray = new string[] { "test", "rock", "fun" };

            foreach (string words in wordsArray)
            {
                Console.Write("'{0}' ", words);
            }
        }

        static void GetFirstCombination()
        {
            Console.WriteLine("()");
        }

        static void GetSecondCombination(int currentCombination)
        {
            if (currentCombination <= combNum)
            {
                PrintSecondCombination();
                return;
            }

            for (int counter = 1; counter <= elNum; counter++)
            {
                array[currentCombination] = counter;
                GetSecondCombination(currentCombination);
            }
        }

        static void PrintSecondCombination()
        {
            for (index = 1; index <= elNum; index++ )
                {
                     //Console.Write("({0}) ", index);
                    PrintSecondWords();
                }
        }

        static void PrintSecondWords()
        {
            if (index <= elNum)
            {
                switch (index)
                {
                    case 1:
                        Console.Write("(test), "); break;
                    case 2:
                        Console.Write(" (rock), "); break;
                    case 3:
                        Console.Write(" (fun), "); break;
                    default:
                        Console.WriteLine("You entered too may combinations for your words! Try with 2 combos!"); break;
                }

            }
        }

        static void GetThirdCombination(int currentCombination2)
        {
            if (currentCombination2 >= combNum)
            {
                PrintThirdCombination();
                return;
            }

            for (int counter = 1; counter <= elNum; counter++)
            {
                array[currentCombination2] = counter;
                GetThirdCombination(currentCombination2 + 1);
            }

        }

        static void PrintThirdCombination()
        {
            for (index2 = 0; index2 <= combNum; index2++)
            {
                // Console.Write("({0}) ", array[index2]);   
                PrintThirdWords();
            }
        }

        static void PrintThirdWords()
        {
            if (array[index2] <= elNum)
            {
                switch (array[index2])
                {
                    case 0:
                        Console.Write(", ");break;
                    case 1:
                        Console.Write("test"); break;
                    case 2:
                        Console.Write(" rock "); break;
                    case 3:
                        Console.Write(" fun "); break;
                    default:
                        Console.WriteLine("You entered too may combinations for your words! Try with 2 combos!"); break;
                }

            }
        }

        static void GetFourthCombination(int currentCombination3)
        {
            if (currentCombination3 <= combNum)
            {
                PrintFourthCombination();
                return;
            }

            for (int counter = 1; counter <= elNum; counter++)
            {
                array[currentCombination3] = counter;
                GetSecondCombination(currentCombination3);
            }
        }

        static void PrintFourthCombination()
        {
            for (index3 = 1; index3 <= elNum; index3++)
            {                
                // Console.Write(index3);
                PrintFourthWords();
            }
        }

        static void PrintFourthWords()
        {
            if (index3 <= elNum)
            {
                switch (index3)
                {                    
                    case 1:
                        Console.Write("test,"); break;
                    case 2:
                        Console.Write(" rock, "); break;
                    case 3:
                        Console.Write("fun "); break;
                    default:
                        Console.WriteLine("You entered too may combinations for your words! Try with 2 combos!"); break;
                }

            }
        }
        // You can use secondhand method call in some main methods (as in 'printwords4' you may 
        // use 'print words2') to avoid useless code
    }
}
