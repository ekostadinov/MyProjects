using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 , 16, 17, 18, 19, 20};

            int length = myArr.Length;

            for (int index = 0; index < length; index++)
            {
                Console.Write(index*2 + " ");
            };
            Console.WriteLine();       
        
        }
    }
}
