using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("За изчисляване на квадратното уравнение 'ах2 + bх + с',");
            Console.WriteLine("въведете коефициент за 'а',");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("въведете коефициент за 'b',");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("въведете коефициент за 'c',");
            int c = int.Parse(Console.ReadLine());

            int d = (b*b) - (4*a*c);
            double d1 = Math.Sqrt(d);

            Console.WriteLine("Вашата дискриминанта е: {0}", d1);

            if (d1 == 0)
            {
                int x = -b / (2 * a);
                Console.WriteLine("Вашето квадратно уравнение има един двоен реален корен 'х 1,2':" + x);
            }

            if (d1 > 0)
            {
                int sum = (b*b) - (4*a*c);
                double sum1 = Math.Sqrt(sum);
                double x1 = (-b + sum1)/2*a;

                int sum2 = (b * b) - (4 * a * c);
                double sum3 = Math.Sqrt(sum2);
                double x2 = (-b - sum3) / 2 * a;
                Console.WriteLine("Вашето квадратно уравнение има два различни реални корена които са 'х 1':" + x1);
                Console.WriteLine("и 'х 2':" + x2);
            }

            if (d1<0)
            {
                Console.WriteLine("Вашето квадратно уравнение няма реални корени!");
            }
        }
    }
}
