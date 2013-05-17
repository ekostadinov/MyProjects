using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11_11_RandomMessage
{
    

    class FirstMessage
    {
        static int randRand;

        public static void GenerateNumbers()
        {

            Random randNum = new Random();

            for (int number = 1; number <= 1; number++)
            {
                randRand = randNum.Next(4) + 1;
                //Console.Write(" {0} ", randRand);
                PrintMessage();

            }
            Console.WriteLine();
        }

        public static void PrintMessage()
        {
            switch (randRand)
            {
                case 1:
                    Console.Write("The product is excellent!");break;
                case 2:
                    Console.Write("This product is awesome!");break;
                case 3:
                    Console.Write("I use this product all the time!");break;
                case 4:
                    Console.Write("This product is the best in this category!");break;
            }
        }




    }
}
