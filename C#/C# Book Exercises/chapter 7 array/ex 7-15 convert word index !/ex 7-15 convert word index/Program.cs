using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The letters in English alphabet are: ");

            string[] alphabet = { 
            "A", "B", "C",	"D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
            "O", "P", "Q", "R", "S", "T", "U", "V","W", "X", "Y", "Z"};

            foreach (string letters in alphabet)
            {
                Console.Write(letters + " ");
            }
            Console.WriteLine();            

            Console.WriteLine("Please enter a word!");
            string word = Console.ReadLine();
            word = word.ToUpper();

            Console.WriteLine("The index of your letters is: ");

            foreach (var symbol in word)
            {
                Console.Write(symbol + " = ");

                switch (symbol)
                {
                        case 'A':
                            Console.Write(0 + " ");break;
                        case 'B':
                            Console.Write(1 + " "); break;
                        case 'C':
                            Console.Write(2 + " "); break;
                        case 'D':
                            Console.Write(3 + " "); break;
                        case 'E':
                            Console.Write(4 + " "); break;
                        case 'F':
                            Console.Write(5 + " "); break;
                        case 'G':
                            Console.Write(6 + " "); break;
                        case 'H':
                            Console.Write(7 + " "); break;
                        case 'I':
                            Console.Write(8 + " "); break;
                        case 'J':
                            Console.Write(9 + " "); break;
                        case 'K':
                            Console.Write(10 + " "); break;
                        case 'L':
                            Console.Write(11 + " "); break;
                        case 'M':
                            Console.Write(12 + " "); break;
                        case 'N':
                            Console.Write(13 + " "); break;
                        case 'O':
                            Console.Write(14 + " "); break;
                        case 'P':
                            Console.Write(15 + " "); break;
                        case 'Q':
                            Console.Write(16 + " "); break;
                        case 'R':
                            Console.Write(17 + " "); break;
                        case 'S':
                            Console.Write(18 + " "); break;
                        case 'T':
                            Console.Write(19 + " "); break;
                        case 'U':
                            Console.Write(20 + " "); break;
                        case 'V':
                            Console.Write(21 + " "); break;
                        case 'W':
                            Console.Write(22 + " "); break;
                        case 'X':
                            Console.Write(23 + " "); break;
                        case 'Y':
                            Console.Write(24 + " "); break;
                        case 'Z':
                            Console.Write(25 + " "); break;
                    default:
                            Console.WriteLine("I told you - You're stupid!");break;

                }
            }

            
            


        }
    }
}
