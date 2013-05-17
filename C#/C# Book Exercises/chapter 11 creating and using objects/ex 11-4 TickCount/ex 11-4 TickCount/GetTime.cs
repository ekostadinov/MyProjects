using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_11_4
{
    class GetTime
    {
        static void Main(string[] args)
        {            
            long startTime = Environment.TickCount;
            
            GetWeekDay();

            long endTime = Environment.TickCount;
            Console.WriteLine("The elapsed time is {0} sec.", (endTime - startTime) / 1000.0);
        }

        static void GetWeekDay()
        {
            DayOfWeek today = DateTime.Now.DayOfWeek;
            Console.WriteLine("Today is {0}!", today);
        }
    }
}
