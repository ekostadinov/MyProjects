using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_11
{
    class Program
    {
        static void ReverseNumber()
        {
            Console.WriteLine("Insert a number!");
            int number = int.Parse(Console.ReadLine());

            string num = number.ToString();
            string output = "";

            for (int index = num.Length - 1; index >= 0; index--)
            {
                output += num[index];
            }
            Console.WriteLine(output);
        }

        static void AverageArithmetic()
        {
            Console.Write("Enter how many numbers you want to be calculated: ");
            int arrSize = int.Parse(Console.ReadLine());

            int [] numbers = new int [arrSize];

            

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write("Enter value for number [{0}]: ", index);
                numbers[index] = int.Parse(Console.ReadLine());
            }
                int sum = numbers.Sum();
                Console.WriteLine(sum);
                double avArith = (double) sum / (double) arrSize; 
                Console.WriteLine("Your average arithmetic is: {0} ", avArith);
        }

        static void EquationArithmetic()
        {
            Console.WriteLine("Enter values for a * x + b = 0 !");
            Console.WriteLine("Enter value for a, must be a > 0!");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for x!");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for b!");
            int b = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("The result is: {0}", (a * x) + b);
            }
            else
            {
                Console.WriteLine("Incorrect input for a! Enter a number bigger than zero!");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("For 'reverse number' press 1, for 'average arithmetic' press 2, for 'equation' press 3 !");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
            ReverseNumber();
            }

            if (userChoice == 2)
            {
                AverageArithmetic(); 
            }

            if (userChoice == 3)
            {
                EquationArithmetic(); 
            }

            if (userChoice == 0 || userChoice > 3)
            {
                Console.WriteLine("Incorrect input! Please try again!");
            }
        }


    }
}
