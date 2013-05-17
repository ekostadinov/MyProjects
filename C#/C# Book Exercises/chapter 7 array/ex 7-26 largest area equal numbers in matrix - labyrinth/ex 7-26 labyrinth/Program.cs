using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_26
{
    class Program
    {
       static char[,] matrix = new char[5, 6]
        {
                {'3', '3', '2', '2', '2', '4'},
                {'3', '3', '3', '2', '4', '4'},
                {'4', '3', '1', '2', '3', 'E'},
                {'4', '3', '1', '3', '3', '1'},
                {'4', '3', '3', '3', '1', '1'},
        };

        static void ShowMatrix()
        {

                for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j]+ " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
        }

        static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < matrix.GetLength(0);

            bool colInRange = col >= 0 && col < matrix.GetLength(1);

            return rowInRange && colInRange;
        }
         

        static void FindPathToExit(int row, int col)

        {
            if (!InRange(row, col))
            {
                return;
            } 

            if (matrix[row, col] == 'E')
            {
                ShowMatrix();
            }

            if (matrix[row, col] != '3')
            {
                return; 
            } 

            matrix[row, col] = 'v';

            FindPathToExit(row, col - 1); // left

            FindPathToExit(row - 1, col); // up

            FindPathToExit(row, col + 1); // right

            FindPathToExit(row + 1, col); // down

            matrix[row, col] = '3';
       }
 

        static void Main(string[] args)
        {
            FindPathToExit(0, 0);
        }
    }
}
