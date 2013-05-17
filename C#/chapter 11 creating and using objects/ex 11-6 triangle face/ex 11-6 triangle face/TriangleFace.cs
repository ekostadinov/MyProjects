using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_11_6_triangle_face
{
    class TriangleFace
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you know: ");            
            Console.WriteLine("1. the length of each side!");
            Console.WriteLine("2. the length of one side and it's height!");
            Console.WriteLine("3. the length of two sides and the angle between them!");
            Console.WriteLine("To calculate your triangle's face choose an option:");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    FirstSolution();break;
                case 2:
                    SecondSolution();break;
                case 3:
                    ThirdSolution();break;
                default:
                    Console.WriteLine("Incorrect input! Try again!");break;
            }

       }

        static void FirstSolution()
        {
            Console.Write("Enter the length of the first side: ");
            int sideA = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second side: ");
            int sideB = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the third side: ");
            int sideC = int.Parse(Console.ReadLine());

            double result = (sideA + sideB + sideC) / 2;
            double result2 = result * (result - sideA) * (result - sideB) * (result - sideC);
            double result3 = Math.Sqrt(result2);

            Console.WriteLine("The face of your triangle is {0}!", result3);
        }

        static void SecondSolution()
        {
            Console.WriteLine("Enter the length of one of the sides: ");
            int sideLen = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of it's height: ");
            int heightLen = int.Parse(Console.ReadLine());

            int result = (sideLen * heightLen) / 2;
            Console.WriteLine("The face of your triangle is {0}!", result);
        }

        static void ThirdSolution()
        {
            Console.WriteLine("Enter the length of the first side: ");
            int firstLen = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side: ");
            int secLen = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the angle between those two sides: ");
            double angle = int.Parse(Console.ReadLine());

            double sine = Math.Sin(angle);
            double result = (firstLen * secLen * sine) / 2;

            Console.WriteLine("The face of your triangle is {0}!", result);
        }


    }
}
