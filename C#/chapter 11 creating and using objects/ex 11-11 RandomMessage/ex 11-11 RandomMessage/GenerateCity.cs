using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11_11_RandomMessage
{
    class GenerateCity
    {
        static int randRand5;

        public static void GenerateCitys()
        {

            Random randNum = new Random();

            for (int number = 1; number <= 1; number++)
            {
                randRand5 = randNum.Next(5) + 1;
               // Console.Write(" {0} ", randRand5);
                PrintCity();

            }
            Console.WriteLine();
        }

        public static void PrintCity()
        {
            switch (randRand5)
            {
                case 1:
                    Console.Write("Sofia"); break;
                case 2:
                    Console.Write("Plovdiv"); break;
                case 3:
                    Console.Write("varna"); break;
                case 4:
                    Console.Write("Ruse"); break;
                case 5:
                    Console.Write("Bourgas"); break;
            }
        }

    }
}
