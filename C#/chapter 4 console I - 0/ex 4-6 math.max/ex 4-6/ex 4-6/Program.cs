using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведе число!");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведе второ число!");
            int b = int.Parse(Console.ReadLine());

            Console.Write("По-голямото от двете числа е:");
            Console.WriteLine(Math.Max(a, b));
            Console.Write("По-малкото от двете числа е:");
            Console.WriteLine(Math.Min(a, b));

            
        }
    }
}
