using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_8
{
    class Program
    {
        static byte[] AddArrayNumbers(byte[] number1, byte[] number2)
        {
            if (number2.Length > number1.Length)
            {
                byte[] temp = number1;
                number1 = number2;
                number2 = temp;
            }
            for (int i = 1; i <= number2.Length; i++)
            {
                number1[number1.Length - i] += number2[number2.Length - i];
                if (number1[number1.Length - i] > 9 && number1.Length - i
    - 1 >= 0)
                {
                    number1[number1.Length - i] %= 10;
                    number1[number1.Length - i - 1]++;
                }
            }
            if (number1[0] > 9)
            {
                number1 = IncreaseSize(number1);
                number1[1] %= 10;
                number1[0]++;
            }
            return number1;
        }

        static T[] IncreaseSize<T>(T[] number)
        {
            T[] newnumber = new T[number.Length + 1];
            for (int i = 1; i < newnumber.Length; i++)
            {
                newnumber[i] = number[i - 1];
            }
            return newnumber;
        }

        static void Main()
        {
            AddArrayNumbers(number1, number2);

            IncreaseSize(number);
        }
    }
}
