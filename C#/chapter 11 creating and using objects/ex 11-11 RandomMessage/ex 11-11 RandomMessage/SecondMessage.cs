using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11_11_RandomMessage
{
    class SecondMessage
    {
        static int randRand2;

        public static void GenerateNumbers2()
        {

            Random randNum = new Random();

            for (int number = 1; number <= 1; number++)
            {
                randRand2 = randNum.Next(5) + 1;
                // Console.Write(" {0} ", randRand2);
                PrintMessage2();

            }
            Console.WriteLine();
        }

        public static void PrintMessage2()
        {
            switch (randRand2)
            {
                case 1:
                    Console.Write("I feel well now!"); break;
                case 2:
                    Console.Write("I managed to change myself!"); break;
                case 3:
                    Console.Write("This product makes wonders!"); break;
                case 4:
                    Console.Write("I can't believe, but I feel awesome now!"); break;
                case 5:
                    Console.Write("You tried it. I'm very pleased!");break;
            }
        }



    }
}
