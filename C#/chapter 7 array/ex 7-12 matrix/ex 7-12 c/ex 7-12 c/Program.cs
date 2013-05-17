using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_12_c
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

            int side = matrix.GetLength(0);
            int coordX = side - 1;
            int coordY = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    for (int counter = 1; counter <= side * side; counter++)
                    {
                        matrix[coordX, coordY] = counter;
                        int nextX = coordX + 1;
                        int nextY = coordY + 1;
                        if (nextX == side && nextY != side)
                        {
                            coordX = (side - coordY - 2);
                            coordY = 0;
                        }
                        else if (nextY == side)
                        {
                            coordY = (side - coordX);
                            coordX = 0;
                        }
                        else
                        {
                            coordX = nextX;
                            coordY = nextY;
                        }
                        Console.Write("[{0, 1}]", matrix [coordX, coordY]);
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
