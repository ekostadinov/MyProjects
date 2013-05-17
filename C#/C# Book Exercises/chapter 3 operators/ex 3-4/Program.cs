using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число с трети бит 1:");
            string line = Console.ReadLine();
            int value;
            
            int.TryParse(line, out value);
            int b = 8;
            if (value != b)
            {
                Console.WriteLine("Въведеното число е с трети бит 0");
            }
            else
            {
                Console.WriteLine("Успех! Въведеното число е с трети бит 1");
            }
            }
    }
}
