using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете просто число от 1 до 100: ");
            string line = Console.ReadLine();
            int n;
            int.TryParse(line, out n);

            int а = 2, b = 3, c = 5, d= 7, f = 11, e = 13, g = 17, i = 19, m = 23, r = 29, 
q = 31, w = 37, t = 41, y = 43, u = 47, o = 53, p = 59, s = 61,
h =  67, j = 71, k = 73, l = 79, z = 83, x = 89, v = 97;
                
                if (n  != а; b; c; d; f; e; g; i; m; r; 
q; w; t; y; u; o; p; s;
h; j; k; l; z; x; v; )
                {
                    Console.WriteLine("Налице е съвпадение! Въведеното число е просто!");
                }
                else
                {
                    Console.WriteLine("Въведенoто число е съставно!");
                }
            }

            
        }
    }
}
