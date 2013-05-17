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
                
                int a = ((x+1)+(y-1)) + ((x+5) + (y-1));
                int b = ((y-1)+(x+5)) + ((y+5)+(x+5));
                int a2 = ((y+5)+(x+5)) + ((y+5)+(x+1));
                int b2 = ((y+5)+(x+1)) + ((y-1)+(x+1));
                int sum = a + b + a2 + b2;

                if (value <= sum)
                {
                    Console.WriteLine("От въведените координати на х и у, следва че точката О се намира в окръжност с r=5 ");
                    Console.WriteLine(" и в правоъгълник с координати ((-1,1)(5,5))");
                }
                else
                {
                    Console.WriteLine("От въведените координати на х и у, следва че точката О се намира в окръжност с r=5 ");
                    Console.WriteLine("и извън правоъгълник с координати ((-1,1)(5,5))");
                }
            }
                 
   
                else
            {
                Console.WriteLine("От въведените координати на х и у, следва че точката О се намира извън окръжност с r=5 ");
            }
       }
    }
   }
