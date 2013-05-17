using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_11_3
{
    class WeekToday
    {
        static void Main(string[] args)
        {            
            DayOfWeek today = DateTime.Now.DayOfWeek;
            Console.WriteLine("Today is {0}!", today);
        }
    }
}
