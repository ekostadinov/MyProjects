using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_16
{
    class Program
    {
        static void Main(string[] args)
        {
            float f;
            int exp = 0, mantisse = 1;
            f = float.Parse(Console.ReadLine());

            //sign
            if (f < 0)
                Console.WriteLine("sign = 1");
            else
                Console.WriteLine("sign = 0");

            //exp
            if (f >= 1 && f < 2)
                exp = (1 << 7) - 1;
            else
            {
                if (f >= 2)
                {
                    while (f >= 2)
                    {
                        f /= 2;
                        exp++;
                    }
                    exp = (1 << 7) - 1 + exp;
                }
                else
                {
                    while (f < 1)
                    {
                        f *= 2;
                        exp++;
                    }
                    exp = (1 << 7) - 1 - exp;
                }
            }
            Console.Write("exp = ");
            ShowBin(exp);

            //mantisse
            f -= 1;
            float tmp = 0.5F;
            Console.Write("mantisse = ");
            //FIX IT
            if (f == 0.0F)
            {
                for (int i = 0; i < 23; i++)
                {
                    Console.Write("0");
                }
            }
            while (f > 0.0F)
            {
                if (f - tmp >= 0)
                {
                    f -= tmp;
                    Console.Write(1);
                }
                else
                    Console.Write(0);
                tmp /= 2;
            }
            Console.WriteLine();
        }

        private static void ShowBin(int exp)
        {
            int br = 8;
            char[] ans = new char[8];
            while (br != 0)
            {
                br--;
                ans[br] = (char)((exp % 2) + '0');
                exp /= 2;
            }
            Console.WriteLine(ans);
        }
    }
}
