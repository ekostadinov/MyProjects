using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Promenlivi_tipove
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1; // Определяме някои променливи 
            int b = 2;
                        // Коя е по-голяма?
            bool greaterAB = (a > b);
                        // 'а" равно ли е на 1?
            bool equalA1 = (a == 1);
                        // Показва резултата в конзолата
            if (greaterAB)
            {
                Console.WriteLine("A > B");
            }
            else
            {
                Console.WriteLine("A <= B");
            }
            Console.WriteLine("greaterAB = " + greaterAB);
            Console.WriteLine("equalA1 = " + equalA1);

            }
    }
}
