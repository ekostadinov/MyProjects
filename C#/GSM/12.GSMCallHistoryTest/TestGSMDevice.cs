using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.MobilePhoneDevice;

namespace _12.GSMCallHistoryTest
{
    class TestGSMDevice
    {
        static void Main()
        {
            //Create an instance of the GSM class.

            GSM nokiaN70 = new GSM(null, null);
            nokiaN70.Battery = new Battery("batt87", 35.5, 3);
            nokiaN70.gsmBattery = new Battery("batt87", 35.5, 3);
            nokiaN70.iPhone4s = new GSM("iphone", "apple");
            nokiaN70.PhoneManufacturer = "Nokia Corp.";
            nokiaN70.PhoneModel = "N70";
            nokiaN70.PhoneOwner = "bai ganio";
            nokiaN70.PhonePrice = 1.01m;
            nokiaN70.Call.CallDuration = 410;
            nokiaN70.Call.DialedPhoneNumber = 0888123456;

            //Add few calls.                        
            GSM nokia = new GSM(null, null);
            nokia.Battery = new Battery("batt87", 35.5, 3);
            nokia.gsmBattery = new Battery("batt87", 35.5, 3);
            nokia.iPhone4s = new GSM("iphone", "apple");
            nokia.PhoneManufacturer = "Nokia Corp.";
            nokia.PhoneModel = "N70";
            nokia.PhoneOwner = "bai ganio";
            nokia.PhonePrice = 1.01m;
            nokia.Call.CallDuration = 410;
            nokia.Call.DialedPhoneNumber = 0888123456;
            GSM.callHistory.Add(nokia.Call); //leave no null characteristics - fill all battery, owner etc.            

            GSM htc = new GSM(null, null);
            htc.Battery = new Battery("batt87", 30.5, 3.2);
            htc.gsmBattery = new Battery("batt87", 35.1, 0.3);
            htc.iPhone4s = new GSM("iphone", "apple");
            htc.PhoneManufacturer = "HTC Corp.";
            htc.PhoneModel = "One";
            htc.PhoneOwner = "bash ganio";
            htc.PhonePrice = 1.06m;
            htc.Call.CallDuration = 110;
            htc.Call.DialedPhoneNumber = 0877123456;
            GSM.callHistory.Add(htc.Call);

            GSM sony = new GSM(null, null);
            sony.Battery = new Battery("batt87", 25.5, 1.3);
            sony.gsmBattery = new Battery("batt87", 35.5, 3);
            sony.iPhone4s = new GSM("iphone", "apple");
            sony.PhoneManufacturer = "Sony Corp.";
            sony.PhoneModel = "Something";
            sony.PhoneOwner = "ganio";
            sony.PhonePrice = 1.08m;
            sony.Call.CallDuration = 210;
            sony.Call.DialedPhoneNumber = 0899123456;
            GSM.callHistory.Add(sony.Call);

            GSM samsung = new GSM(null, null);
            samsung.Battery = new Battery("batt817", 15.5, 4.3);
            samsung.gsmBattery = new Battery("batt817", 35.5, 3);
            samsung.iPhone4s = new GSM("iphone", "apple");
            samsung.PhoneManufacturer = "samsung Corp.";
            samsung.PhoneModel = "s520";
            samsung.PhoneOwner = "one more ganio";
            samsung.PhonePrice = 111.00m;
            samsung.Call.CallDuration = 262;
            samsung.Call.DialedPhoneNumber = 0882111111;
            //GSM.callHistory.Add(samsung.Call);
            GSM.AddCallsToHistory(samsung.Call);


            //Display the information about the calls.
            foreach (var call in GSM.CallHistory)
            {
                Console.WriteLine("Call number: {0}", call.DialedPhoneNumber);
                Console.WriteLine("Call date: {0}", call.Date.ToShortDateString());
                Console.WriteLine("Call time: {0}", call.Time.ToShortTimeString());
                Console.WriteLine("Call duration: {0}", call.CallDuration);
                Console.WriteLine();
            }

            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            GSM.CalculateTotalCallsCost(GSM.callHistory, 0.37m); //pass current call log and call price pre minute in decimal

            //Remove the longest call from the history and calculate the total price again.
            // - sort and find longest call
            var longest = from call in GSM.callHistory
                          orderby call.CallDuration
                          select call;
            // - remove it from the list
            GSM.RemoveCallsFromHistory(longest.Last());
            // - calculate new total call log worth
            Console.WriteLine("After removing longest call in the log: ");
            GSM.CalculateTotalCallsCost(longest.ToList(), 0.37m);
            
            //Finally clear the call history and print it.
            Console.WriteLine("Call log is cleared: ");           
            GSM.ClearCallsHistory();

            Console.WriteLine("--------");
            foreach (var call in GSM.CallHistory)
            {
                Console.WriteLine("Call number: {0}", call.DialedPhoneNumber);
                Console.WriteLine("Call date: {0}", call.Date.ToShortDateString());
                Console.WriteLine("Call time: {0}", call.Time.ToShortTimeString());
                Console.WriteLine("Call duration: {0}", call.CallDuration);
                Console.WriteLine();
            }
            Console.WriteLine("--------");
           

        }
    }
}
