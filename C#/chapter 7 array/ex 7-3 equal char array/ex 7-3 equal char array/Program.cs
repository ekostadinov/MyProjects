using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_3
{
    class Program
    {
        static void Main(string[] args)
        {            
            char[] arr = {'a', 'b', 'd', 'f', 'a'};
            char[] arr2 = { 'a', 'b', 'd', 'a', 'c'};

            int length = arr.Length;
            int length2 = arr2.Length;

            if (length != length2)
            {
                if (length > length2)
                {
                    Console.WriteLine("The second array is  earlier lexicographicaly");
                }
                else
                {
                    Console.WriteLine("The first array is  earlier lexicographicaly");
                }
            }
            else
            {
                Console.WriteLine("The arrays are with equal length !");
            }

            for (int i = 0; i < length; i++)
            {
                if (arr[i] != arr2[i])
                {
                    if (arr[i] < arr2[i])
                    {
                        Console.WriteLine("This char is earlier lexicographicaly, so the first array is earlier !");
                        
                    }
                    else
                    {
                        Console.WriteLine("This char is earlier lexicographicaly, so the second array is earlier !");
                    }
                }
                else
                {
                    Console.WriteLine("equal char!");
                }
            }
            



        }
    }
}
