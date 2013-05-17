using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string num = Console.ReadLine();
            num = num.ToUpper();

            Console.WriteLine("Enter with number, in what numeral system is your number (if 2 <= your number): ");
            int sys = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter with number, in what numeral system you want your number: ");
            int newSys = int.Parse(Console.ReadLine());
            
            string result = Convert.ToString(Convert.ToInt32(num, sys), newSys);
                        
            Console.WriteLine("You number " + num + " in " + sys + " system, is " +result + " in " + newSys + " system!");

        }
    }
}
