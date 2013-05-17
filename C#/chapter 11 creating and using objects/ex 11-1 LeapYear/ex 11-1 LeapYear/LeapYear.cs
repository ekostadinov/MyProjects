using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_11_1
{
    class LeapYear
    {
        static int year;  

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year you want to check if it is a leap year: ");
            year = int.Parse(Console.ReadLine());

            CheckLeapYear();
        }

        static void CheckLeapYear()
        {
            bool result = DateTime.IsLeapYear(year);
 
            if (result ==  true)
            {
                Console.WriteLine("The year {0} is a leap year!", year);
            }
            else
            {
                Console.WriteLine("The year {0} is not a leap year!", year);
            }

        }

        
    }
}
