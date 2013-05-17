using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_11a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] RomanicNumerals = { "I", "V", "X", "L", "C", "D", "M"};

            Console.WriteLine("Enter a roman number: ");
            string inRoma = Console.ReadLine();
            inRoma = inRoma.ToUpper();
            int inArab = 0;
            int oldValue = 0;

            Console.WriteLine("Your number in arabic is: ");

            for (int i = 0; i < RomanicNumerals.Length; i++)
            {
                int newValue = 0;
                char ch = inRoma[i];

                switch (ch)
                {
                    case 'I':
                        newValue = 1; break;
                    case 'V':
                        newValue = 5; break;
                    case 'X':
                        newValue = 10; break;
                    case 'L':
                        newValue = 50; break;
                    case 'C':
                        newValue = 100; break;
                    case 'D':
                        newValue = 500; break;
                    case 'M':
                        newValue = 1000; break;

                    default:
                        Console.WriteLine("Invalid number!"); break;
                }

                if (newValue > oldValue)
                {
                    inArab += newValue - 2 * oldValue;
                }
                else
                {
                    inArab += newValue;
                }
                Console.WriteLine(inArab);
            }

            
        }
    }
}
