using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_13_9_CreateCode
{
    class DoCode
    {
        static void Main()
        {
            Console.WriteLine("Enter text for codding:");
            string text = Console.ReadLine();

            Console.WriteLine("Enter code for codding (exp. ab):");
            string cipter = Console.ReadLine();

            for (int index = 0; index < text.Length; index++)
            {
                foreach (var item in cipter)
	                {
	                	 if (text[index] != null && item != null)
                                {
                                    Console.WriteLine((ushort)text[index] ^ (ushort)cipter[cipter.Length % index]);   
                                }
	                }                                                           
            }
        }
    }
}
