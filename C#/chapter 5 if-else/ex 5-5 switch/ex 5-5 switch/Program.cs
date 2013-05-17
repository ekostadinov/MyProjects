using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число от 0 до 9 и натиснете 'Enter'!");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 0:
                    {
                        Console.WriteLine("Вие въведохте числото 'нула'!");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Вие въведохте числото 'едно'!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Вие въведохте числото 'две'!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Вие въведохте числото 'три'!");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Вие въведохте числото 'четири'!");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Вие въведохте числото 'пет'!");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Вие въведохте числото 'шест'!");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Вие въведохте числото 'седем'!");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Вие въведохте числото 'осем'!");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Вие въведохте числото 'девет'!");
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Грешка!Въведете число от 0 до 9!");
                        break;
                    }
            }
        }
    }
}
