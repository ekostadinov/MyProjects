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
            Console.WriteLine("Моля, въведете цяло число съдържащо трета цифра 7 от дясно на ляво:");
            string line = Console.ReadLine(); // Read string from console
            long value;
            long.TryParse(line, out value);
            Console.WriteLine(value % 100);

            
            long result;
            long.TryParse(line, out result);
            Console.WriteLine(result % 10);

            
            long number;
            long.TryParse(line, out number);
            Console.WriteLine(number);
            
            if (number == 7)
            {
                Console.WriteLine("e 7");
            }
            else
            {
                Console.WriteLine("Моля въведете цяло число съдържащо трета цифра 7 от дясно на ляво");
            }


        }
    }
}
