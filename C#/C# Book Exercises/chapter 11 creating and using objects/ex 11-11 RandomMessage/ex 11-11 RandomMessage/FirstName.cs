using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11_11_RandomMessage
{
    class FirstName
    {

        static int randRand3;

        public static void GenerateName()
        {

            Random randNum = new Random();

            for (int number = 1; number <= 1; number++)
            {
                randRand3 = randNum.Next(5) + 1;
                // Console.Write(" {0} ", randRand3);
                PrintName();

            }
            Console.WriteLine();
        }

        public static void PrintName()
        {
            switch (randRand3)
            {
                case 1:
                    Console.Write("Diana"); break;
                case 2:
                    Console.Write("Petia"); break;
                case 3:
                    Console.Write("Stela"); break;
                case 4:
                    Console.Write("Elena"); break;
                case 5:
                    Console.Write("Katia"); break;
            }
        }





    }
}
