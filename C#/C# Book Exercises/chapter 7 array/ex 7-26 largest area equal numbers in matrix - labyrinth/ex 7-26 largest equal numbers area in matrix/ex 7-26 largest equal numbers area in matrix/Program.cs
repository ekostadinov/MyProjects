using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> coordsQueueToVisit = new Queue<int[]>();
            int[,] matrix = { 
                {3, 3, 2, 2, 2, 4},
                {3, 3, 3, 2, 4, 4},
                {4, 3, 1, 2, 3, 3},
                {4, 3, 1, 3, 3, 1},
                {4, 3, 3, 3, 1, 1},
                 };

            bool[,] isVisited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            int[,] navigator = {{ 1, 0 },
                            { 0, 1 },
                            {-1, 0 },
                            { 0,-1 }};

            int bestLenght = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int workingRow = row;
                    int workingCol = col;
                    int workingElement = matrix[row, col];
                    int elementsFoundCounter = 0;

                    while (!isVisited[workingRow, workingCol])
                    {
                        isVisited[workingRow, workingCol] = true;
                        elementsFoundCounter++;
                        int direction = 0;

                        while (true)
                        {
                            int nextRow = workingRow + navigator[direction, 0];
                            int nextCol = workingCol + navigator[direction, 1];

                            if (
                                nextRow != -1 && nextRow != matrix.GetLength(0)
                                && nextCol != -1 && nextCol != matrix.GetLength(1)
                                && !isVisited[nextRow, nextCol]
                                && matrix[nextRow, nextCol] == workingElement
                               )
                            {
                                int[] packOfCoords = { nextRow, nextCol };

                                bool isUnique = true;
                                foreach (var coords in coordsQueueToVisit)
                                {
                                    if (coords[0] == nextRow && coords[1] == nextCol)
                                    {
                                        isUnique = false;
                                    }
                                }

                                if (isUnique)
                                {
                                    coordsQueueToVisit.Enqueue(packOfCoords);
                                }

                            }
                            direction++;
                            if (direction == 4)
                            {
                                direction = 0;
                                break;
                            }
                        }

                        int[] nextPackCoords;
                        try
                        {
                            nextPackCoords = coordsQueueToVisit.Dequeue();
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Area of {0} elements found. ", elementsFoundCounter);
                            if (bestLenght < elementsFoundCounter)
                            {
                                bestLenght = elementsFoundCounter;
                            }
                            break;
                        }
                        workingRow = nextPackCoords[0];
                        workingCol = nextPackCoords[1];
                    }
                }
            }
            Console.WriteLine("Best lenght is of {0} elements.", bestLenght);
        }
    }
}
