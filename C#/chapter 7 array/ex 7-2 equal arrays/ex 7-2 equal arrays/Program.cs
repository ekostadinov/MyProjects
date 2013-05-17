using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = {1, 2, 3, 4, 5, 6};

            int [] arr2 = {1, 2, 3, 4};

            int length = arr.Length;
            int length2 = arr2.Length;

            for (int index = 0; index < length; index++)
            {
                for (int index2 = 0; index2 < length2; index2++)
                {

                    if (index != index2 && length != length2)
                    {
                        Console.WriteLine("The arrays are NOT equal !");
                    }
                    else
                    {
                        Console.WriteLine("The arrays are equal !");
                    }
               }
            };



        }
    }
}
