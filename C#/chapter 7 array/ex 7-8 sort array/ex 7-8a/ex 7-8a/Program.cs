using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_7_8a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length and then values!");
            int n = int.Parse(Console.ReadLine());

            int [] values = new int [n];

            for (int index = 0; index <= values.Length - 1; index++)
            {
                Console.Write("Enter value for [{0}] : ", index);
                values[index] = int.Parse(Console.ReadLine());

                Array.Sort(values);
                foreach (int value in values)
                {
                    Console.Write(value);
                    Console.Write( ' ' );
                }
                Console.WriteLine();
             }
            
        }
    }
}
