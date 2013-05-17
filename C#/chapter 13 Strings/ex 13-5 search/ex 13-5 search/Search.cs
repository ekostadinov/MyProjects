using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_13_5_search
{
    class Search
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string someText = Console.ReadLine();

            string textLower = someText.ToLower();
            //Console.WriteLine(textLower);

            Console.WriteLine("Enter the word that you want to search in the text:");
            string word = Console.ReadLine();

            int index = someText.IndexOf(word);

            while (index != -1)
            {
                Console.WriteLine("{0} found at index {1}", word, index);
                index = someText.IndexOf(word, index + 1);
            }
            

        }
    }
}
