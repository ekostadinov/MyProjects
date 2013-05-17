using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_12_7_sqrRoot_Exeption
{
    class GetSqrRt
    {
        // according to http://www.dreamincode.net
        //  Math.sqrt() does not throw any exceptions

        static double userInput;
        static double result;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number and see it's square root!");
            userInput = double.Parse(Console.ReadLine());

            DoTheMath();           
        }


        static void DoTheMath()
        {
            result = Math.Sqrt(userInput);
            Console.WriteLine("The square root of {0} is {1}", userInput, result);
            if (userInput <= 0)
            {
                throw new Exception("Invalid Number!");
            }
            try
            {
            }
            catch 
            {   
            }
            finally
            {
                Console.WriteLine("Good Bye!"); // printed only when the input number is positive
            }

        }

        
       

    }
}
