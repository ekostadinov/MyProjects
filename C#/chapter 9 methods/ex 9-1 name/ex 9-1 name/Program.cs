using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_1
{
    class Program
    {
        public static void Main(string[] args)
        {    
            Console.WriteLine("Enter your name: ");
            
            PrintName();          
        }
        
        public static void PrintName()
        {
            string name = Console.ReadLine();

            Console.Write("Hello, {0}!", name);
            Console.WriteLine();
        }



    }
}
