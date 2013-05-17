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
            Console.WriteLine("Enter single roman number: ");
            
            string [] arr = new string [] {Console.ReadLine()};

            
                for (int index = 0; index < arr.Length; index++)
                {
                    Console.WriteLine(arr[index]);

                    switch (arr[index])
                    {
                        case "I":
                            Console.WriteLine(1); break;
                        case "V":
                            Console.WriteLine(5); break;
                        case "X":
                            Console.WriteLine(10); break;
                        case "L":
                            Console.WriteLine(50); break;
                        case "C":
                            Console.WriteLine(100); break;
                        case "D":
                            Console.WriteLine(500); break;
                        case "M":
                            Console.WriteLine(1000); break;

                        default:
                            Console.WriteLine("Invalid number!"); break;
                    }
                }
            

            


        }
    }
}
