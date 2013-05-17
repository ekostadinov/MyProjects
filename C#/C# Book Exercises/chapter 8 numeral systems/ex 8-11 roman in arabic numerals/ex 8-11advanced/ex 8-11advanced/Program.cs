using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inRomanic = { "I", "V", "X", "L", "C", "D", "M"};

            Console.WriteLine("Enter a roman number: ");
            string num = Console.ReadLine();
            num = num.ToUpper();

            int sum = 0;

            Console.WriteLine("Your number in arabic is the sum of: ");

            foreach (var symbol in num)
            {            
 
                switch (symbol)
                {
                    case 'I':
                        Console.WriteLine(1); break;
                    case 'V':
                        Console.WriteLine(5); break;
                    case 'X':
                        Console.WriteLine(10); break;
                    case 'L':
                        Console.WriteLine(50); break;
                    case 'C':
                        Console.WriteLine(100); break;
                    case 'D':
                        Console.WriteLine(500); break;
                    case 'M':
                        Console.WriteLine(1000); break;

                    default:
                        Console.WriteLine("Invalid number!"); break;
                }

                Console.Write(" + ");
            }


            


            


               
            



            

           
        }
    }
}
