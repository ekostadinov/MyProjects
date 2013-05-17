using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace еx_5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете брой на точките!");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Бонусът към Вашите точки е: " + (a * 10)); break;
                case 2:
                    Console.WriteLine("Бонусът към Вашите точки е: " + (a * 10)); break;
                case 3:
                    Console.WriteLine("Бонусът към Вашите точки е: " + (a * 10)); break;
                case 4:
                    Console.WriteLine("Бонусът към Вашите точки е: " + (a * 100)); break;
                case 5:
                    Console.WriteLine("Бонусът към Вашите точки е: " + (a * 100)); break;
                case 6:
                    Console.WriteLine("Бонусът към Вашите точки е: " + (a * 100)); break;
                case 7:
                    Console.WriteLine("Бонусът към Вашите точки е: " + (a * 1000)); break;
                case 8:
                    Console.WriteLine("Бонусът към Вашите точки е: " + (a * 1000)); break;
                case 9:
                    Console.WriteLine("Бонусът към Вашите точки е: " + (a * 1000)); break;
                default:
                    Console.WriteLine("Грешка!");break;
            }
        }
    }
}
