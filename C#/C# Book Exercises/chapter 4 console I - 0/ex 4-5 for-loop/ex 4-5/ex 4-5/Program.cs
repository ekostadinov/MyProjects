using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Въведете число за начало на интервала:"); 
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете число за край на интервала:");
            int b = int.Parse(Console.ReadLine());

            for(int i = a; i<=b; i++)
             {
                 if (i % 5 != 0)
                 {
                     Console.WriteLine("Числата от въведеният интервал кратни на 5 са {0}!",i);
                 } 
             }
        }
    }
}
