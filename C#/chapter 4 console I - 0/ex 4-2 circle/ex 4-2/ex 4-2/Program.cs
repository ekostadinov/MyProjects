using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете радиус на окръжност в сантиметри: ");
            string line = Console.ReadLine();
            int r;
            int.TryParse(line, out r);

            double P = Math.PI;

            double c = 2 * (P * r);
            double s = P * r * r;

            double result = c + s;

            if (result != 0)
            {
                Console.WriteLine("Лицето на окръжността е:" + s + " см" + ", а обиколката:" + c + " см!");
            }
            else
            {
                Console.WriteLine("Моля, въведете цяло число за радиус!");
            }
            }
    }
}
