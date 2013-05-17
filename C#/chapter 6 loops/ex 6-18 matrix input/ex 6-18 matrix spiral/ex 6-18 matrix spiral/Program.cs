using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_6_18_matrix_spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number ot rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number ot columns: ");
            int cols = int.Parse(Console.ReadLine());

            int [,] matrix = new int [rows, cols];

            for (int row = 0; row < rows; row++ )
            {
                for (int col = 0; col < cols; col++ )
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            };





        }
    }
}
