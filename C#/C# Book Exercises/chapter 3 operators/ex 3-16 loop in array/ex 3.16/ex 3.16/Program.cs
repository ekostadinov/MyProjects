using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleInput;
            consoleInput = Console.ReadLine();
            char n = char.Parse(consoleInput);

            char rows = char.Parse(Console.ReadLine());
            char cols = char.Parse(Console.ReadLine());
            char[,] binaryArray = new char[24, 24];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("binary [{0},{1}]=", 24, 24);
                    binaryArray[24, 24] = char.Parse(Console.ReadLine());
                }
            }
        }
    }
}
