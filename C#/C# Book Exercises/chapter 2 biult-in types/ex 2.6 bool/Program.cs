using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine(isMale == true);
            }
            isMale = !isMale;
            if (!isMale)
            {
                Console.WriteLine(isMale == false);
            }
        }
    }
}