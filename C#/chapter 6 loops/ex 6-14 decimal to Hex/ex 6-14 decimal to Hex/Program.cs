using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_6_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your decimal number!");
            int n = int.Parse(Console.ReadLine());
            int i;
            char z = n % 16;

            Console.WriteLine("result:");
            
            switch (z)
            {
                case 10:
                    Console.Write("A");
                    break;
                case 11:
                    Console.Write("B");
                    break;
                case 12:
                    Console.Write("C");
                    break;
                case 13:
                    Console.Write("D");
                    break;
                case 14:
                    Console.Write("E");
                    break;
                case 15:
                    Console.Write("F");
                    break;
            }
            Console.WriteLine(z);

            for ( i = n / 16; i <= n && i >= 0; i = i / 16)
            {                                   
                if (i == 0)
                {
                    break;
                }
                int m = i % 16;                

                switch ( m )
                {
                    case 10:
                        Console.Write("A");
                        break;
                    case 11:
                        Console.Write("B");
                        break;
                    case 12:
                        Console.Write("C");
                        break;
                    case 13:
                        Console.Write("D");
                        break;
                    case 14:
                        Console.Write("E");
                        break;
                    case 15:
                        Console.Write("F");
                        break;                    
                }
                Console.WriteLine(m);
            }

            
            




        }
    }
}
