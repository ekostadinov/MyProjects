using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inBinary = new int[] { 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0};
            Console.Write("The number ");

            int inDecimal = 0;
            for (int i = 0; i < inBinary.Length; i++)
            {
                inDecimal <<= 1;
                inDecimal += inBinary[i] - '0';

                Console.Write(inBinary[i]);
            }

            Console.WriteLine();
            Console.WriteLine("in decimal is: " + inDecimal);




            string inBinary1 = "1111010110011110";
            string inHex = "";
            /**
             * декларирам 3 променливи, които ще използвам в цикъла -
             * на кой бит съм, текущата степен на 2 и текущата 16-ична цифра
             */
            for (int i = inBinary1.Length - 1, powOfTwo = 1, digit = 0; i >= 0;
            i--)
            {
                // добавям текущия бит към 16-ичната цифра
                digit += (inBinary1[i] - '0') * powOfTwo;
                // минавам на следващата степен на 2
                powOfTwo *= 2;
                // ако степента е 16, т.е. в digit имам записани 4 бита
                // трябва да го запиша като 16-ична цифра
                // или ако съм стигнал до последния бит
                if (powOfTwo == 16 || i == 0)
                {
                    char digitLiteral = (char)(

                        digit < 10
                        ? digit + '0'
                        : digit + 'A' - 10);

                    inHex = digitLiteral + inHex;
                    // нулирам цифрата и степента на 2
                    // за следващата 16-ична цифра
                    digit = 0;
                    powOfTwo = 1;
                }
            }
            Console.WriteLine("in hexadecimal is: " + inHex);

        }
    }
}
