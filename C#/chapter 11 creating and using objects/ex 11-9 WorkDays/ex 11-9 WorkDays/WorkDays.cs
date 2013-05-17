using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_11_9_WorkDays
{
    class WorkDays
    {
        // code is correct for 2012, from 28.09.12
        // missing logic to stop compare dates untill user date!

        static string[] workDays;
        static string[] holiDays;
        static DateTime today;
        static DateTime userTime;
        static string workdates;
        static string holidays;
                
        static void Main(string[] args)
        {
            today = DateTime.Now.Date;

            Console.WriteLine("If today is: {0}, \n enter the date that you want and see the workdays up to then!", DateTime.Today.Date);
            string dateString = Console.ReadLine();

            userTime = DateTime.Parse(dateString); // Converts the string of a date and time to its DateTime equivalent

            
            TimeSpan daysBetween = userTime - today;
            int daysDiff = daysBetween.Days; // gets the days between into int

            Console.WriteLine("There are {0} days from today to {1}!", daysDiff, userTime);

            GetMiddleDays();


        }

        static void GetMiddleDays()
        {
            List <DateTime> middleDaysList = new List<DateTime> ();
            DateTime tempDate = today;

            do 
            {
                middleDaysList.Add(tempDate);
                tempDate = tempDate.AddDays(1);
            }while (tempDate <= userTime);

            foreach (DateTime date in middleDaysList )
            {                
                //Console.WriteLine(date);
                AllDaysArrays();
                                
                if (date.ToString() == workdates)
                {
                    Console.WriteLine(workdates + "something");
                }

               
                if (date.ToString() == holidays)
                {
                    Console.WriteLine(holidays);
                }
            }

        }

        static void AllDaysArrays()
        {
            workDays = new string[] { "29.09.2012 - work day", "30.09.2012 - work day", "01.10.2012 - work day", "02.10.2012 - work day", "03.10.2012 - work day", "04.10.2012 - work day", "05.10.2012 - work day", "08.10.2012 - work day", "09.10.2012 - work day", "10.10.2012 - work day", "11.10.2012 - work day", "12.10.2012 - work day", "15.10.2012 - work day", "16.10.2012 - work day", "17.10.2012 - work day", "18.10.2012 - work day", "19.10.2012 - work day", "22.10.2012- work day", "23.10.2012 - work day", "24.10.2012 - work day", "25.10.2012 - work day", "26.10.2012 - work day", "29.10.2012 - work day", "30.10.2012 - work day", "31.10.2012 - work day", "01.11.2012 - work day", "02.11.2012 - work day", "05.11.2012 - work day", "06.11.2012 - work day", "07.11.2012 - work day", "08.11.2012 - work day", "09.11.2012- work day", "12.11.2012 - work day", "13.11.2012 - work day", "14.11.2012 - work day", "15.11.2012 - work day", "16.11.2012- work day", "19.11.2012 - work day", "20.11.2012 - work day", "21.11.2012 - work day", "22.11.2012 - work day", "23.11.2012 - work day", "26.11.2012- work day", "27.11.2012 - work day", "28.11.2012 - work day", "29.11.2012 - work day", "30.11.2012 - work day", "03.12.2012 - work day", "04.12.2012 - work day", "05.12.2012 - work day", "06.12.2012 - work day", "07.12.2012 - work day", "10.12.2012 - work day", "11.12.2012 - work day", "12.12.2012 - work day", "13.12.2012 - work day", "14.12.2012 - work day", "15.12.2012 - work day", "17.12.2012 - work day", "18.12.2012 - work day", "19.12.2012 - work day", "20.12.2012 - work day", "21.12.2012 - work day", "27.12.2012 - work day", "28.12.2012 - work day" };
            holiDays = new string[] { "30.09.2012 - holiday", "06.10.2012- holiday", "07.10.2012- holiday", "13.10.2012- holiday", "14.10.2012- holiday", "20.10.2012- holiday", "21.10.2012- holiday", "27.10.2012- holiday", "28.10.2012- holiday", "03.11.2012- holiday", "04.11.2012- holiday", "10.11.2012- holiday", "11.11.2012- holiday", "17.11.2012- holiday", "18.11.2012- holiday", "24.11.2012- holiday", "25.11.2012- holiday", "01.12.2012- holiday", "02.12.2012- holiday", "08.12.2012- holiday", "09.12.2012- holiday", "16.12.2012- holiday", "22.12.2012- holiday", "23.12.2012- holiday", "24.12.2012- holiday", "25.12.2012- holiday", "26.12.2012- holiday", "29.12.2012- holiday", "30.12.2012- holiday", "31.12.2012- holiday" };
        
            foreach (string workdates in workDays)
            {
                Console.WriteLine(workdates);
            }

            foreach (string holidays in holiDays)
            {
                Console.WriteLine(holidays);
            }   
        
        }







    }        
}
