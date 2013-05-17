using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете първа цифра от четири-цифрено число:");
            string line = Console.ReadLine();
            int a;
            int.TryParse(line, out a);

            Console.WriteLine("Въведете втората цифра от четири-цифреното число:");
            string line1 = Console.ReadLine();
            int b;
            int.TryParse(line1, out b);

            Console.WriteLine("Въведете третата цифра от четири-цифреното число:");
            string line2 = Console.ReadLine();
            int c;
            int.TryParse(line2, out c);

            Console.WriteLine("Въведете последната цифра от четири-цифреното число:");
            string line3 = Console.ReadLine();
            int d;
            int.TryParse(line3, out d);

            Console.WriteLine("Въведеното число е:" + " " + a + b + c + d);
            Console.WriteLine("Сборът на въведените цифри е:" + " " + (a+b+c+d));
            Console.WriteLine("Въведените цифри в обратен ред са:" + " " + d + c + b + a);
            Console.WriteLine("Последната цифра става първа:" + " " + d + a + b + c);
            Console.WriteLine("Трета и четвърта цифра сменят места:" + " " + a + c + b + d);

        }
    } 
}
