using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int [,] matrix = new int [rows, cols];
            Console.WriteLine("Your matrix: ");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = (col + 1) + (row * matrix.GetLength(0));
                    Console.Write("[{0, 1}]", matrix[row, col]);
                }
                Console.WriteLine();
            }






        }
    }
}
