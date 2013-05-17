using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_13_7_populateString
{
    class CheckInput
    {
        static void Main()
        {
            Console.WriteLine("Enter 20 max chars string: ");
            string userInput = Console.ReadLine();
            
            while (userInput.Length > 20)
            {
                Console.WriteLine("Enter 20 max chars string:");
                userInput = Console.ReadLine();
            }
            if (userInput.Length < 20)
            {
                Console.WriteLine(userInput.PadRight(20, '*'));
                
            }
            if (userInput.Length == 20)
            {
                Console.WriteLine(userInput);
            }
            Console.WriteLine();
        }
    }
}
