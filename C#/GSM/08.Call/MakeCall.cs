using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.MobilePhoneDevice;

namespace _08.Call
{
    class MakeCall
    {
        static void Main()
        {
            GSM testGSM = new GSM(null,null);
                       
            testGSM.phoneCall.DialedPhoneNumber = 0888123456;
            testGSM.phoneCall.CallDuration = 1500;

            Console.WriteLine("Call information:");
            Console.Write("Today {0}, ", testGSM.phoneCall.Date.ToShortDateString());
            Console.Write(" You make a call at {0} ", testGSM.phoneCall.Time.ToShortTimeString());
            Console.Write(" and talked to {0} ", testGSM.phoneCall.DialedPhoneNumber);
            Console.Write(" {0} seconds.", testGSM.phoneCall.CallDuration);
            Console.WriteLine();
           
        }
    }
}
