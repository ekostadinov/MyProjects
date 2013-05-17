using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MobilePhoneDevice
{
    class MainInfo
    {
        static void Main(string[] args)
        {
            //adding directly properties
            GSM testGSM = new GSM("s123", "samsung corp");
            Console.WriteLine("GSM model: {0} and manufacturer: {1}", testGSM.PhoneModel, testGSM.PhoneManufacturer);

            //another way
            testGSM.PhoneModel = "a1234";
            testGSM.PhoneManufacturer = "not samsung";

            //add new battery
            Battery bat = new Battery();
            bat.Model = "some123";
            bat.HoursTalk = 1.5;
            bat.HoursStandby = 2;
            //and adding it to the gsm
            testGSM.Battery = bat;
            
        }
    }
}
