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
        static int index4;


        static void Main(string[] args)
        {
            Console.WriteLine("If your words host is: ");

            ShowWords();
            Console.WriteLine();

            Console.WriteLine("All sub-hosts are: ");
            combNum = 2;
            elNum = 3;

            array = new int[combNum];

            GetFirstCombo();
            Console.Write(", ");

            GetSecondCombo();
            Console.Write(", ");

            GetThirdCombo();
            Console.Write(", ");

            GetFourthCombo();

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

        static void GetFirstCombo()
        {
            Console.Write("()");
        }

        static void GetSecondCombo()
        {
            for (index = 1; index <= elNum; index++)
            {
                // Console.Write("({0}),", index);
                PrintWords();
            }
        }

        static void GetThirdCombo()
        {
            for (index2 = 1; index2 <= elNum; index2++)
            {
                for (index3 = 1; index3 <= elNum; index3++)
                {
                    //Console.Write("({0} {1}), ", index2, index3);
                    PrintWords();
                }
            }
        }

        static void GetFourthCombo()
        {
            for (index4 = 1; index4 <= elNum; index4++)
            {
                //Console.Write(index4);
                PrintWords();
            }
        }

        static void PrintWords()
        {
            switch (index)
            {
                case 1:
                    Console.Write("(test)"); break;
                case 2:
                    Console.Write("(rock)"); break;
                case 3:
                    Console.Write("(fun)"); break;
                default:
                    Console.Write(" "); break;
            }


            switch (index2)
            {
                case 1:
                    Console.Write("(test, "); break;
                case 2:
                    Console.Write("(rock, "); break;
                case 3:
                    Console.Write("(fun, "); break;
                default:
                    Console.Write(" "); break;
            }

            switch (index3)
            {
                case 1:
                    Console.Write("test)"); break;
                case 2:
                    Console.Write("rock)"); break;
                case 3:
                    Console.Write("fun)"); break;
                default:
                    Console.Write(" "); break;
            }

            switch (index4)
            {
                case 1:
                    Console.Write("(test, "); break;
                case 2:
                    Console.Write("rock, "); break;
                case 3:
                    Console.Write("fun)"); break;
                default:
                    Console.Write(" "); break;
            }
        }
        // the logic in second and in fourth combo is the same, use it for more elegant solution

    }
}
