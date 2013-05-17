using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете първото число от общо пет!");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете второто число от общо пет!");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете третото число от общо пет!");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете четвъртото число от общо пет!");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете последното число!");
            int e = int.Parse(Console.ReadLine());


            if (a > b && a>c && a>d && a>e)
            {
                Console.WriteLine("Най-голямото въведено число е:" + a);
            }

            if (b>a && b>c && b>d && b>e)
            {
                Console.WriteLine("Най-голямото въведено число е:" + b);
            }

            if (c>a && c>b && c>d && c>e)
            {
                Console.WriteLine("Най-голямото въведено число е:" + c);
            }

            if (d>a && d>b && d>c && d>e)
            {
                Console.WriteLine("Най-голямото въведено число е:" + d);
            }

            if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine("Най-голямото въведено число е:" + e);
            }

            if (a == b && a == c && a == d && a == e)
            {
                Console.WriteLine("Въведените числа са еднакви!");
            }
    
       }
    }
}
