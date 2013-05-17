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
            decimal num = 1M;
            decimal sumNum = num / 1000000;
            decimal sum = 0M;

            do 
            {
                sum += sumNum;
                sum++;
            }while (sum <= 50);

            Console.WriteLine(sum);


        }
    }
}
