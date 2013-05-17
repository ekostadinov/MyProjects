using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_13_8_UnicodeString
{
    class TransformString
    {
        static void Main()
        {
            Console.WriteLine("Enter some string:");
            string userInput = Console.ReadLine();

            foreach (var item in userInput)
            {
                Console.Write("{0:x4}\\", (ushort)item);
            }
            Console.WriteLine();
        }
    }
}
