using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете теглото си килограми:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Теглото Ви на Луната ще е: ");
            Console.WriteLine((number * 0.17) + "кг");
         }
    }
}
