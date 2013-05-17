using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_11_1_simple_math
{
    class SimpleMath
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
            // Pseudocode logic: 
           // if year modulo 400 is 0 then
            // is_leap_year
            // else if year modulo 100 is 0 then
            // not_leap_year
        //else if year modulo 4 is 0 then
            //is_leap_year
            // else
            // not_leap_year


            // годините, кратни на 4 са високосни, останалите не са;
            // изключение 1: годините, кратни на 100 не са високосни;
               // изключение 2: годините, кратни на 400 са високосни.
            // Така 1984, 2000, 2004 години са високосни, а 2003, 1900, 2100 не са.


        }
    }
}
