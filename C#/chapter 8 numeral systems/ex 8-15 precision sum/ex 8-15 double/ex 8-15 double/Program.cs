using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 1D;
            double sumNum = num / 1000000;
            double sum = 0d;

            do
            {
                sum += sumNum;
                sum++;
            } while (sum <= 49.99999999657788);

            Console.WriteLine(sum);
        }
    }
}
