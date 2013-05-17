using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_8_circle_point
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Въведете числовият израз на х на точка О:");
            string line = Console.ReadLine();
            int x;
            int.TryParse(line, out x);

            Console.WriteLine("Въведете числовият израз на y на точка О:");
            string line2 = Console.ReadLine();
            int y;
            int.TryParse(line2, out y);
                      
            int value = (x * x) + (y * y);
                      
            if (value <= 5)
            {
                Console.WriteLine("От въведените координати на х и у, следва че точката О се намира в окръжност с r=5 ");
            }
            else
            {
                Console.WriteLine("От въведените координати на х и у, следва че точката О се намира извън окръжност с r=5 ");
            }
            }
        }
    }

