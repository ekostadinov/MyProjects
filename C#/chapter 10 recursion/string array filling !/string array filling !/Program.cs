using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace string_array_filling__
{
    class Program
    {
        static string[] wordsArray;
        static int index;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of words you want to input!");
            string sizeInput = Console.ReadLine();
            int arrSize = int.Parse(sizeInput);

            wordsArray = new string [arrSize];

            for ( index = 0; index < wordsArray.Length; index++ )
            {
                Console.Write("Enter word {0}: ", index);
                wordsArray[index] = Console.ReadLine();
                 
                 PrintInputWords();   
            }
                     
      
        }

        static void PrintInputWords()
        {
            Console.WriteLine("Your array of words is: ");
            Console.WriteLine(wordsArray[index]);
        }



    }
}
