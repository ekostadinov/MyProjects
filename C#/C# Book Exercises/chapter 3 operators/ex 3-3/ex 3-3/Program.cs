using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи число с цифра трета 7 от дясно на ляво!");
            string line = Console.ReadLine();
            long value;
            long.TryParse(line, out value);
            Console.WriteLine(value % 100);

            int result;
            int.TryParse(line, out result);
            Console.WriteLine(result % 10);

            if (result == 7)

                Console.WriteLine("Резултат!");

            else
                Console.WriteLine("Опитай отново!");


        }
    }
}
