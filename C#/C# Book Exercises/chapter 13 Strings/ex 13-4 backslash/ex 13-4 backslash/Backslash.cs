using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_13_4_backslash
{
    class Backslash
    {
        static void Main()
        {
            Console.WriteLine("Enter text using backslash ('\\') to separate words!");
            string userText = Console.ReadLine();

            char[] separators = new char[] {' ', '\\', ',', '.' };
            string[] textArray = userText.Split(separators);

            foreach (var text in textArray)
            {                
                    Console.Write(text);                
            }

            Console.WriteLine();
            Console.WriteLine("*****************************************");

            char[] trimChars = new char[] {' ', '1', '$', '%', '#', 's', '\\'};
            string reduced = userText.Trim(trimChars);

            Console.WriteLine("rediced {0}", reduced);
            Console.WriteLine();
            Console.WriteLine("*****************************************");

            string[] textArr = userText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string words in textArr)
            {
                Console.Write(words);
            }
            Console.WriteLine();            
        }
    }
}
