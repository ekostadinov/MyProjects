using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value for N, if N < 0 !");
            int n = int.Parse(Console.ReadLine());
            

            for (int row = 1; row <= n; row++)
            {
                for (int col = row ; col <= row + (n - 1); col++)
                {
                    Console.Write(col + " ");
                    
                }
                Console.WriteLine(); 
            }


        }
    }
}
