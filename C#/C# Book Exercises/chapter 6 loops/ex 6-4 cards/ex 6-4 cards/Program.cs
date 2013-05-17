using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Картите в стандартно тесте са: ");

            for (int i = 2; i < 15; i++)
            {
                for (int s = 1; s < 5; s++)
                {
                    switch (i)
                    {
                        case 2:
                            Console.WriteLine("двойка"); break;
                        case 3:
                            Console.WriteLine("тройка"); break;
                        case 4:
                            Console.WriteLine("четворка"); break;
                        case 5:
                            Console.WriteLine("петица"); break;
                        case 6:
                            Console.WriteLine("шестица"); break;
                        case 7:
                            Console.WriteLine("седимца"); break;
                        case 8:
                            Console.WriteLine("осмица"); break;
                        case 9:
                            Console.WriteLine("девятка"); break;
                        case 10:
                            Console.WriteLine("десятка"); break;
                        case 11:
                            Console.WriteLine("Вале"); break;
                        case 12:
                            Console.WriteLine("Дама"); break;
                        case 13:
                            Console.WriteLine("Поп"); break;
                        case 14:
                            Console.WriteLine("Асо"); break;
                        default: Console.Write(""); break;
                       }
                            switch (s)
                            {
                                case 1:
                                    Console.WriteLine("спатия"); break;
                                case 2:
                                    Console.WriteLine("каро"); break;
                                case 3:
                                    Console.WriteLine("купа"); break;
                                case 4:
                                    Console.WriteLine("пика"); break;
                                default: Console.Write(""); break;
                            }
                    Console.WriteLine(i+s);
                    }
                }
                
                
            }
       }
    }

