using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_10_4
{
    class Program
    {
        static int [] array;
        static string [] wordsArray;
        static int combNum;
        static int elNum;
        static int index;
        

        static void Main(string[] args)
        {
            Console.WriteLine("If your words are: ");

            ShowWords();
            Console.WriteLine();
            
            Console.WriteLine("Enter how many words combinations you want!");
            combNum = int.Parse(Console.ReadLine());
            elNum = 3;
            array = new int[elNum];

            Console.WriteLine("The {0} combinations of the words are: ", combNum);
            GetCombinations(0);
            Console.WriteLine();
            
            
        }

        static void ShowWords()
        {
            wordsArray = new string[] {"test", "rock", "fun"};

            foreach (string words in wordsArray)
            {
                Console.Write("'{0}' ", words);
            }
        }


        static void GetCombinations(int currentCombo)
        {
            if (currentCombo >= combNum)
            {
                PrintCombinations();
                return;
            }

            for (int counter = 1; counter <= elNum; counter++)
            {
                array[currentCombo] = counter;
                GetCombinations(currentCombo + 1);
            }

        }

        static void PrintCombinations()
        {
            
            for (index = 0; index < combNum; index++)
            {
                // Console.Write("{0} ", array[index]);
                PrintFinalWords();
            }
            Console.WriteLine();
        }

        static void PrintFinalWords()
        {
            
            if (array[index] <= elNum)
            {
                switch (array[index])
                {
                    case 1:
                        Console.WriteLine("test");break;
                    case 2:
                        Console.WriteLine("rock");break;
                    case 3:
                        Console.WriteLine("fun");break;
                    default:
                        Console.WriteLine("You entered too may combinations for your words! Try with 2 combos!");break;
                }

            }
            
        }



    }
}
