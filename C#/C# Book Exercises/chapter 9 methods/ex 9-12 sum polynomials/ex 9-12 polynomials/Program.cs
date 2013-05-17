using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter variable for your equation!");
            string var = Console.ReadLine();

            Console.WriteLine("Enter the number of the highest math pow of '{0}' for the first polynomial!", var);
            int varPow = int.Parse(Console.ReadLine());

            int [] array = new int [varPow + 1];

            CreateFirstPolynomial(array, var, varPow);
            Console.WriteLine();

            Console.WriteLine("Enter the number of the highest math pow of '{0}' for the second polynomial!", var);
            int varPow2 = int.Parse(Console.ReadLine());

            int[] array2 = new int[varPow2 + 1];

            CreateSecondPolynomial(array2, var, varPow2);
            Console.WriteLine();

            Console.WriteLine("Your equation is: ");
            string print1 = PrintFirstPolynomial(array, varPow, var);
            string print2 = PrintSecondPolynomial(array2, varPow2, var);
            PrintEquation( array, array2, varPow, varPow2, var, print1, print2);
            // or Console.WriteLine("({0}) + ({1})", print1, print2); without PrintEquation(); method
            Console.WriteLine();

            SumPolynomials(); // missing sum logic for the polynomials methods

        }

        static string CreateFirstPolynomial(int[] array, string var, int varPow)
        {            
            for ( int powSeq = 0; powSeq < array.Length; powSeq++)
            {
                Console.Write("Enter coefficient for {0}^{1}: ", var, powSeq);
                array[powSeq] = int.Parse(Console.ReadLine());                
            }

            Console.WriteLine("Your first polynomial is:");
            PrintFirstPolynomial(array, varPow, var);

            return var;
        }

        static string PrintFirstPolynomial(int[] array, int varPow, string var)
        {
            for (int index = 0; index <= varPow; index ++ )
            {                
                Console.Write("{0}{1}^{2} + ", array[index], var, index);
            };
            Console.WriteLine();

            return var;
        }

        static string CreateSecondPolynomial(int[] array2, string var, int varPow2)
        {
            for (int powSeq = 0; powSeq < array2.Length; powSeq++)
            {
                Console.Write("Enter coefficient for {0}^{1}: ", var, powSeq);
                array2[powSeq] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your second polynomial is:");
            PrintSecondPolynomial(array2, varPow2, var);

            return var;
        }

        static string PrintSecondPolynomial(int[] array2, int varPow2, string var)
        {
            for (int index = 0; index <= varPow2; index++)
            {
                Console.Write("{0}{1}^{2} + ", array2[index], var, index);
            };
            Console.WriteLine();

            return var;
        }

        static string PrintEquation(int[] array, int[] array2, int varPow, int varPow2, string var, string print1, string print2)
        {
            Console.WriteLine("({0}) + ({1})", print1, print2);
            Console.WriteLine();

            return var;
        }


    }
}
