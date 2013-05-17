using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] rect = 
            {
                {"ha", "fifi", "ho", "hi"},
                {"fo", "ha", "hi", "xx"},
                {"xxx", "ho", "ha", "xx"},                
            };


            int maxSequence = 1;
            int rowOfBestStartElement = 0;
            int colOfBestStartElement = 0;
            int bestDirection = 0;
            string bestElementValue = null;

            for (int row = 0; row < rect.GetLength(0); row++)
            {
                for (int col = 0; col < rect.GetLength(1); col++)
                {
                    for (int direction = 0; direction <= 2; direction++)
                    {

                        int rowIterator = 0;
                        int colIterator = 0;
                        switch (direction)
                        {
                            case 0:
                                rowIterator = 1;
                                break;
                            case 1:
                                colIterator = 1;
                                break;
                            case 2:
                                rowIterator = 1;
                                colIterator = 1;
                                break;
                        }

                        string workingElement = rect[row, col];
                        int sequence = 1;

                        int rowOfNextElement = row + rowIterator;
                        int colOfNextElement = col + colIterator;
                        while (rowOfNextElement != rect.GetLength(0)
                            && colOfNextElement != rect.GetLength(1)
                            && rect[rowOfNextElement, colOfNextElement] == workingElement)
                        {
                            sequence++;
                            rowOfNextElement += rowIterator;
                            colOfNextElement += colIterator;
                        }
                        if (sequence > maxSequence)
                        {
                            bestElementValue = workingElement;
                            bestDirection = direction;
                            maxSequence = sequence;
                            rowOfBestStartElement = row;
                            colOfBestStartElement = col;
                        }
                    }
                }
            }

            for (int row = 0; row < rect.GetLength(0); row++)
            {
                for (int col = 0; col < rect.GetLength(1); col++)
                {
                    Console.Write("{0} ", rect[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            string directionStr = "";
            switch (bestDirection)
            {
                case 0:
                    directionStr = "GOING DOWN";
                    break;
                case 1:
                    directionStr = "GOING RIGHT";
                    break;
                case 2:
                    directionStr = "GOING DOWN RIGHT";
                    break;

            }
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write("{0} ", bestElementValue);
            }
            Console.WriteLine();
            Console.WriteLine("ROW:{0} COL:{1} DIRECTION:{2}", rowOfBestStartElement, colOfBestStartElement, directionStr);
        }
    }
}
