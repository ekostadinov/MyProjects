using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете int!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете double!");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведетe string!");
            string text = Console.ReadLine();

            Console.WriteLine("Изберете промелива и за int натиснете 0, за double натиснете 1, а за string натиснете  2 !");
            int select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 0:
                    Console.WriteLine("Вие избрахте променлива int  " + (a+1)); break;
                case 1:
                    Console.WriteLine("Вие избрахте променлива double  " + (b+1)); break;
                case 2:
                    Console.WriteLine("Вие избрахте променлива string {0}*  ", text); break;
                default:
                    Console.WriteLine("Грешен избор!"); break;
            }
        }
    }
}
