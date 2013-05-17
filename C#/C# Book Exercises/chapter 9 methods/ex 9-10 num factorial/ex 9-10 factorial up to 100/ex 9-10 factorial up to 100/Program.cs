using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ex_9_10
{
    class Program
    {
        static BigInteger Getfactorial(BigInteger factNum)
        {
            for (int num = 1; num <= 100; num++)
            {
                int [] arr = new int [num];
                for (int index = 0; index < arr.Length - 1; index++ )
                {
                    do
                    {
                        factNum *= arr[index];
                        arr[index]--;
                    } while (arr[index] > 0);
                    
                }     
            Console.WriteLine(factNum);	
            }
            // does factorial 100 times but only for the the first number
            return factNum;
        }

        static int PrintNumbers(int num)
        {
            for (num = 1; num <= 100; num++)
            {
                Console.WriteLine(num);
            }            
            return num;
        }


        static void Main(string[] args)
        {
            BigInteger factNum = 1;
            int num = 1;

            PrintNumbers(num);
            Console.WriteLine();
            
            Getfactorial(factNum);
            Console.WriteLine();
        }
    }
}
