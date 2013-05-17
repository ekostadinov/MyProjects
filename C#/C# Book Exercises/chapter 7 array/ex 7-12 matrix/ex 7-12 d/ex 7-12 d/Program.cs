using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_12_d
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

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int side = matrix.GetLength(0);
                    int xCoord = 0;
                    int yCoord = 0;
                    int directorion = 0;
                    side = matrix.GetLength(0);
                    int[,] navigator = {
                                    { 1, 0 },
                                    { 0, 1 },
                                    { -1, 0 },
                                    { 0, -1 }
                                   };
                    for (int iterator = 1; iterator <= side * side; iterator++)
                    {
                        matrix[xCoord, yCoord] = iterator;
                        int nextXcoord = xCoord + navigator[directorion, 0];
                        int nextYcoord = yCoord + navigator[directorion, 1];
                        if (nextXcoord == side || nextXcoord == -1 || nextYcoord == side || nextYcoord == -1
                            || matrix[nextXcoord, nextYcoord] != 0)
                        {
                            directorion++;
                            directorion %= 4;
                            Console.Write("[{0 , 1}]", matrix[xCoord, yCoord]);
                        }
                        Console.WriteLine();
                    }
                }
            }


        }
    }
}
