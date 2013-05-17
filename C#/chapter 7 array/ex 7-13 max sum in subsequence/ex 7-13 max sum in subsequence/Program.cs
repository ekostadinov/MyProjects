using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {1, 2, 7, 6, 8, 4, 4},
                {3, 3, 8, 3, 5, 9, 3},
                {4, 6, 4, 3, 8, 9, 2},
                {5, 7, 9, 2, 5, 8, 8}
            };

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) ; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int sum = matrix[row, col] + 
                        matrix[row, col + 1] + 
                        matrix [row + 1, col] + 
                        matrix [row + 1, col + 1] + 
                        matrix [row, col + 2] + 
                        matrix[row + 1, col + 2] +
                        matrix[row + 2, col + 2] + 
                        matrix [row + 2, col] +
                        matrix [row +2, col + 1];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine("The best platform is: ");
            Console.WriteLine(" {0} {1} {2}",
                matrix [bestRow, bestCol],
                matrix [bestRow, bestCol + 1],
                matrix [bestRow, bestCol + 2]);
            Console.WriteLine("{0} {1} {2]",
                matrix [bestRow + 1, bestCol],
                matrix [bestRow + 1, bestCol + 1],
                matrix [bestRow + 1, bestCol + 2]);
            Console.WriteLine("{0} {1} {2]",
                matrix [bestRow + 2, bestCol],
                matrix [bestRow + 2, bestCol + 1],
                matrix [bestRow + 2, bestCol + 2]);
            Console.WriteLine("The max sum is: {0}", bestSum);

        }
    }
}
