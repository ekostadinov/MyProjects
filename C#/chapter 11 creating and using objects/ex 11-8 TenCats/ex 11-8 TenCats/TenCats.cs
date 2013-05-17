using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ex_11_8.ManagingCats;

namespace ex_11_8
{
    class TenCats
    {
        static void Main(string[] args)
        {
            // Prints 10 cats X 10 random numbers = 100 results
            Console.WriteLine("Your ten cats are: ");
            ex_11_8.ManagingCats.Cat.Execute();
        }

    }
}
