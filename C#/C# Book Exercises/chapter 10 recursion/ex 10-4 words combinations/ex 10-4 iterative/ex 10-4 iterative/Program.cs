using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_10_4_iterative
{
    class Program
    {
        static int[] array;
        static string[] wordsArray;
        static int combNum;
        static int index;
        static int index2;

        static void Main(string[] args)
        {
            Console.WriteLine("If your words are: ");

            ShowWords();
            Console.WriteLine();

            Console.WriteLine("Enter how many words combinations you want!");
            combNum = int.Parse(Console.ReadLine());
            
            
            array = new int[combNum];

            Console.WriteLine("The {0} combinations of the words are: ", combNum);
            GetCombinations();
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
                
            static void GetCombinations()
             {
                    for (index = 1; index <= combNum; index++)
                    {
                        for (index2 = 1; index2 <= combNum; index2++)
                        {
                            Console.Write("({0} {1}), ", index, index2);
                            PrintFinalWords();
                        }
                    }
             }

            static void PrintFinalWords()
            {

                if (combNum <= 3)
                {
                    SwitchWords();
                }
                else
                {
                    Console.WriteLine("You entered too many combos for just 3 words! Try with 2 or 3 combos!");
                }
            }

            static void SwitchWords()
            {
                switch (index)
                {
                    case 1:
                        Console.WriteLine("test"); break;
                    case 2:
                        Console.WriteLine("rock"); break;
                    case 3:
                        Console.WriteLine("fun"); break;
                    default:
                        Console.WriteLine("No more words for you!"); break;
                }

                switch (index2)
                {
                    case 1:
                        Console.WriteLine("test"); break;
                    case 2:
                        Console.WriteLine("rock"); break;
                    case 3:
                        Console.WriteLine("fun"); break;
                    default:
                        Console.WriteLine("No more words for you!"); break;
                }

            }

    }
}
