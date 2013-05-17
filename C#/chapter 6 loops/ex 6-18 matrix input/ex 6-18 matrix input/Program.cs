using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_6_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns:");
            int cols = int.Parse(Console.ReadLine());

            int [,] matrix = new int [rows, cols];
            Console.WriteLine("Enter cells of the matrix:");

            for (int row = 0; row < rows; row++ )
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix [{0}, {1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }


            



        }
    }
}
