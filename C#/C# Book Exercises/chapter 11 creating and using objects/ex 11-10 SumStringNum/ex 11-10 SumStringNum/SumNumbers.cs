using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11_10_SumStringNum
{
    class SumNumbers
    {
        static string[] eachNum;
        static int[] numbersArray;
        static int index;

        static void Main(string[] args)
        {
            string numbers = "43 68 9 23 318";
            Console.WriteLine("The string numbers are: {0}!", numbers);

            eachNum = numbers.Split(' ');

            for (index = 0; index <= eachNum.Length - 1; index++ )
            {
               // Console.WriteLine(eachNum[index]);
                int eachNumber = Convert.ToInt32(eachNum[index]);
                numbersArray = new int [eachNumber];
                               
                Console.WriteLine(eachNumber); // prints each number as a int

                // missing logic how to sum the numbers, eachNumber = 0 ???
                               
                
            }

            Console.WriteLine();
        }

        
        

    }
}
