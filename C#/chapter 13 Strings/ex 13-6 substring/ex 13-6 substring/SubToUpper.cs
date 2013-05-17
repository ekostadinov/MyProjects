using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_13_6_substring
{
    class SubToUpper
    {
        static int index1;
        static int index2;
        static int pos1;
        static int pos2;

        static void Main()
        {
            Console.WriteLine("Enter text using: <upcase>words</upcase>:");
            string someText = Console.ReadLine();

            string tag1 = "<upcase>";
            string tag2 = "</upcase>";

            index1 = someText.IndexOf(tag1);
            index2 = someText.IndexOf(tag2);

            while (index1 != -1)
            {
                Console.WriteLine("{0} found at index {1}", tag1, index1);
                index1 = someText.IndexOf(tag1, index1 + 1);

                string i = someText.IndexOf(tag1, index1 + 1).ToString();
                Console.WriteLine(i);

                pos1 = 0;
                int.TryParse(i, out pos1);
                Console.WriteLine(pos1);


            }

            while (index2 != -1)
            {
                Console.WriteLine("{0} found at index {1}", tag2, index2);
                index2 = someText.IndexOf(tag2, index2 + 1);

                string i2 = someText.IndexOf(tag2, index2 + 1).ToString();
                Console.WriteLine(i2);

                pos2 = 0;
                int.TryParse(i2, out pos2);
                Console.WriteLine(pos2);
            }

            int midWords = pos2 - pos1 - 1;
            char middleWords = someText[midWords];
            Console.WriteLine(middleWords);
            
           //Console.WriteLine("{0} - {1}", index1, index2);
           // missing logic to find the words inbetween
            // substract index1 from index 2 (calculate length) and then .toupper
        }
    }
}
