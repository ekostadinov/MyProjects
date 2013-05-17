using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_11_5
{
    class Triangle
    {
        static int firstCat;
        static int secondCat;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first triangle cathetus:");
            firstCat = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second triangle cathetus:");
            secondCat = int.Parse(Console.ReadLine());

            GetHypotenuse();            
        }

        static void GetHypotenuse()
        {
            double result = Math.Pow(firstCat, 2);
            double result2 = Math.Pow(secondCat, 2);
            double result3 = result + result2;
            double hypotenuse = Math.Sqrt(result3);

            Console.WriteLine("The hypotenuse of a triangle with cathetus {0} and cathetus {1} is {2}!", 
                firstCat, secondCat, hypotenuse);
        }


    }
}
