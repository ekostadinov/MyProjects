using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11_11_RandomMessage
{
    class SecondName
    {
        static int randRand4;

        public static void GenerateName2()
        {

            Random randNum = new Random();

            for (int number = 1; number <= 1; number++)
            {
                randRand4 = randNum.Next(3) + 1;
                // Console.Write(" {0} ", randRand4);
                PrintName2();

            }
            Console.WriteLine();
        }

        public static void PrintName2()
        {
            switch (randRand4)
            {
                case 1:
                    Console.Write("Ivanova"); break;
                case 2:
                    Console.Write("Petrova"); break;
                case 3:
                    Console.Write("Kirova"); break;                
            }
        }






    }
}
