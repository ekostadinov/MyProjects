using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.MobilePhoneDevice;
using _03.BatteryType;


namespace _04.ShowAllInformation
{
    class AllInfo
    {        
        static void Main()
        {

            GSM04 nextGSM = new GSM04();
            nextGSM.Battery.Type = _03.BatteryType.GSMBatteryTypes.NiCd.ToString();
            
           GSM myGSM = new GSM(null, null);
           
           myGSM.gsmBattery.HoursStandby = 36;
           myGSM.gsmBattery.HoursTalk = 10.5;
           myGSM.gsmBattery.Model = "batt-1223";
           
           myGSM.PhoneManufacturer = "Nokia Corp.";
           myGSM.PhoneModel = "N70";
           myGSM.PhoneOwner = "No One";
           myGSM.PhonePrice = 1000.50m;

           PrintGSMInfo(nextGSM.Battery.Type, myGSM.gsmBattery.HoursStandby, myGSM.gsmBattery.HoursTalk, myGSM.gsmBattery.Model, myGSM.PhoneManufacturer, myGSM.PhoneModel, myGSM.PhoneOwner, myGSM.PhonePrice);
        }

        private static void PrintGSMInfo(string p1, double? nullable1, double? nullable2, string p2, string p3, string p4, string p5, decimal? nullable3)
        {
            Console.WriteLine("GSM info:");
            Console.WriteLine("Phone Manufacturer - {0}", p3);
            Console.WriteLine("Phone Model - {0}", p4);
            Console.WriteLine("Phone Owner - {0}", p5);
            Console.WriteLine("Phone Price - {0} euro", nullable3);
            Console.WriteLine("Battery details: ");
            Console.WriteLine("model - {0}", p2);
            Console.WriteLine("type - {0}", p1);
            Console.WriteLine("hours on standby - {0}", nullable1);
            Console.WriteLine("hours talk - {0}", nullable2);
        }                                                                                                                                             
    }
}
