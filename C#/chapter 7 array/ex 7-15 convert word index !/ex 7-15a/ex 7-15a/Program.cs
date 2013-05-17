using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_15a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to convert: ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToUpper();
            foreach (var symbol in userInput)
            {
                int charIndex = (int)(symbol - 'A');
                Console.Write("{0}, ", charIndex);
            }
            Console.WriteLine();
        }
    }
}
