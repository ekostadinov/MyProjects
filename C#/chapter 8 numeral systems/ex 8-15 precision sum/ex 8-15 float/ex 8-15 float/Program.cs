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
            float num = 1F;
            float sumNum = num / 1000000;
            float sum = 0f;

            do
            {
                sum += sumNum;
                sum++;
            } while (sum <= 32);

            Console.WriteLine(sum);
        }
    }
}
