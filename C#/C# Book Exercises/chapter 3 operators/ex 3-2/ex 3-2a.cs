using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля, въведете цяло число, което да се дели на 5 и 7:");
            string line = Console.ReadLine();
            int value;
            int.TryParse(line, out value);
            bool a = value % 5;
            bool b = value % 7;
            if (value % (a && b))
                Console.WriteLine("Въведеното число е кратно на 5 и 7 !");

            else
                Console.WriteLine("Въведеното число не е кратно на 5 и 7 !");
        
        }
    }
}



